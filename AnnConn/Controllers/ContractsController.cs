using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AnnConn.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace AnnConn.Controllers
{
    public class ContractsController : Controller
    {
        private readonly AnnContext _context;
        private HttpClient client;

        public ContractsController(AnnContext context)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://ctv.annhome.vn/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            _context = context;
        }

        // GET: Contracts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contracts.ToListAsync());
        }

        // GET: Contracts/Details/5
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

        [HttpGet]
        public async Task<IActionResult> CreateContract(int? id)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(c => c.ID == id);
            if (customer != null)
            {
                var collabor = await _context.Collaborators.FirstOrDefaultAsync(c => c.ID == customer.CollaboratorsID);
                try
                {
                    ViewBag.customer = customer.name;
                    ViewBag.phone = customer.phone;
                    ViewBag.email = customer.email;
                    ViewBag.note = customer.note;
                    ViewBag.condition = customer.condition;
                    ViewBag.charge = customer.policy;
                    ViewBag.coll = collabor.fullName;
                    ViewBag.pdate = Convert.ToString(customer.pDate);
                }
                catch (Exception)
                {

                    return NotFound();
                }
                
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateContract([Bind("email,collabor,pDate,customer,phone,email,note,charge,condition,code")] Contracts contract)
        {
            _context.Add(contract);
            var customer = await _context.Customers.FirstOrDefaultAsync(c => c.phone == contract.phone);
            if (customer != null)
            {
                customer.signed = true;
            }
            
            await _context.SaveChangesAsync();
            //var contracts = await _context.Contracts.OrderBy(m => m.ID).ToListAsync();
            //var autho = _context.Administrator.First();
            return RedirectToAction("Contract", "Administrator");
        }

        // GET: Contracts/Create
        public async Task<IActionResult> PartnerRegistrationForm()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://ctv.annhome.vn/api/Company");
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsAsync<string>();
                    ViewBag.companies = JsonConvert.DeserializeObject<List<Company>>(content);
                }
                HttpResponseMessage res = await client.GetAsync("http://ctv.annhome.vn/api/Province");
                if (res.IsSuccessStatusCode)
                {
                    string content = await res.Content.ReadAsAsync<string>();
                    ViewBag.provinces = JsonConvert.DeserializeObject<List<Province>>(content);
                }
            }
            catch (Exception)
            {

                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status502BadGateway);
            }
            
            
            return View();
        }

        // POST: Contracts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PartnerRegistrationForm([Bind("ID,email,fullName,password,office,joinDate,gender,birthday, cmnd, place, day, field,position, house, nation, city, phone, district, town, zip, office_name")] Collaborators collaborator)
        {
            //if (ModelState.IsValid)
            //{
            collaborator.joinDate = DateTime.Now.Date;
            collaborator.office = "Cộng tác viên";

            _context.Add(collaborator);
            await _context.SaveChangesAsync();
            //var contracts = await _context.Contracts.OrderBy(m => m.ID).ToListAsync();
            //var autho = _context.Administrator.First();
            return RedirectToAction("Collaborators", "Administrator");
        }

        // GET: Contracts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contracts = await _context.Contracts.FindAsync(id);
            if (contracts == null)
            {
                return NotFound();
            }
            return View(contracts);
        }

        // POST: Contracts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,collabor,pDate,customer,phone,email,note,condition,s1,d1,f1,day1,r1,dl1,c1,s2,d2,f2,day2,r2,dl2,c2,s3,d3,f3,day3,r3,dl3,c3")] Contracts contracts)
        {
            if (id != contracts.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contracts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContractsExists(contracts.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(contracts);
        }

        // GET: Contracts/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: Contracts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contracts = await _context.Contracts.FindAsync(id);
            _context.Contracts.Remove(contracts);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContractsExists(int id)
        {
            return _context.Contracts.Any(e => e.ID == id);
        }
    }
}
