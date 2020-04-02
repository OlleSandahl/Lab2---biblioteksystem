using BusinessEntity.ClassModels;
using System.Collections.Generic;

namespace DataLayer1.Repositories
{
    public interface IProgramRepository
    {
        LibarysystemDBcontext LibarysystemDBcontext { get; }

        void CreateProgram(Program program);
        List<Program> GetProgram();
    }
}