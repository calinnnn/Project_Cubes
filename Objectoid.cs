using OpenTK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Cubes
{
    class Objectoid
    {
        private bool visibility;
        private bool isGravityBound;
        private Color colour;
        private List<Vector3> coordList;
        private Randomizer rando;

        private const int GRAVITY_OFFSET = 1;

        public Objectoid()
        {
            rando = new Randomizer();

            visibility = true;
            colour = rando.RandomColor();

            coordList = new List<Vector3>();

            
            coordList.Add(new Vector3(0,0,1));
            coordList.Add(new Vector3(0,0,0));
            coordList.Add(new Vector3(1,0,1));
            coordList.Add(new Vector3(1,0,0));
            coordList.Add(new Vector3(1,1,1));
            coordList.Add(new Vector3(1,1,0));
            coordList.Add(new Vector3(0,1,1));
            coordList.Add(new Vector3(0,1,0));


        }

        public void Draw()
        {
            GL.Color3(colour);
            GL.Begin(PrimitiveType.QuadStrip);
            foreach (Vector3 v in coordList)
            {
                GL.Vertex3(v);
            }
            GL.End();
        }
            public void ToggleVisibility()
            {
                visibility = !visibility;
            }

            public void ToggleGravity()
            {
                isGravityBound = !isGravityBound;
            }

            public void SetGravity()
            {
            isGravityBound = true;
            }

            public void UnsetGravity()
        {
            isGravityBound = false;
        }

        

    }
}
