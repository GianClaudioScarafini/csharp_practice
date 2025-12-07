namespace _01_Buddy.Tests;

public class MyNameTests
{
    [Fact]
    public void GetName_ShouldReturnCorrectMessage()
    {
        // Arrange & Act
        string result = MyName.GetName();

        // Assert
        Assert.Equal("Your Name from GitHub is the following:", result);
    }

    [Fact]
    public void GetMynamefromGitHub_WithValidURL_ShouldReturnUsername()
    {
        // Arrange
        string gitURL = "https://github.com/GianClaudioScarafini/csharp_practice";

        // Act
        string result = MyName.GetMynamefromGitHub(gitURL);

        // Assert
        Assert.Equal("GianClaudioScarafini", result);
    }

    [Fact]
    public void GetMynamefromGitHub_WithNullURL_ShouldReturnInvalidMessage()
    {
        // Arrange
        string gitURL = null;

        // Act
        string result = MyName.GetMynamefromGitHub(gitURL);

        // Assert
        Assert.Equal("Invalid GitHub URL.", result);
    }

    [Fact]
    public void GetMynamefromGitHub_WithEmptyURL_ShouldReturnInvalidMessage()
    {
        // Arrange
        string gitURL = "";

        // Act
        string result = MyName.GetMynamefromGitHub(gitURL);

        // Assert
        Assert.Equal("Invalid GitHub URL.", result);
    }

    [Fact]
    public void GetMynamefromGitHub_WithNonGitHubURL_ShouldReturnInvalidMessage()
    {
        // Arrange
        string gitURL = "https://gitlab.com/username/repo";

        // Act
        string result = MyName.GetMynamefromGitHub(gitURL);

        // Assert
        Assert.Equal("Invalid GitHub URL.", result);
    }

    [Fact]
    public void GetMynamefromGitHub_WithIncompleteURL_ShouldReturnInvalidMessage()
    {
        // Arrange
        string gitURL = "https://github.com";

        // Act
        string result = MyName.GetMynamefromGitHub(gitURL);

        // Assert
        Assert.Equal("Invalid GitHub URL.", result);
    }

    [Fact]
    public void GetMynamefromGitHub_WithOnlyUsername_ShouldReturnUsername()
    {
        // Arrange
        string gitURL = "https://github.com/JohnDoe";

        // Act
        string result = MyName.GetMynamefromGitHub(gitURL);

        // Assert
        Assert.Equal("JohnDoe", result);
    }
}