using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolSimples.Clases.arbolBinario
{
    class ArbolBinario
    {
        protected Nodo raiz;//propiedad tipo nodo

        public ArbolBinario()
        {
            // constructor con nulo
            raiz = null;
        }

        public ArbolBinario(Nodo raiz)
        {
            this.raiz = raiz;
        }

        public Nodo raizArbol()
        {//modificadores
            return raiz;
        }
        // Comprueba el estatus del árbol

        bool esVacio()
        {
            return raiz == null; //es lo mismo que hacer un if solo que mas resumido
        }

        public static Nodo nuevoArbol(
                Nodo ramaIzqda, object dato, Nodo ramaDrcha)
        {
            return new Nodo(ramaIzqda, dato, ramaDrcha);
        }
    }
}
