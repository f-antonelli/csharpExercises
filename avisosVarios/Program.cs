using System;
//Interfaces - objetos con parametros y sin parametros
namespace avisosVarios
{
	class Program
	{
		static void Main(string[] args)
		{
			//Aviso sin parametros
			Console.WriteLine("***PRIMER AVISO***");
			AvisosTrafico aviso1 = new AvisosTrafico();

			aviso1.MostrarAviso();

			//Aviso con parametros
			Console.WriteLine("\n***SEGUNDO AVISO***");
			AvisosTrafico aviso2 = new AvisosTrafico("Prefectura", "Vas preso", "31/03/1999");
 
			aviso2.MostrarAviso();
		}
	}
}
