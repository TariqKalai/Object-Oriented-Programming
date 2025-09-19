
Quadratic x = new Quadratic();

x.Solve();

class Quadratic
{

    public void Solve()
    {
        
        // Il y aurait moyen de mieux résoudre en mettant les entrées ailleurs
        // et en laissant juste la partie calcul, mais flemme pour l’instant, ça fonctionne

        Console.WriteLine("Recherche des racines de ax^2 + bx + c");


        Console.WriteLine("Coefficient a :");
        int a = Quadratic.Catcherrors();

        Console.WriteLine("Coefficient b");
        int b = Quadratic.Catcherrors();

        Console.WriteLine("Coefficient c");
        int c = Quadratic.Catcherrors();


        // Calcul du discriminant

        double delta = Math.Pow(b, 2) - 4 * a * c;

        Console.WriteLine("delta : " + delta + "\n");

        // Test des trois cas possibles et affichage des racines du trinôme

        switch (delta)
        {
            case < 0:
                Console.WriteLine("Pas de racine réelle");
                break;

            case 0:
                double x = -b / (2 * a);
                Console.WriteLine("Une racine réelle double : " + x);
                break;
            case > 0:
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Deux racines réelles distinctes : " + x1 + " et " + x2);
                break;
        }



    }


    /// <summary>
    /// Reads an integer from console and retries until user inputs an int
    /// </summary>
    /// <returns>Int</returns>
    private static int Catcherrors()
    {
        while(true)
        {
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }

            catch (FormatException)
            {
                Console.WriteLine("Input is not an INT, Try again : \n");
                return Quadratic.Catcherrors();
            }
        }
    }
}

