namespace BBPasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasswordValidator passwordValidator = new PasswordValidator();
                                   
            while(true)
            {
                Console.WriteLine("Please enter a password");
            string? input = Console.ReadLine();
                Console.WriteLine($"Is the password valid? {passwordValidator.IsPasswordValid(input)}");                
            }            
        }
    }

    internal class PasswordValidator
    {
        private const int _passwordMinLength = 6;
        private const int _passwordMaxLength = 13;
        public bool IsPasswordValid(string password)
        {
            bool passwordValid = false;
            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasNumber = false;
            bool invalidCharactor = false;
            

            if(password.Length >= _passwordMinLength && password.Length <= _passwordMaxLength)
            {
                
                foreach (char letter in password)
                {

                    if (char.IsUpper(letter))
                    {
                        hasUpperCase = true;
                    }
                    
                    if (char.IsLower(letter))
                    {
                        hasLowerCase = true;
                    }
                    
                    if (char.IsNumber(letter))
                    {
                        hasNumber = true;
                    }
                    
                    if (letter == 'T' || letter == '&')
                    {
                        invalidCharactor = true;
                    }

                }                        
                
                if (hasUpperCase && hasLowerCase && hasNumber && !invalidCharactor)
                {
                    passwordValid = true;
                }
            }

            return passwordValid;
        }
    }
}