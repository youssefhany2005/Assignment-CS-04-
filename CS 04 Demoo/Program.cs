namespace CS_04_Demoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //V-01
            #region Conditional Statements

            #region Example 01 [Year Quarter] - [If, Switch with Neumric Type Using Constant Pattern] 
            //Console.Write("Please Enter Month A Number Existed in 1st Quarter: ");
            //bool FlagMonthNumber = int.TryParse(Console.ReadLine(), out int MonthNumber);

            #region If, Else If, Else Solution
            //if (MonthNumber == 1)
            //    Console.WriteLine("Month is Jan");
            //else if (MonthNumber == 2)
            //    Console.WriteLine("Month is Feb");
            //else if (MonthNumber == 3)
            //    Console.WriteLine("Month is Mar");
            //else
            //    Console.WriteLine("Please enter valid Number");
            #endregion
            #region Switch Solution
            //switch(MonthNumber)
            //{
            //    case 1: 
            //        Console.WriteLine("Month is Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Month is Feb");
            //        break;
            //        case 3:
            //        Console.WriteLine("Month is Mar");
            //        break;
            //    default:
            //        Console.WriteLine("Please enter Valid Number");
            //        break;
            //}

            #endregion
            #endregion
            #region Example 02 [Student Age] - [If, Switch with Numric type using Relational Pattern]
            /// Age is Greater than 22 => Student Age is Greater than 22
            /// Age is less than 22 => Student Age is less than 22
            /// Age is 22 => Student Age is 22

            //Console.Write("Please Enter Student Age: ");
            //int.TryParse(Console.ReadLine(), out int age );

            #region If, Else if, Else Solution
            //if (age > 22)
            //    Console.WriteLine("Student Age is Greater than 22");
            //else if (age < 22)
            //    Console.WriteLine("Student Age is less than 22");
            //else
            //    Console.WriteLine("Student Age is 22");
            #endregion

            #region Switch Solution
            //switch (age)
            //{
            //    case > 22:
            //        Console.WriteLine("Student Age is Greater than 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("Student Age is less than 22");
            //        break;
            //    default:
            //        Console.WriteLine("Student Age is 22");
            //        break;
            //}
            #endregion
            #endregion
            #region Example 03 [Student Name] - [If, Switch with String Type]
            /// name = Omar => Hello Omar
            /// name = May => Hello May
            /// name = Aliaa => Hello Aliaa
            //Console.Write("Enter Student Name: ");
            //string name = Console.ReadLine() ?? "No Name Entered";
            #region If, Else If, Else Solution
            //if (name == "Omar")
            //    Console.WriteLine("Hello Omar");
            //else if (name == "May")
            //    Console.WriteLine("Hello May");
            //else if (name == "Aliaa")
            //    Console.WriteLine("Hello Aliaa");
            #endregion
            #region Switch Solution
            //switch(name)
            //{
            //    case "Omar":
            //        Console.WriteLine("Hello Omar");
            //        break;
            //    case "May":
            //        Console.WriteLine("Hello May");
            //        break;
            //    case "Aliaa":
            //        Console.WriteLine("Hello Aliaa");
            //        break;
            //}
            #endregion
            #endregion
            //V-02
            #region Example 04 [Budget] - [Switch with Go to]
            /// Budget is 1000 => Option 01
            /// Budget is 2000 => Option01, Option 02
            /// Budget is 3000 => Option01, Option 02, Option 03
            //Console.Write("Please Enter your Budget : ");
            //int.TryParse(Console.ReadLine(), out int budget);
            //switch(budget)
            //{
            //    case 3000:
            //        Console.WriteLine("Option 03");
            //        goto case 2000;
            //        break;
            //    case 2000:
            //        Console.WriteLine("Option 02");
            //        goto case 1000;
            //        break;
            //    case 1000:
            //        Console.WriteLine("Option 01");
            //        break;
            //}
            #endregion
            #endregion
            //V-03

            #region Evolution of Switch in C# 
            #region C# 7.0 [Pattern Matching - Case Guards (when)]
            //// No Jumb Table will be created
            //object number = 6; // boxing
            #region Example 01 [Pattern Matching on Types]
            //switch(number)
            //{
            //    case int Value:
            //        Console.WriteLine($"{Value} is Integer");
            //        break;
            //    case double Value:
            //        Console.WriteLine($"{Value} is Double");
            //        break;
            //    case string Value:
            //        Console.WriteLine($"{Value} is String");
            //        break;
            //    default:
            //        Console.WriteLine("Invalud");
            //        break;

            //}
            #endregion
            #region Example 02 [Case Guards (when)]

            //switch (number)
            //{
            //    case int Value when Value < 10 && Value > 5:
            //        Console.WriteLine($"{Value} is Integer");
            //        break;
            //    case double Value:
            //        Console.WriteLine($"{Value} is Double");
            //        break;
            //    case string Value:
            //        Console.WriteLine($"{Value} is String");
            //        break;
            //    default:
            //        Console.WriteLine("Invalud");
            //        break;
            //}

            #endregion
            #region Example 03 [Use-defined Data Type]
            //object Input = new Person() { Id = 10, Name = "Ahmed", Age = 20 };

            //switch(Input)
            //{
            //    case int Value when Value < 10 && Value > 5:
            //        Console.WriteLine($"{Value} is Integer");
            //        break;
            //    case double Value:
            //        Console.WriteLine($"{Value} is Double");
            //        break;
            //    case string Value:
            //        Console.WriteLine($"{Value} is String");
            //        break;
            //    case Person Value when Value.Id == 10:
            //        Console.WriteLine("I am Person");
            //        break;
            //    default:
            //        Console.WriteLine("Invalud");
            //        break;
            //}
            #endregion
            #endregion
            //V-04
            #region C# 8.0 [Pattern Matching without alias name - Switch Expressions] Property Pattern
            #region Example 01 - Pattern Matching without alias name 
            //string Option = Console.ReadLine();
            //string Message;

            //switch(Option)
            //{
            //    case "1":
            //        Message = "Option 01";
            //        break;
            //    case "2":
            //        Message = "Option 02";
            //        break;
            //    case "3":
            //        Message = "Option 03";
            //        break;
            //    default:
            //        Message = "Invalid";
            //        break;
            //}

            //Message = Option switch
            //{
            //    "1" => "Option 01",
            //    "2" => "Option 02",
            //    "3" => "Option 03",
            //    _ => "Invalid"
            //};

            //Console.WriteLine(Message);

            #endregion

            #region Example 02 [Property Pattern]
            //Person person = new Person() { Id = 10, Name = "Ahmed", Age = 25 };

            //string Message = person switch
            //{
            //    { Name: "Ahmed", Age: 10 } => "Hello Ahmed",
            //    { Name: "Omar" } => "Hello Omar",
            //    _ => "Invalid"
            //};

            //Console.WriteLine(Message);
            #endregion

            #region Example 03 [Nullable Type - Relational Patterns [Partially]]

            //int? Number = 10;

            //string Result = Number switch
            //{
            //    null => "Null Value",
            //    int X when X > 0 => "Positive",
            //    int X when X < 0 => "Negative",
            //    _ => "Invalid"
            //};

            //Console.WriteLine(Number);
            #endregion
            #endregion
            #endregion
        }
    }
}
