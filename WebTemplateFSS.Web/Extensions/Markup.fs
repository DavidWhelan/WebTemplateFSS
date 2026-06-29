module Falco.Markup.Extensions

module Attr =
    let classList (x: string list) =
        let classes = x |> List.map (fun s -> s.Trim()) |> String.concat " "
        _class_ classes

[<AutoOpen>]
module Html =
    // fsharplint:disable-next-line
    let inline _classList_ s = Attr.classList s
