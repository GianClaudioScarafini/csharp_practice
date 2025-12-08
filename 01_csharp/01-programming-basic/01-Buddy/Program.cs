public class Program
{
    public static void Main(string[] args)
    {
        // Call the GetName method from MyName class and print the result
        string name = MyName.GetName();
        System.Console.WriteLine(name);
        System.Console.WriteLine("paste your GitHub URL here:");
        string? gitURL = Console.ReadLine();
        string namegit = MyName.GetMynamefromGitHub(gitURL ?? "");
        System.Console.WriteLine(namegit);
    }
}
