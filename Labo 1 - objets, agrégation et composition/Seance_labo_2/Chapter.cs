class Chapter
{
    private int number;
    private string title;

    public Chapter(int number, string title)
    {
        this.number = number;
        this.title = title;
    }

    public override string ToString()
    {
        return $"{number} : {title}";
    }

 }
