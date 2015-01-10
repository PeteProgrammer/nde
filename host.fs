module Host
open System
open Nancy
open Nancy.Hosting.Self

let bootstrapper = new DefaultNancyBootstrapper ()
let nancyHost = 
  new NancyHost(
    bootstrapper, 
    new Uri("http://localhost:1239/"), 
    new Uri("http://127.0.0.1:1239/"))

let startHost () = 
  nancyHost.Start()

let stopHost () = 
  nancyHost.Stop()
