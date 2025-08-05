namespace FileSystem

module Types =
    type Folder = {
        Name: string
        Files: File list
        Subfolders: Folder list
    }
