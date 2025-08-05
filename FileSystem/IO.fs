namespace FileSystem
open FileType
open FolderType
/// The `IO` module provides functionality for interacting with file system data structures.
///
/// This module contains:
/// - Functions for manipulating representations of files and folders,
///   such as adding a file to a folder structure.
module IO =
   /// Adds a file to a folder structure, creating any necessary subfolders along the specified path.
   ///
   /// Parameters:
   /// - `path`: A list of folder names representing the path where the file should be added.
   ///           An empty list indicates that the file should be added at the root of the provided folder.
   /// - `file`: The file to be added. It consists of a name and content.
   /// - `folder`: The root of the folder structure where the file should be added.
   ///
   /// Returns:
   /// A new folder structure with the specified file added.
   ///
   /// Behavior:
   /// - If the `path` is empty, the file is added to the root folder's file list.
   /// - If a folder name in the `path` matches the name of an existing subfolder,
   ///   the function recursively navigates into that subfolder.
   /// - If a folder name in the `path` does not exist, the folder structure remains unmodified for that branch.
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
    