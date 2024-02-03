using Proyecto02.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto02.DBCLASS
{
    public class LogDb : Interface1

    {
       private readonly List<MiembroComunidad> miembroComunidadList;
        public LogDb() { 
            this.miembroComunidadList = new List<MiembroComunidad>();
        
        }
        public void Remove(MiembroComunidad miembro)
        {
            this.miembroComunidadList.Remove(miembro);
        }

        public bool exits(MiembroComunidad miembro)
        {
            return this.miembroComunidadList.Exists(cd => cd.Nombre == miembro.Nombre);
        }

        public void save(MiembroComunidad miembro)
        {
            this.miembroComunidadList.Add(miembro);
        }
    }
}
