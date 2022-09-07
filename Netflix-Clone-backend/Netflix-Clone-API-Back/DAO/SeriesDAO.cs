using Microsoft.Data.SqlClient;
using Netflix_Clone_API_Back.Tools;
using Netflix_Clone_API_Back.Classes;
using System.IO;

namespace Netflix_Clone_API_Back.DAO
{
    public class SeriesDAO : BaseDAO<Series>
    {
        public override int Create(Series element)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Series element)
        {
            throw new NotImplementedException();
        }

        public override (bool, Series) Find(int index)
        {
            throw new NotImplementedException();
        }

        public override List<Series> Find(Func<Series, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public override List<Series> FindAll()
        {
            throw new NotImplementedException();
        }

        public override bool Update(Series element)
        {
            throw new NotImplementedException();
        }
    }
}
