using System;
using System.Collections.Generic;
using System.Text;
using carrentsystem;

class Program{
static void Main(string[] args) {



Indica i1 = new Indica("Diesel", 5, "GJ-05-CJ-6146",
VehicleInfo.TypeOfRent.Day, 1, 5, new DateOnly(2022, 01,28 ));


Indica i2 = new Indica("Petrol", 5, "MH-11-KJ-0490",
VehicleInfo.TypeOfRent.KiloMeter, 5, 8, new DateOnly(2021, 08,06 ));


Qualis q1 = new Qualis("Diesel", 7, "TN-10-OP-1923",
VehicleInfo.TypeOfRent.KiloMeter, 10, 10, new DateOnly(2019, 12,23));

MerBenEClass mb1 = new MerBenEClass("Diesel",2, "GJ-01-AA-1111",
VehicleInfo.TypeOfRent.KiloMeter, 3, 25, new DateOnly(2022, 01,15 ));

DavidHarley dh1 = new DavidHarley("Petrol",5, "MH-21-DK-7921",
VehicleInfo.TypeOfRent.Day, 4, 20, new DateOnly(2021, 03,06 ));


DavidHarley dh2 = new DavidHarley("Diesel",4, "GJ-06-WE-1234", VehicleInfo.TypeOfRent.KiloMeter, 6, 18, new DateOnly(2021, 05,26 ));
RentedVehicle<VehicleInfo> rv = new RentedVehicle<VehicleInfo>();

rv.AddVehicle(i1); rv.AddVehicle(i2); rv.AddVehicle(q1); rv.AddVehicle(mb1);
rv.AddVehicle(dh1);



rv.GiveForRent(i1, new DateOnly(2022, 02, 1), new DateOnly(2022, 02,
15), 100);
rv.GiveForRent(i2, new DateOnly(2022, 01, 8), new DateOnly(2022, 01,
10), 500);
rv.GiveForRent(dh2, new DateOnly(2022, 01, 15), new DateOnly(2022, 01,
28), 1000);


Console.Write("\nINFORMATION OF THIS INDICA CAR : \n ");
i2.getInfo();

Console.Write($"\n\n TOTAL RENT PER KILOMETER :
{rv.CalculateTotalRentToday(i2, 5):C2}");

Console.Write("\n ***********************************\n");


Console.Write("\n\n VEHICLES AVAILABLE BEFORE 15-May-2021\n");



rv.ShowAvailabilityforbookingforgivendate(new DateOnly(2021, 03, 11));


Console.Write("\n ***********************************\n");



Console.Write("\n\n VEHICLES WHICH ARE ON RENT CURRENTLY\n");


rv.GetCheckListREntedandAvailableVehicle();
}
}
