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
    [ Padding.value (px 10, px 15)
      BorderWidth.value (px 1)
      BorderStyle.solid
      BorderRadius.value (px 2)
      FontSize.value (px 14)
      Cursor.pointer ]

let createButton (name: string) (colorSet: ColorSet) =
    fss
        name
        [ yield! btn
          BackgroundColor.value colorSet.Enabled
          Color.white
          BorderColor.value colorSet.Enabled
          Hover [ BackgroundColor.value colorSet.Hover ]
          Active [ BackgroundColor.value colorSet.Active ]
          Disabled [ BackgroundColor.value colorSet.Disabled ] ]

let btnPrimary = createButton "btnPrimary" primary
