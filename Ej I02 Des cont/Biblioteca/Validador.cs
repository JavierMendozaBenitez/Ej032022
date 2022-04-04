using System;

namespace Biblioteca
{
    public class Validador
    {
        public static bool ValidarRespuesta(string respuesta, string letraCorrecta)
        {
            bool retorno = false;

            if(respuesta == letraCorrecta)
            {
                retorno = true;
            }
            return retorno;
        }


    }
}
