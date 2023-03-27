using System;
using System.Collections.Generic;
namespace taller1

{
   public class Ingredientes{
    
   public string nombres {get; set ;}
   public  int cantidad {get; set ;}
   public double precio {get; set ;}

   public Ingredientes(string nombres, int cantidad, double precio){
        this.nombres=nombres;
        this.cantidad=cantidad;
        this.precio=precio;
     }
    }
 }