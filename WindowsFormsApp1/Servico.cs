using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.ServiceReference1;

namespace WindowsFormsApp1
{
    class Servico
    {
        public ServiceReference1.BankWSClient servico = new ServiceReference1.BankWSClient();

      

        //  public bool Cadastrar(String nome, String senha, String saldo)
        // {
        //       return servico.cadastrarUser(nome, senha, saldo);
        //   }

        public String nomeSaldo = "Matheus";
        public String senhaSaldo = "23123";
        public Double valor;
        public String nome;
        public String senha;
        public String nomeAtual;
        public String senhaAtual;

        public double Saldo(String nomeSaldo, String senhaSaldo)
        {
            //Console.WriteLine("teste");
            return servico.saldoUser(nomeSaldo, senhaSaldo);
            //return 0;
        }

        public bool Deposito(Double valor, String nome)
        {
            return servico.deposito(valor, nome);
        }

        public bool Saque(Double valor, String nome)
        {
            return servico.saque(valor, nome);
        }

        public bool CadastrarUsuario(String nome, String senha, String valor)
        {
            return servico.cadastrarUser(nome, senha, valor);
        }

        public bool AlterarCadastro(String nomeAtual, String nome, String senhaAtual, String senha)
        {
            return servico.alterCadastro(nomeAtual, nome, senhaAtual, senha);
        }

        public string ConsultarConta(String nome, String senha)
        {
            return servico.consultUser(nome, senha);
        }
        

    }
}
