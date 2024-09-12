
using System.ComponentModel;

Console.WriteLine("Hello, World!");


//string name = "Ivan";
//int age = 18;
//bool study = true;
//double score = 4.6;

//Console.WriteLine($"Имя: {name}");
//Console.WriteLine($"Возраст: {age}");
//Console.WriteLine($"Учиться: {age}");
//Console.WriteLine($"Средний балл: {age}");



//Console.WriteLine("Привет мир!");
//Console.WriteLine("Добро пожаловать в C#");
//Console.WriteLine("Пока, мир...");
//double height = 1.75;

//Console.WriteLine("Введите a и b и c и d");
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());
//int d = Convert.ToInt32(Console.ReadLine());
//a = a + b;
//b = b + c;
//c = c + d;
//d = d + a;
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);
//Console.WriteLine(d);

//int numder1 = 8;
//int numder2 = 6;

//if (numder1 > numder2 && numder1 == 8 );
//{
//    Console.WriteLine($"Число {numder1} больше числа {numder2}");
//}
//else
//{

//}

//int numder1 = 6;
//int numder2 = 8;

//if (numder1 > numder2 && numder1 == 8);
//{
//    Console.WriteLine($"Число {numder1} больше числа {numder2}");
//}
//else
//{
//    Console.WriteLine($"Число {numder1} меньше числа {numder2}");
//}
//int numder1 = 8;
//int numder2 = 8;
//if (numder1 > numder2)
//{
//    Console.WriteLine($"Число {numder1} больше числа {numder2}");
//}
//else if (numder1 > numder2)
//{
//    Console.WriteLine($"Число {numder1} меньше числа {numder2}");
//}
//else
//{
//    Console.WriteLine("Числа равны между собой");
//}

//string name = "Ivan";

//switch (name)
//{
//	case "Doggy":
//		Console.WriteLine("Ваше имя - Doggy");
//		break;
//	case "Ivan":
//		Console.WriteLine("Ваше имя - Ivan");
//		break;
//	default:
//		Console.WriteLine("Вы не добавили имя");
//		break;
//

start:
int a;
int b;
int c;

char operation;

Console.WriteLine("Введите первое число : ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выберете оператор");
operation = Convert.ToChar(Console.ReadLine());

switch (operation)
{
    case '+':
        c = a + b;
        Console.WriteLine("Ответ " + (a) + " + " + (b) + " = " + (c).ToString());
        goto start;
    case '-':
        c = a - b;
        Console.WriteLine("Ответ " + (a) + " - " + (b) + " = " + (c).ToString());
        goto start;
    case '/':
        c = a / b;
        Console.WriteLine("Ответ " + (a) + " / " + (b) + "=" + (c).ToString());
        goto start;
    case '*':
        c = a * b;
        Console.WriteLine("Ответ " + (a) + " * " + (b) + " = " + (c).ToString());
        goto start;
    default:
        Console.WriteLine("Ошибка оператора ");
        goto start;
}




