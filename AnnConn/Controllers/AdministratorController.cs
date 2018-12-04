using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnnConn.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnnConn.Controllers
{
    public class AdministratorController : Controller
    {
        private readonly IHostingEnvironment _environment;
        //private readonly IFileProvider fileProvider;
        private readonly AnnContext _context;
        //private readonly List<Admin> admins;
        //private readonly List<Sale> sales;
        private static Administrator administrator;
        //private IHostingEnvironment _hostingEnvironment;
        public AdministratorController(AnnContext context, IHostingEnvironment hostingEnvironment)
        {
            _environment = hostingEnvironment;
            _context = context;

        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Contract()
        {
            var contracts = await _context.Contracts.OrderBy(m => m.ID).ToListAsync();
            var autho = _context.Administrator.First();
            AdModal modal = new AdModal();
            modal.administrator = autho;
            modal.contracts = contracts;
            administrator = autho;
            return View("Contracts",modal);
        }

        public IActionResult CreateContract(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return RedirectToAction("CreateContract", "Contracts", new { id });
        }

        //[HttpPost]
        public async Task<IActionResult> Contracts(Administrator admin)
        {
            var contracts = await _context.Contracts.OrderBy(m => m.ID).ToListAsync();
            var autho = _context.Administrator.First();
            if (autho != null)
            {
                if (admin.email.Equals(autho.email) && admin.password.Equals(autho.password))
                {
                    AdModal modal = new AdModal();
                    modal.administrator = autho;
                    modal.contracts = contracts;
                    administrator = autho;
                    return View(modal);
                }
                else
                {
                    return View("Error");
                }

            }

            return View("Error");
        }

        public async Task<IActionResult> Collabor_Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.Collaborators.FindAsync(id);
            if (customers == null)
            {
                return NotFound();
            }
            return View("Collabor_Edit",customers);
        }

        // POST: Collabor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Collabor_Edit(int id, [Bind("policy,ID,email, fullName, password, office, joinDate, gender, birthday,cmnd,place, day, office_name,field, position, house, town, nation, city, district,zip, phone")] Collaborators collaborator)
        {
            if (id != collaborator.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(collaborator);
                await _context.SaveChangesAsync();
                return RedirectToAction("Collaborators");
            }
            return View(collaborator);
        }

        //[HttpPost]
        public async Task<IActionResult> Customers()
        {

            var customers = await _context.Customers.Where(c => c.signed == false).OrderBy(m => m.ID).ToListAsync();
            CustomerModal modal = new CustomerModal();
            modal.administrator = administrator;
            modal.customers = customers;
            return View(modal);
        }

        public async Task<IActionResult> Collaborators()
        {

            var partners = await _context.Collaborators.OrderBy(m => m.ID).ToListAsync();
            foreach (var p in partners)
            {
                p.customers = await _context.Customers.Where(c => c.CollaboratorsID == p.ID).ToListAsync();
                p.contracts = await _context.Contracts.Where(c => c.collabor == p.fullName).ToListAsync();
            }
            Partner modal = new Partner();
            modal.ad = administrator;
            modal.collaborators = partners;
            return View(modal);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contract = await _context.Contracts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contract == null)
            {
                return NotFound();
            }

            return View("DeleteContract",contract);
        }

        public async Task<IActionResult> Collabor_Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contract = await _context.Collaborators
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contract == null)
            {
                return NotFound();
            }

            return View("Collabor_Delete", contract);
        }

        [HttpPost, ActionName("Collabor_Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Collabor_DeleteConfirmed(int id)
        {
            try
            {
                var customers = await _context.Collaborators.FindAsync(id);
                _context.Collaborators.Remove(customers);
                await _context.SaveChangesAsync();
                return RedirectToAction("Collaborators");
            }
            catch (Exception)
            {

                return View("Error");
            }
            
        }

        public async Task<IActionResult> Ctm_Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contract = await _context.Customers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contract == null)
            {
                return NotFound();
            }

            return View("Ctm_Delete", contract);
        }

        [HttpPost, ActionName("Ctm_Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ctm_DeleteConfirmed(int id)
        {
            var customers = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customers);
            await _context.SaveChangesAsync();
            return RedirectToAction("Customers");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contracts = await _context.Contracts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contracts == null)
            {
                return NotFound();
            }

            return View(contracts);
        }

        public async Task<IActionResult> Collabor_Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contracts = await _context.Collaborators
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contracts == null)
            {
                return NotFound();
            }

            return View(contracts);
        }

        public async Task<IActionResult> Ctm_Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contracts = await _context.Customers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contracts == null)
            {
                return NotFound();
            }

            return View(contracts);
        }

        // POST: Collabor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customers = await _context.Contracts.FindAsync(id);
            _context.Contracts.Remove(customers);
            await _context.SaveChangesAsync();
            return RedirectToAction("Contract");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            var contract = await _context.Contracts.FindAsync(id);
            if (contract != null)
            {
                return View("EditContract", contract);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("ID,collabor,pDate,customer,phone,email,note,condition,s1,d1,f1,day1,r1,dl1,c1,s2,d2,f2,day2,r2,dl2,c2,s3,d3,f3,day3,r3,dl3,c3,code")] Contracts contracts)
        {
            if (ModelState.IsValid)
            {

                    _context.Update(contracts);
                    await _context.SaveChangesAsync();

                return RedirectToAction("Contract");
            }
            return View("EditContract", contracts);
        }

        [HttpGet]
        public async Task<IActionResult> Ctm_Edit(int? id)
        {
            var contract = await _context.Customers.FindAsync(id);
            if (contract != null)
            {
                return View("Ctm_Edit", contract);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Ctm_Edit(int id, [Bind("ID,name,CollaboratorsID, email, phone, note, condition, cNumber,pNumber,ch, price,policy,charges,totals,pDate,supporter")] Customers contracts)
        {
            if (ModelState.IsValid)
            {

                _context.Customers.Update(contracts);
                await _context.SaveChangesAsync();

                return RedirectToAction("Customers");
            }
            return View("Ctm_Edit", contracts);
        }

        //[HttpGet]
        //public async Task<IActionResult> Collabor_Edit(int? id)
        //{
        //    var contract = await _context.Contracts.FindAsync(id);
        //    if (contract != null)
        //    {
        //        return View("Collabor_Edit", contract);
        //    }
        //    return NotFound();
        //}

        //[HttpPost]
        //public async Task<IActionResult> Collabor_Edit(int id, [Bind("ID,email, fullName, password, ,pDate,customer,phone,email,note,condition,s1,d1,f1,day1,r1,dl1,c1,s2,d2,f2,day2,r2,dl2,c2,s3,d3,f3,day3,r3,dl3,c3,code")] Collaborators contracts)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        _context.Update(contracts);
        //        await _context.SaveChangesAsync();

        //        return RedirectToAction("Collaborators");
        //    }
        //    return View("Collabor_Edit", contracts);
        //}

        public IActionResult Create(int? id)
        {
            //Sale sale = new Sale();
            //var temp = await _context.sale.FirstOrDefaultAsync(s => s.ID == id);
            //sale = temp;
            //TempData["email"] = sale.email;
            return RedirectToAction("PartnerRegistrationForm", "Contracts", new { id });
        }

        
    }
}