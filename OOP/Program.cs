namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            //overloading means same + different parameters + static binding + compile time

            //overriding means child redefines Parent method + Dynamic Binding + Runtime



            #endregion


            #region Question01(b)

            //Static Binding means method call at compile time

            //Dynamic Binding means method call at runtime

            #endregion

            #region Question02
            //A)  What is the purpose of the sealed keyword when applied to a class?
            //sealed reject inheritance from the class

            //B)What is the difference between a sealed class and a sealed method?
            //sealed class reject inheritance from all class

            //sealed method reject overriding from method

            //C) Can a sealed method be overridden? Why?

            //no becuase the goal of sealed method reject any child class to override from method
            #endregion


//            DeliveryCenter center = new DeliveryCenter();

//            Console.Write("Enter Center Name: ");
//            string centerName = Console.ReadLine();
//            center.CenterName = centerName;

//            Driver driver = new Driver("Ahmed", "123456789");

//            center.Driver = driver;

//            // ================= STANDARD SHIPMENT =================

//            Console.WriteLine("\nEnter Standard Shipment Data");

//            Console.Write("Tracking Code: ");
//            string trackingCode1 = Console.ReadLine();

//            Console.Write("Description: ");
//            string description1 = Console.ReadLine();

//            Console.Write("Weight: ");
//            decimal weight1 = decimal.Parse(Console.ReadLine());

//            Console.Write("Delivery Fee: ");
//            decimal fee1 = decimal.Parse(Console.ReadLine());

//            Console.Write("City: ");
//            string city1 = Console.ReadLine();

//            Console.Write("Street: ");
//            string street1 = Console.ReadLine();

//            Console.Write("Building Number: ");
//            int building1 = int.Parse(Console.ReadLine());

//            DeliveryAddress address1 =
//                new DeliveryAddress(city1, street1, building1);

//            StandardShipment shipment1 =
//                new StandardShipment(
//                    trackingCode1,
//                    description1,
//                    weight1,
//                    fee1,
//                    address1);

//            center.AddShipment(shipment1);



//            // ================= EXPRESS SHIPMENT =================

//            Console.WriteLine("\nEnter Express Shipment Data");

//            Console.Write("Tracking Code: ");
//            string trackingCode2 = Console.ReadLine();

//            Console.Write("Description: ");
//            string description2 = Console.ReadLine();

//            Console.Write("Weight: ");
//            decimal weight2 = decimal.Parse(Console.ReadLine());

//            Console.Write("Delivery Fee: ");
//            decimal fee2 = decimal.Parse(Console.ReadLine());

//            Console.Write("City: ");
//            string city2 = Console.ReadLine();

//            Console.Write("Street: ");
//            string street2 = Console.ReadLine();

//            Console.Write("Building Number: ");
//            int building2 = int.Parse(Console.ReadLine());

//            Console.Write("Extra Fee: ");
//            decimal extraFee = decimal.Parse(Console.ReadLine());

//            DeliveryAddress address2 =
//                new DeliveryAddress(city2, street2, building2);

//            ExpressShipment shipment2 =
//                new ExpressShipment(
//                    trackingCode2,
//                    description2,
//                    weight2,
//                    fee2,
//                    address2,
//                    extraFee);

//            center.AddShipment(shipment2);


//            // ================= INTERNATIONAL SHIPMENT =================

//            Console.WriteLine("\nEnter International Shipment Data");

//            Console.Write("Tracking Code: ");
//            string trackingCode3 = Console.ReadLine();

//            Console.Write("Description: ");
//            string description3 = Console.ReadLine();

//            Console.Write("Weight: ");
//            decimal weight3 = decimal.Parse(Console.ReadLine());

//            Console.Write("Delivery Fee: ");
//            decimal fee3 = decimal.Parse(Console.ReadLine());

//            Console.Write("City: ");
//            string city3 = Console.ReadLine();

//            Console.Write("Street: ");
//            string street3 = Console.ReadLine();

//            Console.Write("Building Number: ");
//            int building3 = int.Parse(Console.ReadLine());

//            Console.Write("Destination Country: ");
//            string destinationCountry = Console.ReadLine();

//            Console.Write("Customs Fee: ");
//            decimal customsFee = decimal.Parse(Console.ReadLine());

