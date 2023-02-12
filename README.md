# F# Falco API with tests template

## How to use it

Clone the repo!

## Requirements

[dotNET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
(you can downgrade dotnet version to 6.0 easily in the fsproj files)

Editor capable of working with F#, I personally recommend:
* [Visual Studio Code](https://code.visualstudio.com/) and [Ionide plugin](https://ionide.io/)

Other options:
* [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* [Rider](https://www.jetbrains.com/rider/)

## Stuff inside API

* [Falco](https://www.falcoframework.com/)
* [Feliz.ViewEngine](https://github.com/dbrattli/Feliz.ViewEngine)

The reason for using Feliz.ViewEngine is that I heavily use it in frontend application and if I were to write SSR I would prefer to use it for consistency. As this is a template I use myself, this is what I wanted here. Feel free to remove it.
Similar stuff written in Falco.Markup have looked like this:
```fsharp
let indexView =
  Elem.html [] [
    Elem.head [] [ Elem.title [] [ Text.raw "Falco Sample" ]]
    Elem.body [] [
      Elem.h1 [] [ Text.raw "I |> F#" ]
      Elem.p [Attr.class' "some-css-class"; Attr.id "someId"] [ Text.raw "Hello World"]
    ]
  ]

let defaultPage = Response.ofHtml indexView
```

Take a look at similar:
* [Saturn template](https://github.com/jasiozet/saturn-api-with-tests-template)
* [Giraffe template](https://github.com/jasiozet/giraffe-api-with-tests-template)

## Stuff inside TESTS
* [xUnit](https://xunit.net/)
* [FsUnit](https://fsprojects.github.io/FsUnit/)

## How to run:
* api - ```cd api && dotnet run```
* tests - ```cd tests && dotnet test```

## What if I don't want tests?

Just remove the ```tests``` folder!

## Why make this template?

Comparison with Saturn & Giraffe templates I already made
This template is meant a nice fresh start, without much complication

## Routes to test:
* http://localhost:5000/add/2/3 => 5
* http://localhost:5000/mul/2/3 => 6
* http://localhost:5000/json => {"language":"F#","message":"Hello World"}
* http://localhost:5000/anyRoute => htmled I |> F# Hello World
