using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreApp2.Data.Abstract;
using StoreApp2.Models;
using StoreApp2.ViewModel;

namespace StoreApp2.Controllers
{
    public class HomeController:Controller
    {
        public int pageSize = 3;
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
        public IActionResult List(string search,int? id, int page = 1)
        {
            var products = _productRepository.Products.AsQueryable();
            var categories = _categoryRepository.Categories.ToList();

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
                    Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                    Categories = categories,
                    PageInfo = new PageInfo
                {
                    ItemsPerPage = pageSize,
                    TotalItems = products.Count(),
                    CurrentPage = page
                }
            };

            return View(viewModel);
        }
        public IActionResult Details(int? id)
        {
            return View(_productRepository.Products.FirstOrDefault(i =>i.ProductId==id));
        }
    }
}