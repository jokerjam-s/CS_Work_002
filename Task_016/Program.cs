/*

Доп. задача 16: Напишите программу, 
которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет

*/

// метод для запроса числа
int InputNum(string msg){
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

// метод поиска квадратов числа
// возвращает порядковый номер числа чей квадрат равен второму числу
// иначе - 0
int SquareNumbers(int n1,  int n2){
    int result = 0;

    if(n1*n1 == n2) result = 1;
    if(n2*n2 == n1) result = 2;

    return result;
}

//--------------------

int num1 = InputNum("Input first number: ");
int num2 = InputNum("Input second number: ");

if(SquareNumbers(num1, num2) > 0){
    // одно из чисел квадрат другого
    Console.WriteLine("YES");
}
else{
    // числа не квадраты друг другу
    Console.WriteLine("NO");
}



