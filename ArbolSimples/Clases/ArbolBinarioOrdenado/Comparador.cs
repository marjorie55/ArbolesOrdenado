using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolSimples.Clases.ArbolBinarioOrdenado
{
    public interface Comparador
    {
        bool igualQue(object q);

        bool menorQue(object q);

        bool menorIgualQue(object q);

        bool mayorQue(object q);

        bool mayorIgualQue(object q);
    }
}
