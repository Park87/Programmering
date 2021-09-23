namespace PictureShapes
{
    class Dice
    {
        public Circle tärning1 = new Circle();
        public Circle tärning2 = new Circle();
        public Circle tärning3 = new Circle();
        public Circle tärning4 = new Circle();
        public Circle tärning5 = new Circle();
        public Circle tärning6 = new Circle();
        public Circle tärning7 = new Circle();

        private static System.Random numberGenerator = new System.Random();
        private int number = 1;

        
        public Dice()
        {
            number = numberGenerator.Next(1, 7);
            DrawImage();
        }
        public void Roll()
        {
           if(number == 1)
            {
                tärning4.MakeVisible();
            }
           if(number == 2)
            {
                tärning1.MakeVisible();
                tärning7.MakeVisible();
            }
           if(number == 3)
            {
                tärning1.MakeVisible();
                tärning4.MakeVisible();
                tärning7.MakeVisible();
            }
           if(number == 4)
            {
                tärning1.MakeVisible();
                tärning3.MakeVisible();
                tärning5.MakeVisible();
                tärning7.MakeVisible();
            }
           if(number == 5)
            {
                tärning1.MakeVisible();
                tärning3.MakeVisible();
                tärning4.MakeVisible();
                tärning5.MakeVisible();
                tärning7.MakeVisible();
            }
           if(number == 6)
            {
                tärning1.MakeVisible();
                tärning2.MakeVisible();
                tärning3.MakeVisible();
                tärning4.MakeVisible();
                tärning5.MakeVisible();
                tärning6.MakeVisible();
                tärning7.MakeVisible();

            }
        }
        public void DrawImage()
        {

            
            tärning1.MakeInVisible();
            tärning1.ChangeColor("red");
            tärning1.ChangeSize(100);


            tärning2.MakeInVisible();
            tärning2.ChangeColor("red");
            tärning2.ChangeSize(100);
            tärning2.MoveVertical(150);


            tärning3.MakeInVisible();
            tärning3.ChangeColor("red");
            tärning3.ChangeSize(100);
            tärning3.MoveVertical(300);


            tärning4.MakeInVisible();
            tärning4.ChangeColor("red");
            tärning4.ChangeSize(100);
            tärning4.MoveVertical(150);
            tärning4.MoveHorizontal(150);


            tärning5.MakeInVisible();
            tärning5.ChangeColor("red");
            tärning5.ChangeSize(100);
            tärning5.MoveHorizontal(300);


            tärning6.MakeInVisible();
            tärning6.ChangeColor("red");
            tärning6.ChangeSize(100);
            tärning6.MoveHorizontal(300);
            tärning6.MoveVertical(150);


            tärning7.MakeInVisible();
            tärning7.ChangeColor("red");
            tärning7.ChangeSize(100);
            tärning7.MoveHorizontal(300);
            tärning7.MoveVertical(300);

        }
    }
}
