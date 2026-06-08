/*
 * Keon Bushman
 * CST - 250
 * 06/14/2026
 * Pizza Maker
 * Activity 4
 * Activity 4 Guide
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaMakerClassLibrary.Services.DataAccessLayer
{
    public class PizzaDAO
    {
        // Class level variables
        private List<PizzaModel> _pizzaOrder;

        /// <summary>
        /// Default constructor for the pizza DAO
        /// </summary>
        public PizzaDAO()
        {
            // Initialize the _pizzaOrder list
            _pizzaOrder = new List<PizzaModel>();
        }
    }
}
