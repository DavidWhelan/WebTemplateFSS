[<AutoOpen>]
module Styles

open Fss
open Fss.Static
open Colors

let btn =
    [ Padding.value (px 10, px 15)
      BorderWidth.value (px 1)
      BorderStyle.solid
      BorderRadius.value (px 2)
      FontSize.value (px 14)
      Cursor.pointer ]

let createButton (name: string) (colorSet: ColorSet) (textColor: Types.Color.Color) =
    fss
        name
        [ yield! btn
          BackgroundColor.value colorSet.Enabled
          BorderColor.value colorSet.Enabled
          Color.value textColor
          Hover [ BackgroundColor.value colorSet.Hover; BorderColor.value colorSet.Hover ]
          Active [ BackgroundColor.value colorSet.Active; BorderColor.value colorSet.Active ]
          Disabled [ BackgroundColor.value colorSet.Disabled; BorderColor.value colorSet.Disabled ] ]

let btnPrimary = createButton "btnPrimary" primary Types.Color.Color.White
let btnSecondary = createButton "btnSecondary" secondary Types.Color.Color.White
let btnTertiary = createButton "btnTertiary" tertiary Types.Color.Color.Black
