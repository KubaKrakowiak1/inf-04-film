class Program
{
    static void Main(string[] args)
    {
        Film film = new();
        Console.WriteLine("Przed inicjalizacją:");
        Console.WriteLine(film.getTytul());
        film.setTytul("tytl1");
        Console.WriteLine("Po inicjalizacji: ");
        Console.WriteLine(film.getTytul());

        Console.WriteLine("Przed metodą: ");
        Console.WriteLine(film.getLiczbaWypozyczen());
        Console.WriteLine("Po metodzie: ");
        film.DodajLiczbaWypozyczen();
        Console.WriteLine(film.getLiczbaWypozyczen());
    }
}

class Film
{
    protected string tytul;
    protected int liczbaWypozyczen;

    public Film()
    {
        tytul = string.Empty;
        liczbaWypozyczen = 0;
    }

    public string getTytul()
    {
        return tytul;
    }

    public void setTytul(string nowyTytul)
    {
        if(nowyTytul.Length > 20)
        {
            tytul = nowyTytul.Substring(0, 20);
        }
        else
        {
            tytul = nowyTytul;
        }
    }

    public int getLiczbaWypozyczen()
    {
        return liczbaWypozyczen;
    }

    public void DodajLiczbaWypozyczen()
    {
        liczbaWypozyczen += 1;
    }
}

/*
 * ******************************************************
 nazwa klasy: Film
 pola: tytul - przechowuje tytuł filmu (łańcuch znaków o maksymalnej długości 20 znaków)
       liczbaWypozyczen - przechowuje całkowitą liczbę wypożyczeń filmu
 metody: Film, brak (konstruktor) – inicjalizuje pole tytul wartością pustą oraz pole liczbaWypozyczen wartością 0
         getTytul, string – zwraca aktualny tytuł filmu
         setTytul, void – ustawia tytuł filmu, ograniczając go maksymalnie do 20 znaków w przypadku dłuższego tekstu
         getLiczbaWypozyczen, int – zwraca aktualną liczbę wypożyczeń filmu
         inkrementujLiczbeWypozyczen, void – zwiększa wartość pola liczbaWypozyczen o 1 (inkrementacja)
 informacje: Klasa realizuje mechanizm hermetyzacji z wykorzystaniem modyfikatora protected, 
             co umożliwia bezpieczny dostęp do pól również w klasach potomnych.
*****************************************************
 */