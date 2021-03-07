﻿using FacotyMethodPattern.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacotyMethodPattern.Creators
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
