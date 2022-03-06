using System;

public class Program
{
    public static void Main(String[] args)
    {
        var generadorAleatorio = new Random();
        int numeroParaAdivinar = generadorAleatorio.Next(0, 16);
        int NumeroIntroducidoUsuario = 0;
        int contador = 0;

        const string NumeroIncorrecto = "El numero introducido es incorrecto, por favor intentalo de nuevo";
        const string NumeroMayor = "El numero que usted tiene que adivinar es mayor al introducido, pruebe a introducir un numero diferente";
        const string NumeroMenor = "El numero que usted tiene que adivinar es menor al introducido, pruebe a introducir un numero diferente";


        Console.WriteLine("***ADIVINADOR DE NUMEROS***");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Bievenid@ al adivinador de numeros, que consiste en que usted tendra que escoger un numero entre el 0 y el 16.");
        Console.WriteLine("Recuerde, solo tendra 3 intentos");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Por favor introduzca el numero que desea");
        NumeroIntroducidoUsuario = Int32.Parse(Console.ReadLine());

        while (contador < 2)
        {
            if (numeroParaAdivinar < NumeroIntroducidoUsuario)
            {
                Console.WriteLine(NumeroMenor);
                NumeroIntroducidoUsuario = Int32.Parse(Console.ReadLine());
                contador++;
            }
            else if (numeroParaAdivinar > NumeroIntroducidoUsuario)
            {
                Console.WriteLine(NumeroMayor);
                NumeroIntroducidoUsuario = Int32.Parse(Console.ReadLine());
                contador++;
            }
            else if (numeroParaAdivinar == NumeroIntroducidoUsuario)
            {
                Console.WriteLine($"SIIUUU, LO CONSEGUISTE, FELICIDADES!! EL NÚMERO {NumeroIntroducidoUsuario} es el CORRECTOO!!!");
                contador = 2;
                Environment.Exit(0);
            }
        }
        Console.WriteLine($"Una pena, te has quedado sin intentos, la proxima vez sera. El numero a adivinar era {numeroParaAdivinar}");
    }
}
