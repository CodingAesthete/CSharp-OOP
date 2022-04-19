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
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        private double Length
        { 
            get 
            {
                return this.length;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException($"Length cannot be zero or negative.");
                }
                this.length = value;
            } 
        }
        private double Width 
        { 
            get 
            {
                return this.width;
            } 
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Width cannot be zero or negative.");
                }
                this.width = value;
            } 
        }
        private double Height 
        { 
            get
            {
                return this.height;
            } 
            set 
            {
                if (value<=0)
                {
                    throw new ArgumentException($"Height cannot be zero or negative.");
                }
                this.height = value;
            } 
        }
        public double SurfaceArea()
        {
            double surfaceArea = 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
            return surfaceArea;
        }
        public double LateralSurfaceArea()
        {
            double lateralArea = 2 * Length * Height + 2 * Width * Height;
            return lateralArea;
        }
        public double Volume()
        {
            double volume = Length * Width * Height;
            return volume;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {this.SurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {this.Volume():f2}");
            return sb.ToString();
        }
    }
}
