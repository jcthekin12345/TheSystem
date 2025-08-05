namespace FileSystem

module FileTypes =
    type Folder = {
        Name: string
        Files: FileTypes.File list
        Subfolders: Folder list
    }
