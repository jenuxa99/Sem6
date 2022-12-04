void Z41()
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
{
    int[] N = new int [5];
    int i = 0;
    Console.WriteLine("Введите любое целое число (1/5)");
    N[i] = Convert.ToInt32(Console.ReadLine()); i++;
    Console.WriteLine("Введите любое целое число (2/5)");
    N[i] = Convert.ToInt32(Console.ReadLine()); i++;
    Console.WriteLine("Введите любое целое число (3/5)");
    N[i] = Convert.ToInt32(Console.ReadLine()); i++;
    Console.WriteLine("Введите любое целое число (4/5)");
    N[i] = Convert.ToInt32(Console.ReadLine()); i++;
    Console.WriteLine("Введите любое целое число (5/5)");
    N[i] = Convert.ToInt32(Console.ReadLine()); i++;
    Console.WriteLine("Ваши числа: ");
    for (i = 0; i < 5; i++) Console.Write(N[i] + "\t");
    Console.WriteLine(" ");
    Console.Write("Количество чисел больше 0: ");
    int count = 0;
    for (i = 0; i < 5; i++) if (N[i] > 0) count++; Console.Write(count);
    Console.WriteLine(String.Empty);
}

Z41();

void Z43()
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
{
    Console.WriteLine("Введите значение коэффициента k1:");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение коэффициента b1:");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение коэффициента k2:");
    int k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение коэффициента b2:");
    int b2 = Convert.ToInt32(Console.ReadLine());

    double bd = b2-b1;
    double kd = k1-k2;

    double x = bd / kd;
    double y = (k2*(x))+b2;

    Console.Write($"X = {x}, Y = {y}");

}
Z43();