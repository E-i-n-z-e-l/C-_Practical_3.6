// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

void SidesOfATriangle (int side1, int side2, int side3)
{
if (side1 < side2 + side3 & side2 < side1 + side3 & side3 < side1 + side2)
{
    Console.WriteLine($"Треугольник со сторонами {side1}, {side2}, и {side3} существует");
}
else Console.WriteLine($"Треугольник со сторонами {side1}, {side2}, и {side3} не существует");
}

Console.WriteLine("Введите первое положительное целое число ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе положительное целое число ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье положительное целое число ");
int numberThree = Convert.ToInt32(Console.ReadLine());

SidesOfATriangle(numberOne, numberTwo, numberThree);

