using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreApp2.Data.Abstract;

namespace StoreApp2.Controllers
{
    public class HomeController:Controller
    {
        private IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View(_productRepository.Products.OrderBy(p=>p.PublishedOn).Take(4).ToList());
        }
        public IActionResult List(string search)
        {
            var products = _productRepository.Products;

            if(!String.IsNullOrEmpty(search))
            {
                products = products.Where(p=>p.Description.ToLower().Contains(search.ToLower()));
            }

            return View(products.ToList());
        }
        public IActionResult Details(int? id)
        {
            return View(_productRepository.Products.FirstOrDefault(i =>i.ProductId==id));
        }
    }
}