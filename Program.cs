using System;

namespace cSharp6
{

    public interface Building
    {
        public string Construction();
    }
    public class Apartment : Building
    {
        public string Construction()
        {
            return "here is your apartment. ";
        }
    }
    public class House : Building
    {
        public string Construction()
        {
            return "here is your house. ";
        }
    }

    abstract class BuildingConstruction
    {
        public abstract Building FactoryOfBuilding();

        public string ConstructionResul()
        {
            var building = FactoryOfBuilding();
            var result = building.Construction();
            return result;
        }
    }
    class ApartmentBuilding : BuildingConstruction
    {
        public override Building FactoryOfBuilding()
        {
            return new Apartment();
        }
    }
    class HouseBuilding : BuildingConstruction
    {
        public override Building FactoryOfBuilding()
        {
            return new House();
        }
    }


    class Customer
    {
        public void Main()
        {
            CustomersPick(new HouseBuilding());
        }
        public void CustomersPick(BuildingConstruction pick)
        {
            Console.WriteLine(pick.ConstructionResul());
        }
    }
    class Program 
    {
        public static void Main(string[] args)
        {
            new Customer().Main();
        }
    }


}