namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //1- What is the difference between a class and a struct?
            //class                             stuct
            //reference type                    value type

            //copies the reference              copies the value

            //can be null                       can't be null

            //support iheritance                not support iheritance
            #endregion

            #region Question02
            //Why are classes more suitable than structs for large applications?
            //lasses are usually more suitable than structs for large applications because classes are reference types, while structs are value types.
            #endregion

            #region Question03
            //a) Which class is the parent class?
            //shipment

            //b) Which class is the child class?
            //ExpressShipment

            //c) What members are inherited by ExpressShipment?
            //TrackingCode

            //d) Why is inheritance better than duplicating the same code in multiple classes?
            //reuse code and avoid duplication
            #endregion
        }
    }
}
