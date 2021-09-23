namespace PictureShapes
{
    class Picture
    {
        private Square wall = new Square();
        private Square wall2 = new Square();
        private Circle sun = new Circle();
        private Triangle roof = new Triangle();

        public Picture()
        {
            DrawImage();
        }
        public void DrawImage()
        {
            
            wall.MakeVisible();
            wall.ChangeColor("red");
            wall.ChangeSize(200);
            wall.MoveHorizontal(70);
            wall.MoveVertical(20);


            wall2.MakeVisible();
            wall2.ChangeColor("black");
            wall2.ChangeSize(80);
            wall2.MoveHorizontal(90);
            wall2.MoveVertical(60);


            sun.MakeVisible();
            sun.ChangeColor("yellow");
            sun.ChangeSize(100);
            sun.MoveHorizontal(550);


            roof.MakeVisible();
            roof.ChangeColor("black");
            roof.ChangeSize(250);
            roof.MoveHorizontal(-5);
            roof.MoveVertical(-5);


            roof.MakeVisible();

        }
    }
}
