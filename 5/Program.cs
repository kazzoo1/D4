using System;
using System.Collections.Generic;
using System.Linq;

class Record
{
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime BirthDate { get; set; }

    public override string ToString()
    {
        return $"Фамилия: {Surname}, Телефон: {PhoneNumber}, Дата рождения: {BirthDate.ToShortDateString()}";
    }
}

class Notebook
{
    private List<Record> records;

    public Notebook()
    {
        records = new List<Record>();
    }

    public void AddRecord(string surname, string phoneNumber, DateTime birthDate)
    {
        records.Add(new Record { Surname = surname, PhoneNumber = phoneNumber, BirthDate = birthDate });
        Console.WriteLine("Запись успешно добавлена.");
    }

    public void RemoveRecord(string surname)
    {
        var record = records.FirstOrDefault(r => r.Surname.Equals(surname, StringComparison.OrdinalIgnoreCase));
        if (record != null)
        {
            records.Remove(record);
            Console.WriteLine("Запись успешно удалена.");
        }
        else
        {
            Console.WriteLine("Запись не найдена.");
        }
    }

    public void FindRecordBySurname(string surname)
    {
        var result = records.Where(r => r.Surname.Equals(surname, StringComparison.OrdinalIgnoreCase)).ToList();
        if (result.Any())
        {
            Console.WriteLine("Найденные записи:");
            foreach (var record in result)
            {
                Console.WriteLine(record);
            }
        }
        else
        {
            Console.WriteLine("Записи не найдены.");
        }
    }

    public void FindRecordByBirthDate(DateTime birthDate)
    {
        var result = records.Where(r => r.BirthDate.Date == birthDate.Date).ToList();
        if (result.Any())
        {
            Console.WriteLine("Найденные записи:");
            foreach (var record in result)
            {
                Console.WriteLine(record);
            }
        }
        else
        {
            Console.WriteLine("Записи не найдены.");
        }
    }

    public void FindRecordByPhoneNumber(string phoneNumber)
    {
        var record = records.FirstOrDefault(r => r.PhoneNumber.Equals(phoneNumber));
        if (record != null)
        {
            Console.WriteLine("Найденная запись:");
            Console.WriteLine(record);
        }
        else
        {
            Console.WriteLine("Запись не найдена.");
        }
    }

    public void PrintAllRecords()
    {
        Console.WriteLine("Все записи:");
        foreach (var record in records)
        {
            Console.WriteLine(record);
        }
    }

    public void PrintRecordByIndex(int index)
    {
        if (index >= 0 && index < records.Count)
        {
            Console.WriteLine("Запись по номеру:");
            Console.WriteLine(records[index]);
        }
        else
        {
            Console.WriteLine("Запись с таким номером не найдена.");
        }
    }
}

class Program
{
    static void Main()
    {
        Notebook notebook = new Notebook();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nВыберите пункт:");
            Console.WriteLine("1. Поиск записи по фамилии");
            Console.WriteLine("2. Поиск записи по дате рождения");
            Console.WriteLine("3. Поиск записи по номеру телефона");
            Console.WriteLine("4. Добавление записи");
            Console.WriteLine("5. Удаление записи");
            Console.WriteLine("6. Просмотр всех записей");
            Console.WriteLine("7. Просмотр записи по номеру");
            Console.WriteLine("0. Выход");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите фамилию:");
                    string surname = Console.ReadLine();
                    notebook.FindRecordBySurname(surname);
                    break;
                case 2:
                    Console.WriteLine("Введите дату рождения (дд.мм.гггг):");
                    DateTime birthDate;
                    if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                    {
                        notebook.FindRecordByBirthDate(birthDate);
                    }
                    else
                    {
                        Console.WriteLine("Неверный формат даты.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Введите номер телефона:");
                    string phoneNumber = Console.ReadLine();
                    notebook.FindRecordByPhoneNumber(phoneNumber);
                    break;
                case 4:
                    Console.WriteLine("Введите фамилию:");
                    surname = Console.ReadLine();
                    Console.WriteLine("Введите номер телефона:");
                    phoneNumber = Console.ReadLine();
                    Console.WriteLine("Введите дату рождения (дд.мм.гггг):");
                    if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                    {
                        notebook.AddRecord(surname, phoneNumber, birthDate);
                    }
                    else
                    {
                        Console.WriteLine("Неверный формат даты.");
                    }
                    break;
                case 5:
                    Console.WriteLine("Введите фамилию для удаления:");
                    surname = Console.ReadLine();
                    notebook.RemoveRecord(surname);
                    break;
                case 6:
                    notebook.PrintAllRecords();
                    break;
                case 7:
                    Console.WriteLine("Введите номер записи:");
                    int index = Convert.ToInt32(Console.ReadLine()) - 1; // Пользователь вводит номер начиная с 1
                    notebook.PrintRecordByIndex(index);
                    break;
                case 0:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неверный пункт меню.");
                    break;
            }
        }
    }
}
