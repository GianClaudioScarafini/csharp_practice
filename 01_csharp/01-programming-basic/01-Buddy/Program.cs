public class Program
{
    public static void Main(string[] args)
    {
        // Call the GetName method from MyName class and print the result
        string name = MyName.GetName();
        System.Console.WriteLine(name);
        System.Console.WriteLine("paste your GitHub URL here:");
        string gitURL= Console.ReadLine();
        string namegit = MyName.GetMynamefromGitHub(gitURL);
        System.Console.WriteLine(namegit);
    }
}

public class MyName
{
    public static string GetName()
    {
        return "Your Name from GitHub is the following:";
    }

    public static string GetMynamefromGitHub( string gitURL )
    {
        if (string.IsNullOrEmpty(gitURL))
        {
            return "Invalid GitHub URL.";
        }
        else if (gitURL.StartsWith("https://github.com/")== false)
        {
            return "Invalid GitHub URL.";
        }
        else
        {
            // Extract the username from the URL
            string[] parts = gitURL.Split('/');
            if (parts.Length >= 4)
            {
                return parts[3]; // The username is the fourth part of the URL
            }
            else
            {
                return "Invalid GitHub URL.";
            }
        }
    }
}
