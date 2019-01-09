using System;

namespace programmation_temps_reel_i4_algorithme_ordonnance
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int period = 10;
            Scheduler scheduler = new Scheduler(period);
            
            scheduler.addTask(new Task("A", 40));
            scheduler.addTask(new Task("B", 60));
            scheduler.addTask(new Task("C", 40));
            scheduler.addTask(new Task("D", 70));
            
            scheduler.addTask(new Task("E", 80));
            scheduler.addTask(new Task("F", 80));
            scheduler.addTask(new Task("G", 120));
            scheduler.addTask(new Task("H", 150));
            scheduler.addTask(new Task("I", 160));
            scheduler.addTask(new Task("J", 170));

            for (int time = 0; scheduler.getTaskByTime(time) != null; time += period)
            {
                Console.WriteLine(scheduler.getTaskByTime(time));
            }
            
        }
    }
}