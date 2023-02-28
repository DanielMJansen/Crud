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

namespace Crud
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Contatos;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;

        public Form1()
        {
            InitializeComponent();
            ExibirDados();
        }

        private void ExibirDados()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("Select * FROM Contato", con);
                adapt.Fill(dt);
                dgvCrud.DataSource = dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            combox_lanepref.Text = "";
            combox_laneodiada.Text = "";
            num_nota.Value = 70;
            txtNome.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && combox_lanepref.Text != "" && combox_laneodiada.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Contatos(Nome, LanePref, LaneOdiada, Nota) Values (@Nome, @LanePref, @LaneOdiada, @Nota)", con);
                    con.Open();
                    cmd.Parameters.Add("@Nome", txtNome.Text.ToUpper());
                    cmd.Parameters.Add("@LanePref", combox_lanepref.Text.ToUpper());
                    cmd.Parameters.Add("@LaneOdiada", combox_laneodiada.Text.ToUpper());
                    cmd.Parameters.Add("@Nota", Convert.ToInt32(num_nota.Value.ToString()));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    con.Close();
                    ExibirDados();
                }
            }
            else
            {
                MessageBox.Show("Necessário informar todos os dados solicitados para realizar um novo cadastro.");
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && combox_lanepref.Text != "" && combox_laneodiada.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("UPDATE Contatos SET Nome=@Nome, LanePref=@LanePref, LaneOdiada=@LaneOdiada, Nota=@Nota WHERE id=@id", con);
                    con.Open();
                    cmd.Parameters.Add("@id", ID);
                    cmd.Parameters.Add("@Nome", txtNome.Text.ToUpper());
                    cmd.Parameters.Add("@LanePref", combox_lanepref.Text.ToUpper());
                    cmd.Parameters.Add("@LaneOdiada", combox_laneodiada.Text.ToUpper());
                    cmd.Parameters.Add("@Nota", Convert.ToInt32(num_nota.Value.ToString()));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro atualizado com sucesso.");
                }catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    con.Close();
                    ExibirDados();
                }
            }
            else
            {
                MessageBox.Show("Necessário informar todos os dados solicitados para atualizar um cadastro.");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                if(MessageBox.Show("Você realmente deseja deletar esse registro?", "Contato", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cmd = new SqlCommand("DELETE Contato Where id=@id", con);
                        con.Open();
                        cmd.Parameters.Add("@id", ID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuário deletado com sucesso.");
                    } catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                        ExibirDados();
                    }
                }
            }
            else
            {
                MessageBox.Show("Necessário informar um registro para ser deletado.");
            }
        }

        private void dgvCrud_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dgvCrud.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNome.Text = dgvCrud.Rows[e.RowIndex].Cells[1].Value.ToString();
                combox_lanepref.Text = dgvCrud.Rows[e.RowIndex].Cells[2].Value.ToString();
                combox_laneodiada.Text = dgvCrud.Rows[e.RowIndex].Cells[3].Value.ToString();
                num_nota.Value = Convert.ToInt32(dgvCrud.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
