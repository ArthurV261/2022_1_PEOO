using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite o valor da base");
      string s = Console.ReadLine();
    double b = double.Parse(s);
    Console.WriteLine("Digite o valor da altura");
    string r = Console.ReadLine();
    double h = double.Parse(r);

      double a = b * h / 2;

    Console.WriteLine($"Área do triâgulo = {a:0.00}");
  }
}
