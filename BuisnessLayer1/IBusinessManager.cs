using BusinessEntity.ClassModels;
using System.Collections.Generic;

namespace BuisnessLayer1
{
    public interface IBusinessManager
    {
        bool AlumnLogIn();
        void Complete();
        List<Alumnus> GetAlumni();
        Alumnus GetAlumnus(int id);
        Person GetLogIn();
        void UppdateAlumn(Alumnus newAlumn);
        bool VerifyLogIn(string Id, string pw);
    }
}