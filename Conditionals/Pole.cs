namespace Conditionals
{
    class program
    {
        public enum Pole
        {
            North,
            South
        }
        enum CapitalCities
        {
            London,
            Paris,
            Madrid,
            Rome
        }

        static void Main(string[] args)
        {
            Pole pole = Pole.North;
            string animal;

            if (pole == Pole.North)
            {
                animal = "Polar Bear";
            }
            else
            {
                animal = "Penguin";
            }

            Console.WriteLine($"The animal that lives in the {pole} Pole is the {animal}");

            pole = Pole.South;
            animal = (pole == Pole.North) ? "Polar Bear" : "Penguin";

            Console.WriteLine($"The animal that lives in the {pole} Pole is the {animal}");




            Console.WriteLine("##### Switch Statement #####");
            var city = CapitalCities.London;
            string countryMessage = "";
            Console.WriteLine(countryMessage);

            //switch (city)
            //{
            //    case CapitalCities.London:
            //        countryMessage = $"{city} is the capital of the UK";
            //        break;

            //    case CapitalCities.Paris:
            //        countryMessage = $"{city} is the capital of France";
            //        break;

            //    case CapitalCities.Rome:
            //        countryMessage = $"{city} is the capital of Italy";
            //        break;

            //    case CapitalCities.Madrid:
            //        countryMessage = $"{city} is the capital of Spain";
            //        break;

            //    default:
            //        countryMessage = "Unknown city";
            //        break;

            //}


            countryMessage = city switch
            {
                CapitalCities.London => $"{city} is the capital of the UK",

                CapitalCities.Paris => $"{city} is the capital of France",

                CapitalCities.Rome => $"{city} is the capital of Italy",

                CapitalCities.Madrid => $"{city} is the capital of Spain",

                _ => "Unknown city",

            };










            Console.WriteLine(countryMessage);

        }

    }
}
