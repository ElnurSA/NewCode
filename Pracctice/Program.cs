using Pracctice;
using Pracctice.Helpers;

//string email = Console.ReadLine();

//var result = email.CheckEmail();

//if(result == true)
//{
//    Console.WriteLine("Success");
//}
//else
//{
//    Console.WriteLine("Wrong");
//}

//Console.WriteLine("Please add your email address: ");
//string email = Console.ReadLine();

//var res = email.ChechTrimEmail(@"\s");

//if(res == true)
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("false");
//}

//Person person = new();
//person.Id = 1;
//person.Name = "Cavid";
//person.Surname = "Bashirov";

//Console.WriteLine(person.GetFullName());


//int[] arr = { 1, 2, 3, 4, 5 };
//Console.WriteLine(arr.GetMultiplyArray());


//IntList list = new IntList();
//list.Add(1);
//list.Add(2);
//list.Add(100);

//list.GetAll();

//StringList list = new();
//list.Add("Oruc");
//list.Add("Semed");
//list.Add("Nurlan");

//list.GetAll();


//PersonList list = new PersonList();

//list.Add(new Person { Id = 1, Name = "Test1", Surname = "Test1" });
//list.Add(new Person { Id = 2, Name = "Test2", Surname = "Test2" });
//list.Add(new Person { Id = 3, Name = "Test3", Surname = "Test3" });

//list.GetAll();

//DataList<int> datas = new();

//datas.Add(5);
//datas.Add(10);

//datas.Add(20);

//datas.GetAll();

//DataList<string> stringList = new();

//stringList.Add("adaf");

//stringList.Add("adfdaf");

//stringList.GetAll();

//DataList<Person> students = new();

//students.Add(new Person { Id = 1, Name = "Test1", Surname = "Test1" });
//students.Add(new Person { Id = 2, Name = "Test1", Surname = "Test1" });

//var res = students.GetAll();

//foreach (var item in res)
//{
//    Console.WriteLine(item.Name);
//}

//List<Person> people = new();

//people.Add(new Person { Id = 1, Name = "Test1", Surname = "Test1" });

//foreach (Person person in people)
//{
//    Console.WriteLine(person.Name);
//}

//Repository<string> repo1 = new Repository<string>();
//Repository<int> repo2 = new Repository<int>();
//Repository<bool> repo3 = new Repository<bool>();
//Repository<Person> repo4 = new Repository<Person>();

//Repository<Person, BaseEntity> test = new Repository<Person, BaseEntity>();

//DataList<string> words = new DataList<string>();

//words.Add("Salam1");
//words.Add("Salam2");
//words.Add("Salam3");

//var datas = words.GetAll();

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}

//Repository<Person> repository = new Repository<Person>();
//repository.Add(new Person { Id = 1, Name = "Test1", Surname = "Test1" });

//Repository<Student> studnet = new Repository<Student>();


string paymentType = "Cash";

int tp = 2;

static void CheckPaymentType(string type)
{

    switch (type)
    {
        case nameof(PaymentType.Card):
            Console.WriteLine("With Card");
            break;
        case nameof(PaymentType.Cash):
            Console.WriteLine("With Cash");
            break;
        default:
            Console.WriteLine("Payment in wrong");
            break;
    }

    if (type == PaymentType.Card.ToString())
    {
        Console.WriteLine("With Card");
    }
    else if(type == PaymentType.Cash.ToString())
    {
        Console.WriteLine("With Cash");
    }
    else
    {
        Console.WriteLine("Payment type is wrong");
    }
}

CheckPaymentType(paymentType);