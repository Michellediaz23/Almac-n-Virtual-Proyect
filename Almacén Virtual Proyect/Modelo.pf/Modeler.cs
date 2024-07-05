using System.Collections;

namespace Modelo.pf
{
    public class Modeler
    {
        ArrayList Productoss = new ArrayList();
        //...
        //.-.Txt primera pagina..
        public string Producto { get; set; }
        public string Existencia { get; set; }
        public string IDProducto { get; set; }
        public int precio { get; set; }
        public string Marca { get; set; }



        public Modeler(string producto, string Existencia, string IDproducto, int precio, string Marca) 
        {
            this.Producto = producto;
            this.Existencia = Existencia;
            this.IDProducto = IDproducto;
            this.precio = precio;
            this.Marca = Marca;
              
        }





       
        public Modeler()
        { }



       

        


        
       
    }
}