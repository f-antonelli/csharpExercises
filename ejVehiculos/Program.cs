using System;
//Aplicando concepto de clases y herencia - uso de virtual y override
namespace ejVehiculos
{
	class Program
	{
		static void Main(string[] args)
		{
			var coche1 = new Coche("Lamborghini");
			var avion1 = new Avion("Boeing 777");

			Console.WriteLine("***Coche***");
			coche1.GetName();
			coche1.ArrancarMotor();
			coche1.Conducir();
			coche1.PararMotor();

			Console.WriteLine("\n***Avion***");
			avion1.GetName();
			avion1.ArrancarMotor();
			avion1.Conducir();
			avion1.PararMotor();
		}
	}
}
