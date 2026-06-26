module Views.Shared.Layout

open Falco.Markup

let scripts = [ _script [ _type_ "module"; _src_ "js/lib/datastar.js" ] [] ]

let template (content: XmlNode list) =

    _html [ _lang_ "en" ] [ _head [] Theme.css; _body [] (content @ scripts) ]
