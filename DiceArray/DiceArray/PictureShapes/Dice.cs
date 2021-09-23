namespace PictureShapes
{
    class Dice
    {
        Circle[] dots = new Circle[7];

        private static System.Random numberGenerator = new System.Random();
        private int number = 1;

        
        public Dice()
        {
            number = numberGenerator.Next(1, 7);

            for (int cirkel = 0; cirkel < 7; cirkel = cirkel + 1)
            {
                dots[cirkel] = new Circle();
            }

            
            DrawImage();
        }
        public void Roll()
        {
           if(number == 1)
            {
                dots[3].MakeVisible();
            }
           if(number == 2)
            {
                dots[0].MakeVisible();
                dots[6].MakeVisible();
            }
           if(number == 3)
            {
                dots[0].MakeVisible();
                dots[3].MakeVisible();
                dots[6].MakeVisible();
            }
           if(number == 4)
            {
                dots[0].MakeVisible();
                dots[2].MakeVisible();
                dots[4].MakeVisible();
                dots[6].MakeVisible();
            }
           if(number == 5)
            {
                dots[0].MakeVisible();
                dots[2].MakeVisible();
                dots[3].MakeVisible();
                dots[4].MakeVisible();
                dots[6].MakeVisible();
            }
           if(number == 6)
            {
                dots[0].MakeVisible();
                dots[1].MakeVisible();
                dots[2].MakeVisible();
                dots[3].MakeVisible();
                dots[4].MakeVisible();
                dots[5].MakeVisible();
                dots[6].MakeVisible();

            }
        }
        public void DrawImage()
        {

            
            dots[0].MakeInVisible();
            dots[0].ChangeColor("red");
            dots[0].ChangeSize(100);


            dots[1].MakeInVisible();
            dots[1].ChangeColor("red");
            dots[1].ChangeSize(100);
            dots[1].MoveVertical(150);


            dots[2].MakeInVisible();
            dots[2].ChangeColor("red");
            dots[2].ChangeSize(100);
            dots[2].MoveVertical(300);


            dots[3].MakeInVisible();
            dots[3].ChangeColor("red");
            dots[3].ChangeSize(100);
            dots[3].MoveVertical(150);
            dots[3].MoveHorizontal(150);


            dots[4].MakeInVisible();
            dots[4].ChangeColor("red");
            dots[4].ChangeSize(100);
            dots[4].MoveHorizontal(300);


            dots[5].MakeInVisible();
            dots[5].ChangeColor("red");
            dots[5].ChangeSize(100);
            dots[5].MoveHorizontal(300);
            dots[5].MoveVertical(150);


            dots[6].MakeInVisible();
            dots[6].ChangeColor("red");
            dots[6].ChangeSize(100);
            dots[6].MoveHorizontal(300);
            dots[6].MoveVertical(300);

            int 
        }
    }
}
