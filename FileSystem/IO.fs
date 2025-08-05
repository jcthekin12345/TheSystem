namespace FileSystem
open FileTypes
module IO =
    
   let rec addFile (path: string list) (file: File) (folder: Folder) : Folder =
    match path with
    | [] ->
        { folder with
            Files = file :: folder.Files }
    | dir :: rest ->
        let updatedSubfolders =
            folder.Subfolders
            |> List.map (fun sub -> if sub.Name = dir then addFile rest file sub else sub)

        { folder with
            Subfolders = updatedSubfolders }
    