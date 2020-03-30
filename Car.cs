namespace StaticExamples
{
    /// <summary>
    /// A very simple representation of a car
    /// </summary>
    public class Car
    {
        #region Instance fields
        private string _licensePlate;
        private int _price;

        private static int _noOfCars;

        private static int _noOfLicensePlates = 0;

        private static int _noOfPrice = 0;
        
        #endregion

        #region Constructor
        public Car(string licensePlate, int price)
        {
            _licensePlate = licensePlate;
            _price = price;
            _noOfCars = _noOfCars++;
        }
        #endregion

        #region Properties
        public string LicensePlate
        {
            get { _noOfLicensePlates++; return _licensePlate; }
            set { _licensePlate = value; _noOfLicensePlates++;}
        }

        public int Price
        {
            get { _noOfPrice++; return _price; }
            set { _price = value; _noOfPrice++;}
        } 


        #endregion

        #region Methods
        public static void PrintUsageStatistics()
        {
            System.Console.WriteLine($"Number of Cars: {_noOfCars}");
            System.Console.WriteLine($"Number of License Plate properties: {_noOfLicensePlates}");
            System.Console.WriteLine($"Number of Price properties: {_noOfPrice}");
        }
        #endregion
    }
}