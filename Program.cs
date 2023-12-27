//Сложность 2
//(Рабочий и инструмент)



using System;

class Program
{
    static void Main(string[] args)
    {

        Instrument hammer = new Instrument { Name = "Дрель :)" }; // Создание экземпляра класса Instrument

        Worker<Instrument> worker = new Worker<Instrument>(hammer); // Создание экземпляра обобщённого класса Worker с параметром-типом Instrument

        worker.UseTool("Григорий");  // Вызов метода UseTool

        Console.ReadLine(); //Вывод в консоль
    }
}
class Instrument //Класс параметра-типа 'Инструмент'
{
    public string Name { get; set; }

    public override string ToString() // Переопределение метода ToString() (выводит в консоль название инструмента)
    {
        return Name;
    }
}
class Worker<T> //Обобщенный класс 'Рабочий', где параметр-типа - это первый класс
{
    private T Tool;

    public Worker(T tool) //конструктор класса
    {
        Tool = tool;
    }

    public void UseTool(string workerName) //ввывод заданного метода
    {
        Console.WriteLine("Рабочий {0} использует {1}", workerName, Tool);
    }
}