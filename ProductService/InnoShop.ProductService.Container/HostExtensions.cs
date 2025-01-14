﻿using InnoShop.ProductService.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace InnoShop.ProductService.Container;

public static class HostExtensions
{
    public static WebApplication Migrate(this WebApplication webApplication)
    {
        using var scope = webApplication.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
        context.Database.Migrate();
        return webApplication;
    }
}