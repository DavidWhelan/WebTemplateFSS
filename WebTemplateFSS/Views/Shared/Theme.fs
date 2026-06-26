module Views.Shared.Theme

open Fss


module Button =
    let hoverClass, hoverStyle =
        fss [ BackgroundColor.green; Hover [ BackgroundColor.red ] ]


let css = [ Button.hoverStyle ]
