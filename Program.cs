using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Device.Location;
using System.Globalization;
using System.Collections;


namespace VehiclePosition
{
    //Class declaration
    public class Program
    {

        //Creating Coordinate objects (Latitude & Longitude) for Vehicle Positions
        static GeoCoordinate Position1 { get; set; } = new GeoCoordinate(34.544909, -102.100843);
        static GeoCoordinate Position2 { get; set; } = new GeoCoordinate(32.345544, -99.123124);
        static GeoCoordinate Position3 { get; set; } = new GeoCoordinate(33.234235, -100.214124);
        static GeoCoordinate Position4 { get; set; } = new GeoCoordinate(35.195739, -95.348899);
        static GeoCoordinate Position5 { get; set; } = new GeoCoordinate(31.895839, -95.789573);
        static GeoCoordinate Position6 { get; set; } = new GeoCoordinate(32.895839, -101.789573);
        static GeoCoordinate Position7 { get; set; } = new GeoCoordinate(34.115839, -100.225732);
        static GeoCoordinate Position8 { get; set; } = new GeoCoordinate(32.335839, -99.992232);
        static GeoCoordinate Position9 { get; set; } = new GeoCoordinate(33.535339, -94.792232);
        static GeoCoordinate Position10 { get; set; } = new GeoCoordinate(32.234235, -100.222222);

        #region BinaryData
        static Int32 VehicleID;
        static string VehicleRegistration = "\n";
        static float Latitude;
        static float Longitude;
        static UInt64 RecordedTimeUTC;
        #endregion


        //Some VARIABLES
        static double DistanceBetween;
        static double Kilometers;
        static double Kilo;
        const double KM = 0.001;

        #region DELEGATES

        //Below Delegate for Position1Position10 method
        delegate double Pos1Pos10();
        //Below Delegate for Position1Position9 method
        delegate double Pos1Pos9();
        //Below Delegate for Position1Position8 method
        delegate double Pos1Pos0();
        //Below Delegate for Position1Position7 method
        delegate double Pos1Pos7();
        //Below Delegate for Position1Position6 method
        delegate double Pos1Pos6();
        //Below Delegate for Position1Position5 method
        delegate double Pos1Pos5();
        //Below Delegate for Position1Position4 method
        delegate void Pos1Pos4();
        //Below Delegate for Position1Position3 method
        delegate double Pos1Pos3();
        //Below Delegate for Position1Position2 method
        delegate double Pos1Pos2();

        delegate double VehList();


        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Vehicle GPS Co-ordinates");
            Console.WriteLine("**************************");
            Console.WriteLine();
            VehicleNearestPosition();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("The list below shows the NEAREST Vehicle upto the FURTHEST Vehicle");
            Console.WriteLine("----------------------------------------------------------------------");
            VehiclePositionSorted();
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Search for a Vehicle");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            BinarySearchVehicle();
            Console.WriteLine();

        }

        static void VehicleNearestPosition()
        {
            //Distance between Position 1 and Position 2
            Position1Position2();
            //Distance between Position 1 and Position 3
            Position1Position3();
            //Distance between Position 1 and Position 4
            Position1Position4();
            //Distance between Position 1 and Position 5
            Position1Position5();
            //Distance between Position 1 and Position 6
            Position1Position6();
            //Distance between Position 1 and Position 7
            Position1Position7();
            //Distance between Position 1 and Position 8
            Position1Position8();
            //Distance between Position 1 and Position 9
            Position1Position9();
            //Distance between Position 1 and Position 10
            Position1Position10();

        }
        #region DistanceCalculations

        private static double Position1Position10()
        {
            //Calculate Distance between Position1(Coordinates) & Position10(Coordinates)
            DistanceBetween = Position1.GetDistanceTo(Position10);
            //Convert to Kms
            Kilometers = DistanceBetween * KM;
            Kilo = Math.Round(Kilometers, 2);
            Console.WriteLine($"The distance between Position 1 and Position 10 is = {DistanceBetween} meters / its  {Kilo}  Km.");
            Console.WriteLine();
            return Kilo;
        }

        private static double Position1Position9()
        {
            //Calculate Distance between Position1(Coordinates) & Position9(Coordinates)
            DistanceBetween = Position1.GetDistanceTo(Position9);
            //Convert to Kms
            Kilometers = DistanceBetween * KM;
            Kilo = Math.Round(Kilometers, 2);
            Console.WriteLine($"The distance between Position 1 and Position 9 is = {DistanceBetween} meters / its  {Kilo}  Km.");
            Console.WriteLine();
            return Kilo;
        }

        private static double Position1Position8()
        {
            //Calculate Distance between Position1(Coordinates) & Position8(Coordinates)
            DistanceBetween = Position1.GetDistanceTo(Position8);
            //Convert to Kms
            Kilometers = DistanceBetween * KM;
            Kilo = Math.Round(Kilometers, 2);
            Console.WriteLine($"The distance between Position 1 and Position 8 is = {DistanceBetween} meters / its  {Kilo}  Km.");
            Console.WriteLine();
            return Kilo;
        }

        private static double Position1Position7()
        {
            //Calculate Distance between Position1(Coordinates) & Position7(Coordinates)
            DistanceBetween = Position1.GetDistanceTo(Position7);
            //Convert to Kms
            Kilometers = DistanceBetween * KM;
            Kilo = Math.Round(Kilometers, 2);
            Console.WriteLine($"The distance between Position 1 and Position 7 is = {DistanceBetween} meters / its  {Kilo}  Km.");
            Console.WriteLine();
            return Kilo;
        }

