/*

Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

*/

// метод для запроса числа
int InputNum(string msg){
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

// метод поиска выходного дня, 
// правильность номера дня недели не проверяет
bool WeekEnd(int day){
    if(day == 6 || day == 7) return true;
    else return false;
}

//----------------------------

int dayNo = InputNum("Input day of week: ");

if(WeekEnd(dayNo)){
    // выходной
    Console.WriteLine("It is dayoff");
}
else{
    // рабочий день
    Console.WriteLine("It is workday");
}