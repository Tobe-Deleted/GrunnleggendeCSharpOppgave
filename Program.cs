namespace GrunnleggendeCSharp;
//oppgave 1: lag et nytt prosjekt
class Program
{
    static void Main(string[] args)
    {
        //oppgave 2: 
        int number = 13;
        Console.WriteLine(number);
        string text = "Ørret";
        Console.WriteLine(text);
        double decimalNumber = 3.25;
        Console.WriteLine(decimalNumber);
        char letter = 'D';
        Console.WriteLine(letter);

        int[] integerArray = {1, 2, 3, 4, 7};

        for(int i = 0; i < integerArray.Count(); i++) 
        {
            Console.WriteLine(integerArray[i]);
        }
        string[] stringArray = {"nudler", "smaker", "godt!", "Men taco er bedre."};

        foreach( string strings in stringArray)
        {
            Console.WriteLine(strings);
        }

        List<string> stringList = new List<string>();

        stringList.Add("Nudler smaker godt!");
        stringList.Add("men");
        stringList.Add("taco");
        stringList.Add("smaker");
        stringList.Add("bedre.");

        foreach(string listStrings in stringList)
        {
            Console.WriteLine(listStrings);
        }
//slutten på oppgave 2
//oppgave 3:

        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        Dictionary<string, string> myTestDictionary = new Dictionary<string, string>();
        //bruker fasit herfra, da jeg satt meg litt fast.
        myDictionary.Add(1, "value 1");
        myDictionary.Add(2, "value 2");
        

        foreach(var keyValuePair in myDictionary)
        {
            Console.WriteLine(keyValuePair);
        }

        /*bare tester litt
        myTestDictionary.Add("kan jeg", "bruke to strings?");
        myTestDictionary.Add("Ja", "det kan jeg");

         foreach(var keyValuePair2 in myTestDictionary)
        {
            Console.WriteLine(keyValuePair2);
        }*/

        
        Console.WriteLine(AddNumbers(5,5));
        Console.WriteLine(SayHello("World"));

        

        
    }
        static int AddNumbers(int a, int b) 
        {
        return a + b;
        }

        static string SayHello(string greeting) 
        {
        return "Hello there, " + greeting + "!";
        }
}
