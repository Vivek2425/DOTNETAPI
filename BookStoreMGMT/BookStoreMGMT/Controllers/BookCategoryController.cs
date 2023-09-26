using BookStoreMGMT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BookStoreMGMT.Controllers
{
    public class BookCategoryController : Controller
    {
        private string APIURL;
        private List<BookCategory> _categories;

        public BookCategoryController()
        {
            APIURL = @"http://localhost:18154/api/Categories";
        }

        // GET: BookCategoryController
        public async Task<ActionResult> Index()
        {
            List<BookCategory> BookCategoryList;// = new List<BookCategory>();
            using(var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(APIURL))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    BookCategoryList = JsonConvert.DeserializeObject<List<BookCategory>>(apiResponse);
                }
            }
            return View(BookCategoryList);
        }

        // GET: BookCategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookCategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookCategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookCategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookCategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookCategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookCategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
