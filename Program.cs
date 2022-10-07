//Найти большее число в случайно выбранном.

int num = new Random().Next(10, 100);

int num1 = num/10;
int num2 = num%10;
int max = num1;

if(num2< max){
    max = num1;
}

else{
    max = num2;
}

Console.WriteLine($"В числе {num} max число {max}");
