module Views.Shared.Layout

open Falco.Markup

let scripts = [ _script [ _type_ "module"; _src_ "js/lib/datastar.js" ] [] ]

let styles = [ _link [ _rel_ "stylesheet"; _href_ "css/styles.css" ] ]

let template (content: XmlNode list) =

    _html [ _lang_ "en" ] [ _head [] styles; _body [] (content @ scripts) ]
