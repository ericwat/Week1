
namespace Login
{
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
                string invalidCredentialsMessage =
                    "\nUser name or password are incorrect. Try again.\nToo many attempts will lock your account.";
                Console.WriteLine(invalidCredentialsMessage);
            }
        }
    }
}


