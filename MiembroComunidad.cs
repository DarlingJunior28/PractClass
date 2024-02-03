using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto02
{
    // Las clases bases normalmente se declaran como abstract
    public abstract class MiembroComunidad
    {
        public string Nombre {  get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }

        public abstract void Guardar();

        public virtual void update()
        {
            //logica//
            //logica//
        }
        public virtual void delete() 
        { 
        
        }
        
    }
}
