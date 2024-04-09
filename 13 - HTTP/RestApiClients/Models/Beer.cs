using System.Text;

namespace Models;

public class Beer
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("price")]
    public string Price { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("image")]
    public string Image { get; set; }

    [JsonPropertyName("rating")]
    public Rating Rating { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"({this.Id}) Name: {this.Name}");
        sb.AppendLine($"Image {this.Image}");
        sb.AppendLine($"Price: {this.Price}");
        sb.AppendLine($"Rating:");
        sb.AppendLine($"{this.Rating?.Average} ({this.Rating?.Reviews} reviews)");
        return sb.ToString();
    }
}
