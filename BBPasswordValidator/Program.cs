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
            if (password.Length < _passwordMinLength)
            {
                return false;
            }

            if (password.Length > _passwordMaxLength)
            {
                return false;
            }

            if (!HasUppercase(password))
            {
                return false;
            }

            if (!HasLowercase(password))
            {
                return false;
            }

            if (!HasDigits(password))
            {
                return false;
            }

            if (Contains(password, 'T'))
            {
                return false;
            }

            if (Contains(password, '&'))
            {
                return false;
            }

            return true;
        }

        bool HasUppercase(string password)
        {
            foreach(char letter in password)
            {
                if(Char.IsUpper(letter))
                {
                    return true;
                }
            }
            return false;
        }

        bool HasLowercase(string password)
        {
            foreach (char letter in password)
            {
                if (Char.IsLower(letter))
                {
                    return true;
                }
            }
            return false;
        }
        bool HasDigits(string password)
        {
            foreach (char letter in password)
            {
                if (Char.IsDigit(letter))
                {
                    return true;
                }
            }
            return false;
        }

        bool Contains(string password, char letter)
        {
            foreach (char character in password)
            {
                if (character == letter)
                {
                    return true;
                }
            }
            return false;
        }
    }
}