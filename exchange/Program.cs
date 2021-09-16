using System;
//Aplicando concepto de clases,modularizacion y funciones
namespace exchange
{
	class Program
	{
		static void Main(string[] args)
		{
			Exchange binance = new Exchange(10);

			Crypto c1 = new Crypto("SOL", 2012, 220.50);
			Crypto c2 = new Crypto("TRX", 2011, 0.12354);
			Crypto c3 = new Crypto("BTC", 2007, 56000);
			Crypto c4 = new Crypto("ETH", 2009, 3500);
			Crypto c5 = new Crypto("DEC", 2021, 0.3);
			Crypto c6 = new Crypto("BNB", 2006, 700);
			Crypto c7 = new Crypto("AXS", 2020, 158.235);

			//Añadiendo cryptos
			binance.AniadirCrypto(c1);
			binance.AniadirCrypto(c2);
			binance.AniadirCrypto(c3);
			binance.AniadirCrypto(c4);
			binance.AniadirCrypto(c5);

			Console.WriteLine("***Cryptos listadas en Binance***");
			binance.MostrarCrypto();

			//Prueba eliminar
			binance.EliminarCrypto(c3);
			binance.EliminarCrypto(c1);	

			Console.WriteLine("\n**Se eliminaron algunas cryptos, nuevo listado**");
			binance.MostrarCrypto();			

			//Prueba agregar
			binance.AniadirCrypto(c6);
			binance.AniadirCrypto(c7);
			Console.WriteLine("\n**Se añadio una nueva crypto**");
			binance.MostrarCrypto();
		}
	}
}
