using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteDonaMaria.Dominio.ModuloMateria;
using TesteDonaMaria.Dominio.ModuloTeste;

namespace TesteDonaMaria.WinApp.ModuloTeste
{
    public partial class TelaCadastroTesteForm : Form
    {

        private Teste teste;
        public Func<Teste, ValidationResult> GravarRegistro { get; set; }
        public Teste Teste 
        {
            get
            {
                return teste;
            }
            set
            {
                teste = value;

                txtNumero.Text = teste.Numero.ToString();
                cmbMateria.SelectedItem = teste.Materia;
                txtNumQuestoes.Text = teste.NumQuestoes.ToString();
            }
        }

        public TelaCadastroTesteForm(List<Materia> materias)
        {
            InitializeComponent();

            CarregarMateria(materias);

        }

        private void CarregarMateria(List<Materia> materias)
        {
            cmbMateria.Items.Clear();

            foreach (var item in materias)
            {
                cmbMateria.Items.Add(item);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            teste.Materia = (Materia)cmbMateria.SelectedItem;
            teste.NumQuestoes = Convert.ToInt32(txtNumQuestoes.Text);

            ValidationResult resultadoValidacao = GravarRegistro(teste);

            if (resultadoValidacao.IsValid == false)
            {
                string primeiroErro = resultadoValidacao.Errors[0].ErrorMessage;
                TelaPrincipal.Instancia.AtualizarRodape(primeiroErro);
                DialogResult = DialogResult.None;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void cmbDisciplinas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
