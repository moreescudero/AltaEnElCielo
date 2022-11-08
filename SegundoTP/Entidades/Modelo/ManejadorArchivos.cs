using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelo
{
    public static class ManejadorArchivos
    {
        static string? ruta;

        static ManejadorArchivos()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //consigue la ruta desde cualquier pc
            ruta += @"/Archivos"; //la carpeta
        }

        /// <summary>
        /// escribe un archivo
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="archivo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool EscribirArchivo(string? mensaje, string? archivo, string? nombre)
        {
            string? completa = archivo + @"/" + nombre + ".txt";
            try
            {
                using(StreamWriter sw = new StreamWriter(completa))
                {
                    sw.WriteLine(mensaje);
                }
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Error en el archivo " + completa);
            }
            return false;
        }

        /// <summary>
        /// busca un archivo
        /// </summary>
        /// <param name="archivo"></param>
        /// <returns></returns>
        private static string BuscarArchivo(string? archivo)
        {
            string[] archivos = Directory.GetFiles(ruta); 

            foreach (string item in archivos)
            {
                if(item.Contains(archivo))
                {
                    return item;
                }
            }
            return null;
        }

        /// <summary>
        /// lee un archivo específico en caso de que este exista
        /// </summary>
        /// <param name="archivo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static string? LeerArchivo(string? archivo)
        {
            string? datos = "";

            if (Directory.Exists(ruta))
            {
                string? completa = BuscarArchivo(archivo);
                if(completa is not null)
                {
                    using (StreamReader sr = new StreamReader(completa))
                    {
                        string linea = sr.ReadToEnd();
                        datos += linea;
                    }
                }
                else
                {
                    throw new Exception("No se encontro el archivo");
                }
            }
               
            return datos;
        }
    }
}
