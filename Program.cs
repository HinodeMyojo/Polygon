using Polygon;

using ( ApplicationContext db = new ApplicationContext( ) )
{
    Planet mars = new Planet { Name = "Марс", Radius = 1234 };
    Planet jupiter = new Planet { Name = "Юпитер", Radius = 9999 };

    db.Planets.Add(mars);
    db.Planets.Add(jupiter);
    db.SaveChanges();
    Console.WriteLine("Все усспешно сохранено");

    var plantes = db.Planets.ToList();
    Console.WriteLine("Список планет: ");
    foreach (Planet? planet in plantes)
    {
        Console.WriteLine($"{planet.Id}.{planet.Name} = {planet.Radius}");
    }

}