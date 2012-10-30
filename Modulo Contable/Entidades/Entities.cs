using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Entities : List<Entity>
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Entities()
            : base()
        {
        }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="entidades">entidades inicializadoras</param>
        public Entities(params Entity[] entidades)
            : base()
        {
            foreach (Entity e in entidades)
            {
                this.Add(e);
            }
        }

        /// <summary>
        /// Busca un objeto Entity de acuerdo a una llave y un valor especificados.
        /// </summary>
        /// <param name="key">llave de la búsqueda</param>
        /// <param name="value">valor de la búsqueda</param>
        /// <returns>Objeto de tipo Entity</returns>
        public Entity Get(String key, Object value)
        {
            foreach (Entity e in this)
            {
                if (e.Get(key).Equals(value))
                {
                    return e;
                }
            }
            return null;
        }

        /// <summary>
        /// Establece un valor asociado a un llave a los 
        /// Objetos Entity que concuerden con los parametros de búsqueda
        /// </summary>
        /// <param name="key">llave de la búsqueda</param>
        /// <param name="value">valor de la búsqueda</param>
        /// <param name="newKey">llave del nuevo valor</param>
        /// <param name="newValue">Objeto a establecer</param>
        public void Set(String key, Object value, String newKey, Object newValue)
        {
            foreach (Entity e in this)
            {
                if (e.Get(key).Equals(value))
                {
                    e.Set(newKey, newValue);
                }
            }
        }

    }
    
}
