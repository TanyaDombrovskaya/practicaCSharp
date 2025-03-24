using ZavodNamespace;

class Task1
{
    static void Main()
    {
        Worker[] workers = new Worker[]
        {
            new Welder("Иван"),
            new Assebler("Петр"),
            new Electrician("Сергей")
        };

        foreach (Worker worker in workers)
        {
            worker.DoWork();
        }
    }
}