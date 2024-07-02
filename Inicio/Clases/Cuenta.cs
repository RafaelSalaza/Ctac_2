using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class Cuenta
    {
        private int id_cuenta;
        private string numero_cuenta;
        private string banco;
        private int id_categortia_cuenta;

        public int Id_cuenta { get => id_cuenta; set => id_cuenta = value; }
        public string Numero_cuenta { get => numero_cuenta; set => numero_cuenta = value; }
        public string Banco { get => banco; set => banco = value; }
        public int Id_categortia_cuenta { get => id_categortia_cuenta; set => id_categortia_cuenta = value; }
    }
}
