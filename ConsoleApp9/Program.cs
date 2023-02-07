using ConsoleApp9.Models;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
    //    ApplicationContext ef = new ApplicationContext();
    //    Ticket tick = new Ticket()
    //    {

    //        Passanger = ef.Passangers.FirstOrDefault(x => x.IdPassanger == 2),
    //        PointArrival = ef.Points.FirstOrDefault(x => x.IdPoint == 3),
    //        PointDeparture = new Point() { Value = "Берлин" },
    //        DateArrive = new DateTime(2023, 02, 07, 11, 31, 10)

    //    };
        //ef.Add(tick);
        //ef.SaveChanges();
        Console.WriteLine("Hello, World!");
        ApplicationContext ef = new ApplicationContext();
        Passanger p = new Passanger()
        {
            Name = "Иванова светлана",
            Phone = "+79372334213"
        };
        Passanger p2 = new Passanger()
        {
            Name = "Кузнецов Сергей",
            Phone = "+79375647623"

        };
        Passanger p3 = new Passanger()
        {
            Name = "Шишкина Екатерина",
            Phone = "+79371872901"
        };
        if (!ef.Passangers.Any(x => x.Name == p.Name))
        {
            ef.Add(p);
        }

        ef.Add(p);
        ef.Add(p2);
        ef.Add(p3);

        Point point = new Point() { Value = "Самара" };
        Point point2 = new Point() { Value = "Москва" };
        Point point3 = new Point() { Value = "Брянск" };
        Point point4 = new Point() { Value = "Тольятти" };
        Point point5 = new Point() { Value = "Архангельск" };
        Point point6 = new Point() { Value = "Пермь" };
        Point point7 = new Point() { Value = "Астрахань" };
    }
}