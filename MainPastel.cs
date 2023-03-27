using System;
using System.Collections.Generic;
using taller1;

internal class Program
{
    private static void Main(string[] args)
    {
        Pastel pastel = new Pastel("Pastel Vainilla ", "Mediano");

        Ingredientes huevos = new Ingredientes("5 huevos enteros", 2, 15000);
        Ingredientes harina = new Ingredientes("250 gramos de harina", 2, 1500);
        Ingredientes mantequilla = new Ingredientes("150 gramos de mantequilla", 2, 5000);
        Ingredientes polvo = new Ingredientes("1 cucharada copeteada de polvo para hornear", 2, 600);
        Ingredientes vainilla = new Ingredientes("1 cucharada de vainilla", 2, 800);

        pastel.anadirIngrediente(huevos);
        pastel.anadirIngrediente(harina);
        pastel.anadirIngrediente(mantequilla);
        pastel.anadirIngrediente(polvo);
        pastel.anadirIngrediente(vainilla);

        System.Console.WriteLine("------Pastel de Vainilla------");
        System.Console.WriteLine($"Cantidad de ingredientes : {pastel.contar()}");
        System.Console.WriteLine($"------Ingredientes------\n{pastel.listar()}");
        System.Console.WriteLine($"Costo de ingredientes : {pastel.costoTotal()}");
    }
}