        private static double Position1Position6()
        {
            //Calculate Distance between Position1(Coordinates) & Position6(Coordinates)
            DistanceBetween = Position1.GetDistanceTo(Position6);
            //Convert to Kms
            Kilometers = DistanceBetween * KM;
            Kilo = Math.Round(Kilometers, 2);
            Console.WriteLine($"The distance between Position 1 and Position 6 is = {DistanceBetween} meters / its  {Kilo}  Km.");
            Console.WriteLine();
            return Kilo;
        }

        private static double Position1Position5()
        {
            //Calculate Distance between Position1(Coordinates) & Position5(Coordinates)
            DistanceBetween = Position1.GetDistanceTo(Position5);
            //Convert to Kms
            Kilometers = DistanceBetween * KM;
            Kilo = Math.Round(Kilometers, 2);
            Console.WriteLine($"The distance between Position 1 and Position 5 is = {DistanceBetween} meters / its  {Kilo}  Km.");
            Console.WriteLine();
            return Kilo;
        }

        private static double Position1Position4()
        {
            //Calculate Distance between Position1(Coordinates) & Position4(Coordinates)
            DistanceBetween = Position1.GetDistanceTo(Position4);
            //Convert to Kms
            Kilometers = DistanceBetween * KM;
            Kilo = Math.Round(Kilometers, 2);
            Console.WriteLine($"The distance between Position 1 and Position 4 is = {DistanceBetween} meters / its {Kilo} Km.");
            Console.WriteLine();
            return Kilo;
        }

        private static double Position1Position3()
        {
            //Calculate Distance between Position1(Coordinates) & Position3(Coordinates)
            DistanceBetween = Position1.GetDistanceTo(Position3);
            //Convert to Kms
            Kilometers = DistanceBetween * KM;
            Kilo = Math.Round(Kilometers, 2);
            Console.WriteLine($"The distance between Position 1 and Position 3 is = {DistanceBetween} meters / its {Kilo} Km.");
            Console.WriteLine();
            return Kilo;
        }

        private static double Position1Position2()
        {
            //Calculate Distance between Position1(Coordinates) & Position2(Coordinates)
            DistanceBetween = Position1.GetDistanceTo(Position2);
            //Convert to Kms
            Kilometers = DistanceBetween * KM;
            Kilo = Math.Round(Kilometers, 2);
            Console.WriteLine($"The distance between Position 1 and Position 2 is = {DistanceBetween} meters / its {Kilo} Km.");
            Console.WriteLine();
            return Kilo;
        }
        #endregion

        //Sort Vehicle Location updates
        static bool VehiclePositionSorted()
        {
            //Invoke or implement DELEGATE

            List<VehList> SortedList = new List<VehList>();
            {

                //Use delegates
                SortedList.Add(Position1Position10);
                SortedList.Add(Position1Position9);
                SortedList.Add(Position1Position8);
                SortedList.Add(Position1Position7);
                SortedList.Add(Position1Position6);
                SortedList.Add(Position1Position5);
                SortedList.Add(Position1Position4);
                SortedList.Add(Position1Position3);
                SortedList.Add(Position1Position2);
            };


            //Sort the list in ASCENDING Order
            SortedList.Sort((Vehicle1, Vehicle2) => Vehicle1.GetType().Name.CompareTo(Vehicle2.GetType().Name));
           
            //Display Sorted list
            foreach (var SL in SortedList)
            {
                double ListedVehicles = SL.Invoke();
                Console.WriteLine($"{ListedVehicles}");
            }
            return true;

        }

        //Binary Search the Closest Vehicle
        static void BinarySearchVehicle()
        {
            try
            {
                List<VehList> BinaryList = new List<VehList>();
                {

                    //Use delegates
                    BinaryList.Add(Position1Position10);
                    BinaryList.Add(Position1Position9);
                    BinaryList.Add(Position1Position8);
                    BinaryList.Add(Position1Position7);
                    BinaryList.Add(Position1Position6);
                    BinaryList.Add(Position1Position5);
                    BinaryList.Add(Position1Position4);
                    BinaryList.Add(Position1Position3);
                    BinaryList.Add(Position1Position2);
                };

                // Search for a Vehicle using BINARYSEARCH
                Console.WriteLine("Enter Vehicle to Search...");
                VehicleID = Convert.ToInt32(Console.ReadLine());
                foreach (var V in BinaryList)
                {
                    VehicleID = Convert.ToInt32(V.Invoke());
                    double Vehicle = BinaryList.BinarySearch(V);
                    Vehicle = Convert.ToDouble(VehiclePosition());

                }

            }
            catch (Exception EXP)
            {
                EXP.Message.ToString();
            }
 
        }
        //Get the Current Vehicle Position
        static bool VehiclePosition()
        {
            GeoCoordinate GeoCoord = new GeoCoordinate();

            if (GeoCoord.IsUnknown != true)
            {
                Console.WriteLine("Latitude : {0}, Longitude : {1}, Altitude : {2}, Speed :{3}", GeoCoord.Latitude, GeoCoord.Longitude, GeoCoord.Altitude, GeoCoord.Speed);
            }
            return true;
        }



    }



}

















