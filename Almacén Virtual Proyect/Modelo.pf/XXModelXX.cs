using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.pf
{
    public class XXModelXX
    {

        List <Modeler> Productoss = new List<Modeler>();

        
    

         //...#
        //...Add
        public void Agregar(Modeler produ) 
        { 
          Productoss.Add(produ);    
        }

        //....
       //...Delete
        public void Eliminar(int p) 
        {
            if (p != -1)
            {
                Productoss.RemoveAt(p);
            }
        }

        public IEnumerable<Modeler> Lin(double parametro) {

            IEnumerable<Modeler> L = from P in Productoss where P.precio < parametro select P;
            return L;

        }
        public IEnumerable<Modeler> Lin1(double parametro)
        {

            IEnumerable<Modeler> L = from P in Productoss where P.precio > parametro select P;
            return L;

        }
    }

}
