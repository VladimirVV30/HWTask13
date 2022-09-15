// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

try  
{ 
    void HWTask13 ()
    { 
        Console.WriteLine("Введите целое число ");
        int num=Convert.ToInt32 (Console.ReadLine());
     
        if (num > 99)  Console.WriteLine($"Третья цифра числа {num} будет " + num % 10);
        else if (num < -99)  Console.WriteLine($"Третья цифра числа {num} будет " + (-num % 10));
        else Console.WriteLine($"В числе {num} третьей цифры нет");
        
    }
    HWTask13();
}
catch
{
    Console.WriteLine("Неверно введено число, необходимо было ввести целое число цифрами");
}