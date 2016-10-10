// Fruit.cs
// Created: 2016-10-10

namespace DataTemplates.Model
{
    public abstract class Fruit
    {
        protected Fruit(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}