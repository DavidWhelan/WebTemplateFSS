module Falco.Markup.Extensions

module Elem =
    let styleList (attrs: XmlAttribute list) (css: string list) =
        let styles = css |> List.map (fun s -> s.Trim()) |> String.concat ""
        _style attrs [ Text.raw styles ]

module Attr =
    let classList (x: string list) =
        let classes = x |> List.map (fun s -> s.Trim()) |> String.concat " "
        _class_ classes

[<AutoOpen>]
module Html =
    // fsharplint:disable-next-line
    let inline _classList_ s = Attr.classList s
    let inline _styleList attrs css = Elem.styleList attrs css
