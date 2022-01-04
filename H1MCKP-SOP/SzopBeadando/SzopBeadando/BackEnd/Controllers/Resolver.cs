using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzopBeadando.BackEnd.Controllers
{
    class Resolver : DefaultContractResolver
    {
        protected override JsonDictionaryContract CreateDictionaryContract(Type objectType)
        {
            var contract = base.CreateDictionaryContract(objectType);

            var keyType = contract.DictionaryKeyType;
            if (keyType.BaseType == typeof(Enum))
            {
                contract.DictionaryKeyResolver =
                         propName => ((int)Enum.Parse(keyType, propName)).ToString();
            }

            return contract;
        }

        protected override string ResolvePropertyName(string propertyName)
        {
            return propertyName.ToLower();
        }

    }
}
