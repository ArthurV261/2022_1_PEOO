using System; 

public class Program {

  public static void Main(string[] args) {
     string s = Console.ReadLine();
     string[] v = s.Split();
      double a = double.Parse(v[0]);
      double b = double.Parse(v[1]);
      double c = double.Parse(v[2]);
      double tr = (a * c) / 2 ;
      double cir =  3.14159 * Math.Pow(c,2);
      double tra = ((a + b) * c) / 2;
      double qua = Math.Pow(b,2);
      double ret = a * b ;
      Console.WriteLine($"TRIANGULO: {tr:0.000}");
      Console.WriteLine($"CIRCULO: {cir:0.000}");
      Console.WriteLine($"TRAPEZIO: {tra:0.000}");
      Console.WriteLine($"QUADRADO: {qua:0.000}");
      Console.WriteLine($"RETANGULO: {ret:0.000}");
  }
}
