module Views.IndexView

open Falco.Markup
open Falco.Datastar
open Views.Shared
open Views.Shared.Theme
open Routes

let page =
    Layout.template
        [ _h1 [] [ _text "Example: Hello World" ]
          _button
              [ _id_ "hello"
                Ds.onClick (Ds.get IndexRoutes.clickRoute)
                _class_ Button.hoverClass ]
              [ _text "Click Me" ] ]

let clickResponse = _h2 [ _id_ "hello" ] [ _text "Hello, World, from Server!" ]
