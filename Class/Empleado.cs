using Proyecto02.DBCLASS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto02.Class
{
    public class Empleado : MiembroComunidad
    {

        public string ordenar {  get; set; }
        
 
        public readonly LogDb estudianteDb;

        public Empleado()
        {
            this.estudianteDb = new LogDb();
        }
        public override void Guardar()
        {
            this.estudianteDb.save(new Empleado());
        }
        public override void update()
        {
            this.estudianteDb.exits(new Empleado());
        }
        public override void delete()
        {
            this.estudianteDb.Remove(new Empleado());
        }
    }

}
