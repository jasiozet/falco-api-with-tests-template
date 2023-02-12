open Falco
open Falco.Routing
open Falco.HostBuilder
open Falco.Markup
open Logic

let indexView =
  Elem.html [] [
    Elem.head [] [ Elem.title [] [ Text.raw "Falco Sample" ]]
    Elem.body [] [
      Elem.h1 [] [ Text.raw "I |> F#" ]
      Elem.p [Attr.class' "some-css-class"; Attr.id "someId"] [ Text.raw "Hello World"]
    ]
  ]

let defaultPage = Response.ofHtml indexView
let executeBasicOpHandler operation : HttpHandler =
  let getResult (route : RouteCollectionReader) =
    let a = route.GetInt "a" 0
    let b = route.GetInt "b" 0
    ExecuteBasicOperation operation a b
  Request.mapRoute getResult Response.ofPlainText

[<EntryPoint>]
let main args =
  webHost args {
    endpoints [
        get "/mul/{a:int}/{b:int}" (executeBasicOpHandler Multiplication)
        get "/add/{a:int}/{b:int}" (executeBasicOpHandler Addition)
        get "/json"                (Response.ofJson {| Message="Hello World"; Language="F#" |})
        get "/"                    defaultPage
    ]
  }
  0

//Tests:
//http://localhost:5000/add/2/3 => 5
//http://localhost:5000/mul/2/3 => 6
//http://localhost:5000/json => {"language":"F#","message":"Hello World"}
//http://localhost:5000/ => htmled I |> F# Hello World