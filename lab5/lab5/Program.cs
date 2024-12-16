using System;

interface IParent
{
    string Info();
    void Metod();
}

class Child1 : IParent
{
    private double speed;
    private double costPrice;
    private double cost;

    public Child1(double speed, double costPrice)
    {
        this.speed = speed;
        this.costPrice = costPrice;
    }

    public string Info()
    {
        return $"Морський транспорт: Швидкість = {speed}, Собівартість = {costPrice}, Вартість = {cost}";
    }

    public void Metod()
    {
        cost = costPrice / speed;
    }
}

class Child2 : IParent
{
    private double speed;
    private double costPrice;
    private double cost;
    private double roadTax;

    public Child2(double speed, double costPrice, double roadTax)
    {
        this.speed = speed;
        this.costPrice = costPrice;
        this.roadTax = roadTax;
    }

    public string Info()
    {
        return $"Наземний транспорт: Швидкість = {speed}, Собівартість = {costPrice}, Дорожній збір = {roadTax}, Вартість = {cost}";
    }

    public void Metod()
    {
        cost = (costPrice / speed) + roadTax;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        for (int i = 1; i <= 5; i++)
        {
            double speed = random.Next(1, 101);
            double costPrice = random.Next(100, 10001);

            bool isMaritime = random.Next(0, 2) == 0;

            if (isMaritime)
            {
                IParent obj = new Child1(speed, costPrice);
                obj.Metod();
                Console.WriteLine(obj.Info());
            }
            else
            {
                double roadTax = random.Next(10, 501);
                IParent obj = new Child2(speed, costPrice, roadTax);
                obj.Metod();
                Console.WriteLine(obj.Info());
            }

            Console.WriteLine("-----");
        }

        Console.ReadKey();
    }
}
