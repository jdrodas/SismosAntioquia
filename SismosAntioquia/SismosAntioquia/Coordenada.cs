using System;

namespace SismosAntioquia
{
    public class Coordenada
    {
        // Atributos para el manejo de los componentes en notación real
        private double longitud, latitud;

        public double Latitud
        {
            get { return latitud; }
            set
            {
                latitud = value;
                LatitudGMS = CalculaGMS(latitud, "LAT");
            }
        }
        public double Longitud
        {
            get { return longitud; }
            set
            {
                longitud = value;
                LongitudGMS = CalculaGMS(longitud, "LON");
            }
        }
        public PuntoGMS LatitudGMS { get; set; }
        public PuntoGMS LongitudGMS { get; set; }

        /// <summary>
        /// Constructor Predeterminado
        /// </summary>
        public Coordenada()
        {
            latitud = default(double);
            longitud = default(double);
            ConvierteAGMS();
        }

        /// <summary>
        /// Constructor de la clase que recibe componentes en formato decimal
        /// </summary>
        /// <param name="latitud">Componente latitud en formato decimal</param>
        /// <param name="longitud">Componente longitud en formato decimal</param>
        public Coordenada(double latitud, double longitud)
        {
            this.latitud = latitud;
            this.longitud = longitud;
            ConvierteAGMS();
        }

        /// <summary>
        /// Constructor de la clase que recibe componentes en formato GMS
        /// </summary>
        /// <param name="latitudGMS">Componente latitud en formato GMS</param>
        /// <param name="longitudGMS">Componente longitud en formato GMS</param>
        public Coordenada(PuntoGMS latitudGMS, PuntoGMS longitudGMS)
        {
            LatitudGMS = latitudGMS;
            LongitudGMS = longitudGMS;
            ConvierteADecimal();
        }

        /// <summary>
        /// Toma los componentes de la coordenada que están en GMS y los pasa a decimal.
        /// </summary>
        private void ConvierteADecimal()
        {
            Latitud = CalculaDecimal(LatitudGMS);
            Longitud = CalculaDecimal(LongitudGMS);
        }

        /// <summary>
        /// Obtiene el valor decimal de un componente de coordenada expresado en GMS
        /// </summary>
        /// <param name="punto">Componente de coordenada en formato GMS</param>
        /// <returns>El valor decimal correspondiente equivalente</returns>
        private double CalculaDecimal(PuntoGMS punto)
        {
            if (punto == null)
                return default(double);

            //Usamos operador terciario para identificar el valor del signo
            double signo = punto.Tipo == "LAT"
                ? punto.Orientacion == "N" ? 1 : -1
                : punto.Orientacion == "E" ? 1 : -1;

            return Math.Round(signo * (punto.Grados + punto.Minutos / 60 + punto.Segundos / 3600), 6);
        }

        /// <summary>
        /// Toma los componentes de la coordenada que están en decimal y los pasa a GMS
        /// </summary>
        private void ConvierteAGMS()
        {
            LatitudGMS = CalculaGMS(Latitud, "LAT");
            LongitudGMS = CalculaGMS(Longitud, "LON");
        }

        /// <summary>
        /// Obtiene el valor GMS a partir de un valor decimal y un tipo de punto
        /// </summary>
        /// <param name="valor">Valor del componente</param>
        /// <param name="tipoPunto">Tipo de Componente: Latitud o Longitud</param>
        /// <returns>El valor en formato GMS equivalente</returns>
        private PuntoGMS CalculaGMS(double valor, string tipoPunto)
        {
            //Usamos operador terciario para identificar la orientación de la coordenada
            //Segun el tipo de punto
            string orientacion = tipoPunto == "LAT"
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
                Orientacion = orientacion,
                Tipo = tipoPunto
            };

            return resultado;
        }
    }
}
