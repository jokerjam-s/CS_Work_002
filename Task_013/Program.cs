/*

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6

*/

// метод для запроса числа
int InputNum(){
    Console.Write("Input number: ");
    return Convert.ToInt32(Console.ReadLine());
}

// метод поиска третьей цифры 
// возвращает цифру или -1, если ее нет
int FindThirdDigit(int n){
    // реверс отрицательного числа
    if(n < 0) n = -n;

    if(n < 100){
        n = -1;
    }
    else
    {
        while(n > 1000) n = n / 10;
        n = n % 10;
    }

    return n;
}

// -------------------------
int num = InputNum();
int result = FindThirdDigit(num);

if(result < 0){ 
    // нет 3й цифры
    Console.WriteLine("The number hasn't a third digit");
}
else { 
    // вываод результата
    Console.WriteLine($"Third digit is {result}");
}
