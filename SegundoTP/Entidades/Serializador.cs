using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Serializador<T>
    {
        static string ruta;

        static Serializador ()
        {
            ruta = @"./Archivos-Serializador";
        }

        public static void EscribirJSon(T dato, string archivo)
        {
            string completa = ruta + @"/" + archivo;

            if(!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);    
            }
            JsonSerializerOptions opcion = new JsonSerializerOptions()
            {
                Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },
            };
            string objetoJSon = JsonSerializer.Serialize(dato, opcion);

            File.WriteAllText(completa, objetoJSon);
        }

        public static T LeerJSon (string archivo)
        {
            T datos = default;

            string completo = ruta + @"/" + archivo;

            if(!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

            JsonSerializerOptions opcion = new JsonSerializerOptions()
            {
                Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },
            };

            string archivoJSon = File.ReadAllText(completo);
            datos = JsonSerializer.Deserialize<T>(archivoJSon, opcion);

            return datos;
        }
    }
}
