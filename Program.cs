using FactoryPattern;

var newVehicle = VehicleFactory.GetVehicle("2");

newVehicle.Drive();