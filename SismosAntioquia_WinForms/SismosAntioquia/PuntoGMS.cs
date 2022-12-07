using System;

namespace SismosAntioquia
{
    /// <summary>
    /// Define un Componente de Coordenada en Formato Grados-Minutos-Segundos-Orientacion
    /// </summary>
    public class PuntoGMS
    {
        private double segundos;

        /// <summary>
        /// Obtiene o Establece el valor de los grados de la coordenada
        /// </summary>
        public double Grados { get; set; }
        /// <summary>
        /// Obtiene o Establece el valor de los minutos de la coordenada
        /// </summary>
        public double Minutos { get; set; }
        /// <summary>
        /// Obtiene o Establece el valor de los segundos de la coordenada
        /// </summary>
        public double Segundos
        {
            get { return Math.Round(segundos, 2); }
            set { segundos = value; }
        }
        /// <summary>
        /// Obtiene o Establece el valor de la orientación de la coordenada
        /// </summary>
        public string Orientacion { get; set; }
        /// <summary>
        /// Obtiene o Establece el tipo de coordenada LAT = Latitud, LON = Longitud
        /// </summary>
        public string Tipo { get; set; }
        /// <summary>
        /// Constructor predeterminado
        /// </summary>
        public PuntoGMS()
        {
            Grados = 0;
            Minutos = 0;
            Segundos = 0;
            Orientacion = "N";
            Tipo = "LAT";
        }
        /// <summary>
        /// Obtiene la cadena de caracteres que representa un punto en GMS
        /// </summary>
        /// <returns>Una cadena de caracteres con información detallada</returns>
        public override string ToString()
        {
            return string.Format(
                $"{Grados} " +
                $"{Minutos} " +
                $"{Segundos} " +
                $"{Orientacion}");
        }
    }
}
