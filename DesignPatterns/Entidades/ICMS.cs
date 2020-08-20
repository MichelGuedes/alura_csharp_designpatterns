﻿namespace DesignPatterns.Entidades
{
    public class ICMS: Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
