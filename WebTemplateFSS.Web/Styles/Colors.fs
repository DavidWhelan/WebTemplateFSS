module Colors

open Fss

type ColorSet =
    { Enabled: Fss.Types.Color.Color
      Hover: Fss.Types.Color.Color
      Active: Fss.Types.Color.Color
      Disabled: Fss.Types.Color.Color }


//Color Palatte: https://colorhunt.co/palette/ebe1d141644a0d4715e9762b
let primary =
    { Enabled = hex "0D4715"
      Hover = hex "35663C"
      Active = hex "092F0E"
      Disabled = hex "D7E0D8" }

let secondary =
    { Enabled = hex "E9762B"
      Hover = hex "ED8D4E"
      Active = hex "9B4F1D"
      Disabled = hex "FBE8DC" }

let tertiary =
    { Enabled = hex "EBE1D1"
      Hover = hex "EEE6D9"
      Active = hex "9D968B"
      Disabled = hex "F8F5F0" }
