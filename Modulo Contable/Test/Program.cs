using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Xml;
using System.IO;
using AccesoDatos;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {


        /// <summary>
        /// Replaces text in a file.
        /// </summary>
        /// <param name="filePath">Path of the text file.</param>
        /// <param name="searchText">Text to search for.</param>
        /// <param name="replaceText">Text to replace the search text.</param>
        static public void ReplaceInFile( string filePath, string filePathDestiny, string searchText, string replaceText )
        {
            StreamReader reader = new StreamReader( filePath );
            string content = reader.ReadToEnd();
            reader.Close();

            content = Regex.Replace( content, searchText, replaceText );

            StreamWriter writer = new StreamWriter( filePathDestiny );
            writer.Write( content );
            writer.Close();
        }

        static void Main(string[] args)
        {
            ReplaceInFile("C:\\Users\\Javier\\Desktop\\hola.txt", "C:\\Users\\Javier\\Desktop\\hola3.txt", "las personas","el mundo");
            ///////////////////////////
            //Se prueba objeto entity
            ///////////////////////////

            //Método Set (no case sensitive)
            Entity e = new Entity();
            e.Set("Nombre", "Javier");
            e.Set("Nombre", "Alonso");
            e.Set("Apellido", "Alvarez");
            e.Set("edad", 20);
            e.Set("fecha_nacimiento", new DateTime(1992,2,2));

            //Método Get (no case sensitive)
            Console.WriteLine("Información de Javier:");
            Console.WriteLine("Nombre: " + (string)e.Get("Nombre"));
            Console.WriteLine("Apellido: " + (string)e.Get("apellido"));
            Console.WriteLine("Edad: " + (int)e.Get("edad"));
            Console.WriteLine("Fecha de Nacimiento: " + (DateTime)e.Get("fecha_nacimiento"));

            ///////////////////////////
            ///////////////////////////

            ManejadorBaseDatos.Instancia.EjecutarScript("AYA");
            ///////////////////////////
            //Se prueba DA
            ///////////////////////////

            // Prueba Carga XML con DA
            Entities sp = new XMLLoader().loadXML("C://Users//Javier//.netbeans//7.1.2//config//GF3//domain1//tmsite//da//da.xml");
            
            // Prueba Ejecutar SP con objeto entity
            Entity parametros = new Entity();
            parametros.Set("pID", 1);
            parametros.Set("pCarro","Toyota");
            parametros.Set("pNombre","Javier");


            ///////////////////////////
            ///////////////////////////

            Console.ReadKey();


        }
    }
}
