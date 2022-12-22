using System;
// string currentCountry = "Honduras";
// Console.WriteLine("Insert your name and country");
// string country = Console.ReadLine();
// Console.WriteLine("Insert your name and name");
// string name = Console.ReadLine();

// void hiCountry(){
//     Console.WriteLine("Hello, " + name + " We send you greeting from " + currentCountry + " to " + country);
// }

// hiCountry();

// void evaluateNumber()
// {
//     Console.WriteLine("Insert two numbers: ");
//     Console.WriteLine("Insert the first one: ");
//     string? num1 = Console.ReadLine();
//     int numa = int.Parse(s: num1);
//     Console.WriteLine("Insert the Second one: ");
//     string? num2 = Console.ReadLine();
//     int numb = int.Parse(s: num2);
//     int sum = numa + numb;
//     Console.WriteLine(sum);
// }
// evaluateNumber();

// Pedir nombre y edad
// Console.WriteLine("Insert your name: ");
// string name = Console.ReadLine();

// Console.WriteLine("Insert your age: ");
// string age = Console.ReadLine();
// int ages = int.Parse(age);
// Console.WriteLine("Your name is: " + name + " and your age is: " + ages);


// Comparar dos numeros
// void CompareNumber()
// {
// Console.WriteLine("Insert the first number");
// string num1 = Console.ReadLine();
// int Tnum = int.Parse(num1);

// Console.WriteLine("Insert the second number");
// string num2 = Console.ReadLine();
// int Tnum1 = int.Parse(num2);

// if (Tnum > Tnum1)
// {
//     Console.WriteLine(Tnum + " is the greatest");
// }
// else
// {
//     Console.WriteLine(Tnum1 + " is the greatest");
// }

// enum clases
// {
//     bajo,
//     mid,
//     high,
// }
// }
// CompareNumber();

//dias de la semana
// void Week()
// {
// Console.WriteLine("Insert the name of a day");
// string day = Console.ReadLine();

// switch (day)
// {
//     case "monday":
//         Console.WriteLine("Week is starting");
//         break;
//     case "tuesday":
//         Console.WriteLine("The Week started yestarday and Tomorrow is Wednesday");
//         break;
//     case "wednesday":
//         Console.WriteLine(" today is mid of week");
//         break;
//     case "thursday":
//         Console.WriteLine("tomorrow is friday");
//         break;
//     case "friday":
//         Console.WriteLine("Tomorrow is weekend");
//         break;
//     case "saturday":
//         Console.WriteLine("Now starts weekend");
//         break;
//     case "sunday":
//         Console.WriteLine("end of the week");
//         break;
// }
// }
// Week();

//payment
// void Payment()
// {
//     Console.WriteLine("Insert the product price");
//     string productPrice = Console.ReadLine();
//     int price = int.Parse(productPrice);

//     Console.WriteLine("Insert type of payment, (card/cash)");
//     string pay = Console.ReadLine();
//     switch (pay)
//     {
//         case "card":
//             Console.WriteLine("Insert your card number");
//             string card = Console.ReadLine();
//             int numberCard = int.Parse(card);
//             Console.WriteLine("Confirm your card number, (y/n)");
//             string confirm = Console.ReadLine();
//             switch (confirm)
//             {
//                 case "y":
//                     Console.WriteLine("Thank you, completed transaction");
//                     break;
//                 case "n":
//                     Console.WriteLine("Re-insert your card number please");
//                     string reCard = Console.ReadLine();
//                     int numCard = int.Parse(reCard);
//                     Console.WriteLine("Thank you, completed transaction");
//                     break;
//             }
//             break;
//         case "cash":
//             Console.WriteLine("It's  $" + price);
//             break;
//         default:
//             Console.WriteLine("Method of payment is not supported");
//             break;
//     }
// }
// Payment();

// recorrer 1 al 100 con for
// for (int i = 1; i <= 100; i++){
//         Console.WriteLine(i);
// }
// mostrar numeros pares
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }
//recorrer con while
// int counter = 0;
// while (counter <= 100)
// {
//     Console.WriteLine(counter);
//     counter += 1;
// }

// muestra numero divisible de 3
for (int i = 1; i < 100; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + " es par");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine(i + " es divisible por 3");
    }
    else
    {
        Console.WriteLine(i);
    }
}
