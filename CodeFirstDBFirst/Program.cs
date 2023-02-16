// See https://aka.ms/new-console-template for more information
using CodeFirstDBFirst.DB;
using CodeFirstDBFirst.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
Console.WriteLine("Inizio");


using (var context = new TestContext())
{
    //Inserisco dei valori nel DB
    context.Tabella1.Add(new Tabella1 { Pk = 6, Descr = "cinque" });
    context.SaveChanges();

    //Leggo dei valori dal DB  
    foreach (var rec in context.Tabella1)
    {
        Console.WriteLine("PK : " + rec.Pk);
        Console.WriteLine("Employee Name : " + rec.Descr);
    }

    context.Database.Migrate();
}

Console.WriteLine("Press Any key to exit....");
Console.ReadKey();