using BusinessEntity.ClassModels;
using System.Collections.Generic;

namespace DataLayer1.Repositories
{
    interface ISectionRepository
    {
        LibarysystemDBcontext LibarysystemDBcontext { get; }

        void CreateSection(Section section);
        Section GetSection(int sectionId);
        List<Section> GetSections();
    }
}