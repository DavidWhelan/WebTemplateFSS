module Styles.Buttons

open Fss
open Colors

let btn =
    [ Padding.value (px 10, px 15)
      BorderWidth.value (px 1)
      BorderStyle.solid
      BorderRadius.value (px 2)
      FontSize.value (px 14)
      Cursor.pointer ]

let createButton (colorSet: ColorSet) (textColor: Types.Color.Color) =
    createFss
        [ yield! btn
          BackgroundColor.value colorSet.Enabled
          BorderColor.value colorSet.Enabled
          Color.value textColor
          Hover [ BackgroundColor.value colorSet.Hover; BorderColor.value colorSet.Hover ]
          Active [ BackgroundColor.value colorSet.Active; BorderColor.value colorSet.Active ]
          Disabled [ BackgroundColor.value colorSet.Disabled; BorderColor.value colorSet.Disabled ] ]

let btnPrimary, btnPrimaryStyle = createButton primary Types.Color.Color.White
let btnSecondary, btnSecondaryStyle = createButton secondary Types.Color.Color.White
let btnTertiary, btnTertiaryStyle = createButton tertiary Types.Color.Color.Black

let btnStyles = [ btnPrimaryStyle; btnSecondaryStyle; btnTertiaryStyle ]
