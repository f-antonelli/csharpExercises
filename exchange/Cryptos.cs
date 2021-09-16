using System;
using System.Collections.Generic;
using System.Text;

namespace exchange
{
	class Crypto
	{
		private String _ticker;
		private int _anio;
		private double _precio;

		public Crypto(string ticker, int anio, double precio)
		{
			this.Ticker = ticker;
			this.Anio = anio;
			this.Precio = precio;
		}
	
		public double Precio { get => _precio; set => _precio = value; }
		public int Anio { get => _anio; set => _anio = value; }
		public string Ticker { get => _ticker; set => _ticker = value; }

		public override string ToString()
		{
			return "Ticker: " + Ticker + ", Anio de creacion: " + Anio + " Precio actual: " + Precio;
		}

	}
}