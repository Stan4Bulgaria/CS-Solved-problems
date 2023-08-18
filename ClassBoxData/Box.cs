using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box()
        {

        }
        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
            Length = length;
            Width = width;
            Height = height;
        
        }

        public double Length
        {
            get 
            {
                return this.length;
            }
            private set 
            {
                if(this.length <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
            } 
        }
        public double Width
        {
            get 
            {
                return this.width;
            }
            private set
            {
                if(this.width <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
            }
        }
        public double Height
        {
            get 
            { 
                return this.height; 
            }
            private set 
            {
                if(this.height <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
            }
        }
        public double SurfaceArea()
        {
            double surfaceArea = 2 * (this.length * this.width) + 2 * (this.length * height) + 2 * (width * height);
            return surfaceArea;
        }
        public double LateralSurfaceArea()
        {
            double laternalSurface = 2 * (this.length * this.height) + 2 * (width * height);
            return laternalSurface;
        }
        public double Volume()
        {
            double volume = length * width * height;
            return volume;
        }

    }
}
