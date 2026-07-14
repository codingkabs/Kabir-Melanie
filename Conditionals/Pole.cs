namespace Conditionals
{
    class program
    {
        static void Main(string[] args) {
            Pole pole = new Pole.North;
            string animal;

            if (pole == Pole.North)
            {
                animal = "Polar Bear";
            }
            else
            {
                animal = "Pengu";
            }

            Console.WriteLine($"The animal that lives in the {pole} Pole is the {animal}");

                
        }
    }
    public enum Pole
    {
        North,
        South
    }
}
