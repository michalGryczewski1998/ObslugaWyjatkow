
using System.Collections.Generic;
using Wyjatki;
using Wyjatki.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            WyszukajAuta();
        }
        catch(DefektException ex) 
        {
            Console.WriteLine(ex.Message);
        }

    }

    private static void WyszukajAuta()
    {
        var listaPrzedPrzeszukaniem = SeedData();

        if (listaPrzedPrzeszukaniem.Any())
        {
            var defekt = listaPrzedPrzeszukaniem.FirstOrDefault(x => x.Rocznik == DateTime.MinValue);
            if (defekt != null)
            {
                throw new DefektException("Znaleziono błędnie dodany pojazd do kolekcji !");
            }
        }
    }

    public static List<Auto> SeedData()
    {
        var listaAut = new List<Auto>
        {
            new()
            {
                Marka = "Audi",
                Model = "A6",
                TypNadwozia = "Sedan",
                IloscDrzwi = 5,
                Silnik = String.Empty,
                MocSilnika = 225,
                SpalanieNaStoKilometrow = 7,
                Rocznik = new DateTime(2024, 01, 20)
            },

            new()
            {
                Marka = "BMW",
                Model = "E36",
                TypNadwozia = "Sedan",
                IloscDrzwi = 3,
                Silnik = "2.5L R6 turbodiesel (M51D25)",
                MocSilnika = 235,
                SpalanieNaStoKilometrow = 9,
                Rocznik = DateTime.MinValue
            },

            new()
            {
                Marka = "Volvo",
                Model = "V60",
                TypNadwozia = "Sedan",
                IloscDrzwi = 5,
                Silnik = "2.0L czterocylindrowy silnik wysokoprężny z bezpośrednim wtryskiem paliwa",
                MocSilnika = int.MinValue,
                SpalanieNaStoKilometrow = int.MinValue,
                Rocznik = DateTime.MaxValue
            }
        };

        return listaAut;
    }
}