string name;
string food;
string place;


Console.WriteLine("Vad är ditt namn?");
name = Console.ReadLine();

Console.WriteLine("Vad är din favorit mat?");
food = Console.ReadLine();

Console.WriteLine("Vad är din favorit plats?");
place = Console.ReadLine();

Console.WriteLine($"{name} gick på en promenad till butiken och köpte {food}, sedan gick han till {place} och åt.");

Console.ReadLine();