using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AnnConn.Models;
using Microsoft.AspNetCore.Hosting;
using reCAPTCHA.AspNetCore;
using System.Globalization;

namespace AnnConn.Controllers
{
    public class CollaboratorsController : Controller
    {
        private readonly AnnContext _context;
        private readonly IHostingEnvironment _environment;
        private static Collaborators coll;
        private List<Collaborators> _colls;
        private IRecaptchaService _recaptcha;
        private static List<Company> companies;

        public CollaboratorsController(AnnContext context, IHostingEnvironment hostingEnvironment, IRecaptchaService recaptcha)
        {
            _recaptcha = recaptcha;
            _context = context;
            _environment = hostingEnvironment;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Home(Collaborators c)
        {
            
            var autho = await _context.Collaborators.SingleOrDefaultAsync(coll => coll.email == c.email);
            if (autho != null)
            {
                if (c.email.Equals(autho.email) && c.password.Equals(autho.password))
                {
                    var customers = await _context.Customers.Where(cm => cm.CollaboratorsID == autho.ID).ToListAsync();
                    CustomerModal modal = new CustomerModal();
                    modal.coll = autho;
                    modal.customers = customers;
                    coll = autho;
                    return View(modal);
                }
                else
                {
                    return View("Error");
                }

            }

            return View("Error");
        }

        // GET: Collabor
        public async Task<IActionResult> Created(int? id)
        {
            var coll = await _context.Collaborators.FindAsync(id);
            if (coll != null)
            {
                var apps = await _context.appoinment.Where(a => a.sale == coll.email).OrderBy(m => m.ID).ToListAsync();
                AppsModal modal = new AppsModal();
                modal.coll = coll;
                modal.appoinments = apps;
                return View(modal);
            }
            return View("Error");
        }

        // GET: Collabor
        public async Task<IActionResult> Home()
        {
            var customers = await _context.Customers.Where(c => c.CollaboratorsID == coll.ID).ToListAsync();
            CustomerModal modal = new CustomerModal();
            modal.coll = coll;
            modal.customers = customers;
            return View(modal);
        }

        // GET: Collabor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (customers == null)
            {
                return NotFound();
            }

            return View(customers);
        }

        public bool Check(string email, string pass)
        {
            //var colls = await _context.Collaborators.ToListAsync();
            foreach (Collaborators sale in _colls)
            {
                if (email.Equals(sale.email) && pass.Equals(sale.password))

                    return true;
            }
            return false;
        }

        //Create appoinment
        [HttpGet]
        public IActionResult CreateAppoinment(int? id)
        {
            try
            {
                var customer = _context.Customers.Find(id);
                ViewBag.customer = customer.name;
                ViewBag.phone = customer.phone;
                ViewBag.email = customer.email;
                return View();
            }
            catch (Exception)
            {

                return NotFound();
            }

        }

