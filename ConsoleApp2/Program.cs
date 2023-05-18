class Program
{
    public class Planet
    {
        private string planetName;

        public string PlanetName
        {
            get
            {
                return planetName;
            }
            set
            {
                if (planetName == null)
                {

                    planetName = value;
                }
            }
        }

        private double planetWeight;

        public double PlanetWeight
        {
            get
            {
                return planetWeight;
            }
            set
            {
                if (planetWeight == 0 || planetWeight < 0)
                {

                    planetWeight = value;
                }
            }
        }

        private double planetDiameter;

        public double PlanetDiameter
        {
            get
            {
                return planetDiameter;
            }
            set
            {
                if (planetDiameter < 0 || planetDiameter == 0)
                {
                    planetDiameter = value;
                }
            }
        }

        private int solarDistance;

        public int SolarDistance
        {
            get
            {
                return solarDistance;
            }
            set
            {
                if (solarDistance == 0 || solarDistance < 0)
                {
                    solarDistance = value;
                }
            }
        }
        private int solarDistanceMil;
        public int SolarDistanceMil()
        {
           
                solarDistanceMil = solarDistance * 621;
            return solarDistanceMil;
            
            




        }

        public Planet() { }

        public Planet(string planetName, double planetWeight, double planetDiameter, int satellitsCount)
        {


            PlanetName = planetName;
            PlanetWeight = planetWeight;
            PlanetDiameter = planetDiameter;
            SolarDistance = solarDistance;
        }

        public void ShowPlanet()
        {
            Console.WriteLine($"Название планеты: {PlanetName},\n" +
                              $"Вес планеты: {PlanetWeight}, \n" +
                              $"Диаметр планеты: {PlanetDiameter}, \n" +
                              $"Расстояние от солнца: {SolarDistance}.");
        }
        static void Main(string[] args)
        {
            Planet p = new Planet("Земля", 100000.5, 1500.5, 10000);
            p.ShowPlanet();
            Planet p3 = new Planet();
            p3.PlanetName = "Venera";
            p3.PlanetWeight = 100000;
            p3.PlanetDiameter = 2000;
            p3.SolarDistance = 3000000;
            p3.SolarDistanceMil();
            p3.ShowPlanet();
            Console.ReadKey();



        }
    }













}