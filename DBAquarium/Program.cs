using DBAquarium.DataContext;
using DBAquarium.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            var Db = new OceansContext();
            Db.Ocean.AddOrUpdate(
              a => a.Name,
              new Oceans
              {
                  Name = "Pacific Ocean",
                  AverageTemperature = 86
              },
              new Oceans
              {
                  Name = "Atlantic Ocean",
                  AverageTemperature = 57
              },
              new Oceans
              {
                  Name = "Indian Ocean",
                  AverageTemperature = 77
              },
              new Oceans
              {
                  Name = "Artic Ocean",
                  AverageTemperature = 31
              });
            Db.SaveChanges();


            Db.Aquarium.AddOrUpdate(
              a => a.Name,
              new Aquariums
              {
                  Name = "The Best Aquarium ever",
                  City =  "Denver"
              },
              new Aquariums
              {
                  Name = "Aquarium Of The North",
                  City = "NewYork" 
 
              });

            Db.SaveChanges();

            Db.AquaticLifes.AddOrUpdate(
            a => a.Name,
            new AquaticLife
            {
                Name = "Jack",
                Type = "Red fish",
                Color = "Black",
                IsInQuarentine = false
            },
            new AquaticLife
            {
                Name = "James",
                Type = "fish",
                Color = "Blue",
                IsInQuarentine = false

            });

            Db.SaveChanges();


            var Tanks = Db.Aquarium.First(f => f.Name == "The Best Aquarium ever");
            var Oceans = Db.Ocean.First(f => f.Name == "Pacific Ocean");
            var Fishes = Db.Fish.First(f => f.Name == "Jack");


        }
    }
}
