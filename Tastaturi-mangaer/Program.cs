using Tastaturi_mangaer;

internal class Program
{
    private static void Main(string[] args)
    {
        UserService userService = new UserService();

        userService.AfisareUser();
    }
}