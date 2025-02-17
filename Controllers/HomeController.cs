using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreApp2.Data.Abstract;
using StoreApp2.Models;

namespace StoreApp2.Controllers
{
    public class HomeController:Controller
    {
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;


        public HomeController(IProductRepository productRepository,ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            return View(_productRepository.Products.OrderBy(p=>p.PublishedOn).Take(4).ToList());
        }
        public IActionResult List(string search,int? id)
        {
            var products = _productRepository.Products;

            if(id != null)
            {
                products = products.Where(p=>p.CategoryId==id);
            }

            if(!String.IsNullOrEmpty(search))
            {
                products = products.Where(p=>p.Description.ToLower().Contains(search.ToLower()));
            }

            var viewModel = new ProductListViewModel
            {
                Products = products.ToList(),
                Categories = _categoryRepository.Categories.ToList()
            };

            return View(viewModel);
        }
        public IActionResult Details(int? id)
        {
            return View(_productRepository.Products.FirstOrDefault(i =>i.ProductId==id));
        }
    }
}