namespace Setup

module phases =

    let phaseOne =
        [<Literal>]
        let introDialogue = "Hello...seEms yOu ave the SyStem me on."
        introDialogue |> String.iter (fun c -> printf $"%s{introDialogue}")
        printfn "Hello"