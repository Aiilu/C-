using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.CantidadCombustible = 0;
            this.EnCompetencia = false;
            this.VueltasRestantes = 0;
        }

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }

        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return (v1.Numero == v2.Numero) && (v1.Escuderia == v2.Escuderia);
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($" Cantidad Combustible: {this.CantidadCombustible}");
            datos.AppendLine($" En Competencia: {this.EnCompetencia}");
            datos.AppendLine($" Escuderia: {this.Escuderia}");
            datos.AppendLine($" Numero: {this.Numero}");
            datos.AppendLine($" Vueltas Restantes: {this.VueltasRestantes}");

            return datos.ToString();
        }
    }
}
