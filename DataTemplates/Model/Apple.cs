// Apple.cs
// Created: 2016-10-10

namespace DataTemplates.Model
{
    public class Apple : Fruit
    {
        public Apple() : base("Apple")
        {
        }

        public string Breed { get; set; }
        public string Flavor { get; set; }
        public bool IsGoodForBaking { get; set; }
    }
}