namespace Calculator
{
  public class Program
  {
    public static void Main(string[] args)
    {
      IStartInMain();
    }

    public static void IStartInMain()
    {
      Console.WriteLine("Willkommen bei Ihrem Taschenrechner!\n\n");
      Console.WriteLine("Treffen Sie eine Auswahl:");
      Console.WriteLine("1) Addition\n2) Subtraktion\n3) Multiplikation\n4) Division");
      int choice = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Nennen Sie mir die erste Zahl:");
      int num1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Nennen Sie mir die zweite Zahl");
      int num2 = Convert.ToInt32(Console.ReadLine());

      const string resultText = "Ihr Ergebnis lautet: ";

      if (choice == 1)
      {
        Console.WriteLine(resultText + Addition(num1, num2));
      }
      else if (choice == 2)
      {
        Console.WriteLine(resultText + Subtraction(num1, num2));
      }
      else if (choice == 3)
      {
        Console.WriteLine(resultText + Multiplication(num1, num2));
      }
      else if(choice == 4)
      {
        Console.WriteLine(resultText + Divide(num1, num2));
      }

      Console.WriteLine("Erneut? y/n");
      string again = Console.ReadLine().ToLower();
      
      if(again == "y")
      {
        Console.Clear();
        IStartInMain();
      }
      else 
      { 
        Environment.Exit(0);
      }
    }

    public static int Addition(int num1, int num2)
    {
      return num1 + num2;
    }

    public static int Subtraction(int num1, int num2)
    {
      return num1 - num2;
    }
    public static int Multiplication(int num1, int num2) 
    {  
      return num1 * num2; 
    }
    public static int Divide(int num1, int num2)
    {
      if (num2 == 0)
      {
        Console.WriteLine("Nicht durch 0 teilen!\nErneut? ;)");
        Console.Clear();
        IStartInMain();
        Environment.Exit(0);
      }
      return num1 / num2;
    }
  }
}