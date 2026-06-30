module Controllers.ErrorController

open Views.Shared
open Falco
open Microsoft.AspNetCore.Http
open Falco.Markup

let notFound: HttpHandler =
    let markup = Layout.template [] [ _h1' "Not Found" ]
    Response.withStatusCode 404 >> Response.ofHtml markup

let serverException: HttpHandler =
    let markup = Layout.template [] [ _h1' "Server Error" ]
    Response.withStatusCode 500 >> Response.ofHtml markup
