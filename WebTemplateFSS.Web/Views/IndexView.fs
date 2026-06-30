module Views.IndexView

open Falco.Markup
open Falco.Markup.Extensions
open Falco.Datastar
open Styles
open Views.Shared
open Routes

let page =
    Layout.template
        [ _styleList [] Buttons.btnStyles ]
        [ _h2 [ _id_ "hello" ] [ _text "Hello, World!" ]
          _button
              [ Ds.onClick (Ds.get IndexRoutes.clickRoute)
                _classList_ [ Buttons.btnPrimary ] ]
              [ _text "Click Me" ]
          _button
              [ Ds.onClick (Ds.get IndexRoutes.clickRoute)
                _classList_ [ Buttons.btnSecondary ] ]
              [ _text "Click Me" ]
          _button
              [ Ds.onClick (Ds.get IndexRoutes.clickRoute)
                _classList_ [ Buttons.btnTertiary ] ]
              [ _text "Click Me" ] ]

let clickResponse =
    _div [ _id_ "hello" ] [ _h2 [] [ _text "Hello, World, from Server!" ] ]
