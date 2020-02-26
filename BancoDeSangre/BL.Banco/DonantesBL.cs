using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Banco
{
    public class DonantesBL
    {
        public BindingList<Donantes> ListaDonantes { get; set; }

        public DonantesBL()
        {
            ListaDonantes = new BindingList<Donantes>();

            var donante1 = new Donantes();
            donante1.Id = 1;
            donante1.Identidad = "0501-1995-10498";
            donante1.Nombre = "Jose";
            donante1.Fecha = "14/02/2020";
            donante1.Telefono = "3353-6009";
            donante1.Direccion = "33 Calle 27 Ave";
             
            ListaDonantes.Add(donante1);

            var donante2 = new Donantes();
            donante2.Id = 2;
            donante2.Identidad = "0501-1986-25633";
            donante2.Nombre = "Carlos";
            donante2.Fecha = "14/02/2020";
            donante2.Telefono = "2552-0000";
            donante2.Direccion = "33 Calle 27 Ave";

            ListaDonantes.Add(donante2);

            var donante3 = new Donantes();
            donante3.Id = 3;
            donante3.Identidad = "0501-1963-05966";
            donante3.Nombre = "Roberto";
            donante3.Fecha = "14/02/2020";
            donante3.Telefono = "3259-7941";
            donante3.Direccion = "33 Calle 27 Ave";

            ListaDonantes.Add(donante3);
        }

        public BindingList<Donantes> ObtenerDonantes()
        {
            return ListaDonantes;
        }

    }

    public class Donantes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Identidad { get; set; }
        public string Fecha { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
