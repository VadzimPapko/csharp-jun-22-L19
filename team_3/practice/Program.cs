using practice;
using System.Threading.Channels;

Motorcycle[] arr = new Motorcycle[5];

arr[0] = new Motorcycle { Model = "Minsk X250", MadeIn = "China", Odometer = 6_000 };
arr[1] = new Motorcycle { Model = "Honda CB500F", MadeIn = "Japan", Odometer = 11_500 };
arr[2] = new Motorcycle { Model = "BMW G1200R", MadeIn = "Germany", Odometer = 20_000 };
arr[3] = new Motorcycle { Model = "Triumph Tiger 800", MadeIn = "China", Odometer = 30_000 };
arr[4] = new Motorcycle { Model = "Honda CB1100RR", MadeIn = "Japan", Odometer = 26_000 };

FirstOrDefault(arr, el => el.Odometer>=50_000);
Console.WriteLine();

FirstOrDefault(arr, el => el.MadeIn!.Equals("China"));
Console.WriteLine();

FirstOrDefault(arr, el => el.Odometer>=25_000 && el.MadeIn!.Equals("Japan"));
Console.WriteLine();

void FirstOrDefault(Motorcycle[] array,Func<Motorcycle,bool>predicate)
{
    bool flag = false;

    foreach (var item in array)
    {
        if (predicate(item))
        {
            Console.WriteLine(item.ToString());
            flag=true;
            break;
        }
    }

    if (flag==false) Console.WriteLine("No items according this condition\nDefault value is the first Motorcycle {0}", array[0]);
}

//создается новый instance, скрин прилагается