using System;
using SplashKitSDK;
namespace ShapeDrawer
{
    public class Program
    {

        public static void Main()
        {
            Window window = new Window("Shape Drawer", 800, 600);

            Drawing dr = new Drawing();
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                

                
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape sh = new Shape();

                    sh.X = SplashKit.MouseX();
                    sh.Y = SplashKit.MouseY();
                    dr.AddShape(sh);

                }
                

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    
                    Point2D mp = SplashKit.MousePosition();
                    dr.SelectShapesAt(mp);
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {

                    dr.Background1 = SplashKit.RandomRGBColor(255);
                }

                if (SplashKit.KeyTyped(KeyCode.DeleteKey))
                {
                    foreach (Shape s in dr.Selectedshapes)
                    {
                        dr.DeleteShape(s);
                    }
                }

                if (SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    foreach (Shape s in dr.Selectedshapes)
                    {
                        dr.DeleteShape(s);
                    }
                }

                
                dr.Draw();
                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);
        }
    }

}





