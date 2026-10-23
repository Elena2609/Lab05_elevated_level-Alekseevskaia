// //Шаг 2. Обратный отсчёт и сумма
// Console.WriteLine("Обратный отсчёт");

// int countdown = 5;
// while (countdown >= 1){
//     Console.WriteLine(countdown);
//     countdown--;
// }
// Console.WriteLine("Пуск!");

// Console.WriteLine();
// Console.WriteLine("Сумма чисел от 1 до 10");

// int number = 1;
// int sum = 0;

// while (number <= 10){
//     sum += number;
//     number++;
// } 

// Console.WriteLine($"Сумма: {sum}");

// //Шаг 4. Ловим ошибку своими руками 
// Console.WriteLine();
// Console.WriteLine("Бесконечный цикл");

// int i = 1;
// while (i <= 5){
//     Console.WriteLine($"Значение i: {i}");
//     i++;
// } 

// //Шаг 5. Валидация ввода через while
// Console.WriteLine();
// Console.WriteLine("Валидация ввода через while");
// bool isValid = false;
// int enteredAge = 0;
// while (!isValid){
//     Console.Write("Введите ваш возраст (целое число): ");
//     string input = Console.ReadLine();
//     isValid = int.TryParse(input, out enteredAge);

//     if (!isValid){
//         Console.WriteLine("Это не похоже на целое число. Попробуйте еще раз.");
//     }
// } 
// Console.WriteLine($"Принято! Ваш возраст: {enteredAge}");

//Шаг 7. Меню на do-while
// Console.WriteLine();
// Console.WriteLine("Меню (без выхода, один проход)");

// string menuChoice;
// do {
//     Console.WriteLine("1 - Показать дату");
//     Console.WriteLine("2 - Показать приветствие");
//     Console.WriteLine("0 - Выход");
//     Console.Write("Выберите пункт: ");
//     menuChoice = Console.ReadLine();

//     switch (menuChoice){
//         case "1":
//             Console.WriteLine($"Сегодня : {DateTime.Now:dd.MM.yyyy}");
//             break;
//         case "2":
//             Console.WriteLine("Здраствуйте! Рады видеть вас снова");
//             break;
//         case "0":
//             Console.WriteLine("До свидания!");
//             break;
//         default:
//             Console.WriteLine("Такого пункта нет, попробуйте снова.");
//             break;
//     }
// }while (menuChoice != "0");

// //Шаг 9. Прямой, обратный счёт и шаг, отличный от 1 
// Console.WriteLine();
// Console.WriteLine("Прямой счёт");
// for (int i = 1; i <= 5; i++){
//     Console.WriteLine(i);
// } 
// Console.WriteLine();
// Console.WriteLine("Обратный счёт");
// for (int i = 5; i >= 1; i--){
//     Console.WriteLine(i);
// }

// Console.WriteLine();
// Console.WriteLine("Чётные числа от 0 до 20");
// for (int i = 0; i <= 20; i += 2){
//     Console.WriteLine($"{i} ");
// }
// Console.WriteLine();

//Шаг 11. foreach по строке и подсчёт гласных
// Console.WriteLine();
// Console.WriteLine("foreach по строке");

// string word = "Программирование";

// foreach (char letter in word){
//     Console.Write($"{letter} ");
// } 
// Console.WriteLine();

// Console.WriteLine();
// Console.WriteLine("Считаем гласные");

// string sentense = "Курс алгоритмизации и программирования";
// string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
// int vowelCount = 0;

// foreach (char letter in sentense){
//     if (vowels.Contains(letter)){
//         vowelCount++;
//     }
// } 
// Console.WriteLine($"Гласных букв в предложении: {vowelCount}");

// //Шаг 12. Вложенные циклы: таблица умножения, треугольник и break во внутреннем цикле 
// Console.WriteLine();
// Console.WriteLine("Таблица умножения 1-9");

// for (int row = 1; row <= 9; row++){
//     for (int col = 1; col <= 9; col++){
//         Console.Write($"{row*col, 4}");
//     }
//     Console.WriteLine();
// } 
// Console.WriteLine();
// Console.WriteLine("Треугольник");
// for (int row = 1; row <= 5; row++){
//     for (int col = 1; col <= row; col++){
//         Console.Write("*");
//     }
//     Console.WriteLine();
// } 

// Console.WriteLine();
// Console.WriteLine("break прерывает только ВНУТРЕННИЙ цикл");

// for (int row = 1; row <= 3; row++){
//     Console.WriteLine($"Внешняя итерация: {row}");
//     for (int col = 1; col <= 5; col++){
//         if (col == 3){
//             break;
//         } 
//         Console.WriteLine($"    Внутренняя итерация: {col}");
//     }
// } 

//Шаг 14. Собираем все циклы вместе 
Console.WriteLine();
Console.WriteLine("Меню");

string menuChoice;
do {
    Console.WriteLine("1 - Проанализировать предложение");
    Console.WriteLine("2 - Найти позицию первой заглавной буквы");
    Console.WriteLine("0 - Выход");
    Console.Write("Выберите пункт: ");
    menuChoice = Console.ReadLine();

    switch (menuChoice){
        case "1":
            Console.Write("Введите предложение: ");
            string sentence = Console.ReadLine();
            int vowels = 0;
            int consonants = 0;
            int spaces = 0;
            string vowelsList = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
                string consonantsList = "бвгджзйклмнпрстфхцчшщьъБВГДЖЗЙКЛМНПРСТФХЦЧШЩЬЪ";
            foreach (char letter in sentence){
                if (letter == ' '){
                    spaces++;
                    continue;
                }
                if (vowelsList.Contains(letter))
                    {
                        vowels++;
                    } 
                else if (consonantsList.Contains(letter)){
                        consonants++;
                    }
            }
            Console.WriteLine($"Всего символов: {sentence.Length}");
            Console.WriteLine($"Гласных: {vowels}");
            Console.WriteLine($"Согласных: {consonants}");
            Console.WriteLine($"Пробелов: {spaces}");
            break;

        case "2":
            Console.Write("Введите предложение: ");
            string sentence1 = Console.ReadLine();
            bool found = false;
            string upper = "АЕЁИОУЫЭЮЯБВГДЖЗЙКЛМНПРСТФХЦЧШЩЬЪ";
            for (int i = 0; i < sentence1.Length; i++){
                char c = sentence1[i];
                if (upper.Contains(c)){
                    Console.WriteLine($"Первая заглавная буква '{c}' находится на позиции: {i}");
                    found = true;
                    break;
                }
            }
            if (!found){
                    Console.WriteLine("Заглавных букв нет");
                }
            break;
        case "0":
            Console.WriteLine("До свидания!");
            break;
        default:
            Console.WriteLine("Такого пункта нет, попробуйте снова.");
            break;
    }
}while (menuChoice != "0");
