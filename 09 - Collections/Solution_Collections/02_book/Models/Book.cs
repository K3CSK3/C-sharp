public class Books
{
    public string WriterFirstName { get; set; }
    public string WriterLastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }
    public string Publisher { get; set; }
    public int PublishYear { get; set; }
    public int Price { get; set; }
    public string Topic { get; set;}
    public int PageNumber { get; set; }
    public int Honorarium { get; set; }

    public Books() {}

    public Books(string writerFirstName, string writerLastName, DateTime birthDate, string title, string isbn, string publisher, int publishYear, int price, string topic, int pageNumber, int honorarium)
    {
        WriterFirstName = writerFirstName; //
        WriterLastName = writerLastName; //
        BirthDate = birthDate; //
        Title = title; //
        ISBN = isbn;
        Publisher = publisher; //
        PublishYear = publishYear; //
        Price = price; //
        Topic = topic; //
        PageNumber = pageNumber; //
        Honorarium = honorarium; //
    }

    public override string ToString()
    {
        return $"ISBN({ISBN}) -- {WriterFirstName} {WriterLastName}({BirthDate.Year}.{BirthDate.Month}.{BirthDate.Day}) -- {Title}({PublishYear}) - {Topic} Published by {Publisher} costs {Price} Honorarium:{Honorarium},Page number:{PageNumber}";
    }
}