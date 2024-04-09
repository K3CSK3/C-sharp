namespace BeerApp;

public static class Menu
{
    public static async void Main()
    {
        int id = ExtendedConsole.ReadInteger("Enter the ID of the beer you want to look at: ",0);

        Beer beer = await BeerService.GetByIdAsync(id);

        beer.WriteToConsole();
    }
}