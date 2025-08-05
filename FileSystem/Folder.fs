namespace FileSystem
/// The `FileTypes` module contains data types representing files and folders.
///
/// This module includes:
/// - A `File` type representing a single file with a name and content.
/// - A `Folder` type representing a folder with a name, a collection of files,
///   and a collection of subfolders.
module FileTypes =
    /// Represents a folder in a file system.
    ///
    /// A folder has the following properties:
    /// - `Name`: The name of the folder as a string.
    /// - `Files`: A list of `File` objects representing the files contained in the folder.
    /// - `Subfolders`: A list of `Folder` objects representing the subfolders contained within the folder.
    type Folder = {
        Name: string
        Files: FileTypes.File list
        Subfolders: Folder list
    }
