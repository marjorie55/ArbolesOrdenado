using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolSimples.Clases.ArbolBinarioOrdenado
{
    class Estudiante : Comparador
    {

        public String numMat;
        public String nombre;
        public bool igualQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return nombre.CompareTo(p2.nombre) == 0;
        }

        public bool mayorIgualQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return nombre.CompareTo(p2.nombre) >= 0;
            /*Estudiante p2 = (Estudiante)q;
            return numMat >= p2.numMat;*/
        }

        public bool mayorQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return nombre.CompareTo(p2.nombre) > 0;
        }

        public bool menorIgualQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return nombre.CompareTo(p2.nombre) <= 0;
        }

        public bool menorQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return nombre.CompareTo(p2.nombre) < 0;
            /* Estudiante p2 = (Estudiante)op2;
             return numMat < p2.numMat;*/
        }
    }
}
