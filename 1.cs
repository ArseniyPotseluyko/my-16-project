using System;

class MyList<T>
{
    private T[] items;
    private int count;

    // Конструктор
    public MyList()
    {
        items = new T[4]; // Начальный размер массива
        count = 0;
    }

    // Метод для добавления элемента
    public void Add(T item)
    {
        if (count == items.Length)
        {
            Array.Resize(ref items, items.Length * 2); // Увеличиваем размер массива при необходимости
        }
        items[count] = item;
        count++;
    }

    // Индексатор для доступа к элементам
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Индекс выходит за границы списка.");
            return items[index];
        }
    }

    // Свойство для получения общего количества элементов
    public int Count => count;
}

class Program
{
    static void Main()
    {
        MyList<int> myList = new MyList<int>();

        // Добавление элементов
        myList.Add(10);
        myList.Add(20);
        myList.Add(30);
        myList.Add(40);

        // Вывод элементов
        Console.WriteLine("Элементы списка:");
        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine($"[{i}] -> {myList[i]}");
        }

        // Вывод общего количества элементов
        Console.WriteLine($"\nКоличество элементов: {myList.Count}");
    }
}
