using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario : Persona
    {
        private string password;
        public Rol Rol;

       

	    public string Password
	    {
		    get { return password;}
		    set { password = value;}
	    }

    }
}
