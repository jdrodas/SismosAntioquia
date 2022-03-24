using System;

namespace SismosAntioquia
{
    public class Sismo
    {
        public int Id { get; set; }
        public int Id_Region { get; set; }
        public string Nombre_Region { get; set; }
        public double Magnitud { get; set; }
        public double Profundidad { get; set; }

        //Las propiedades de Latitud y Longitud son utilizadas
        //al momento de insertar/actualizar información de un sismo
        public double Latitud { get { return Coordenada.Latitud; } }
        public double Longitud { get { return Coordenada.Longitud; } }
        public Coordenada Coordenada { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }

        /// <summary>
        /// Constructor de la clase usando parámetros
        /// </summary>
        /// <param name="region"></param>
        /// <param name="fecha"></param>
        /// <param name="hora"></param>
        /// <param name="magnitud"></param>
        /// <param name="profundidad"></param>
        /// <param name="coordenada"></param>
        public Sismo(int region, string fecha, string hora, double magnitud, double profundidad, Coordenada coordenada)
        {
            Id = 0;
            Id_Region = region;
            Fecha = fecha;
            Hora = hora;
            Magnitud = magnitud;
            Profundidad = profundidad;
            Coordenada = coordenada;
        }
        /// <summary>
        /// Constructor predeterminado de la clase
        /// </summary>
        public Sismo()
        {
            Id = default(int);
            Id_Region = default(int);
            Nombre_Region = "";
            Fecha = "";
            Hora = "";
            Magnitud = default(double);
            Profundidad = default(double);
            Coordenada = new Coordenada();
        }
        /// <summary>
        /// Obtiene la cadena de caracteres que describe el sismo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(
                $"Id: {Id} " + Environment.NewLine +
                $"Id Región: {Id_Region} " + Environment.NewLine +
                $"Nombre Región: {Nombre_Region} " + Environment.NewLine +
                $"Fecha: {Fecha} " + Environment.NewLine +
                $"Hora: {Hora} " + Environment.NewLine +
                $"Magnitud: {Magnitud.ToString()} " + Environment.NewLine +
                $"Profundidad: {Profundidad.ToString()} " + Environment.NewLine +
                $"Latitud: {Coordenada.LatitudGMS.ToString()} " + Environment.NewLine +
                $"Longitud: {Coordenada.LongitudGMS.ToString()} "
                );
        }
    }
}
