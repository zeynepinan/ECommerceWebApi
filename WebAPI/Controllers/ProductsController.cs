﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]   // Attribute-- class hakkında bilgi verme ,imzalama   //Java-annotation
    public class ProductsController : ControllerBase
    {
        //Loosely coupled--Gevşek bağlılık
        //naming convention
        //IoC Container -- Inversion of Control
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get() 
        {
            //Dependency chain--
            
            var result =_productService.GetAll();
            return result.Data;
        }
    }
}
