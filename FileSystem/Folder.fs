namespace FileSystem

module FileTypes =
    type Folder = {
        Name: string
        Files: File list
        Subfolders: Folder list
    }
