[<AutoOpen>]
module Styles

open Fss
open Fss.Static

type ColorSet =
    { Enabled: Fss.Types.Color.Color
      Hover: Fss.Types.Color.Color
      Active: Fss.Types.Color.Color
      Disabled: Fss.Types.Color.Color }

let primary =
    { Enabled = hex "0D4715"
      Hover = hex "35663C"
      Active = hex "092F0E"
      Disabled = hex "D7E0D8" }

let btn =
    fss
        "btn"
        [ Padding.value (px 10, px 5)
          BorderRadius.value (px 5)
          BorderWidth.value (px 1)
          BorderStyle.solid
          BorderColor.value primary.Enabled
          FontSize.value (px 16)
          FontWeight.bold
          Cursor.pointer ]

let btnPrimary =
    fss
        "btnPrimary"
        [ BackgroundColor.value primary.Enabled
          Color.white
          Hover [ BackgroundColor.value primary.Hover ]
          Active [ BackgroundColor.value primary.Active ] ]
