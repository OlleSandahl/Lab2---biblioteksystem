using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity.ClassModels;

namespace DataLayer1.Repositories
{
    public class ProgramRepository : GenericRepository<Program>
    {
        public List<Program> GetPrograms()
        {
            using (var db = new LibarysystemDBcontext())
            {
                return db.Programs.ToList();
            }
        }
        public ProgramRepository(LibarysystemDBcontext libarysystemDBcontext) : base(libarysystemDBcontext)
        {

        }
    }




    //    public ProgramRepository(LibarysystemDBcontext context) : base(context)
    //    {

    //    }
    //    public void CreateProgram(Program program)
    //    {
    //        using (var db = new LibarysystemDBcontext())
    //        {
    //            db.Programs.Add(program);
    //            db.SaveChanges();
    //        }
    //    }

    //    public List<Program> GetProgram()
    //    {
    //        using (var db = new LibarysystemDBcontext())
    //        {
    //            return db.Programs.ToList();
    //        }
    //    }

    //    public LibarysystemDBcontext LibarysystemDBcontext
    //    {
    //        get { return Context as LibarysystemDBcontext; }
    //    }
    //}
}
