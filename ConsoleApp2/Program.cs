using ConsoleApp2;


Motorcycle[] arr = new Motorcycle[5];

arr[0] = new Motorcycle { Model = "Minsk X250", MadeIn = "China", Odometer = 6_000 };
arr[1] = new Motorcycle { Model = "Honda CB500F", MadeIn = "Japan", Odometer = 11_500 };
arr[2] = new Motorcycle { Model = "BMW G1200R", MadeIn = "Germany", Odometer = 20_000 };
arr[3] = new Motorcycle { Model = "Triumph Tiger 800", MadeIn = "China", Odometer = 30_000 };
arr[4] = new Motorcycle { Model = "Honda CB1100RR", MadeIn = "Japan", Odometer = 26_000 };


void FirstOrDefault(Motorcycle[] arr2, Func<Motorcycle, bool> result)
{
    bool results = false;

    foreach (var moto in arr2)
    {
        if (result(moto))
        {
            results = true;
            Console.WriteLine(moto.ToString());
            results = true;
        }
    }
    if (results == false) Console.WriteLine(arr[0].ToString());
}


FirstOrDefault(arr, moto => moto.Odometer >= 50_000);

FirstOrDefault(arr, moto => moto.MadeIn.Equals("China"));

FirstOrDefault(arr, moto => moto.Odometer >= 25_000 && moto.MadeIn.Equals("Japan"));
