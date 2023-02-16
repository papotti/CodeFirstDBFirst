// See https://aka.ms/new-console-template for more information
using CodeFirstDBFirst.DB;
using Microsoft.EntityFrameworkCore;
Console.WriteLine("Inizio");


using (var context = new TestContext())
{
    Console.WriteLine("Inizio Migrazione");
    context.Database.Migrate();
    Console.WriteLine("Fine Migrazione");

    Console.WriteLine("Inizio Forzature Post-Migrazione");
    context.Tabella1.Add(new Tabella1
    {
        Pk = (int)DateTime.Now.Ticks,
        Descr = "aaa"
    });
    context.SaveChanges();
    Console.WriteLine("Fine Forzature Post-Migrazione");
}


