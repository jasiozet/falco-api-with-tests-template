module Logic

type BasicOperation = Addition | Multiplication

let HelloThere name =
  $"Hello {name}"

let ExecuteBasicOperation operation a b =
  match operation with
  | Addition -> a + b |> string
  | Multiplication -> a * b |> string