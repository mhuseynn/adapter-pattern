namespace Adapter
{
  
    public interface ICar
    {
        void Drive();
    }

    
    public class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving in normal weather");
        }
    }

    
    public interface IRainyWeatherAdapter
    {
        void DriveInRainyWeather();
    }

    
    public class RainyWeatherAdapter : IRainyWeatherAdapter
    {
        private  ICar car;

        public RainyWeatherAdapter(ICar car)
        {
            this.car = car;
        }

        public void DriveInRainyWeather()
        {           
            Console.WriteLine("Adapter for Driving in Rainy weather");
           
        }
    }

   


    class Program
    {
        static void Main()
        {
            
            ICar car = new Car();
          
            //Normal Weather
            car.Drive();

            Console.WriteLine();
            Console.WriteLine();
            //For Rainy Weather
            IRainyWeatherAdapter modied_car = new RainyWeatherAdapter(car);

            modied_car.DriveInRainyWeather();
        }
    }

}