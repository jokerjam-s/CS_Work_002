/*

Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/


// метод для запроса числа
int InputNum(){
    Console.Write("Input number: ");
    return Convert.ToInt32(Console.ReadLine());
}


// метод нахождения второй цифры трехзначного числа
// возвращает вторую цифру переданного числа или
// ошибку если число не 3х значное: 
//          -1 - число из 2х знаков или менее
//          -2 - число из 4х знаков или более
int CalcNumber(int n){
    
    // приведем к положительному
    if(n < 0) n = -n;

    // проверим условия
    if(n < 100) return -1;

    if(n > 999) return -2;

    // вычислим результат
    return n % 100 / 10;
}


int num = InputNum();
int result = CalcNumber(num);

if(result >= 0){
    Console.WriteLine($"Second digit: {result}");
}
else if(result == -1){
    Console.WriteLine("Error! Number has two or less digits.");
}
else{
    Console.WriteLine("Error! Number has four or more digits.");
}






