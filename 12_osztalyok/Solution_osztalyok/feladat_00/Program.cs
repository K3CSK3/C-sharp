using feladat_00;

Motorcycle honda = new Motorcycle();
honda.Manufacturer = "Honda";
honda.Model = "CB 600F Hornet";
honda.YearOfProduction = 2008;
honda.ToString();

Console.Write(honda);

Movie johnWick = new Movie();
johnWick.Genre = "Action/Thriller";
johnWick.MovieLength = 101;
johnWick.ReleaseYear = 2014;
johnWick.Director = "Chad Stahelski";
johnWick.MovieName = "John Wick";

Console.Write(johnWick);

Firearm gun = new Firearm();
gun.Manufacturer = "Gaston Glock";
gun.MagazineSize = 17;
gun.YearOfProduction = 1982;
gun.Caliber = "9x19 mm";
gun.Model = "Glock-18";

Console.Write(gun);