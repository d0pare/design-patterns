using System;

namespace DuckSort
{
    public class Duck : IComparable<Duck>
    {
        public Duck(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; }
        public int Weight { get; }

        public int CompareTo(Duck other)
        {
            if (Weight < other.Weight)
            {
                return -1;
            }

            return Weight == other.Weight ? 0 : 1; //Weight > other.Weight;
        }

        public override string ToString() => $"{Name} weighs {Weight.ToString()}";
    }
}