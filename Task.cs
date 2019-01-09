using System;

namespace programmation_temps_reel_i4_algorithme_ordonnance
{
    public class Task
    {
        private string name;
        private int deadline;

        public Task(string name, int deadline)
        {
            this.name = name;
            this.deadline = deadline;
        }

        public int Deadline => deadline;

        public string Name
        {
            get { return name; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}