// Дополнительная задача (задача со звёздочкой): Напишите программу, которая на вход принимает 
// 3 трехзначных числа и находит среднее арифметическое, далее проверяет больше ли последняя 
// цифра среднего арифметического, чем первая цифра минимума вводимых чисел.

Console.Write("Введите первое трехзначное число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе трехзначное число: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье трехзначное число: ");
int num3 = int.Parse(Console.ReadLine());

// Находим среднее арифметическое из трех введенных чисел
int average = (num1 + num2 + num3) / 3;
// Находим последную цифру от ср. арифмитического числа
int average_last_num = average % 10;

// Находим мин. число из трех введенных
int min = (num1 <= num2) ? num1 : num2; 
min = min < num3 ? min : num3;
// Находим первую цифру у минимального введенного числа
int min_first = min / 100;

if (average_last_num == min_first){
    Console.WriteLine("Цифры равны");
}
else{
    Console.WriteLine(average_last_num > min_first ? "Да" : "Нет");
}