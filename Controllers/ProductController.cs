﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers {
    public class ProductController : Controller {
        private IProductRepository repository;
        public int PageSize = 4;
        public ProductController (IProductRepository repo) {
            repository = repo;
        }

        public ViewResult List (int productPage = 1) =>
            View (repository.Products
                .OrderBy (p => p.ProductId)
                //skips PageSize number of records to provide proper pagination
                .Skip ((productPage - 1) * PageSize)
                .Take (PageSize));
    }
}