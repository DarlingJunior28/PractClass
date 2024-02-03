using Proyecto02.DBCLASS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto02.Class
{
    public class Estudiante : MiembroComunidad
    {
        public readonly LogDb estudiante;
        public Estudiante()
        {
            this.estudiante = new LogDb();
        }
        public override void Guardar()
        {
           this.estudiante.save(new Estudiante());

        }

        public override void update()
        {
            this.estudiante.exits(new Estudiante());

        }

        public override void delete()
        {
            this.estudiante.Remove(new Estudiante());

        }


    }
}
