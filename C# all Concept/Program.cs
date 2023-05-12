////// All c# Concepts

//////Print & Hold screen

////Console.WriteLine("Ahmed mushtaq");
////Console.ReadLine();

//////Variables and Data Types:

////int age = 25;
////string name = "John";
////bool isEmployed = true;
////double salary = 2500.50;
////Console.WriteLine("int"+age + "\t string" + name + "\tbool" + isEmployed + "\tdouble" + salary);

//////Control Structures (if-else, switch-case, loops):

//////if-else

////int number = 10;

////if (number > 0)
////{
////    Console.WriteLine("Number is positive");
////}
////else if (number < 0)
////{
////    Console.WriteLine("Number is negative");
////}
////else
////{
////    Console.WriteLine("Number is zero");
////}

//////switch-case

////switch (number)
////{
////    case 0:
////        Console.WriteLine("Number is zero");
////        break;
////    case 1:
////    case 2:
////        Console.WriteLine("Number is either 1 or 2");
////        break;
////    default:
////        Console.WriteLine("Number is greater than 2");
////        break;
////}

//////loops

////for (int i = 0; i < 5; i++)
////{
////    Console.WriteLine("Iteration: " + i);
////}

////while (number > 0)
////{
////    Console.WriteLine("Number: " + number);
////    number--;
////}

//////Arrays:

////int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

////for (int i = 0; i < numbers.Length; i++)
////{
////    Console.WriteLine(numbers[i]);
////}

//////Functions:

////int AddNumbers(int a, int b)
////{
////    return a + b;
////}

////int result = AddNumbers(5, 3);
////Console.WriteLine("Result: " + result);


///*Console.Write("Enter your name: ");
//string uName = Console.ReadLine();
//Console.WriteLine("Your name is " + uName);
//*/
////Console.ReadLine();
////Console.WriteLine("Enter any number for Table");
////int tNum =Convert.ToInt32( Console.ReadLine());
////int sTable = 1;
////while (sTable <= 20)
////{
////    Console.WriteLine(tNum + "*" + sTable + "=" + tNum*sTable);
////    sTable++;
////}
////Console.ReadLine();


//Console.WriteLine("Enter your Name");
//Console.Write("Name :");
//string? name = Console.ReadLine();
//Console.WriteLine("Enter your passwor to unlock");
//Console.Write("Password :");
//string? pass = Console.ReadLine();
//int password =Convert.ToInt32 (pass);
//if (name != "Ahmed")
//{
//    Console.WriteLine("Who are you? Don't tuch AHmed's PC");
//}
//else if (password != 2526)
//{
//    Console.WriteLine("Rong password");
//}
//else
//{
//    Console.WriteLine("Well come Ch Ahmed");
//}
//Console.ReadLine();

//Variables
//string userName;
//int userPassword;

////Start Code
//Console.Write("Enter User Name: ");
//userName = Console.ReadLine();
//Console.Write("Enter User Password: ");
//userPassword = Convert.ToInt32(Console.ReadLine());
//if (userName == "Ahmed" && userPassword == 1234)
//{
//    Console.WriteLine("WelCome Ahmed");
//}
//else
//{
//    Console.WriteLine("You Enter Wrong Data");
//}

//string userName;
//int userPassword;

////Start Code

//Console.Write("Enter User Name: ");
//userName = Console.ReadLine();
//if(userName == "Ahmed")
//{
//    Console.Write("Enter User Password: ");
//    userPassword = Convert.ToInt32(Console.ReadLine());
//    if (userPassword == 1234)
//    {
//        Console.WriteLine("WelCome Ahmed");
//    }
//    else
//        Console.WriteLine("You Enter Wrong Password");

//}
//else
//{
//    Console.WriteLine("You Enter Wrong Name");
//}

string? inputValue, inputValue1 = null, inputValue2 = null, inputValue3 = null, inputValue4 = null;
bool isContinue = true, isFirst = true;
int selectionToDo;

while (isContinue)
{
    Console.WriteLine("\tToDo List");
    Console.WriteLine("1 - Add Item in List\n2 - Delete Item in List\n3 - Display List\n4 - Exit");
    Console.Write(">>");
    selectionToDo = Convert.ToInt32(Console.ReadLine());
    switch (selectionToDo)
    {
        case 1:
            int inputValueForGiveInput;
            bool isContinue1 = true;
            Console.WriteLine("Select an option:\n1 - Input Value\n2 - back");
            inputValueForGiveInput = Convert.ToInt32(Console.ReadLine());
            while (isContinue1)
            {
                switch (inputValueForGiveInput)
                {
                    case 1:
                        Console.Write("Input a Message: ");
                        inputValue = Console.ReadLine();
                        if (inputValue1 == " " || inputValue1 == null)
                        {
                            inputValue1 = inputValue;
                            Console.WriteLine("item is add successfully");
                            Console.Write("Enter Any Key To Continue...");
                            Console.ReadKey();
                        }
                        else if (inputValue2 == " " || inputValue2 == null)
                        {
                            inputValue2 = inputValue;
                            Console.WriteLine("item is add successfully");
                            Console.Write("Enter Any Key To Continue...");
                            Console.ReadKey();
                        }
                        else if (inputValue3 == " " || inputValue3 == null)
                        {
                            inputValue3 = inputValue;
                            Console.WriteLine("item is add successfully");
                            Console.Write("Enter Any Key To Continue...");
                            Console.ReadKey();
                        }
                        else if (inputValue4 == " " || inputValue4 == null)
                        {
                            inputValue4 = inputValue;
                            Console.WriteLine("item is add successfully");
                            Console.Write("Enter Any Key To Continue...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Please Delete a Query");
                            Console.Write("Enter Any Key To Continue...");
                            Console.ReadKey();
                        }
                        isContinue1 = false;
                        Console.Clear();
                        break;
                    default:
                        isContinue1 = false;
                        Console.Clear();
                        break;
                }
            }
            break;
        case 2:
            Console.Write("Input a Number For Delete Query(1-4): ");
            inputValue = Console.ReadLine();
            switch (inputValue)
            {
                case "1":
                    inputValue1 = null;
                    Console.WriteLine("item is Delete successfully");
                    Console.Write("Enter Any Key To Continue...");
                    Console.ReadKey();
                    break;
                case "2":
                    inputValue2 = null;
                    Console.WriteLine("item is Delete successfully");
                    Console.Write("Enter Any Key To Continue...");
                    Console.ReadKey();
                    break;
                case "3":
                    inputValue3 = null;
                    Console.WriteLine("item is Delete successfully");
                    Console.Write("Enter Any Key To Continue...");
                    Console.ReadKey();
                    break;
                case "4":
                    inputValue4 = null;
                    Console.WriteLine("item is Delete successfully");
                    Console.Write("Enter Any Key To Continue...");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Please Enter a Valid Number");
                    Console.Write("Enter Any Key To Continue...");
                    Console.ReadKey();
                    break;
            }
            Console.Clear();
            break;
        case 3:
            Console.WriteLine(inputValue1);
            Console.WriteLine(inputValue2);
            Console.WriteLine(inputValue3);
            Console.WriteLine(inputValue4);
            Console.Write("Enter Any Key To Continue...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 4:
            isContinue = false;
            break;
        default:
            Console.WriteLine("Please Enter A Valid Number");
            Console.Write("Enter Any Key To Continue...");
            Console.ReadKey();
            Console.Clear();
            break;
    }

}


Console.ReadLine();