        // POST: Appoinments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAppoinment([Bind("Customer,Gender,Address,Phone,Email,Job,WorkPlace,Cmnd,Day,Place,Money,Purpose,Requires,Price,Details,DType,Cash,NCH1,NCH2,NCH21,NCH3,NMS,NS,NSHH,NSH,HKTT,password,Contract,supporter")] Appoinment appoinment)
        {
            //if (ModelState.IsValid)
            //{
            var colls = await _context.Collaborators.ToListAsync();
            if (colls == null)
            {
                return NotFound();
            }
            _colls = colls;
            foreach (Collaborators coll in colls)
            {
                if (coll.password == appoinment.password)
                {
                    TempData["name"] = coll.fullName;
                    appoinment.sale = coll.email;
                    appoinment.SaleDetails = coll.office;
                    break;
                }

            }
            string str = "";
            if (appoinment.sale == null)
            {
                return View();
            }
            if (!Check(appoinment.sale, appoinment.password))
            {
                return View();
            }
            else
            {
                //var recaptcha = await _recaptcha.Validate(Request);
                //if (!recaptcha.success)
                //{
                //    ModelState.AddModelError("Recaptcha", "There was an error validating recatpcha. Please try again!");
                //    return View();
                //}
                List<Appoinment> appoinments = await _context.appoinment.ToListAsync();
                if (appoinments.Count > 0)
                {
                    appoinment.Contract = _context.appoinment.Max(c => c.Contract) + 1;
                    if (appoinment.NCH1 > 0 || appoinment.NCH2 > 0 || appoinment.NCH3 > 0 || appoinment.NCH21 > 0)
                    {
                        appoinment.ph = _context.appoinment.Max(c => c.ph) + appoinment.NCH2 + appoinment.NCH1 + appoinment.NCH3 + appoinment.NCH21;
                        str += "Căn hộ: " + Convert.ToString(appoinment.ph) + "\n";
                    }
                    if (appoinment.NSH > 0)
                    {
                        appoinment.psh = _context.appoinment.Max(c => c.psh) + appoinment.NSH;
                        str += "Nhà phố: " + Convert.ToString(appoinment.psh) + "\n";
                    }
                    if (appoinment.NSHH > 0)
                    {
                        appoinment.pshh = _context.appoinment.Max(c => c.pshh) + appoinment.NSHH;
                        str += "Shophouse: " + Convert.ToString(appoinment.pshh) + "\n";
                    }
                    if (appoinment.NMS > 0)
                    {
                        appoinment.pms = _context.appoinment.Max(c => c.pms) + appoinment.NMS;
                        str += "Biệt thự: " + Convert.ToString(appoinment.pms) + "\n";
                    }
                    if (appoinment.NS > 0)
                    {
                        appoinment.pns = _context.appoinment.Max(c => c.pns) + appoinment.NS;
                        str += "Shop (kios chung cư): " + Convert.ToString(appoinment.pns) + "\n";
                    }

                }
                else
                {
                    Random rd = new Random();
                    appoinment.Contract = rd.Next(100, 151);
                    if (appoinment.NCH1 > 0 || appoinment.NCH2 > 0 || appoinment.NCH3 > 0 || appoinment.NCH21 > 0)
                    {
                        appoinment.ph = rd.Next(100, 151);
                        str += "Căn hộ: " + Convert.ToString(appoinment.ph) + "\n";
                    }
                    if (appoinment.NSH > 0)
                    {
                        appoinment.psh = rd.Next(100, 151);
                        str += "Nhà phố: " + Convert.ToString(appoinment.psh) + "\n";
                    }
                    if (appoinment.NSHH > 0)
                    {
                        appoinment.pshh = rd.Next(100, 151);
                        str += "Shophouse: " + Convert.ToString(appoinment.pshh) + "\n";
                    }
                    if (appoinment.NMS > 0)
                    {
                        appoinment.pms = rd.Next(100, 151);
                        str += "Biệt thự: " + Convert.ToString(appoinment.pms) + "\n";
                    }
                }
                appoinment.IsActive = true;
                appoinment.New = true;
                appoinment.Official = false;
                appoinment.cTime = DateTime.Now.ToString("ddMMyyyy HH:mm:ss.FFFFFFF");
                appoinment.Confirm = false;
                var customers = await _context.Customers.Where(c => c.CollaboratorsID == coll.ID).ToListAsync();
                foreach (var c in customers)
                {
                    if (c.phone == appoinment.Phone)
                    {
                        if (appoinment.supporter)
                        {
                            c.charges = 1.0;
                        }
                        else
                        {
                            c.charges = 1.3;
                        }
                        break;
                    }
                }
                _context.Add(appoinment);
                AppModal modal = new AppModal();
                modal.appoinment = appoinment;
                Collaborators co = _colls.Find(x => x.email == appoinment.sale);
                modal.collaborator = co;
                await _context.SaveChangesAsync();

                TempData["ct"] = appoinment.Contract;
                TempData["pt"] = str;
                return View("Confirm", modal);
            }
            //}
            //return NotFound();
        }


        public async Task<IActionResult> Views(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appoinment = await _context.appoinment
                .FirstOrDefaultAsync(m => m.Contract == id);
            //Random rand = new Random();
            //int rd = rand.Next(100, 151);
            //ViewBag.rd = appoinment.Priority;
            if (appoinment == null)
            {
                appoinment = await _context.appoinment.FirstOrDefaultAsync(m => m.ID == id);
            }
            ViewBag.name = coll.fullName;
            ViewBag.Money_Letters = So_chu(appoinment.Money);
            string temp = (appoinment.Money).ToString("N", new CultureInfo("is-IS"));
            ViewBag.New_Money = temp.Substring(0, temp.Length - 3) + " VNĐ";
            if (appoinment == null)
            {
                return NotFound();
            }

            return View(appoinment);
        }

