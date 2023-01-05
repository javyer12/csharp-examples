using System;
string currentCountry = "Honduras";
Console.WriteLine(currentCountry.Length);
// Console.WriteLine("Insert your name and country");
// string country = Console.ReadLine();
// Console.WriteLine("Insert your name and name");
// string name = Console.ReadLine();

// void hiCountry(){
//     Console.WriteLine("Hello, " + name + " We send you greeting from " + currentCountry + " to " + country);
// }

// hiCountry();

void evaluateNumber()
{
    Console.WriteLine("Insert the first numbers: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Insert the Second one: ");
    int num2 = int.Parse(Console.ReadLine());
    int sum = num1 + num2;
    Console.WriteLine(sum);
}
evaluateNumber();

// Pedir nombre y edad
Console.WriteLine("Insert your name: ");
string name = Console.ReadLine();

Console.WriteLine("Insert your age: ");
int ages = int.Parse(Console.ReadLine());
Console.WriteLine("Your name is: " + name + " and your age is: " + ages);


// Comparar dos numeros
void CompareNumber()
{
    Console.WriteLine("Insert the first number");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Insert the second number");
    int num2 = int.Parse(Console.ReadLine());

    if (num1 > num2)
        Console.WriteLine(num1 + " is the greatest");
    else
        Console.WriteLine(num2 + " is the greatest");

    // enum clases
    // {
    //     bajo,
    //     mid,
    //     high,
    // }
}
CompareNumber();

//dias de la semana
void Week()
{
    Console.WriteLine("Insert the name of a day");
    string day = Console.ReadLine();

    switch (day)
    {
        case "monday":
            Console.WriteLine("Week is starting");
            break;
        case "tuesday":
            Console.WriteLine("The Week started yestarday and Tomorrow is Wednesday");
            break;
        case "wednesday":
            Console.WriteLine(" today is mid of week");
            break;
        case "thursday":
            Console.WriteLine("tomorrow is friday");
            break;
        case "friday":
            Console.WriteLine("Tomorrow is weekend");
            break;
        case "saturday":
            Console.WriteLine("Now starts weekend");
            break;
        case "sunday":
            Console.WriteLine("end of the week");
            break;
    }
}
Week();

//payment
void Payment()
{
    Console.WriteLine("Insert the product price");
    string productPrice = Console.ReadLine();
    int price = int.Parse(productPrice);

    Console.WriteLine("Insert type of payment, (card/cash)");
    string pay = Console.ReadLine();
    switch (pay)
    {
        case "card":
            Console.WriteLine("Insert your card number");
            string card = Console.ReadLine();
            int numberCard = int.Parse(card);
            Console.WriteLine("Confirm your card number, (y/n)");
            string confirm = Console.ReadLine();
            switch (confirm)
            {
                case "y":
                    Console.WriteLine("Thank you, completed transaction");
                    break;
                case "n":
                    Console.WriteLine("Re-insert your card number please");
                    string reCard = Console.ReadLine();
                    int numCard = int.Parse(reCard);
                    Console.WriteLine("Thank you, completed transaction");
                    break;
            }
            break;
        case "cash":
            Console.WriteLine("It's  $" + price);
            break;
        default:
            Console.WriteLine("Method of payment is not supported");
            break;
    }
}
Payment();

// recorrer 1 al 100 con for
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}
// mostrar numeros pares
for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
//recorrer con while
int counter = 0;
while (counter <= 100)
{
    Console.WriteLine(counter);
    counter += 1;
}

// muestra numero divisible de 3
for (int i = 1; i < 100; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("🤷🏻  " + i + " es par");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("👍🏻  " + i + " es divisible por 3");
    }
    else
    {
        Console.WriteLine(i);
    }
}

// //tabla de multiplicar
// public class Math {
//     void Sum(int num1, int num2){
//         int sum = num1 + num2;
//         return sum;
//     }

//      void Multiply(numMultiplier, numLimit){
//         // int PascalCase
//         // int camelCase
//         Console.WriteLine("You inserted the table of {numMultiplier}, and limit {numLimit}, the result is: ");
//         for (int i = 1; i <= numLimit; i++){
//             int multy = i * numMultiplier;
//             Console.WriteLine(numMultiplier + " * " + i + " = " + multy);
//         }
//     }
// }

void Multiply(int numMultiplier, int numLimit)
{
    // //         // int PascalCase
    // //         // int camelCase
    Console.WriteLine("You inserted the table of " + numMultiplier + " and limit " + numLimit + " , the result is: ");
    for (int i = 1; i <= numLimit; i++)
    {
        int multy = i * numMultiplier;
        Console.WriteLine("💙" + numMultiplier + " * " + i + " = " + multy);
    }
}
Multiply(8, 100);



// CREATE RANDOM NAMES FOR ANIMAL AND HUMANS
Random rnd = new Random();
string[] malePetNames = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska" };
string[] femalePetNames = { "Maggie", "Penny", "Saya", "Princess",
                            "Abby", "Laila", "Sadie", "Olivia",
                            "Starlight", "Talla" };
string[] femaleHumanNames = { "Maggie", "Loisa", "Emily", "Ross",
                            "Abby", "Leila", "Maria Fernanda", "Leslie",
                            "Katherine", "Rachel", "Vannesa", "Karla","Gissel", "Amy" };
string[] malesHumanName = { "Carl", "Lucas", "David", "Douglas",
                            "Alllan", "Jack", "Frank", "Lionel",
                            "Ramon", "Jesus", "Antony", "Joshua", "Ronald", "Felipe" };
string[] abc = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o",
                         "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

// string[] createRandomName(int length)
// {
//     string[] randomName = new string[]{};
//     for (int i = 0; i < length; i++)
//     {
//         foreach (string letter in abc)
//         {
//             randomName.Add(letter);
//         }
//     }
//     // Console.WriteLine("   For a male pets:     {0}", randomName);
//     return randomName;
// }

Console.WriteLine("Write your command to generate a new name: ");
Console.WriteLine("example: ");
Console.WriteLine(" - create -f human ");
Console.WriteLine(" - create -m animal");
Console.WriteLine(" XD: Use the (create) command to create new name, flag (-f) for female genre, flag(-m) for male genre, (animal,human, city) to identify the subject.");

Console.Beep();
string input = Console.ReadLine();
// Generate random indexes for pet names.
int mAnimalIndex = rnd.Next(malePetNames.Length);
int fAnimalIndex = rnd.Next(femalePetNames.Length);
int fHumanIndex = rnd.Next(femaleHumanNames.Length);
int mHumanIndex = rnd.Next(malesHumanName.Length);


switch (input)
{
    case "create -f human":
        Console.WriteLine("   For a female:     {0}", femaleHumanNames[fHumanIndex]);
        break;
    case "create -m human":
        Console.WriteLine("   For a male:     {0}", malesHumanName[mHumanIndex]);
        break;
    case "create -f animal":
        Console.WriteLine("   For a female pets:     {0}", femalePetNames[fAnimalIndex]);
        break;
    case "create -m animal":
        Console.WriteLine("   For a male pets:     {0}", malePetNames[mAnimalIndex]);
        break;
    // case "create -abc":
    //     Console.WriteLine(createRandomName(6));
    //     break;
    default:
        Console.WriteLine("Command inconrrect❌");
        break;
}
// Display the result.
// Console.WriteLine("Suggested pet name of the day: ");
// Console.WriteLine("   For a male:     {0}", malePetNames[mIndex]);
// Console.WriteLine("   For a female:   {0}", femalePetNames[fIndex]);