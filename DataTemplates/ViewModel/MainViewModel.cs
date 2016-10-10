//  --------------------------------------------------------------------------------------
//  <copyright file="MainViewModel.cs" company="Copper Star Systems, LLC">
//     Copyright 2016 Copper Star Systems, LLC. All Rights Reserved.
//  </copyright>
//  --------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using DataTemplates.Model;
using GalaSoft.MvvmLight;

namespace DataTemplates.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        readonly IList<Fruit> fruits;
        Fruit selectedValue;

        public MainViewModel()
        {
            fruits = new List<Fruit> {new Orange(), new Apple() };
            SelectedValue = fruits.First();
        }

        public Fruit SelectedValue
        {
            get
            {
                return selectedValue;
            }
            set
            {
                selectedValue = value;
                RaisePropertyChanged(() => SelectedValue);
            }
        }

        public IEnumerable<Fruit> Fruits
        {
            get
            {
                return fruits;
            }
        }
    }
}