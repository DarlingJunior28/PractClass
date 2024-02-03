using Proyecto02.DBCLASS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto02.Class
{
    public class Docente : Empleado
    {
        public readonly LogDb estudianteDb;

        public Docente()
        {
            this.estudianteDb = new LogDb();
        }

        public override void Guardar()
        {
            this.estudianteDb.save(new Docente() { });
        }

        public override void update()
        {
            this.estudianteDb.exits(new Docente() { });
        }

        public override void delete()
        {
            this.estudianteDb.Remove(new Docente() { });
        }
    }
}
