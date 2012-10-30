using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Xml;

namespace AccesoDatos
{
    public class XMLLoader
    {

        /// <summary>
        /// Carga los SP en objetos de tipo Entity, obtiene la 
        /// información de un archivo X-ml
        /// </summary>
        /// <param name="pFilePath"> Ruta del archivo XML</param>
        /// <returns>Objeto de tipo Entities con todos los SP</returns>
        public Entities loadXML(String pFilePath)
        {
            Entities result = new Entities();
            Entity sp = new Entity();
            Entities parameters = new Entities();

            try
            {
                XmlReader builder = XmlReader.Create(pFilePath);
                while (builder.Read())
                {
 
                    if (builder.NodeType.Equals(XmlNodeType.Element))
                    {
                        if (builder.Name.Equals("StoredProcedure"))
                        {
                            sp = new Entity();
                            parameters = new Entities();

                            builder.MoveToAttribute("Name");
                            string nombre = builder.Value;
                            sp.Set("Nombre", nombre);

                            builder.MoveToAttribute("SP");
                            string spName = builder.Value;
                            sp.Set("SP", spName);

                            builder.MoveToAttribute("ReturnData");
                            bool returnData = bool.Parse(builder.Value);
                            sp.Set("Retorna", returnData);
                        }
                        if (builder.Name.Equals("Parameter"))
                        {
                            Entity parameter = new Entity();
                            builder.MoveToAttribute("Name");
                            string pnombre = builder.Value;
                            parameter.Set("Nombre", pnombre);

                            parameter.Set("Valor", null);

                            builder.MoveToAttribute("Type");
                            string ptipo = builder.Value;
                            parameter.Set("Tipo", ptipo);
                            parameters.Add(parameter);
                        }
                    }
                    else
                    {
                        if (builder.NodeType.Equals(XmlNodeType.EndElement))
                        {
                            if (builder.Name.Equals("StoredProcedure"))
                            {
                                sp.Set("Parametros", parameters);
                                result.Add(sp);
                                sp = new Entity();
                                parameters = new Entities();

                            }
                        }
                    }
                }
            }
            catch 
            {
                return new Entities();
            }
            return result;
        }
        
    }
}
