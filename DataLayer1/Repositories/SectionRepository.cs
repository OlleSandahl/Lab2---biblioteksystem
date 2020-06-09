﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity.ClassModels;

namespace DataLayer1.Repositories
{
    public class SectionRepository : GenericRepository<Section>
    {
        public Section GetSection(int SectionId)
        {
            using (var db = new LibarysystemDBcontext())
            {
                return db.Sections.Where(x => x.SectionId == SectionId).FirstOrDefault();
            }
        }
        public SectionRepository(LibarysystemDBcontext libarysystemDBcontext) : base(libarysystemDBcontext)
        {

        }
    }




    //    public SectionRepository(LibarysystemDBcontext context) : base(context)
    //    {

    //    }
    //    public void CreateSection(Section section)
    //    {
    //        using (var db = new LibarysystemDBcontext())
    //        {
    //            db.Sections.Add(section);
    //            db.SaveChanges();
    //        }
    //    }

    //    public Section GetSection(int sectionId)
    //    {
    //        using (var db = new LibarysystemDBcontext())
    //        {
    //            return db.Sections.OfType<Section>().Where(x => x.SectionId == sectionId).FirstOrDefault();
    //        }
    //    }

    //    public List<Section> GetSections()
    //    {
    //        using (var db = new LibarysystemDBcontext())
    //        {
    //            return db.Sections.ToList();
    //        }
    //    }

    //    public LibarysystemDBcontext LibarysystemDBcontext
    //    {
    //        get { return Context as LibarysystemDBcontext; }
    //    }
    //}
}
