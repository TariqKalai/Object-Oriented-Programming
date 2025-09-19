class Library
{
    private string library_name;
    public readonly List<Subscriber> Subscribers = new List<Subscriber>();

    public readonly List<Book> Books = new List<Book>();


    public Library(string name)
    {
        library_name = name;
    }

    //creation d'une variable public get le libraryname
    public string Libraryname
    {
        get
        {
            return library_name;
        }
    }


    public void addSubscriber(Subscriber subscriber)
    {
        Subscribers.Add(subscriber);
    }


    public void addBook(Book book)
    {
        Books.Add(book);
    }

    // Affiche nos abonne ou nos livres
    public void displaySubscribers()
    {
        foreach (Subscriber sub in Subscribers)
        {
            Console.WriteLine(sub);
        }
    }


    public void displayBooks()
    {

         foreach (Book book in Books)
        {
            Console.WriteLine(book);
        }
    }
}

