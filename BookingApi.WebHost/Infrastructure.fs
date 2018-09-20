namespace Ploeh.Samples.Booking.HttpApi.HttpHost

open System
open System.Web.Http
open Ploeh.Samples.Booking.HttpApi.Infrastructure

type HttpRouteDefaults = { Controller : string; Id : obj }

type Global() = 
    inherit System.Web.HttpApplication()
    member _this.Application_Start (_ : obj) (_ : EventArgs) = 
        Configure GlobalConfiguration.Configuration