        // GET: Collabor/Create
        public IActionResult Return()
        {
            return RedirectToAction("Home", new { coll });
        }

        //public IActionResult _home()
        //{
        //    return RedirectToAction("Return");
        //}

        // GET: Collabor/Create
        public async Task<IActionResult> Create()
        {
            PartnerModal modal = new PartnerModal();
            modal.sales = new List<SelectListItem>();
            var sales = await _context.sale.Where(s => s.type == "Nội bộ").OrderBy(s => s.ID).ToListAsync();
            if (sales != null)
            {
                foreach (var sale in sales)
                {
                    modal.sales.Add( new SelectListItem { Text = sale.name, Value = sale.name });
                }
                modal.collaborators = coll;

                return View(modal);
            }
            return View("Error");
        }

        // POST: Collabor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,name,phone,email,note,condition,cNumber,pNumber,ch,price,policy,charges,totals,pDate, q4a, q5a" +
            ",q5b,q5c,q5d,q6a,q6b,q6c,q7a,q7b,q7c,q7d,q7e,q7f,q7g,q7h,q7i,q7j,q7k,q7l,q7m,supporter")] Customers customer)
        {
            //if (ModelState.IsValid)
            //{
            var tmp = _context.Customers.SingleOrDefault(m => m.phone == customer.phone);
            if (tmp != null)
            {
                ViewBag.name = customer.name;
                ViewBag.phone = customer.phone;
                return View("Exist");
            }
            customer.signed = false;
            customer.pDate = DateTime.Now;
            _context.Customers.Add(customer);
            customer.CollaboratorsID = coll.ID;
            customer.provider = coll.fullName;
            customer.charges = 0.25;
            if (customer.q4a == null||(customer.q5a == false && customer.q5b == false && customer.q5c == false && customer.q5d == false)
                ||(customer.q6b == false && customer.q6c == false && customer.q6a == false)||(customer.q7l == false && customer.q7k == false &&
                customer.q7a == false && customer.q7b == false && customer.q7e == false && customer.q7h == false && customer.q7j == false &&
                customer.q7d == false && customer.q7c == false && customer.q7f == false && customer.q7g == false && customer.q7i == false &&
                customer.q7m == false) || customer.note == null)
            {
                customer.charges = 0.25;
                //customer.CollaboratorsID = coll.ID;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Home));
            }
            else
            {
                customer.charges = 0.6;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Home));
            }
            //if (customer.note != null)
            //{
            //    customer.charges = 1.0;
            //}
            //if (customer.q6a == true || customer.q6b == true || customer.q6c == true || customer.q6d == true || customer.q6e == true ||
            //    customer.q6f == true || customer.q6g == true || customer.q6h == true || customer.q6i == true || customer.q6j == true ||
            //    customer.q6k == true || customer.q6l == true || customer.q6m == true)
            //{
            //    customer.charges = 1.0;
            //}
            //await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Home));
            //}
        }

        // GET: Collabor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers.FindAsync(id);
            if (customers == null)
            {
                return NotFound();
            }
            return View(customers);
        }

        // POST: Collabor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,name,phone,email,note,condition,cNumber,pNumber,ch,price,policy,charges,totals,pDate")] Customers customers)
        {
            if (id != customers.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomersExists(customers.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Home));
            }
            return View(customers);
        }

        // GET: Collabor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (customers == null)
            {
                return NotFound();
            }

            return View(customers);
        }

        // POST: Collabor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customers = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Home));
        }

        private bool CustomersExists(int id)
        {
            return _context.Customers.Any(e => e.ID == id);
        }

        public static string So_chu(double gNum)
        {
            if (gNum == 0)
                return "Không đồng";

            string lso_chu = "";
            string tach_mod = "";
            string tach_conlai = "";
            double Num = Math.Round(gNum, 0);
            string gN = Convert.ToString(Num);
            int m = Convert.ToInt32(gN.Length / 3);
            int mod = gN.Length - m * 3;
            string dau = "[+]";

            // Dau [+ , - ]
            if (gNum < 0)
                dau = "[-]";
            dau = "";

            // Tach hang lon nhat
            if (mod.Equals(1))
                tach_mod = "00" + Convert.ToString(Num.ToString().Trim().Substring(0, 1)).Trim();
            if (mod.Equals(2))
                tach_mod = "0" + Convert.ToString(Num.ToString().Trim().Substring(0, 2)).Trim();
            if (mod.Equals(0))
                tach_mod = "000";
            // Tach hang con lai sau mod :
            if (Num.ToString().Length > 2)
                tach_conlai = Convert.ToString(Num.ToString().Trim().Substring(mod, Num.ToString().Length - mod)).Trim();

            ///don vi hang mod
            int im = m + 1;
            if (mod > 0)
                lso_chu = Tach(tach_mod).ToString().Trim() + " " + Donvi(im.ToString().Trim());
            /// Tach 3 trong tach_conlai

            int i = m;
            int _m = m;
            int j = 1;
            string tach3 = "";
            string tach3_ = "";

            while (i > 0)
            {
                tach3 = tach_conlai.Trim().Substring(0, 3).Trim();
                tach3_ = tach3;
                lso_chu = lso_chu.Trim() + " " + Tach(tach3.Trim()).Trim();
                m = _m + 1 - j;
                if (!tach3_.Equals("000"))
                    lso_chu = lso_chu.Trim() + " " + Donvi(m.ToString().Trim()).Trim();
                tach_conlai = tach_conlai.Trim().Substring(3, tach_conlai.Trim().Length - 3);

                i = i - 1;
                j = j + 1;
            }
            if (lso_chu.Trim().Substring(0, 1).Equals("k"))
                lso_chu = lso_chu.Trim().Substring(10, lso_chu.Trim().Length - 10).Trim();
            if (lso_chu.Trim().Substring(0, 1).Equals("l"))
                lso_chu = lso_chu.Trim().Substring(2, lso_chu.Trim().Length - 2).Trim();
            if (lso_chu.Trim().Length > 0)
                lso_chu = dau.Trim() + " " + lso_chu.Trim().Substring(0, 1).Trim().ToUpper() + lso_chu.Trim().Substring(1, lso_chu.Trim().Length - 1).Trim() + " đồng chẵn.";

            return lso_chu.ToString().Trim();

        }
        private static string Chu(string gNumber)
        {
            string result = "";
            switch (gNumber)
            {
                case "0":
                    result = "không";
                    break;
                case "1":
                    result = "một";
                    break;
                case "2":
                    result = "hai";
                    break;
                case "3":
                    result = "ba";
                    break;
                case "4":
                    result = "bốn";
                    break;
                case "5":
                    result = "năm";
                    break;
                case "6":
                    result = "sáu";
                    break;
                case "7":
                    result = "bảy";
                    break;
                case "8":
                    result = "tám";
                    break;
                case "9":
                    result = "chín";
                    break;
            }
            return result;
        }
        private static string Donvi(string so)
        {
            string Kdonvi = "";

            if (so.Equals("1"))
                Kdonvi = "";
            if (so.Equals("2"))
                Kdonvi = "nghìn";
            if (so.Equals("3"))
                Kdonvi = "triệu";
            if (so.Equals("4"))
                Kdonvi = "tỷ";
            if (so.Equals("5"))
                Kdonvi = "nghìn tỷ";
            if (so.Equals("6"))
                Kdonvi = "triệu tỷ";
            if (so.Equals("7"))
                Kdonvi = "tỷ tỷ";

            return Kdonvi;
        }
        private static string Tach(string tach3)
        {
            string Ktach = "";
            if (tach3.Equals("000"))
                return "";
            if (tach3.Length == 3)
            {
                string tr = tach3.Trim().Substring(0, 1).ToString().Trim();
                string ch = tach3.Trim().Substring(1, 1).ToString().Trim();
                string dv = tach3.Trim().Substring(2, 1).ToString().Trim();
                if (tr.Equals("0") && ch.Equals("0"))
                    Ktach = " không trăm lẻ " + Chu(dv.ToString().Trim()) + " ";
                if (!tr.Equals("0") && ch.Equals("0") && dv.Equals("0"))
                    Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm ";
                if (!tr.Equals("0") && ch.Equals("0") && !dv.Equals("0"))
                    Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm lẻ " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
                if (tr.Equals("0") && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = " không trăm mười " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && ch.Equals("1") && dv.Equals("0"))
                    Ktach = " không trăm mười ";
                if (tr.Equals("0") && ch.Equals("1") && dv.Equals("5"))
                    Ktach = " không trăm mười lăm ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười " + Chu(dv.Trim()).Trim() + " ";

                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("0"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười ";
                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười lăm ";

            }


            return Ktach;

        }
    }
}
