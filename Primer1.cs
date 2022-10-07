//Является ли второе число кратным первого.Вариант 2

Console.WriteLine("Введите число:"); 
int num1 = int.Parse(Console.ReadLine()!);

int num2 = new Random().Next(1, 10);
Console.WriteLine($"Число 2: {num2}.");

if(num1 % num2 == 0){
Console.WriteLine($"Число {num2} кратно {num1}.");
}

else{
Console.WriteLine($"Число {num2} не является кратным {num1}."); 
}
