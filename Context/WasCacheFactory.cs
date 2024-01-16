using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace WasWebServerNew.Context
{
    public class WasCacheFactory : IModelCacheKeyFactory
    {
        public object Create(DbContext context)
        {
            return new WasModelCache(context);
        }
    }
    public class WasModelCache : ModelCacheKey
    {
        private string _suffix;

        private string _connString;
        public WasModelCache(DbContext context) : base(context)
        {
            //_suffix = (context as JDWWheelContext)?._suffix;
            _connString = (context as JDWWheelContext)?._connString;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj) && (obj as WasModelCache)?._connString == _connString;
        }

        public override int GetHashCode()
        {
            var hashCode = base.GetHashCode() * 397;

            hashCode ^= _connString.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();

        }
    }
    }