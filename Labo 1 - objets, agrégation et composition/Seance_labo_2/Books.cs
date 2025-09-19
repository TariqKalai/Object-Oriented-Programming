using System.Runtime.CompilerServices;

class Book
{
    private string book_title;
    private List<Chapter> Chapters = new List<Chapter>();

    public Book(string title)
    {

        this.book_title = title;
    }

    public override string ToString()
    {
        return book_title;
    }

    public void addChapter(int number, string title)
    {
        Chapters.Add(new Chapter(number, title));
    }

    public void displayChapter()
    {

        foreach (Chapter chap in Chapters)
        {
            Console.WriteLine(chap);
        }
    }
 }

