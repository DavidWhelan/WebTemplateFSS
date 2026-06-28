open Microsoft.AspNetCore.Builder
open Falco
open Controllers

let endpoints = IndexController.endpoints

let bldr = WebApplication.CreateBuilder()

let wapp = bldr.Build()

let isDevelopment = wapp.Environment.EnvironmentName = "Development"

wapp
    .UseRouting()
    .UseIf(isDevelopment, DeveloperExceptionPageExtensions.UseDeveloperExceptionPage)
    .UseIf(not (isDevelopment), FalcoExtensions.UseFalcoExceptionHandler ErrorController.serverException)
    .Use(DefaultFilesExtensions.UseDefaultFiles)
    .Use(StaticFileExtensions.UseStaticFiles)
    .UseFalco(endpoints)
    .UseFalcoNotFound(ErrorController.notFound)
    .Run()
