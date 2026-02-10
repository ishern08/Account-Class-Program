using System.Security.Principal;

namespace Capstone_Projects___Isabella_Hernandez;

class Program
{
    static void Main(string[] args)
    {
        int? x1;
        int? x2;

        x1 = 20;
        x2 = null;

        pracMethod(x1);
        pracMethod(x2);






    }

    public static void pracMethod(int? val)
    {
        if (val == null)
        {
            Console.WriteLine("The parameter does not have a value.");
        }
        else
        {
            Console.WriteLine(val);
        }
    }
}



