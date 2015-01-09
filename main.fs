module Main
open System
open Nancy
open Nancy.Hosting.Self

[<EntryPoint>]
let main args = 
  let bootstrapper = new DefaultNancyBootstrapper ()
  let nancyHost = 
    new NancyHost(
      bootstrapper, 
      new Uri("http://localhost:1239/"), 
      new Uri("http://127.0.0.1:1239/"))
  nancyHost.Start()
  nancyHost.Stop()
  printfn "Hello world"
  0
