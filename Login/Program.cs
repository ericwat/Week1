internal class Program
{
    public static void Main(string[] args)
    {
        // prompt the user to enter username and password
        string message = "Enter your user name and password\n";
        Console.WriteLine(message);
        // get the username
        string usernamePrompt = "Username :";
        Console.WriteLine(usernamePrompt);
        var username = Console.ReadLine();
        // get the password
        string passwordPrompt = "\npassword :";
        Console.WriteLine(passwordPrompt);
        var password = Console.ReadLine();

        // check if user exists
        var service = new UserService();
        
        // if user exists
        if (service.AuthenticateUser(username, password))
        {
            // if password matches display login successful    
            string loginSuccessMessage = "\nYou are logged in {0}";
            Console.WriteLine(loginSuccessMessage, username);
        }
        else
        {
            // did not fnd the user or match the password so tell the user the credentials are invalid
            string invalidCredentialsMessage = "\nUser name or password are incorrect. Try again.\nToo many attempts will lock your account.";
            Console.WriteLine(invalidCredentialsMessage);
        }
    }
}

public class UserService
{
    List<User> users = new List<User>();
    public UserService()
    {
        // create a user 
        var user = new User
        {
            FirstName = "Eric",
            LastName = "Watkins",
            Email = "name@domail.com",
            Username = "papasharp",
            Password = "sl1ckD3v"
        };

        // add the user to the mock user database
        users.Add(user);
    }


    public bool AuthenticateUser(string? username, string? password)
    {
        // assume the service will fail
        var result = false;

        // find the user. there will only be a user if both the username and password match.
        var user = users.Find(u => u.Username == username && u.Password == password);
        
        // user is not empty so we found it. set result to a successful state.
        if (user != null)
            result = true;
        
        return result;
    }
}
/// <summary>
/// Represents a user in the system. Assume all properties are required.
/// </summary>
public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}