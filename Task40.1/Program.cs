// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool SidesOfATriangle_Bool(int side1, int side2, int side3)
{
    if (side1 < side2 + side3 & side2 < side1 + side3 & side3 < side1 + side2) return true;
    else return false;
}

Console.WriteLine("Введите первое положительное целое число ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе положительное целое число ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье положительное целое число ");
int numberThree = Convert.ToInt32(Console.ReadLine());

bool sidesBoolTriangle = SidesOfATriangle_Bool(numberOne, numberTwo, numberThree);
if (sidesBoolTriangle)
{
    Console.WriteLine($"Треугольник со сторонами {numberOne}, {numberTwo}, и {numberThree} существует");
}
else 
{
    Console.WriteLine($"Треугольник со сторонами {numberOne}, {numberTwo}, и {numberThree} не существует");
}
