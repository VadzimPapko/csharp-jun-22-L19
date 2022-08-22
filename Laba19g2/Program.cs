using Laba19g2;

Motorcycle[] arr = new Motorcycle[5];

arr[0] = new Motorcycle { Model = "Minsk X250", MadeIn = "China", Odometer = 6_000 };
arr[1] = new Motorcycle { Model = "Honda CB500F", MadeIn = "Japan", Odometer = 11_500 };
arr[2] = new Motorcycle { Model = "BMW G1200R", MadeIn = "Germany", Odometer = 20_000 };
arr[3] = new Motorcycle { Model = "Triumph Tiger 800", MadeIn = "China", Odometer = 30_000 };
arr[4] = new Motorcycle { Model = "Honda CB1100RR", MadeIn = "Japan", Odometer = 26_000 };

Motorcycle myMoto = new();

var moto1 = myMoto.FirstOrDefault(arr, m => m.Odometer >= 50_000);
var moto2 = myMoto.FirstOrDefault(arr, m => m.MadeIn.Equals("Chine",StringComparison.OrdinalIgnoreCase));
var moto3 = myMoto.FirstOrDefault(arr, m => m.Odometer >= 25_000 && m.MadeIn.Equals("Japan", StringComparison.OrdinalIgnoreCase));

Console.WriteLine(moto1.Model);
Console.WriteLine(moto2.Model);
Console.WriteLine(moto3.Model);