

#region Calculator



//using AccessModifiers;
//using System.ComponentModel;
//using System.Security.Claims;

//calculate();

//static void calculate()
//{
//    Calculator calculator = new();

//    Console.WriteLine("Add first number :");
//    Number1: string number1 = Console.ReadLine();

//    int checkedNum1;

//    bool isParseNum1 = int.TryParse(number1, out checkedNum1);



//    if (!isParseNum1)
//    {


//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Please add correct format number1");
//        Console.ResetColor();
//        goto Number1;
//    }

//    Console.WriteLine("Add operation");

//    string operation = Console.ReadLine();



//    Console.WriteLine("Add second number:");


//   Number2: string number2 = Console.ReadLine();
//   int checkedNum2;

//    bool isParseNum2 = int.TryParse(number2, out checkedNum2);


//    if (isParseNum2)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Please add correct fornat number 2");
//        Console.ResetColor();
//        goto Number2;


//    }
//    if(checkedNum2== 0 && operation =="/")
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Please dont add 0");
//        Console.ResetColor();
//        goto Number2;

//    }


//    var result = calculator.Calculation(checkedNum1, checkedNum2, operation);



//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine(result);
//    Console.ResetColor();
//}



#endregion



#region Doctor


//using AccessModifiers;




//var startDate = new DateTime(1993, 05, 25);
//var endDate = new DateTime(2002, 12, 25);


//GetDoctorByBirthday(startDate, endDate);
//static void GetDoctorByBirthday(DateTime start, DateTime end)
//{
//    var doctors = GetDoctors();

//    foreach(var doctor in doctors)
//    {
//        if(doctor.Birthday > start && doctor.Birthday < end)
//        {
//            Console.WriteLine($"{doctor.Name} {doctor.Surname} {doctor.Address} { doctor.Birthday}");
//        }
//    }

//}
//static Doctor[] GetDoctors()
//{

//    Doctor doctor1 = new Doctor()
//    {
//        Name = "Hesen",
//        Surname = "Hesenov",
//        Address = "Xetai",
//        Birthday = new DateTime(1994, 10, 05)
//    };

//    Doctor doctor2 = new Doctor()
//    {
//        Name = "Resid",
//        Surname = "Hesenov",
//        Address = "Xetai",
//        Birthday = new DateTime(2000, 10, 05)
//    };

//    Doctor doctor3 = new Doctor()
//    {
//        Name = "Qadir",
//        Surname = "Hesenov",
//        Address = "Xetai",
//        Birthday = new DateTime(2002, 10, 05)
//    };

//    Doctor doctor4 = new Doctor()
//    {
//        Name = "Cemil",
//        Surname = "Hesenov",
//        Address = "Xetai",
//        Birthday = new DateTime(2003, 10, 05)
//    };

//    Doctor doctor5 = new Doctor()
//    {
//        Name = "Hesen",
//        Surname = "Hesenov",
//        Address = "Xetai",
//        Birthday = new DateTime(2005, 10, 05)
//    };

//    Doctor[] doctors= new Doctor[] { doctor1,doctor2, doctor3,doctor4,doctor5 };
//    return doctors;

//}


#endregion


#region Order


//using AccessModifiers;

//static Order[] GetOrder()
//{
//    var order1 = new Order(new DateTime(2022, 12, 19), 500);
//    var order2 = new Order(new DateTime(2022, 12, 18), 300);
//    var order3 = new Order(new DateTime(2022, 12, 19), 250);
//    var order4 = new Order(new DateTime(2022, 12, 20), 1500);
//    var order5 = new Order(new DateTime(2022, 12, 22), 1500);
//    var order6 = new Order(new DateTime(2022, 12, 28), 500);

//    return new Order[] { order1, order2, order3, order4, order5, order6 };


//}


//DateTime filteredDate = DateTime.Now.AddDays(1);

//double filteredPrice = 300;

//GetFiltersOrders(filteredDate, filteredPrice);

//static void GetFiltersOrders(DateTime date, double price)
//{
//    var orders = GetOrder();

//    foreach (var item in orders)
//    {
//        if (item.Price > price && item.Date <= date)
//        {
//            Console.WriteLine(item.Date + ":" + item.Price);
//        }
//    }
//}

#endregion


#region Person


using AccessModifiers;

static Person[] GetAllPersons()
{


    
        Person person1 = new Person()
        {
            Name = "Gunay",
            Surname = "Qubadova",
            Age = 18,
            IsMarried = true
        };

        Person person2 = new Person()
        {
            Name = "Hesen",
            Surname = "Qubadova",
            Age = 15,
            IsMarried = false
        };


        Person person3 = new Person()
        {
            Name = "Qadir",
            Surname = "Qubadova",
            Age = 20,
            IsMarried = true
        };

        Person person4 = new Person()
        {
            Name = "Cemil",
            Surname = "Qubadova",
            Age = 25,
            IsMarried = true


        };

    return new Person[] { person1, person2, person3, person4 };
  
}

GetFilteredPersons(18);

static void GetFilteredPersons(int age)
{

    var persons = GetAllPersons();

    int count = 0;

    foreach (var item in persons)
    {
        if (item.Age > age && item.IsMarried)
        {
            count++;
        }

    }   

    if(count == 0)
    {
        Console.WriteLine("Evli olan yoxdur");
        return;
    }
    Console.WriteLine(count);
}
#endregion