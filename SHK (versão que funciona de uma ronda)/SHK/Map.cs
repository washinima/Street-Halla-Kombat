﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SHK
{
    public class Map : GameObject
    {
        bool isSoft;
        public Vector2 Size;
        public Vector2 Position;

        private Plataforma plat;
        Vector2 platPosition = new Vector2(0, 0);
        Vector2 platSize = new Vector2(0,0);
        public List<Plataforma> ListaPlataformas = new List<Plataforma>();
        

        public Map(Vector2 size, Vector2 position, string imageName) : base(imageName, position, size)
        {
            this.Size = size;
            this.Position = position;

            if (imageName.Equals("map1"))
            {
                platPosition = new Vector2(2150, 365);
                platSize = new Vector2(1000, 100);
                plat = new Plataforma(false, platSize, platPosition);
                ListaPlataformas.Add(plat);
                ///////////////////////////////////////
                platPosition = new Vector2(420, 645);
                platSize = new Vector2(1100, 100);
                plat = new Plataforma(false, platSize, platPosition);
                ListaPlataformas.Add(plat);
            }
            else if (imageName.Equals("map2"))
            {
                //////////////////////////////////////// dir
                platPosition = new Vector2(425, 680);
                platSize = new Vector2(650, 60);
                plat = new Plataforma(true, platSize, platPosition);
                ListaPlataformas.Add(plat);
                /////////////////////////////////////// esq
                platPosition = new Vector2(2055, 680);
                platSize = new Vector2(640, 60);
                plat = new Plataforma(true, platSize, platPosition);
                ListaPlataformas.Add(plat);
                /////////////////////////////////////// main
                platPosition = new Vector2(1225, 105);
                platSize = new Vector2(1825, 210);
                plat = new Plataforma(false, platSize, platPosition);
                ListaPlataformas.Add(plat);
            }

        }

        public override void Draw()
        {
            
            base.Draw();
            foreach (var plat in ListaPlataformas)
            {
                plat.Draw();
            }
        }
    }
}
