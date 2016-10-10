//  --------------------------------------------------------------------------------------
//  <copyright file="Fruit.cs" company="Copper Star Systems, LLC">
//     Copyright 2016 Copper Star Systems, LLC. All Rights Reserved.
//  </copyright>
//  --------------------------------------------------------------------------------------

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