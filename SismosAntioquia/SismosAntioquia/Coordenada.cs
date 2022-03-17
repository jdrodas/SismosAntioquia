using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SismosAntioquia
{
    public class Coordenada
    {
        /// <summary>
        /// Obtiene o establece el valor de la latitud
        /// </summary>
        public double Latitud { get; set; }

        /// <summary>
        /// Obtiene o establece el componente de la longitud
        /// </summary>
        public double Longitud { get; set; }

        /// <summary>
        /// Obtiene o establece el componente de Latitud en nomenclatura GMS
        /// </summary>
        internal PuntoGMS LatitudGMS { get; set; }

        /// <summary>
        /// Obtiene o establece el componente de Longitud en nomenclatura GMS
        /// </summary>
        internal PuntoGMS LongitudGMS { get; set; }

        /// <summary>
        /// Constructor de la clase que recibe componentes en formato decimal
        /// </summary>
        /// <param name="latitud">Componente latitud en formato decimal</param>
        /// <param name="longitud">Componente longitud en formato decimal</param>
        public Coordenada(double latitud, double longitud)
        {
            Latitud = latitud;
            Longitud = longitud;
            ConvierteAGMS();
        }

        /// <summary>
        /// Constructor de la clase que recibe componentes en formato GMS
        /// </summary>
        /// <param name="latitudGMS">Componente latitud en formato GMS</param>
        /// <param name="longitudGMS">Componente longitud en formato GMS</param>
        internal Coordenada(PuntoGMS latitudGMS, PuntoGMS longitudGMS)
        {
            LatitudGMS = latitudGMS;
            LongitudGMS = longitudGMS;
            ConvierteADecimal();
        }

        /// <summary>
        /// Toma los componentes de la coordenada que están en GMS y los pasa a decimal.
        /// </summary>
        public void ConvierteADecimal()
        {
            Latitud = CalculaDecimal(LatitudGMS);
            Longitud = CalculaDecimal(LongitudGMS);
        }

        /// <summary>
        /// Obtiene el valor decimal de un componente de coordenada expresado en GMS
        /// </summary>
        /// <param name="punto">Componente de coordenada en formato GMS</param>
        /// <returns></returns>
        private double CalculaDecimal(PuntoGMS punto)
        {
            if (punto == null)
                return default(double);

            //Usamos operador terciario para identificar el valor del signo
            double signo = punto.Tipo == TipoPunto.Lat
                ? punto.Orientacion == "N" ? 1 : -1
                : punto.Orientacion == "E" ? 1 : -1;

            //double signo;
            //if (punto.Tipo == TipoPunto.Lat)
            //    if (punto.Orientacion == "N")
            //        signo = 1;
            //    else
            //        signo = -1;           
            //else            
            //    if (punto.Orientacion == "E")
            //        signo = 1;
            //    else
            //        signo = -1;            


            return Math.Round(signo * (punto.Grados + punto.Minutos / 60 + punto.Segundos / 3600), 6);
        }

        /// <summary>
        /// Toma los componentes de la coordenada que están en decimal y los pasa a GMS
        /// </summary>
        public void ConvierteAGMS()
        {
            LatitudGMS = CalculaGMS(Latitud, TipoPunto.Lat);
            LongitudGMS = CalculaGMS(Longitud, TipoPunto.Lon);
        }

        /// <summary>
        /// Obtiene el valor GMS a partir de un valor decimal y un tipo de punto
        /// </summary>
        /// <param name="valor">Valor del componente</param>
        /// <param name="tipo">Tipo de Componente: Latitud o Longitud</param>
        /// <returns></returns>
        private PuntoGMS CalculaGMS(double valor, TipoPunto tipo)
        {
            //Usamos operador terciario para identificar la orientación de la coordenada
            //Segun el tipo de punto
            string orientacion = tipo == TipoPunto.Lat
                ? valor < 0 ? "S" : "N"
                : valor < 0 ? "W" : "E";

            valor = Math.Abs(valor);
            double grados = Math.Truncate(valor);
            double minutos = Math.Truncate((valor - grados) * 60);
            double segundos = ((valor - grados) * 60 - minutos) * 60;

            PuntoGMS resultado = new PuntoGMS
            {
                Grados = grados,
                Minutos = minutos,
                Segundos = segundos,
                Orientacion = orientacion
            };

            return resultado;
        }
    }

    /// <summary>
    /// Define un Componente de Coordenada en Formato Grados-Minutos-Segundos-Orientacion
    /// </summary>
    internal class PuntoGMS
    {
        public double Grados { get; set; }
        public double Minutos { get; set; }
        public double Segundos { get; set; }
        public string Orientacion { get; set; }
        internal TipoPunto Tipo { get; set; }

        /// <summary>
        /// Obtiene la cadena de caracteres que representa un punto en GMS
        /// </summary>
        /// <returns>Una cadena de caracteres con información detallada</returns>
        public override string ToString()
        {
            return string.Format(
                $"{Grados} " +
                $"{Minutos} " +
                $"{Math.Round(Segundos, 2)} " +
                $"{Orientacion}");
        }
    }

    /// <summary>
    /// Especifica el tipo de punto para la coordenada (Latitud o Longitud)
    /// </summary>
    internal enum TipoPunto
    {
        Lat,
        Lon
    }
}
