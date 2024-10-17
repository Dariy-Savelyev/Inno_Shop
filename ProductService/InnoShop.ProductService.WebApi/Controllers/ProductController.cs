﻿using InnoShop.ProductService.Application.Models;
using InnoShop.ProductService.Application.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace InnoShop.ProductService.WebApi.Controllers;

public class ProductController(IProductService service) : BaseController
{
    [HttpGet]
    public async Task<IEnumerable<GetAllProductModel>> GetAllProducts()
    {
        return await service.GetAllProductsAsync();
    }

    [HttpGet]
    public async Task<SearchProductModel> SearchProductByName(string productName)
    {
        return await service.SearchProductByNameAsync(productName);
    }

    [HttpPost]
    public async Task Create(CreationProductModel model)
    {
        await service.CreateProductAsync(model);
    }

    [HttpPut]
    public async Task Edit(ModificationProductModel model)
    {
        await service.EditProductAsync(model);
    }

    [HttpDelete]
    public async Task Delete(DeletionProductModel model)
    {
        await service.DeleteProductAsync(model);
    }
}