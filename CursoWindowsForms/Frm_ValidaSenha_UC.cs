﻿using CursoWindowsFormsBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaSenha_UC : UserControl
    {
        bool VerSenhaTxt = false;
        public Frm_ValidaSenha_UC()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Senha.Text = "";
            lbl_Resultado.Text = "";
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            Cls_Uteis.ChecaForcaSenha verifica = new Cls_Uteis.ChecaForcaSenha();
            Cls_Uteis.ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(Txt_Senha.Text);
            lbl_Resultado.Text = forca.ToString();

            if (lbl_Resultado.Text == "Inaceitavel" | lbl_Resultado.Text == "Fraca")
            {
                lbl_Resultado.ForeColor = Color.Red;
            }
            if (lbl_Resultado.Text == "Aceitavel")
            {
                lbl_Resultado.ForeColor = Color.Blue;
            }
            if (lbl_Resultado.Text == "Forte" | lbl_Resultado.Text == "Segura")
            {
                lbl_Resultado.ForeColor = Color.Green;
            }
        }

        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                Txt_Senha.PasswordChar = '\0';
                VerSenhaTxt = true;
                Btn_VerSenha.Text = "Esconder Senha";
            }
            else
            {
                Txt_Senha.PasswordChar = '*';
                VerSenhaTxt = false;
                Btn_VerSenha.Text = "Ver Senha";
            }
        }
    }
}
