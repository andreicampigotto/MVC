using ExemploMVC02.Database;
using ExemploMVC02.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExemploMVC02.Repositorio
{
    public class RecrutadoraRepositorio
    {
        public List<Recrutadora> ObterTodos() {

            List<Recrutadora> recrutadoras = new List<Recrutadora>();
            SqlCommand comando = new BancoDados().ObterConexao();
            comando.CommandText = "SELECT Id, Nome, CPF, Tempo_espera, Salario From recrutadoras";
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            foreach (DataRow linha in tabela.Rows)
            {
                Recrutadora recrutadora = new Recrutadora()
                {
                    Id = Convert.ToInt32(linha[0].ToString()),
                    Nome = linha[1].ToString(),
                    CPF = linha[2].ToString(),
                    TempoEmpresa = Convert.ToByte(linha[3].ToString()),
                    Salario = Convert.ToDouble(linha[4].ToString())
                };
                recrutadoras.Add(recrutadora);
            }
            return recrutadoras;
        }
        public int Cadastrar(Recrutadora recrutadora)
        {
            return 0;
        }
        public bool Alterar(Recrutadora recrutadora)
        {
            return false;
        }
        public bool Excluir(int id) 
        {
            return false;
        }
        public Recrutadora ObterPeloID(int id)
        {
            Recrutadora recrutadora = null;
            return recrutadora;
        }
    }
}