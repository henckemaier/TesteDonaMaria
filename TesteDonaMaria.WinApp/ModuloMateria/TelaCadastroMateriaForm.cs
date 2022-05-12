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

namespace TesteDonaMaria.WinApp.ModuloMateria
{
    public partial class TelaCadastroMateriaForm : Form
    {
        public TelaCadastroMateriaForm()
        {
            InitializeComponent();

            CarregarSerie();

            CarregarDisciplina();
        }

        private void CarregarSerie()
        {
            var serie = Enum.GetValues(typeof(SerieMateriaEnum));

            foreach (var item in serie)
            {
                cmbSerieMateria.Items.Add(item);
            }

            cmbSerieMateria.SelectedItem = SerieMateriaEnum.Primeira;
        }

        private void CarregarDisciplina()
        {
            var disciplina = Enum.GetValues(typeof(MateriaDisciplinaEnum));

            foreach (var item in disciplina)
            {
                cmbDisciplinas.Items.Add(item);
            }

            cmbDisciplinas.SelectedItem = MateriaDisciplinaEnum.Matematica;
        }

        private Materia materia;

        public Func<Materia, ValidationResult> GravarRegistro {  get; set; }

        public Materia Materia 
        {
            get 
            { 
                return materia; 
            }
            set
            {
                materia = value;

                txtNumero.Text = materia.Numero.ToString();
                txtNomeMateria.Text = materia.NomeMateria;
                cmbSerieMateria.SelectedItem = materia.Serie;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            materia.NomeMateria = txtNomeMateria.Text;
            materia.Serie = (SerieMateriaEnum)cmbSerieMateria.SelectedItem;

            ValidationResult resultadoValidacao = GravarRegistro(materia);

            if(resultadoValidacao.IsValid == false)
            {
                string primeiroErro = resultadoValidacao.Errors[0].ErrorMessage;
                TelaPrincipal.Instancia.AtualizarRodape(primeiroErro);
                DialogResult = DialogResult.None;
            }
        }

        private void cmbSerieMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
