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
        public IActionResult List()
        {
            return View(_productRepository.Products.ToList());
        }
    }
}