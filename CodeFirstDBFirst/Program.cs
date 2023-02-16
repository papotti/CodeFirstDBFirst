// See https://aka.ms/new-console-template for more information
using CodeFirstDBFirst.DB;
using Microsoft.EntityFrameworkCore;
Console.WriteLine("Inizio");


using (var context = new TestContext())
{
    Console.WriteLine("Inizio Migrazione!");
    context.Database.Migrate();
    Console.WriteLine("Fine Migrazione!");
}


