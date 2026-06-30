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
              [ Ds.onClick (Ds.get (IndexRoutes.clickURL "Primary"))
                _class_ Buttons.btnPrimary ]
              [ _text "Click Me" ]
          _button
              [ Ds.onClick (Ds.get (IndexRoutes.clickURL "Secondary"))
                _class_ Buttons.btnSecondary ]
              [ _text "Click Me" ]
          _button
              [ Ds.onClick (Ds.get (IndexRoutes.clickURL "Tertiary"))
                _class_ Buttons.btnTertiary ]
              [ _text "Click Me" ] ]

let clickResponse color =
    _div [ _id_ "hello" ] [ _h2 [] [ _text $"Hello, World, from Server! The button color was {color}" ] ]
