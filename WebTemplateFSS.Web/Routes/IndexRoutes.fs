module Routes.IndexRoutes

let pageRoute = "/"

let clickRoute = "/click/{color}"

let clickURL color = clickRoute.Replace("{color}", color)
