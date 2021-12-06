using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        //private readonly ApplicationDbContext _context;
        
        private IProductRepository repository;
        public int PageSize = 15;

        //public ProductController (ApplicationDbContext context)
        ////{
        ////    _context = context;
        ////}

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(string category, string name,string description, int page = 1)
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                            .Where(p => category == null || p.Category == category)
                            .Where(p => name == null || p.Name == name)
                            .Where(p => description == null || p.Description == description)
                            .OrderBy(p => p.ProductID)
                            .Skip((page - 1) * PageSize)
                            .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?

                                repository.Products.Count() : 
                                repository.Products.Where(e =>
                                    e.Category == category).Count()
                },
                CurrentCategory = category
            });

        public async Task<IActionResult> ShowSearchForm()
        {
            return View();
        }
        
        public async Task<IActionResult> SearchResults(String searchPhrase)
        {
            String searchThis = char.ToUpper(searchPhrase[0]) + searchPhrase.Substring(1); //Trying to capitalize first letter here. Won't work for some reason
            return Redirect("/Product/List/?category=" + searchPhrase);
        }
    }
}