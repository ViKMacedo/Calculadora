using System;

class MainClass {
  public static void Main (string[] args) {
    
    int firstnumber, secondnumber, equal = 0;

    string opeation;

   Console.WriteLine("Digite o primeiro valor: ");
      firstnumber = int.Parse(Console.ReadLine());
   
   Console.WriteLine("Digite a operação: ");
      opeation = Console.ReadLine();
   
   Console.WriteLine("Digite o segundo valor: ");
      secondnumber = int.Parse(Console.ReadLine());  
    

    switch (opeation)
    {
        case "+" :
        equal = firstnumber + secondnumber;
        break;

        case "-" :
        equal = firstnumber - secondnumber;
        break;

        case "*" :
        equal = firstnumber * secondnumber;
        break;

        case "/" :
        equal = firstnumber / secondnumber;
        break;

        default:
        Console.WriteLine("Digite um valor válido");
        break;
      }
        
      Console.WriteLine("{0}{1}{2} = {3}", firstnumber, opeation, secondnumber, equal);
    
    Console.ReadKey (true);
  }
}