//            DeliveryAddress address3 =
//                new DeliveryAddress(city3, street3, building3);

//            InternationalShipment shipment3 =
//                new InternationalShipment(
//                    trackingCode3,
//                    description3,
//                    weight3,
//                    fee3,
//                    address3,
//                    destinationCountry,
//                    customsFee);

//            center.AddShipment(shipment3);

//            DeliveryHelper.PrintShipmentDetails(shipment1);
//            DeliveryHelper.PrintShipmentDetails(shipment2);
//            DeliveryHelper.PrintShipmentDetails(shipment3);

//            // ================= PRINT ALL =================

//            Console.WriteLine("\n--- All Shipments ---");

//            center.PrintAllShipments();

//            shipment1.UpdateWeight(10);
//            shipment2.UpdateWeight(8, 2);
//            // ================= SEARCH =================

//            Console.Write("\nEnter Tracking Code to search: ");
//            string searchCode = Console.ReadLine();

//            shipment result = center[searchCode];

//            if (result != null)
//            {
//                Console.WriteLine("\nShipment Found:");
//                result.PrintShipment();
//            }
//            else
//            {
//                Console.WriteLine("Shipment not found.");
//            }

//            shipment[] mixedShipments =
//{
//    shipment1,
//    shipment2,
//    shipment3
//};

//            for (int i = 0; i < mixedShipments.Length; i++)
//            {
//                mixedShipments[i].PrintShipment();
//            }
//            // ================= REMOVE =================

//            Console.Write("\nEnter Tracking Code to remove: ");
//            string removeCode = Console.ReadLine();

//            bool removed = center.RemoveShipment(removeCode);

//            if (removed)
//            {
//                Console.WriteLine("Shipment removed successfully.");
//            }
//            else
//            {
//                Console.WriteLine("Shipment not found.");
//            }

//            CompletedShipment completed =
//    new CompletedShipment(
//        "CMP001",
//        "Documents",
//        2,
//        40,
//        address1);

//            completed.PrintShipment();

//            PriorityInternationalShipment priority =
//                new PriorityInternationalShipment(
//                    "PRI001",
//                    "Electronics",
//                    6,
//                    100,
//                    address2,
//                    "UK",
//                    50);

//            priority.GenerateCustomsReport();
//            // ================= PRINT REMAINING =================

//            Console.WriteLine("\n--- Remaining Shipments ---");

