﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArbolSimples.TipoPila
{
    class PilaVector
    {
        private static int INICIAL = 19;
        private int cima;
        private ArrayList listaPila;

        public PilaVector()
        {
            cima = -1;
            listaPila = new ArrayList(INICIAL);
        }

        public void insertar(object elemento)
        {
            cima++;
            listaPila.Add(elemento);
        }

        public object quitar()
        {
            object aux;
            if (pilaVacia())
            {
                throw new Exception("Pila vacía, no se puede extraer.");
            }
            aux = listaPila[cima];
            listaPila.RemoveAt(cima);
            cima--;
            return aux;
        }

        public object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila vacía, no se puede extraer.");
            }
            return listaPila[cima];
        }

        public bool pilaVacia()
        {
            return cima == -1;
        }

        public void limpiarPila()
        {
            while (!pilaVacia())
            {
                quitar();
            }
        }
    }
}
