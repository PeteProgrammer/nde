module Main
open Host

[<EntryPoint>]
let main args = 
  startHost ()
  stopHost ()
  printfn "Hello world"
  0
