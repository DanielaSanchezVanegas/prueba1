using taller2;


Vehiculo car1 = new Vehiculo("McLaren", "1");
Vehiculo car2 = new Vehiculo("Ferraria", "2");
Vehiculo car3 = new Vehiculo("Redbull", "3");
Circuito cir = new Circuito(2, "SRS");


cir.AñadirVehiculo(car1);
var retur = cir.RealizarPrueba();
cir.SacarVehiculo(car1);
Console.WriteLine($"El vehiculo {car1.Tipo} realizo las pruebas en {retur}");

cir.AñadirVehiculo(car2);
var retur1 = cir.RealizarPrueba();
cir.SacarVehiculo(car2);
Console.WriteLine($"El vehiculo {car2.Tipo} realizo las pruebas en {retur1}");

cir.AñadirVehiculo(car3);
var retur2 = cir.RealizarPrueba();
cir.SacarVehiculo(car3);
Console.WriteLine($"El vehiculo {car3.Tipo} realizo las pruebas en {retur2}");
