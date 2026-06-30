module Views.Shared.Layout

open Falco.Markup

let scripts = [ _script [ _type_ "module"; _src_ "js/lib/datastar.js" ] [] ]

let template (style: XmlNode list) (content: XmlNode list) =

    _html [ _lang_ "en" ] [ _head [] style; _body [] (content @ scripts) ]
