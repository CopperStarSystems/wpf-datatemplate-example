//  --------------------------------------------------------------------------------------
//  <copyright file="Apple.cs" company="Copper Star Systems, LLC">
//     Copyright 2016 Copper Star Systems, LLC. All Rights Reserved.
//  </copyright>
//  --------------------------------------------------------------------------------------

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