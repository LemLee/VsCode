using System.Reflection;
using System.Security.AccessControl;
using System;
using OrmLight;
using System.Linq;

namespace OrmLight.TSql
{
    public class Db : IDB
    {
        public Db()
        {

        }

        public string Name {get;}
        public IDBSelect<T> Select<T>()
        {
            var properties = typeof(T)
            .GetProperties()
            .Select(prop => new Property(prop.Name, GetPropType(prop)));

            return default;
        }

        private PropertyType GetPropType(PropertyInfo info)
        {
            var type = info.PropertyType;
            return PropertyType.Int;
        }

        enum PropertyType{Short, Int, BigInt, Char, NChar, VarChar, NVarChar}
        private class Property
        {
            public Property(string name, PropertyType type)
            {
                Name = name;
                Type = type;
            }            
            
            public string Name{get;}
            public PropertyType Type { get; }
        }
    }
}