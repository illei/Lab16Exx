// See https://aka.ms/new-console-template for more information
using Lab16Exx.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");
Ex1();
void Ex2()
{
    using var autovehicule = new AutovehiculDbContext();
    //SeedDB();
   // Afisati toate autovehiculele in ordinedescrescatoare a anului de fabricatie
    autovehicule.Autovehicule
        .Include(x => x.Producator)
        .OrderBy(x => x.AnFabricatie)
        .ToList();
    //.ForEach(a=> Console.WriteLine(a));
    //Afisati autovehiculele grupate in functiede numele producatorului:
        var Gurpate = autovehicule.Autovehicule
        .Include(a => a.Producator)
        .GroupBy(a => a.Producator.Nume)
        .ToList();

    foreach (var group in Gurpate)
    {
        Console.WriteLine(group.Key + ":");
        foreach (var autovehicul in group)
        { Console.WriteLine(autovehicul); };

    }
}
 static void SeedDB() 
{
    var VW = new Producator
    {
        Adresa = "Cazaban 15",
        Nume = "Voltswagen",
    };

    var Audi = new Producator
    {
        Adresa = "Aradului 12",
        Nume = "Audi",
    };
    var BMW = new Producator
    {
        Adresa = "Clujului 20",
        Nume = "BMW",
    };
    var Dacia = new Producator
    {
        Adresa = "Cuza  voda 22",
        Nume = "Dacia"
    };

    using var autovehiculeContext = new AutovehiculDbContext();

    autovehiculeContext.Autovehicule.Add(
        new Autovehicul
        {
            Nume = "Golf6",
            SerieSasiu = "WZX2289018390",
            AnFabricatie = 2009,
            Producator = new Producator {
                Adresa = "Cazaban 15",
                Nume = "Voltswagen",
            }
        });

    autovehiculeContext.Autovehicule.Add(
       new Autovehicul
       {
           Nume = "Audi A3",
           SerieSasiu = "WARM2289018390",
           AnFabricatie = 2007,
           Producator = new Producator
           {
               Adresa = "Aradului 12",
               Nume = "Audi",
           }

       });

    autovehiculeContext.Autovehicule.Add(
       new Autovehicul
       {
           Nume = "M3",
           SerieSasiu = "BMS2289018390",
           AnFabricatie = 2019,
           Producator = new Producator() {
               Adresa = "Clujului 20",
               Nume = "BMW",
           }
       });

    autovehiculeContext.Autovehicule.Add(
       new Autovehicul
       {
           Nume = "Logan",
           SerieSasiu = "RNO1ik3134933",
           AnFabricatie = 2020,
           Producator = new Producator {
               Adresa = "Cuza  voda 22",
               Nume = "Dacia"
           }

       });
    autovehiculeContext.Autovehicule.Add(
       new Autovehicul
       {
           Nume = "Golf 7",
           SerieSasiu = "WZX22823232390",
           AnFabricatie = 2017,
           Producator = new Producator {
               Adresa = "Cazaban 15",
               Nume = "Voltswagen",
           }
       });

    autovehiculeContext.Autovehicule.Add(
       new Autovehicul
       {
           Nume = "Seria 3",
           SerieSasiu = "WZX2289018390",
           AnFabricatie = 2006,
           Producator = new Producator {
               Adresa = "Clujului 20",
               Nume = "BMW",
           }
       });

    autovehiculeContext.Autovehicule.Add(
       new Autovehicul
       {
           Nume = "Dokker",
           SerieSasiu = "RNO1289018390",
           AnFabricatie = 2020,
           Producator = new Producator
           {
               Adresa = "Cuza  voda 22",
               Nume = "Dacia"
           }
       });

    autovehiculeContext.SaveChanges();

}
 void Ex1()
{
    using var catalog = new StudentDBContext();

    catalog.Database.EnsureCreated();
    SeedDB();
    //• Afisati toti studentii din DB inordine alfabetica
    /*catalog
       .Students
       .OrderBy(s => s.FirstName)
       .ToList()
       .ForEach(s => Console.WriteLine(s));*/
    var deGasit = catalog.Students
       //Afisati cel mai tanar student dela constructii cu varsta de peste 20 de ani
        .Where(s => s.Specializare == Majors.Constuction && s.Age > 20)
        .OrderBy(s => s.Age)
        .FirstOrDefault();
    Console.WriteLine(deGasit);

    static void SeedDB()
    {
        using var CatalogContex = new StudentDBContext();

        CatalogContex.Students.Add(
           new Student
           {
               FirstName = "Rebenciuc",
               LastName = "Dorel",
               Age = 22,
               Specializare = Majors.Constuction



           });

        CatalogContex.Students.Add(
           new Student
           {
               FirstName = "Cizmar",
               LastName = "Gabi",
               Age = 19,
               Specializare = Majors.Constuction



           });

        CatalogContex.Students.Add(
           new Student
           {
               FirstName = "Davos",
               LastName = "marcel",
               Age = 33,
               Specializare = Majors.Constuction



           });



        CatalogContex.Students.Add(
           new Student
           {
               FirstName = "Valeriu",
               LastName = "Alex",
               Age = 31,
               Specializare = Majors.Info

           });

        CatalogContex.Students.Add(
          new Student
          {
              FirstName = "Constatinopo",
              LastName = "Danut",
              Age = 22,
              Specializare = Majors.Info
          });

        CatalogContex.Students.Add(
           new Student
           {
               FirstName = "Cojocaru",
               LastName = "Marcel",
               Age = 18,
               Specializare =
                Majors.Letters

           });
        CatalogContex.Students.Add(
          new Student
          {
              FirstName = "Avramescu",
              LastName = "Dan",
              Age = 18,
              Specializare =
                Majors.Letters

          });
        CatalogContex.SaveChanges();
    }
}
