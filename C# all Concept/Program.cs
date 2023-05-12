////// All c# Concepts

//print & hold screen

console.writeline("ahmed mushtaq");
console.readline();

//variables and data types:

int age = 25;
string name = "john";
bool isemployed = true;
double salary = 2500.50;
console.writeline("int" + age + "\t string" + name + "\tbool" + isemployed + "\tdouble" + salary);

//control structures (if-else, switch-case, loops):

//if-else

int number = 10;

if (number > 0)
{
    console.writeline("number is positive");
}
else if (number < 0)
{
    console.writeline("number is negative");
}
else
{
    console.writeline("number is zero");
}

//switch-case

switch (number)
{
    case 0:
        console.writeline("number is zero");
        break;
    case 1:
    case 2:
        console.writeline("number is either 1 or 2");
        break;
    default:
        console.writeline("number is greater than 2");
        break;
}

//loops

for (int i = 0; i < 5; i++)
{
    console.writeline("iteration: " + i);
}

while (number > 0)
{
    console.writeline("number: " + number);
    number--;
}

//arrays:

int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

for (int i = 0; i < numbers.length; i++)
{
    console.writeline(numbers[i]);
}

//functions:

int addnumbers(int a, int b)
{
    return a + b;
}

int result = addnumbers(5, 3);
console.writeline("result: " + result);


/*console.write("enter your name: ");
string uname = console.readline();
console.writeline("your name is " + uname);
*/
console.readline();
console.writeline("enter any number for table");
int tnum = convert.toint32(console.readline());
int stable = 1;
while (stable <= 20)
{
    console.writeline(tnum + "*" + stable + "=" + tnum * stable);
    stable++;
}
console.readline();


console.writeline("enter your name");
console.write("name :");
string? name = console.readline();
console.writeline("enter your passwor to unlock");
console.write("password :");
string? pass = console.readline();
int password = convert.toint32(pass);
if (name != "ahmed")
{
    console.writeline("who are you? don't tuch ahmed's pc");
}
else if (password != 2526)
{
    console.writeline("rong password");
}
else
{
    console.writeline("well come ch ahmed");
}
console.readline();

variables
string username;
int userpassword;

//start code
console.write("enter user name: ");
username = console.readline();
console.write("enter user password: ");
userpassword = convert.toint32(console.readline());
if (username == "ahmed" && userpassword == 1234)
{
    console.writeline("welcome ahmed");
}
else
{
    console.writeline("you enter wrong data");
}

string username;
int userpassword;

//start code

console.write("enter user name: ");
username = console.readline();
if (username == "ahmed")
{
    console.write("enter user password: ");
    userpassword = convert.toint32(console.readline());
    if (userpassword == 1234)
    {
        console.writeline("welcome ahmed");
    }
    else
        console.writeline("you enter wrong password");

}
else
{
    console.writeline("you enter wrong name");
}

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