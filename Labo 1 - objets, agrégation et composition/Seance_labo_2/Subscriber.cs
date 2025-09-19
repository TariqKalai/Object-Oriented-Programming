class Subscriber
{
    private string name;
    private string adress;

    public Subscriber(string name, string adress)
    {
        this.name = name;
        this.adress = adress;

    }
    
    public override string ToString()
    {
        return $"{name} : {adress}";
    }
 }

