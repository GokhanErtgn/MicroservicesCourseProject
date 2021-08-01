using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseServices.Catalog.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string CourseCollectionName { get; set; }
        public string CategoryCollectionName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DatabaseName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
