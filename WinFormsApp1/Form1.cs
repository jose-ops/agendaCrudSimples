using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class F_contatos : Form
    {
        public void limparCampos()
        {
            
            tb_Nome.Clear();
            tb_email.Clear();
            mtb_telefone.Clear();
        }

        public void AtivaCampos()
        {
            tb_email.Enabled = true;
            
            tb_Nome.Enabled = true;
            mtb_telefone.Enabled = true;
            tsb_cancelar.Enabled = true;
            tlb_alterar.Enabled = true;
            tlb_excluir.Enabled = true;
            tlb_salvar.Enabled = true;
            btn_BuscaDataGrip.Enabled = true;
            dg_Dados.Enabled = true;
        }

        public void DesativaCampos()
        {
            tb_email.Enabled = false;
            
            tb_Nome.Enabled = false;
            mtb_telefone.Enabled = false;
            tsb_cancelar.Enabled = false;
            tlb_alterar.Enabled = false;
            tlb_excluir.Enabled = false;
            tlb_salvar.Enabled = false;
            btn_BuscaDataGrip.Enabled = false;
            dg_Dados.Enabled = false;
        }

        public F_contatos()
        {
            InitializeComponent();
        }

        private void lb_telefone_Click(object sender, EventArgs e)
        {

        }

        SqlConnection sqlConn = null;

        private string strConn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DB_VENDAS;Integrated Security=True";
        private string strSql = string.Empty;
        private void tlb_salvar_Click(object sender, EventArgs e)
        {
            strSql = "insert into funcionarios ( Nome, Telefone, Email) values ( @Nome, @Telefone, @Email)";
            sqlConn = new SqlConnection(strConn);
            SqlCommand comando = new SqlCommand(strSql, sqlConn);

            
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = tb_Nome.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = mtb_telefone.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = tb_email.Text;

            try
            {
                sqlConn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!");
                limparCampos();
                tb_Nome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void tlb_pesquisar_Click(object sender, EventArgs e)
        {
            AtivaCampos();
            strSql = "select * from Funcionarios where nome=@nome";
            sqlConn = new SqlConnection(strConn);
            SqlCommand comando = new SqlCommand(strSql, sqlConn);

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txt_buscarPorNome.Text;

            try
            {
                if (txt_buscarPorNome.Text == string.Empty)
                {
                    throw new Exception("Digite um nome");
                    txt_buscarPorNome.Focus();
                }
                sqlConn.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("nome não cadastrado!");
                    
                }
                dr.Read();
                
                tb_Nome.Text = Convert.ToString(dr["Nome"]);
                mtb_telefone.Text = Convert.ToString(dr["Telefone"]);
                tb_email.Text = Convert.ToString(dr["Email"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void tlb_alterar_Click(object sender, EventArgs e)
        {
            strSql = "update funcionarios set id=@id, nome=@nome, telefone=@telefone, email=@email where nome=@txt_buscarPorNome";
            sqlConn = new SqlConnection(strConn);
            SqlCommand comando = new SqlCommand(strSql, sqlConn);

            comando.Parameters.Add("@txt_buscarPorNome", SqlDbType.VarChar).Value = txt_buscarPorNome.Text;

            
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = tb_Nome.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = mtb_telefone.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = tb_email.Text;

            try
            {
                sqlConn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Contato atualizado com sucesso!");
                limparCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void tlb_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse contato ?", "cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!");
            }
            else
            {
                strSql = "Delete from funcionarios where Id=@Id";
                sqlConn = new SqlConnection(strConn);
                SqlCommand comando = new SqlCommand(strSql, sqlConn);

                comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txt_buscarPorNome.Text;

                try
                {
                    sqlConn.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Contato deletado com sucesso!");
                    limparCampos();
                    tb_Nome.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    sqlConn.Close();
                }
            }
        
        }

        public void listaGrid()
        {
            strSql = "Select * from funcionarios";
            sqlConn = new SqlConnection(strConn);
            SqlCommand comando = new SqlCommand(strSql, sqlConn);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(comando);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                dg_Dados.DataSource = dtLista;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void novo_Click(object sender, EventArgs e)
        {
            limparCampos();
            tb_Nome.Focus();
            AtivaCampos();
            tlb_alterar.Enabled = false;
            tlb_excluir.Enabled = false;
          

        }

        private void btn_BuscaDataGrip_Click(object sender, EventArgs e)
        {
            listaGrid();
        }

        private void F_contatos_Load(object sender, EventArgs e)
        {
           DesativaCampos();
            btn_BuscaDataGrip.Enabled = true;

        }

        private void tsb_cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
