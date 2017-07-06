module Info.View

open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Core.JsInterop
open Elmish.Bulma.Elements

let root =
  div
    [ ClassName "content" ]
    [ h1
        [ ]
        [ str "Location" ]
      p [ ] [ str "This template is a simple application build with Fable + Elmish + React." ]
      Image.image [] [img [Src "img/cap-sciences.jpg"]]
      iframe [
        Src "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d5656.240080660091!2d-0.5584963664357877!3d44.85985097909837!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0xd55288fe041f36f%3A0xc849cfd5c16a7bb8!2sCap+Sciences!5e0!3m2!1sen!2ses!4v1499327326158"
        Style [Border 0; Height 450; CSSProp.Width "100%"]
        AllowFullScreen true
      ] []

    ]
