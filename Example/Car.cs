using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    class Car
    {
        #region Properties
        // Properties
        // These are set to private and can only be called from withing this class
        // We can not change these from outside the class
        private string _colour;
        private string _brand;
        private string _model;
        #endregion

        #region GEtters and Setters
        // Getters and Setters
        // These are set to public and called from outside of the calss
        // Getters allow other parts of the application to receive property content
        // Setters allow other parts of the applocation to change property content
        public string colour
        {
            // get returns the value of a private property
            get { return this._colour; }
            // set updates the value of the private property to the given value
            set { this._colour = value; }
        }
        public string brand
        {
            // get returns the value of a private property
            get { return this._brand; }
        }

        public string model
        {
            // get returns the value of a private property
            get { return this._model; }
        }
        #endregion

        #region Constructors
        // To create an object with the provided properties we need a constructor
        // There are default constructors which create an object with pre-defined values
        public Car()
        {
            this._colour = "Pink";
            this._brand = "Daf";
            this._model = "Truck";
        }

        // But we can also define our own objects with custom values
        public Car(string colour, string brand, string model)
        {
            this._colour = colour;
            this._brand = brand;
            this._model = model;
        }

        // Or a combination
        public Car(string colour)
        {
            this._colour = colour;
            this._brand = "Lambo";
            this._model = "On The Moon";
        }
        #endregion

        #region Methods
        // A class can also have it's own methods
        // They can be called from outside the class
        // In this case we use a method to change colour
        public void repaint(string colour)
        {
            this.colour = colour;
        }
        #endregion
    }
}
