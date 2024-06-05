# Приложение - Парковочная автостоянка

### Данное приложение разработано для работы с парковочной автостоянкой. Приложение предназначено для предприятий, в которых присутсвует парковочная стоянка.

## Содержание
- Использование
- Технологии
- Разработка
- Тестирование
- To do
- Команда проекта
- Источники

## Использование
Для работы с приложением необходимо следующее программное обеспечение:

Microsoft Visual Studio Community 2022

Перед началом работы с Информационной средой «Краткие заметки» на рабочем месте пользователя необходимо выполнить следующие действия:

- Открыть программу Microsoft Visual Studio Community 2022.
- Найти программу «Monitoring».
- Открыть ее.
- Нажать на кнопку запуска

### Задача: «Работа с транспортом: добавление, удаление, вычисление стоимости парковки транспорта»

Нажать кнопку добавить для добавления транспорта 

![малимабин](https://github.com/346pt/Prakt1ka/assets/117898513/262a527e-3fd6-42d6-8526-a1ce31ea1b19)

Нажать кнопку удалить для удаления транспорта 

![малимабин1](https://github.com/346pt/Prakt1ka/assets/117898513/35205be9-0d07-43ae-a3ed-37f22698e828)

Нажать кнопку стоимоисть для вычисления стоимости парковки транспорта

![малимабин11](https://github.com/346pt/Prakt1ka/assets/117898513/df57a7ef-2b19-4f07-bde8-fd9390de3fe9)

### Задача: «Ввод данных из файла и сохранение данных в файл»

Нажать кнопку сохранить

![малямабин111](https://github.com/346pt/Prakt1ka/assets/117898513/3969f7d8-c2f0-4791-b5a8-a68c5b1632f0)

Сохранить в файл 

![sav](https://github.com/346pt/Prakt1ka/assets/117898513/0bab7dd3-bda1-4955-94f6-0625847fe809)

Нажать кнопку загрузить

![444](https://github.com/346pt/Prakt1ka/assets/117898513/a84838f0-3cd2-4b00-9fba-39cd6e290c1d)

Загрузка из файла

![ope](https://github.com/346pt/Prakt1ka/assets/117898513/cd72b1ea-bb1c-4ae7-a5fc-4032739319e1)

## Технологии
- [VisualStudio 2022](https://visualstudio.microsoft.com/ru/vs/community/)
- [c#](https://learn.microsoft.com/ru-ru/dotnet/csharp/)
- [.NET 8.0](https://learn.microsoft.com/ru-ru/dotnet/welcome)

## Разработка

Для установки и запуска проекта, необходим [VisualStudio 2022](https://visualstudio.microsoft.com/ru/vs/community/)

## Тестирование

Для тестирования данного приложения использовалась интеграционное тестирование

### Тестовый граф

![шашлыки](https://github.com/346pt/Prakt1ka/assets/117898513/0cacf258-827a-4eae-9cc7-a934010e21cf)

1 - Запуск программы

2 - Работа с транспортом

3 - Работа с данными

4 - Добавления транспорта

5 - Удаление транспорта

6 - Вычисление стоимости транспорта

7 - Загрузка данных

8 - Сохранение данных

9 - Завершение программы

Т1: 1 - 2 - 4 - 9.

Т2: 1 - 2 - 5 - 9.

Т3: 1 - 2 - 6 - 9.

Т4: 1 - 3 - 7 - 9.

Т5: 1 - 3 - 8 - 9.

Т6: 1 - 2 - 4 - 2 - 5 - 9.

Т7: 1 - 2 - 4 - 2 - 6 - 9.

Т8: 1 - 3 - 7 - 3 - 8 - 9.

Т9: 1 - 3 - 8 - 3 - 7 - 9.

Т10: 1 - 2 - 4 - 2 - 3 - 7 - 9.

Т11: 1 - 2 - 4 - 2 - 3 - 8 - 9.

Т12: 1 - 3 - 7 - 3 - 2 - 4 - 9.

Т13: 1 - 3 - 8 - 3 - 2 - 5 - 9.

Т14: 1 - 2 - 4 - 2 - 5 - 2 - 3 - 7 - 9.

Путь 1: Запуск программы, работа с транспортом, добавление транспорта, завершение программы.

Путь 2: Запуск программы, работа с транспортом, удаление транспорта, завершение программы.

Путь 3: Запуск программы, работа с транспортом, вычисление стоимости транспорта, завершение программы.

Путь 4: Запуск программы, работа с данными, сохранение данных, завершение программы.

Путь 5: Запуск программы, работа с данными, загрузка данных, завершение программы.

Путь 6: Запуск программы, работа с транспортом, добавление транспорта, работа с транспортом, удаление транспорта, завершение программы.

Путь 7: Запуск программы, работа с транспортом, добавление транспорта, работа с транспортом, вычисление стоимости парковки, завершение программы.

Путь 8: Запуск программы, работа с данными, сохранение данных, работа с данными, загрузка данных, завершение работы.

Путь 9: Запуск программы, работа с данными, загрузка данных, работа с данными, сохранение данных, завершение работы.

Путь 10: Запуск программы, работа с транспортом, добавление транспорта, работа с транспортом, работа с данными, сохранение данных, завершение работы.

Путь 11: Запуск программы, работа с транспортом, добавление транспорта, работа с транспортом, работа с данными, загрузка данных, завершение работы.

Путь 12: Запуск программы, работа с данными, сохранение данных, работа с данными, работа с транспортом, добавление транспорта, завершение работы.

Путь 13: Запуск программы, работа с данными, загрузка данных, работа с данными, работа с транспортом, удаление транспорта, завершение работы.

Путь 14: Запуск программы, работа с транспортом, добавление данных, работа с транспортом, удаление данных, работа с транспортом, работа с данными, сохранение данных, завершение программы.

### Тест-кейсы

Тест-кейс загрузки данных из файла

![11](https://github.com/346pt/Prakt1ka/assets/117898513/94227ede-698c-47af-8832-fd4cf4d7a2d9)

Тест-кейс сохранение данных в файл

![22](https://github.com/346pt/Prakt1ka/assets/117898513/07731bca-4b5b-4590-ab07-02d8a0b35033)

Тест-кейс добавления данных

![33](https://github.com/346pt/Prakt1ka/assets/117898513/0b22d9ae-82ba-42e8-a4c9-587d6095081b)

Тест-кейс удаления данных

![44](https://github.com/346pt/Prakt1ka/assets/117898513/f8a94a7d-a7a9-4f33-ada5-fcbb5cc225ed)

Тест-кейс вычисления стоимости парковки

![55](https://github.com/346pt/Prakt1ka/assets/117898513/3eece60f-32a3-4f9a-9925-50d52fe1d53f)

## To do
- Работа с данными: добавление, изменение, удаление.
- Создание диаграмм
- Ввод и вывод данных в файл.

## Команда проекта

Крючков Евгений - главный программист, разработчик, тестировщик, проектировщик, дизайнер

## Источники

- [c#](https://metanit.com/sharp/)
- [windowsforms](https://learn.microsoft.com/ru-ru/dotnet/desktop/winforms/overview/?view=netdesktop-8.0)
