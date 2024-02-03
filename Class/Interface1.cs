using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto02.Class
{
    public interface Interface1
    {
        void save(MiembroComunidad miembro);

        void Remove(MiembroComunidad miembro);

        bool exits(MiembroComunidad miembro);
    }
}
