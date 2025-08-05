namespace Setup

open System
module phases =

    [<Literal>]
    let introDialogue = "Hello...seEms yOu ave the SyStem me on."
    
    let phaseOne =
        introDialogue |> String.iter (fun c -> printf $"%s{introDialogue}")
        printfn "Hello"