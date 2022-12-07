namespace AtividadeLista
{
  class program
  {
    public static void Main(string[] args)
    {
      List<string> listaString = new List<string>();

      listaString.Add("SP");
      listaString.Add("RJ");
      listaString.Add("MG");
      listaString.Add("BA");
      listaString.Add("SC");

      Console.WriteLine("Percorrendo Lista com FOR!");
      Console.WriteLine();

      for (int contador = 0; contador < listaString.Count; contador++)
      {
        Console.WriteLine($"Posição do estado Nº {contador} - {listaString[contador]}.");
      }

      Console.WriteLine();
      Console.WriteLine("Percorrendo Lista com FOREACH!");
      Console.WriteLine();

      int contadorForeach = 0;

      foreach (string estado in listaString)
      {
        Console.WriteLine($"Posição do estado Nº {contadorForeach} - {estado}.");
        contadorForeach++;
      }
    }
  }
}




















