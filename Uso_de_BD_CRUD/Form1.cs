using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uso_de_BD_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //3-cria uma instância do objeto Connection em memória
            SqlConnection conn = new SqlConnection("Data Source = DESKTOP-K8F68PB; Initial Catalog = InvocadoresLeagueOfLegends; Integrated Security = SSPI");

            // instancia do objeto dr para que possa ter acesso às informações oriundas de um SELECT
            SqlDataReader dr = null;

            try
            {
                // 2. Abre a conexão
                conn.Open();
                // 3. Passa conexão para o objeto command
                SqlCommand cmd = new SqlCommand("select * from InvocadorBasico", conn);

                // 4. Usa conexão
                // obtêm o resultado da consulta
                dr = cmd.ExecuteReader();

                //percorre o SqlDataReader para obter os dados da tabela
                while (dr.Read())
                {
                    //Exibindo o ID em dr[0]
                    //e o nome em dr["nome"]
                    listBoxSaida.Items.Add(Convert.ToString(dr[0] + " - " + dr["nomeInvocador"] + " - " + dr["RankInv"] + " - " + dr["Divisao"]));
                }

                dr.Close();

            }
            finally
            {
                // 4. Fecha a conexão
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
