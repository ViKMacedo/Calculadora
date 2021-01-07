using System;

class MainClass {
  public static void Main (string[] args) {
    
    int num1, num2, res = 0;

    string op;

   Console.WriteLine("Digite o primeiro valor: ");
     num1 = int.Parse(Console.ReadLine());
   
   Console.WriteLine("Digite a operação: ");
    op = Console.ReadLine();
   
   Console.WriteLine("Digite o segundo valor: ");
     num2 = int.Parse(Console.ReadLine());  
    

    switch (op)
    {
        case "+" :
        res = num1 + num2;
        break;

        case "-" :
        res = num1 - num2;
        break;

        case "*" :
        res = num1 * num2;
        break;

        case "/" :
        res = num1 / num2;
        break;

        default:
        Console.WriteLine("Digite um valor válido");
        break;
      }
        
      Console.WriteLine("{0}{1}{2} = {3}", num1, op, num2, res);


    
    Console.ReadKey (true);
  }
}
