using Tastaturi_mangaer;

internal class Program
{
    private static void Main(string[] args)
    {
        UserService userService = new UserService();

        User userNou = new User(6, "gtreg@gmail.com", "gfer", 0754353);

        userService.AddUser(userNou);

        userService.SaveData();
    }
}