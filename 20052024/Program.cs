public class Program
{
    public static void Main()
    {
        string password = "SeSioS29#2";
        bool Valid = ValidatePassword(password);
        Console.WriteLine($"Password succesfully - {Valid}");
    }

    public static bool ValidatePassword(string password)
    {
        if (password.Length < 8)
        {
            return false;
        }

        if (!char.IsUpper(password[0]))
        {
            return false;
        }

        if (!password.Any(char.IsDigit))
        {
            return false;
        }

        if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
        {
            return false;
        }

        return true;
    }
}
