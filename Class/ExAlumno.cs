using Proyecto02.DBCLASS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto02.Class
{
    public class ExAlumno : MiembroComunidad
    {
        public readonly  LogDb estudianteDb;
         public ExAlumno()
        {
            this.estudianteDb = new LogDb();
        }
        public override void Guardar()
        {
            this.estudianteDb.save(new ExAlumno() { });
        }
        public override void update()
        {
            this.estudianteDb.exits(new ExAlumno() { });
        }
        public override void delete()
        {
            this.estudianteDb.Remove(new ExAlumno() { });
        }
    }
}
