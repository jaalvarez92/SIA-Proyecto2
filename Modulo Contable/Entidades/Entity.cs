using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Entity:Dictionary<String, Object> 
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Entity():base()
        {
        }

        /// <summary>
        /// Obtiene el valor del Entity asociado a la llave
        /// </summary>
        /// <param name="key">llave de la búsqueda</param>
        /// <returns>Objeto asociado a la llave</returns>
        public Object Get(String key)
        {
            Object result= new Object();
            this.TryGetValue(key.ToLower(),out result);
            return result;
        }


        /// <summary>
        /// Establece el valor dado para una llave especificada
        /// </summary>
        /// <param name="key">llave</param>
        /// <param name="value">Objeto que se asociará a la llave</param>
        public void Set(String key, Object value)
        {
            if (this.ContainsKey(key.ToLower()))
            {
                this[key.ToLower()] = value;
            }
            else
            {
                this.Add(key.ToLower(), value);
            }
        }

    }
}
