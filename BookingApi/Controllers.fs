namespace Ploeh.Samples.Booking.HttpApi

open System.Net
open System.Net.Http
open System.Web.Http

type HomeController() = 
    inherit ApiController()
    member _this.Get() = new HttpResponseMessage()

type ReservationsController() = 
    inherit ApiController()
    member _this.Post() (rendition : MakeReservationRendition) = 
        new HttpResponseMessage(HttpStatusCode.Accepted)
