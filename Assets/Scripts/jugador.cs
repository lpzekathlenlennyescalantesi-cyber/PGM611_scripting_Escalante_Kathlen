using logica_de_enemigo.herramientas.calculos;
using logica_de_jugado;
using UnityEngine;

// el UnityEngine es un namespace
// el namespace sirve para organizar el codigo completo
// se crea los bloques con extensiones

namespace logica_de_jugado
{
    public class jugador : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

namespace logica_de_enemigo
{
    public class Enemigo : MonoBehaviour
    {

    }

    #region Mundo

    namespace herramientas
    {
        namespace calculos
        {
            public class Ejemplo
            {
                public void metodoEjemplo()
                {
                    jugador j;
                }
            }
        }

        namespace conectividad
        {
            public partial class Herramienta
            {

            }
        }
    }

    #endregion

    namespace logica_de_saltar
    {
        namespace caminar
        {
            using herramientas.calculos;

            public class caminar
            {
                public void metodo_caminar()
                {
                    Ejemplo e;
                }
            }
        }
    }
}