
#region Fibonacci
//Fibonacci(5);

//static void Fibonacci(int n)
//{
//    int a = 1;
//    int b = 1;
//    int c;
//    Console.WriteLine(a);

//    Console.WriteLine(b);

//    for (int i = 0; i <= n; i++)
//    {
//        c = a + b;
//        a = b;
//        b = c;

//        Console.WriteLine(c);

//    }




//}




//ShowSameNameStudentsCount();

//static void ShowSameNameStudentsCount()
//{
//    Student stu1 = new Student()
//    {
//        Id = 1,
//        Name = "Test"

//    };
//    Student stu2 = new Student()
//    {
//        Id = 2,
//        Name = "Test"

//    };
//    Student stu3 = new Student()
//    {
//        Id = 3,
//        Name = "Test1"

//    }; Student stu4 = new Student()
//    {
//        Id = 4,
//        Name = "Test"

//    };


//    Student[] students = { stu1, stu2, stu3, stu4 };

//    int count = 0;
//    for (int i = 0; i < students.Length; i++)
//    {
//        for (int j = 1; j < students.Length - 1; j++)
//        {
//            count++;
//        }


//    }
//    Console.WriteLine(count);
//}

#endregion

#region Implicit-Explicit

//using ClassWorkPractice.Models;

//Manat manat = new Manat(150);
//Dollar dollar = manat;

//Console.WriteLine(dollar.Usd);

#endregion


using ClassWorkPractice;
using ClassWorkPractice.Models;

//StringList list1 = new StringList();

//list1.Add("Azer");
//list1.Add("Ceyhun");
//list1.Add("Roya");

//list1.GetAll();

//DataList<string> students = new DataList<string>();
//students.Add("Cahandar");
//students.Add("Ismayil");
//students.Add("Elcan");

//students.GetAll();

//IntList list2 = new IntList();
//list2.Add(1);
//list2.Add(2);
//list2.Add(3);

//list2.GetAll();

//DataList<int> numbers = new DataList<int>();
//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(3);

//numbers.GetAll();


//StudentList list3 = new StudentList();
//list3.Add(new Student { Id = 1, Name = "Cahandar" });
//list3.Add(new Student { Id = 2, Name = "Ismayil" });
//list3.Add(new Student { Id = 3, Name = "Ceyhun" });
//list3.Add(new Student { Id = 4, Name = "Nurlan" });

//list3.GetAll();


//DataList<Student> studlist = new DataList<Student>();

//studlist.Add(new Student { Id = 1, Name = "Mirze" });
//studlist.Add(new Student { Id = 2, Name = "Cavid" });
//studlist.Add(new Student { Id = 3, Name = "Orxan" });

//studlist.GetAll();

Repository<Student> student = new Repository<Student>();

Repository<int> num = new Repository<int>();

Repository<string> str = new Repository<string>();

Repository<bool> married = new Repository<bool>();










