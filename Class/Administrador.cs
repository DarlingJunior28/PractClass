using Proyecto02.DBCLASS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto02.Class
{
    public class Administrador : Docente
    {
        public readonly LogDb estudianteDb;
        public Administrador()
        {
            this.estudianteDb = new LogDb();
        }
        public override void Guardar()
        {
            this.estudianteDb.save(new Administrador() { });
        }
        public override void update()
        {
            this.estudianteDb.exits(new Administrador() { });
        }
        public override void delete()
        {
            this.estudianteDb.Remove(new Administrador() { });
        }
    }
}
