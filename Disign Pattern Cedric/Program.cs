﻿using Patterns.Iterator;
using Patterns.Adapter;
using Patterns.Singleton;
using Patterns.AbstractFactory;
using Patterns.Decorator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("test singleton");
        SingletonLiasse.getInstance().Add("doc1");
        SingletonLiasse.getInstance().Remove("doc1");
        
        Console.WriteLine("test adapteur");
        IDocument html = new HTMLDocument();
        IDocument pdf = new PDFDocument(new ComponentPDF());
        ShowAndPrintIDocument(html, "test adapteur");
        ShowAndPrintIDocument(pdf, "test adapteur");

        Console.WriteLine("test iterateur");
        VehicleCatalogue catalogue = new VehicleCatalogue();
        VehicleIterator iterator = catalogue.Search();
        catalogue.setVehicleList(getVehicleList());
        while (!iterator.End())
        {
            Console.WriteLine(iterator.Item().GetInfo());
            iterator.Next();
        }

        Console.WriteLine("test Abstract Factory");
        Car electricCar = new Catalogue().CreateElectricVehicleFactory().CreateCar("tuture");
        Scooter fuelScooter = new Catalogue().CreateFuelVehicleFactory().CreateScooter("scooty");
        Console.WriteLine("test de la voiture electrique (on remet du carburant et on part !)");
        electricCar.FillUp();
        electricCar.Drive();
        Console.WriteLine("test du scooter à essence (on remet du carburant et on part !)");
        fuelScooter.FillUp();
        fuelScooter.Drive();

        Console.WriteLine("test Decorator");
        IVehicleGraphicComponent vehicleView = new ModelDecorator(new BrandDecorator(new VehicleView(), "Peugot"), "208");
        vehicleView.Show();

        Console.WriteLine("test Observer");
        Patterns.Observer.Vehicle vehicle = new Patterns.Observer.Vehicle();
        Patterns.Observer.VehiclePriceView vehiclePriceView = new Patterns.Observer.VehiclePriceView(vehicle);
        Console.WriteLine("changement du prix à 2000€");
        vehicle.setPrice(2000);
        Console.WriteLine("ajout de l'observateur");
        vehicle.AddObserver(vehiclePriceView);
        Console.WriteLine("changement du prix à 1500€");
        vehicle.setPrice(1500);
        Console.WriteLine("changement de la description");
        vehicle.setDescription("Voiture pas terrible");







    }
    
    static private void ShowAndPrintIDocument(IDocument document,string text)
    {
        document.SetContent(text);
        Console.WriteLine("Ecriture de : " + document.Draw());
        Console.WriteLine("Impression en cours : ");
        document.Print();
    }
    
    static private List<Vehicle> getVehicleList()
    {
        return new List<Vehicle>()
        {
           new Vehicle("tesla model X"),
           new Vehicle("Peugot 208"),
           new Vehicle("Citroen C3"),
           new Vehicle("Volkswagen Polo")
        };
    }
}
