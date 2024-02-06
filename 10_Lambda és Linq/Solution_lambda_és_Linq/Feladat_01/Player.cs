using System.Text.Encodings.Web;
using System.Text.Json;

namespace Feladat___01
{
    public class Player
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string ImageLink { get; set; }
        
        public string Club { get; set; }
        
        public string Position  { get; set; }
        
        public string Birthday { get; set; }
        
        public int Weight { get; set; }
        
        public double Height { get; set; }

        public Player()
        {
        }

        public Player(int id, string name, string imageLink, string club, string position, string birthday, int weight, double height)
        {
            Id = id;
            Name = name;
            ImageLink = imageLink;
            Club = club;
            Position = position;
            Birthday = birthday;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                PropertyNameCaseInsensitive = true,
                WriteIndented = true,
            };

            return JsonSerializer.Serialize(this, options);
        }
    }
}
