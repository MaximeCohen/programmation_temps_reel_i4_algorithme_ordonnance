using System;
using System.Collections.Generic;
using System.Linq;

namespace programmation_temps_reel_i4_algorithme_ordonnance
{
    public class Scheduler
    {
        private List<Task> tasks;
        private int period;

        public Scheduler(int period)
        {
            tasks = new List<Task>();
            this.period = period;
        }

        public void addTask(Task task)
        {
            tasks.Add(task);
            tasks = tasks.OrderBy(o => o.Deadline).ToList();
        }

        public Task getTaskByTime(int time)
        {
            List<Task> tmp = new List<Task>();
            foreach (var task in tasks)
            {
                if (task.Deadline > time && tmp.Count == 0)
                {
                    tmp.Add(task);
                } 
                else if (tmp.Count != 0 && task.Deadline == tmp.First().Deadline)
                {
                    tmp.Add(task);
                }
            }

            if (tmp.Count > 0)
            {
                return tmp[time / period % tmp.Count];   
            }
            return null;
        }

    }
}