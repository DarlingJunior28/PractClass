using Proyecto02.DBCLASS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto02.Class
{
    public class Administrativo : Empleado
    {
        public readonly LogDb estudianteDb;

        public Administrativo()
        {
            this.estudianteDb = new LogDb();
        }

        public override void Guardar()
        {
            this.estudianteDb.save(new Administrativo() { });
        }

        public override void update()
        {
            this.estudianteDb.exits(new Administrativo() { });
        }

        public override void delete()
        {
            this.estudianteDb.Remove(new Administrativo() { });
        }
    }
}
