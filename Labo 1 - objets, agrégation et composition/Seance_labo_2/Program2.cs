using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        Library moulin = new Library("moulin");
        Book livre = new Book("livre de la jungle");
        Book LIVRE3 = new Book("La suite");
        Subscriber MICHel = new Subscriber("Michel", "rue neuve cours");

        livre.addChapter(1, "mowgli");
        moulin.addBook(livre);
        moulin.addBook(LIVRE3);
        moulin.addSubscriber(MICHel);
        moulin.displayBooks();
        moulin.Books[0].displayChapter();
        moulin.displaySubscribers();
    }
}

