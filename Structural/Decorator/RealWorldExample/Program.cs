using Decorator.Repositories;
using DecoratorOption1 =  Decorator.Decorators.Option1;
using DecoratorOption2 =  Decorator.Decorators.Option2;
using Microsoft.Extensions.Caching.Memory;
using Decorator;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMemoryCache();
builder.Services.AddLogging();

builder.Services.AddSingleton<UserRepository>();
builder.Services.AddSingleton<IUsersService>(
    sp =>
    {
        var component = new UsersService(sp.GetRequiredService<UserRepository>());

        var memoryCache = sp.GetRequiredService<IMemoryCache>();
        var logger = sp.GetRequiredService<ILogger<IUsersService>>();

        var cacheDecorator = new DecoratorOption1.UsersServiceCacheDecorator(component, memoryCache);
        var loggerDecorator = new DecoratorOption1.UsersServiceLoggerDecorator(cacheDecorator, logger);

        return loggerDecorator;
    });

var app = builder.Build();

app.MapGet(
    "/",
    (IUsersService usersService) => usersService.GetAllUsers());

app.Run();