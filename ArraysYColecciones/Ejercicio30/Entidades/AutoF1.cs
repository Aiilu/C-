using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            SetCantidadCombustible(0);
            SetEnCompetencia(false);
            SetVueltasRestantes(0);
        }

        public static bool operator ==(AutoF1 f1, AutoF1 f2)
        {
            return (f1.numero == f2.numero) && (f1.escuderia == f2.escuderia);
        }

        public static bool operator !=(AutoF1 f1, AutoF1 f2)
        {
            return !(f1 == f2);
        }

        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }

        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }

        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }

        public void SetCantidadCombustible(short combustible)
        {
            this.cantidadCombustible = combustible;
        }

        public void SetEnCompetencia(bool competencia)
        {
            this.enCompetencia = competencia;
        }

        public void SetVueltasRestantes(short vueltas)
        {
            this.vueltasRestantes = vueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"Cantidad Combustible: {GetCantidadCombustible()}");
            datos.AppendLine($"En Competencia: {GetEnCompetencia()}");
            datos.AppendLine($"Escuderia: {this.escuderia}");
            datos.AppendLine($"Numero: {this.numero}");
            datos.AppendLine($"Vueltas Restantes: {GetVueltasRestantes()}");

            return datos.ToString();
        }

    }
}
