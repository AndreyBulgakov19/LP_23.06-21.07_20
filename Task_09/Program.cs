
// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

//int rndNum = new Random().Next(10, 100);
//Console.WriteLine($"Случайное число из отрезка 10 - 99 => {rndNum}");


// int firstDigit = rndNum / 10; //5
// int secondDigit = rndNum % 10; //1

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;

//Console.WriteLine($"Наибольшая цифра числа {rndNum} => {maxDigit}");

// int maxDigit = firstDigit;
// if(secondDigit > maxDigit) maxDigit = secondDigit;
// else if (secondDigit == maxDigit) maxDigit = 0;

int rndNum = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {rndNum}");

var rnd = new Random();
int n1 = rnd.Next();
int n2 = rnd.Next();

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if(firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(rndNum);
string result = maxDigit > 0 ? maxDigit.ToString() : "числа равны";
Console.WriteLine($"Наибольшая цифра числа {rndNum} => {result}");


