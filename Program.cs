// See https://aka.ms/new-console-template for more information

double N;
        double contador = 1;

        Console.Write("Qual o número da tabuada: ");

        Console.WriteLine();

        N = Convert.ToDouble(Console.ReadLine());

        if (N<1 || N>10){

        Console.WriteLine("Número invalido, digite um número de 1 a 10");

        } 
        else {
        while (contador <=10){

        Console.WriteLine($"{N} X {contador} = {N*contador} ");
        contador = contador + 1;
        }
        }