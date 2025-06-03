using System.Security.Cryptography;

namespace UML_Classes;

public class CloudStorage
{
    static public void CloudStorageMain()
    {
        User user1 = new User()
        {
            UserId = RandNum(),
            Name = "John",
            Email = "examplebox@email.com",
            Password = "123456"
        };

        CloudFile file1 = new CloudFile()
        {
            Name = "text",
            Size = 15,
            Type = ".txt",
            Owner = user1
        };

        Access file1Access = new Access()
        {
            Level = "w"
        };
        
        user1.CreateFolder("testFolder", user1);
        user1.Folders[0].AddFile(file1, user1.Folders[0]);
        
        user1.ProvideAccess(file1, user1, file1Access);
    }

    private static int RandNum()
    {
        Random random = new Random();
        return random.Next(100000, 777777);
    }
}
file class User : FetchPull
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public List<Folder> Folders { get; set; }

    public void Download(CloudFile file)
    {
        Console.WriteLine($"File {file.Name} downloaded.");
    }

    public void CreateFolder(string folderName, User owner)
    {
        Folder newFolder = new Folder()
        {
            Name = folderName,
            Owner = owner
        };
        Folders.Add(newFolder);
    }

    public void ProvideAccess(CloudFile file, User user, Access access)
    {
        access.File = file;
        access.User = user;
    }
}

file class FetchPull
{
    public DateTime Date { get; set; }
    public CloudFile FetchPullFile { get; set; }
    public string Status { get; set; }

    public void PerformFetchPull()
    { 
        Date = DateTime.Now;
        try
        {
            // Cloud synchronization...
            Status = "successfully";
            Console.WriteLine($"Synchronization status: {Status}.");
        }
        catch (Exception e)
        {
            Status = "error";
            Console.WriteLine($"Synchronization status: {Status}.");
            Console.WriteLine("Try again.");
            throw;
        }
        
    }
}

file class Folder
{
    public string Name { get; set; }
    public User Owner { get; set; }
    public Folder ParentFolder { get; set; }
    public List<CloudFile> Files { get; set; }
    public List<Folder> ChildFolders { get; set; }

    public void AddFile(CloudFile file, Folder fileFolder)
    {
        file.Folder = fileFolder;
        Files.Add(file);
    }

    public void AddChildFolder(Folder folder)
    {
        ChildFolders.Add(folder);
    }
}

file class CloudFile : Access
{
    public string Name { get; set; }
    public int Size { get; set; }
    public string Type { get; set; }
    public User Owner { get; set; }
    public Folder Folder { get; set; }
}

file class Access
{
    public string Level { get; set; }
    public User User { get; set; }
    public CloudFile File { get; set; }

    public void EditAccess(string level)
    {
        Level = level;
    }
}