[<AutoOpen>]
module Styles

open Fss
open Fss.Static

type ColorSet =
    { Enabled: Fss.Types.Color.Color
      Hover: Fss.Types.Color.Color
      Active: Fss.Types.Color.Color
      Disabled: Fss.Types.Color.Color }
