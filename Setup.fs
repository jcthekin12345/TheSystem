namespace Setup

open System


module dialogue =
     [<Literal>]
     let introDialogue: string = "Hello..yOu ave switched oN the System."
     
module phases =
     let phaseOne =
        printfn "%s" dialogue.introDialogue


