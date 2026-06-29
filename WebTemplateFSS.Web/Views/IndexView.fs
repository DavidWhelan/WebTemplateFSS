module Views.IndexView

open WebTemplateFss.GeneratedStyles
open Falco.Markup
open Falco.Markup.Extensions
open Falco.Datastar
open Views.Shared
open Routes

let page =
    Layout.template
        [ _h1 [] [ _text "Example: Hello World" ]
          _button
              [ _id_ "hello"
                Ds.onClick (Ds.get IndexRoutes.clickRoute)
                _classList_ [ styles.btn; styles.btnPrimary ] ]
              [ _text "Click Me" ] ]

let clickResponse = _h2 [ _id_ "hello" ] [ _text "Hello, World, from Server!" ]
