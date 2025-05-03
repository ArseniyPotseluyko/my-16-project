using System;
using System.Collections.Generic;

// Класс MyList<T> (аналог List<T>)
class MyList<T>
{
    private List<T> items;

    public MyList()
    {
        items = new List<T>();
    }

    // Метод для добавления элемента
    public void Add(T item)
    {
        items.Add(item);
    }

    // Индексатор для получения значения элемента по индексу
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= items.Count)
                throw new IndexOutOfRangeException("Индекс выходит за границы списка.");
            return items[index];
        }
    }

    // Свойство для получения общего количества элементов
    public int Count => items.Count;

    // Метод для получения всех элементов в виде массива (обычный)
    public T[] ToArray()
    {
        return items.ToArray();
    }
}

// Расширяющий метод для MyList<T>
static class MyListExtensions
{
    public static T[] GetArray<T>(this MyList<T> list)
    {
        return list.ToArray();
    }
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

        // Применение расширяющего метода GetArray()
        int[] array = myList.GetArray();

        // Вывод элементов массива
        Console.WriteLine("Элементы массива:");
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}
