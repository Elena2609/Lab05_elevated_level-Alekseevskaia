//Шаг 2. Обратный отсчёт и сумма
Console.WriteLine("Обратный отсчёт");

int countdown = 5;
while (countdown >= 1){
    Console.WriteLine(countdown);
    countdown--;
}
Console.WriteLine("Пуск!");

Console.WriteLine();
Console.WriteLine("Сумма чисел от 1 до 10");

int number = 1;
int sum = 0;

while (number <= 10){
    sum += number;
    number++;
} 

Console.WriteLine($"Сумма: {sum}");

//Шаг 4. Ловим ошибку своими руками 
