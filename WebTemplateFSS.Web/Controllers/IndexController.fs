module Controllers.IndexController

open Views.IndexView
open Routes.IndexRoutes
open Microsoft.AspNetCore.Http
open Falco
open Falco.Routing

let pageHandler: HttpHandler = Response.ofHtml page

let clickHandler (color: string) : HttpHandler = Response.ofHtml (clickResponse color)

let endpoints =
    [ get pageRoute pageHandler
      mapGet clickRoute (fun r -> r.GetString "color") clickHandler ]
