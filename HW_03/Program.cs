string x =Convert.ToString((int)ContactType.SMS);

string y =Convert.ToString((int)ContactType.Email);

Console.WriteLine(x+"      "+ y);

string[] array = {x,y};



Console.WriteLine($"Cast Number 2 to Enum Member: {(ContactType)2}");



Console.WriteLine($"Numbers of Enum: {(int)ContactType.SMS} {(int)ContactType.Email}");

Console.WriteLine("please enter 1 or 2 or 3");

var M= Console.ReadLine();


    switch (M)
    {
    case "1":
        Console.WriteLine($"Enum Member is: {(ContactType)1}");
        break;
    case "2":
        Console.WriteLine($"Enum Member is: {(ContactType)2}");
        break;
    case "3":
        Console.WriteLine($"Enum Member is: {(ContactType)3}");
        break;

    default:
        Console.WriteLine("Not range");
        break;
    }

GetDisplayNmae();

 void GetDisplayNmae()
{
    Console.WriteLine((int)ContactType.SMS);
    Console.WriteLine((int)ContactType.Email);
    Console.WriteLine((int)ContactType.Red);
}


