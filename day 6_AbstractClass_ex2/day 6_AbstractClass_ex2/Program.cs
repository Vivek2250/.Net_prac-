using day_6_AbstractClass_ex2;

class program
{
    public static void Main()
    {
        Painting p1 = new Painting();
        p1.Title = "Mona Lisa";
        p1.Artist = "Leonardo Da Vinci";
        p1.YearCreated = 1876;
        p1.CanvasSize = 4;
        p1.Describe();

        Sculpture s1 = new Sculpture();
        s1.Title = "Iron Man";
        s1.Artist = "Robert Downey Jr.";
        s1.YearCreated = 2010;
        s1.Material = "Iron";
        s1.Describe();

    }
}