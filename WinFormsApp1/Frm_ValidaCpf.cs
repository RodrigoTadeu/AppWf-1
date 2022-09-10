using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Frm_ValidaCpf : Form
    {
        public Frm_ValidaCpf()
        {
            InitializeComponent();
        }

        public bool Valida(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
           
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            string vConteudo;
            vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "");
            vConteudo = vConteudo.Trim();
            if (vConteudo == "" || vConteudo.Length !=11 )
            {
                MessageBox.Show("Digite um CPF válido!", "Messagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
            bool validaCpf = false;
            validaCpf = Valida(Msk_CPF.Text);
            if (validaCpf == true)
            {
               MessageBox.Show("CPF válido!","Messagem de validação",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("CPF inválido!", "Messagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }

        }
    }
}
