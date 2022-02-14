using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Rol
    {
        private int id;
        private string nombre;
        private string descripcion;

        public Rol()
        {
        
        }

        public Rol(int id, string nombre, string descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        //Atributos
        public int Id   
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre   
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        //Métodos
    }
}
