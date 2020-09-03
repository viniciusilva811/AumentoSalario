using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace AumentoSalario
{
    class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public Funcionario(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }
        public void aumentoSalario(double percentage)
        {
            Salario += Salario * percentage / 100.0;
        }

        public override string ToString()
        {
            return ID
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}