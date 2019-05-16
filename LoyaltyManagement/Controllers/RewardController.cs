using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LoyaltyManagement.Models;
using LoyaltyManagement.Interfaces;
using LoyaltyManagement.Common;
using Microsoft.EntityFrameworkCore;

namespace LoyaltyManagement.Controllers
{
    public class RewardController : Controller
    {
        private readonly IRewadsRepository rewadsRepository;

        public RewardController(IRewadsRepository rewadsRepository)
        {
            Gaurd.IsNotNull(rewadsRepository, nameof(rewadsRepository));

            this.rewadsRepository = rewadsRepository;
        }
        // GET: Reward
        public ActionResult Index()
        {
            return View();
        }

        // GET: Reward/Details/5
        public ActionResult Details(int id)
        {
            var points = rewadsRepository.GetPoints(1);

            var result = points.Select(x => new RewardDetailsViewModel { Points = x })
                 .DefaultIfEmpty(new RewardDetailsViewModel { Points = 0 })
                 .Single();

            return View(result);
        }

        // GET: Reward/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reward/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("CustomerId", "Points")] AddRewardViewModel addReward)
        {
            try
            {
                // TODO: Add insert logic here

                rewadsRepository.AddPoints(addReward.CustomerId, addReward.Points);
                return RedirectToAction(nameof(Details));
            }
            catch(DbUpdateConcurrencyException ex)
            {

                 ModelState.AddModelError("", "Unable to save changes. The Record was modified by another user after you got the original value.");

                return View();
            }
        }

        // GET: Reward/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reward/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Reward/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reward/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}