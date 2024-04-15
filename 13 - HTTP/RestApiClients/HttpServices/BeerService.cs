namespace HttpServices;

public class BeerService: BaseService
{
    public static async Task<List<Beer>> GetAllBeersAsync()
    {
        List<Beer> beers = await SendGetRequestAsync<List<Beer>>("api/beer/get-all");

        return beers;
    }
    public static async Task<Beer> GetBeerByIdAsync(int id)
    {
        Beer beer = await SendGetRequestAsync<Beer>("api/beer/get", id);

        return beer;
    }
    public static async Task<List<Beer>> GetFiveBeersAsync(int starterId)
    {
        int endId = starterId + 4;
        List<Beer> beers = new List<Beer>();
        for (int i = starterId; i <= endId; i++)
        {
            Beer beer = await GetBeerByIdAsync(i);
            beers.Add(beer);
        }

        return beers;
    }
}