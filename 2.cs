using System;
using System.Collections.Generic;

class MyDictionary<TKey, TValue>
{
    private List<TKey> keys;
    private List<TValue> values;

    // Конструктор
    public MyDictionary()
    {
        keys = new List<TKey>();
        values = new List<TValue>();
    }

    // Метод для добавления пары ключ-значение
    public void Add(TKey key, TValue value)
    {
        if (keys.Contains(key))
        {
            throw new ArgumentException("Ключ уже существует в словаре.");
        }

        keys.Add(key);
        values.Add(value);
    }

    // Индексатор для доступа к значению по ключу
    public TValue this[TKey key]
    {
        get
        {
            int index = keys.IndexOf(key);
            if (index == -1)
            {
                throw new KeyNotFoundException("Ключ не найден.");
            }
            return values[index];
        }
    }

    // Свойство для получения общего количества элементов
    public int Count => keys.Count;
}

class Program
{
    static void Main()
    {
        MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

        // Добавление пар ключ-значение
        myDictionary.Add(1, "Яблоко");
        myDictionary.Add(2, "Банан");
        myDictionary.Add(3, "Апельсин");

        // Вывод значений по ключу
        Console.WriteLine("Элементы словаря:");
        Console.WriteLine($"Ключ 1 -> {myDictionary[1]}");
        Console.WriteLine($"Ключ 2 -> {myDictionary[2]}");
        Console.WriteLine($"Ключ 3 -> {myDictionary[3]}");

        // Вывод общего количества пар
        Console.WriteLine($"\nКоличество пар: {myDictionary.Count}");
    }
}
