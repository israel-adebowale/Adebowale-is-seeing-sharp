using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WiredBrainCoffee.StorageApp.Entities
{
    public static class EntityExtensions
    {
        public static T? Copy<T>(this T itemsToCopy)
        {
            var json = JsonSerializer.Serialize(itemsToCopy);
            return JsonSerializer.Deserialize<T>(json);
        }
        
    }
}
