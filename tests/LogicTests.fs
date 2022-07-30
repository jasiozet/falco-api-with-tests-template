module Tests

open Logic
open Xunit
open FsUnit

[<Fact>]
let ``Hello there returns correct string`` () =
    HelloThere "Obi Wan Kenobi" |> should equal "Hello Obi Wan Kenobi"

[<Fact>]
let ``Addition operation for basic tests works`` () =
    ExecuteBasicOperation Addition 2 3 |> should equal "5"

[<Fact>]
let ``Multiplication operation for basic tests works`` () =
    ExecuteBasicOperation Multiplication 2 3 |> should equal "6"