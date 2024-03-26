using KonyvtarLibrary.Data;

KonyvtarContext db = new KonyvtarContext();

if (!db.Kolcsonzok.Any())
{
    var sorok = File.ReadAllLines(@"C:\Users\diak\Downloads\kolcs\Kolcsonzesek.csv").Skip(1);
    foreach (var line in sorok)
        db.Kolcsonzok.Add(new KonyvtarLibrary.Models.Kolcsonzok(line));
        db.SaveChanges();

    Console.WriteLine("'Kolcsonzesek' importálása sikeres!");
}
else
{
    Console.WriteLine("'Kolcsonzesek' nem létezik!");
}