//            center.PrintAllShipments();
        }



        //public class shipment
        //{
        //    private string trackingCode;
        //    private string description;
        //    private decimal weight;
        //    private decimal deliveryFee;

        //    public DeliveryAddress Destination { get; set; }

        //    public string TrackingCode
        //    {
        //        get { return trackingCode; }

        //        private set
        //        {
        //            if (!string.IsNullOrWhiteSpace(value))
        //                trackingCode = value;
        //        }
        //    }

        //    public string Description
        //    {
        //        get { return description; }
        //        set
        //        {
        //            if (!string.IsNullOrWhiteSpace(value))
        //                description = value;
        //        }
        //    }

        //    public decimal Weight
        //    {
        //        get { return weight; }
        //        set
        //        {
        //            if (value > 0)
        //                weight = value;
        //        }
        //    }

        //    public decimal DeliveryFee
        //    {
        //        get { return deliveryFee; }
        //        private set
        //        {
        //            if (value > 0)
        //                deliveryFee = value;
        //        }
        //    }

        //    public virtual decimal EstimatedCost
        //    {
        //        get { return deliveryFee + (decimal)(weight * 5); }
        //    }

        //    public virtual void PrintShipment()
        //    {
        //        Console.WriteLine("Tracking Code: " + TrackingCode);
        //        Console.WriteLine("Description: " + Description);
        //        Console.WriteLine("Weight: " + Weight);
        //        Console.WriteLine("Delivery Fee: " + DeliveryFee);
        //        Console.WriteLine("Destination: " + Destination.GetFullAddress());
        //        Console.WriteLine("Estimated Cost: " + EstimatedCost);
        //    }

        //    public void UpdateDeliveryFee(decimal newFee)
        //    {
        //        if (newFee > 0)
        //        {
        //            DeliveryFee = newFee;
        //        }
        //    }

        //    public void UpdateWeight(decimal newWeight)
        //    {
        //        if (newWeight > 0)
        //        {
        //            Weight = newWeight;
        //        }
        //    }

        //    public void UpdateWeight(decimal newWeight, decimal packingWeight)
        //    {
        //        if (newWeight > 0 && packingWeight >= 0)
        //        {
        //            Weight = newWeight + packingWeight;
        //        }
        //    }


        //    public shipment(string trackingCode)
        //    {
        //        this.TrackingCode = trackingCode;
        //        this.description = "Unknown";
        //        this.weight = 1;
        //        this.deliveryFee = 50;
        //        this.Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        //    }

        //    public shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        //    {
        //        this.Weight = weight;
        //        this.DeliveryFee = deliveryFee;
        //        this.Destination = destination;
        //        this.TrackingCode = trackingCode;
        //        this.Description = description;
        //    }
        //}

        //public class StandardShipment : shipment
        //{
        //    public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        //    {

        //    }

        //    public override void PrintShipment()
        //    {
        //        Console.WriteLine("Tracking Code: " + TrackingCode);
        //        Console.WriteLine("Description: " + Description);
        //        Console.WriteLine("Weight: " + Weight);
        //        Console.WriteLine("Delivery Fee: " + DeliveryFee);
        //        Console.WriteLine("Destination: " + Destination.GetFullAddress());
        //        Console.WriteLine("Estimated Cost: " + EstimatedCost);
        //    }
        //}

        //public class ExpressShipment : shipment
        //{
        //    private decimal extraFee;

        //    public decimal ExtraFee
        //    {
        //        get { return extraFee; }
        //        set
        //        {
        //            if (value >= 0)
        //                extraFee = value;
        //        }
        //    }

        //    public override decimal EstimatedCost
        //    {
        //        get
        //        {
        //            return DeliveryFee + (Weight * 5) + ExtraFee;
        //        }
        //    }

        //    public ExpressShipment(
        //        string trackingCode,
        //        string description,
        //        decimal weight,
        //        decimal deliveryFee,
        //        DeliveryAddress destination,
        //        decimal extraFee)
        //        : base(trackingCode, description, weight, deliveryFee, destination)
        //    {
        //        ExtraFee = extraFee;
        //    }
        //    public override void PrintShipment()
        //    {
        //        Console.WriteLine("Tracking Code: " + TrackingCode);
        //        Console.WriteLine("Description: " + Description);
        //        Console.WriteLine("Weight: " + Weight);
        //        Console.WriteLine("Delivery Fee: " + DeliveryFee);
        //        Console.WriteLine("Destination: " + Destination.GetFullAddress());
        //        Console.WriteLine("Estimated Cost: " + EstimatedCost);
        //        Console.WriteLine("Extra Fee: " + ExtraFee);
        //    }
        //}
        //public class InternationalShipment : shipment
        //{
        //    private string destinationCountry;
        //    private decimal customsFee;

        //    public string DestinationCountry
        //    {
        //        get { return destinationCountry; }
        //        set
        //        {
        //            if (!string.IsNullOrWhiteSpace(value))
        //                destinationCountry = value;
        //        }
        //    }

        //    public decimal CustomsFee
        //    {
        //        get { return customsFee; }
        //        set
        //        {
        //            if (value >= 0)
        //                customsFee = value;
        //        }
        //    }

        //    public override decimal EstimatedCost
        //    {
        //        get
        //        {
        //            return DeliveryFee + (Weight * 5) + CustomsFee;
        //        }
        //    }


        //    public virtual void GenerateCustomsReport()
        //    {
        //        Console.WriteLine("Customs Report");
        //    }


        //    public override void PrintShipment()
        //    {
        //        Console.WriteLine("Tracking Code: " + TrackingCode);
        //        Console.WriteLine("Description: " + Description);
        //        Console.WriteLine("Weight: " + Weight);
        //        Console.WriteLine("Delivery Fee: " + DeliveryFee);
        //        Console.WriteLine("Destination: " + Destination.GetFullAddress());
        //        Console.WriteLine("Estimated Cost: " + EstimatedCost);
        //        Console.WriteLine("Destination Country: " + DestinationCountry);
        //        Console.WriteLine("Customs Fee: " + CustomsFee);
        //    }

        //    public InternationalShipment(
        //        string trackingCode,
        //        string description,
        //        decimal weight,
        //        decimal deliveryFee,
        //        DeliveryAddress destination,
        //        string destinationCountry,
        //        decimal customsFee)
        //        : base(trackingCode, description, weight, deliveryFee, destination)
        //    {
        //        DestinationCountry = destinationCountry;
        //        CustomsFee = customsFee;
        //    }
        //}

        //public class PriorityInternationalShipment : InternationalShipment
        //{
        //    public PriorityInternationalShipment(
        //        string trackingCode,
        //        string description,
        //        decimal weight,
        //        decimal deliveryFee,
        //        DeliveryAddress destination,
        //        string destinationCountry,
        //        decimal customsFee)
        //        : base(
        //            trackingCode,
        //            description,
        //            weight,
        //            deliveryFee,
        //            destination,
        //            destinationCountry,
        //            customsFee)
        //    {
        //    }

        //    public sealed override void GenerateCustomsReport()
        //    {
        //        Console.WriteLine("Priority Customs Report");
        //    }
        //}

        //public class Driver
        //{
        //    public string Name { get; set; }
        //    public string Phone { get; set; }

        //    public Driver(string name, string phone)
        //    {
        //        Name = name;
        //        Phone = phone;
        //    }
        //}

        //public class DeliveryCenter
        //{
        //    private shipment[] shipments;


        //    public DeliveryCenter()
        //    {
        //        shipments = new shipment[20];
        //    }

        //    public string CenterName { get; set; }

        //    public Driver Driver { get; set; }
        //    public shipment this[int index]
        //    {
        //        get
        //        {
        //            if (index >= 0 && index < shipments.Length)
        //                return shipments[index];

        //            return default;
        //        }

        //        set
        //        {
        //            if (index >= 0 && index < shipments.Length)
        //                shipments[index] = value;
        //        }
        //    }


        //    public shipment this[string trackingCode]
        //    {
        //        get
        //        {
        //            for (int i = 0; i < shipments.Length; i++)
        //            {
        //                if (shipments[i].TrackingCode == trackingCode)
        //                    return shipments[i];
        //            }

        //            return default;
        //        }
        //    }

        //    public bool RemoveShipment(string trackingCode)
        //    {
        //        for (int i = 0; i < shipments.Length; i++)
        //        {
        //            if (shipments[i] != null &&
        //                shipments[i].TrackingCode == trackingCode)
        //            {
        //                shipments[i] = null;
        //                return true;
        //            }
        //        }

        //        return false;
        //    }


        //    public bool AddShipment(shipment newShipment)
        //    {
        //        for (int i = 0; i < shipments.Length; i++)
        //        {
        //            if (shipments[i] == null)
        //            {
        //                shipments[i] = newShipment;
        //                return true;
        //            }
        //        }

        //        return false;
        //    }

        //    public void PrintAllShipments()
        //    {
        //        for (int i = 0; i < shipments.Length; i++)
        //        {
        //            if (shipments[i] != null)
        //            {
        //                shipments[i].PrintShipment();
        //            }
        //        }
        //    }


        //}

        //public static class DeliveryHelper
        //{
        //    public static void PrintShipmentDetails(shipment shipment)
        //    {
        //        shipment.PrintShipment();
        //    }
        //}

        //public sealed class CompletedShipment : shipment
        //{
        //    public CompletedShipment(
        //        string trackingCode,
        //        string description,
        //        decimal weight,
        //        decimal deliveryFee,
        //        DeliveryAddress destination)
        //        : base(trackingCode, description, weight, deliveryFee, destination)
        //    {
        //    }
        //}

        //public struct DeliveryAddress
        //{
        //    public string City;
        //    public string Street;
        //    public int BuildingNumber;
        //    public DeliveryAddress(string city, string street, int buildingNumber)
        //    {
        //        City = city;
        //        Street = street;
        //        BuildingNumber = buildingNumber;
        //    }
        //    public string GetFullAddress()
        //    {
        //        return City + "," + Street + "Building" + BuildingNumber;
        //    }
        //    }
}
}
