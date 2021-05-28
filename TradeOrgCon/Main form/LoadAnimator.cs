using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace TradeOrgCon.Main_form
{
    class LoadAnimator
    {
        Graphics graphicsOfFormAnimation = null;
        Form form;
        bool isDrawing = false;
        Rectangle[] loadCircleCoords =
        {
            new Rectangle(125,92,15,15),
            new Rectangle(145,92,15,15),
            new Rectangle(165,92,15,15),
            new Rectangle(185,92,15,15)
        };

        Color currentColor = Color.AliceBlue;
        int currentCircle = 0;
        public LoadAnimator(Form form, Graphics graphicsOfFormAnimation)
        {
            this.graphicsOfFormAnimation = graphicsOfFormAnimation;
            this.form = form;
        }

        public async void StartAnimation()
        {
            isDrawing = true;
            await Task.Run(() => { DrawCircle(); });
        }

        public void StopDrawing()
        {
            isDrawing = false;
        }

        private void DrawCircle()
        {
            while (isDrawing)
            {
                if (currentCircle >= 4)
                {
                    currentCircle = 0;
                    currentColor = currentColor == Color.LightGreen ? Color.AliceBlue : Color.LightGreen;
                }

                Thread.Sleep(1000); graphicsOfFormAnimation.FillEllipse(new SolidBrush(currentColor), loadCircleCoords[currentCircle++]);
            }

            graphicsOfFormAnimation.Clear(Color.LightGreen);
        }
    }
}
