namespace FileSystem
/// The `FileTypes` module defines basic data types for representing a file system structure.
///
/// This module includes:
/// - A `File` type, which models a file with a name and its content.
module FileTypes =
    /// Represents a file in a file system.
    ///
    /// A file has the following properties:
    /// - `Name`: The name of the file as a string.
    /// - `Content`: The content of the file, represented as a string.
    type File = {
        Name: string
        Content: string // or byte[], or custom type
    }
    






