﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace StuntEngine
{
    class Engine : GameWindow
    {
        public Engine() :
            base(800, 600)
        {

        }

        static void Main(string[] args)
        {
            using (Engine StuntEngine = new Engine())
            {
                StuntEngine.Run(60.0, 0.0);
            }
        }
    }
}
