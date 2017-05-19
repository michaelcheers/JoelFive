﻿using Bridge;
using Bridge.Html5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoelFive
{
    public class DrawnGameObject : GameObject
    {
        public Rectangle Position = new Rectangle();
        public double X
        {
            get
            {
                return Position.X;
            }
            set
            {
                Position.X = value;
            }
        }
        public double Y
        {
            get
            {
                return Position.Y;
            }
            set
            {
                Position.Y = value;
            }
        }
        public double Width
        {
            get
            {
                return Position.Width;
            }
            set
            {
                Position.Width = value;
            }
        }
        public double Height
        {
            get
            {
                return Position.Height;
            }
            set
            {
                Position.Height = value;
            }
        }
        public Union<HTMLImageElement, string> Image;

        public async Task Parse1 (dynamic @dynamic)
        {
            X = @dynamic.x;
            Y = @dynamic.y;
            Width = @dynamic.width;
            Height = @dynamic.height;
            string imageString = @dynamic.image;
            if (imageString[0] == '#')
                Image = imageString;
            else
                Image = await App.LoadImage(imageString);
        }
    }
}