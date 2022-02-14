﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Caso
    {
        private int id;
        public Cliente Cliente;
        public Vehiculo Vehiculo;
        private string diagnostico;
        private string estado;

        public Caso() 
        { 
        
        }

        public Caso(int id, string diagnostico, string estado) 
        {
            this.id = id;
            this.diagnostico = diagnostico;
            this.estado = estado;
        }

        //Atributos

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        //Métodos
    }
}
