using System;
using System.Collections.Generic;
using System.Text;

namespace avisosVarios
{
	class AvisosTrafico : IAvisos
	{
		private string remitente;
		private string mensaje;
		private string fecha;

		public AvisosTrafico()
		{
			remitente = "La Policia";
			mensaje = "Sancion cometida.. si abona antes recibira un descuento..";
			fecha = "de HOY";
		}
		public AvisosTrafico(string remitente, string mensaje, string fecha) 
		{
			this.remitente = remitente;
			this.mensaje = mensaje;
			this.fecha = fecha;
		}

		public string GetFecha() => fecha;
		public void MostrarAviso() => Console.WriteLine("Mensaje: {0} enviado por: {1} el dia {2}", mensaje, remitente, fecha);
	}
}
