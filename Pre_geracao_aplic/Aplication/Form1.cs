using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aplication
{
    public partial class dvgFunci : Form
    {        
        DAL acesso = new DAL();
        string numMes = "0";
        string numCiclo = "";
        string numAno = "";
        string numBase = "";
        string porc = "";        
        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

        public dvgFunci()
        {
            InitializeComponent();
            dgvFunci2.DataSource = dgvFunci2.MaximumSize;
            DateTime hoje = DateTime.Today;
            int ano = hoje.Year;
            int anoAdic = hoje.Year + 1;
            txtAno.Items.Add(ano);
            txtAno.Items.Add(anoAdic);

        }
        private static void FreezeBand(DataGridViewBand band)
        {
            band.Frozen = true;
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.WhiteSmoke;
            band.DefaultCellStyle = style;
        }

        private void atualizarExibicao()
        {
            dgvFunci2.Columns.Clear();
            dgvFunci2.DataSource = acesso.GetTodosRegistros();
            dgvTotais.DataSource = acesso.MostrarTotais();

            dgvFunci2.Columns["qt_vr"].DefaultCellStyle.Font = new Font("default", 15.0f, FontStyle.Bold, GraphicsUnit.World);
            dgvFunci2.Columns["tot_var"].DefaultCellStyle.Font = new Font("default", 15.0f, FontStyle.Bold, GraphicsUnit.World);
            FreezeBand(dgvFunci2.Columns["operadora"]);
            FreezeBand(dgvFunci2.Columns["tipo_cobranca"]);

            for (int i = 0; i < dgvFunci2.Rows.Count; i++)
            {
                string seta1 = Convert.ToString(dgvFunci2.Rows[i].Cells[8].Value);
                if (seta1 == "↑")
                {
                    dgvFunci2.Rows[i].Cells[8].Style.ForeColor = Color.Green;
                    dgvFunci2.Rows[i].Cells[7].Style.ForeColor = Color.Green;
                }
                else
                {
                    if (seta1 == "↓")
                    {
                        dgvFunci2.Rows[i].Cells[8].Style.ForeColor = Color.Red;
                        dgvFunci2.Rows[i].Cells[7].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        dgvFunci2.Rows[i].Cells[8].Style.ForeColor = Color.Purple;
                        dgvFunci2.Rows[i].Cells[7].Style.ForeColor = Color.Purple;
                    }
                }
                string seta2 = Convert.ToString(dgvFunci2.Rows[i].Cells[14].Value);
                if (seta2 == "↑")
                {
                    dgvFunci2.Rows[i].Cells[14].Style.ForeColor = Color.Green;
                    dgvFunci2.Rows[i].Cells[13].Style.ForeColor = Color.Green;
                }
                else
                {
                    if (seta2 == "↓")
                    {
                        dgvFunci2.Rows[i].Cells[14].Style.ForeColor = Color.Red;
                        dgvFunci2.Rows[i].Cells[13].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        dgvFunci2.Rows[i].Cells[14].Style.ForeColor = Color.Purple;
                        dgvFunci2.Rows[i].Cells[13].Style.ForeColor = Color.Purple;
                    }
                }
                string alarme = Convert.ToString(dgvFunci2.Rows[i].Cells[2].Value);
                if (alarme == "▼")
                {
                    dgvFunci2.Rows[i].Cells[2].Style.ForeColor = Color.Red;
                }
                else
                {                   
                    dgvFunci2.Rows[i].Cells[2].Style.ForeColor = Color.Green;                    
               
                }
                string alarme2 = Convert.ToString(dgvFunci2.Rows[i].Cells[3].Value);
                if (alarme2 == "▼")
                {
                    dgvFunci2.Rows[i].Cells[3].Style.ForeColor = Color.Red;
                }
                else
                {
                    dgvFunci2.Rows[i].Cells[3].Style.ForeColor = Color.Green;

                }                
                string tot = Convert.ToString(dgvFunci2.Rows[i].Cells[1].Value);
                if (tot.Contains("SubTotal") || tot == "")
                {
                    dgvFunci2.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }               
            }
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtBase.Text == string.Empty || txtCiclo.Text == string.Empty || txtMes.Text == string.Empty || txtAno.Text == string.Empty )
            {
                txtBase.Focus();
                return;
            }

            try
            {
                this.Cursor = Cursors.WaitCursor;
                numCiclo = txtCiclo.Text;
                numAno = txtAno.Text;
                numBase = txtBase.Text;
                porc = txtPorc.Text;
                switch (txtMes.Text)
                {
                    case "Janeiro":
                        numMes = "1";
                        break;
                    case "Fevereiro":
                        numMes = "2";
                        break;
                    case "Março":
                        numMes = "3";
                        break;
                    case "Abril":
                        numMes = "4";
                        break;
                    case "Maio":
                        numMes = "5";
                        break;
                    case "Junho":
                        numMes = "6";
                        break;
                    case "Julho":
                        numMes = "7";
                        break;
                    case "Agosto":
                        numMes = "8";
                        break;
                    case "Setembro":
                        numMes = "9";
                        break;
                    case "Outubro":
                        numMes = "10";
                        break;
                    case "Novembro":
                        numMes = "11";
                        break;
                    case "Dezembro":
                        numMes = "12";
                        break;
                }
                acesso.Vazio();
                acesso.AtualizarRegistro(numBase, numCiclo, numMes, numAno, porc);                   
                atualizarExibicao();
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Erro : " + ex.Message);
            }
        }
        private void Mensagem()
        {
            MessageBox.Show("Operação realizada com sucesso !");
        }

        private void dgvFunci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dvgFunci_Load(object sender, EventArgs e)
        {

        }

        private void dgvFunci2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFunci2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgvFunci2_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void dgvFunci2_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void dgvFunciZ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {


            switch (selNew.SelectedIndex)
            {
                case 0:
                    if (dgvFunci2.Rows.Count > 0)
                    {
                        try
                        {
                            this.Cursor = Cursors.WaitCursor;
                            XcelApp.Application.Workbooks.Add(Type.Missing);
                            for (int i = 1; i < dgvFunci2.Columns.Count + 1; i++)
                            {
                                XcelApp.Cells[1, i] = dgvFunci2.Columns[i - 1].HeaderText;
                            }
                            //
                            for (int i = 0; i < dgvFunci2.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < dgvFunci2.Columns.Count; j++)
                                {
                                    XcelApp.Cells[i + 2, j + 1] = dgvFunci2.Rows[i].Cells[j].Value.ToString();
                                }
                            }
                            //
                            XcelApp.Columns.AutoFit();
                            //
                            XcelApp.Visible = true;
                            this.Cursor = Cursors.Default;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro : " + ex.Message);
                            XcelApp.Quit();
                            this.Cursor = Cursors.Default;
                        }
                    };
                    break;
                case 1:
                    if (dgvTotais.Rows.Count > 0)
                    {
                        try
                        {
                            this.Cursor = Cursors.WaitCursor;
                            XcelApp.Application.Workbooks.Add(Type.Missing);
                            for (int i = 1; i < dgvTotais.Columns.Count + 1; i++)
                            {
                                XcelApp.Cells[1, i] = dgvTotais.Columns[i - 1].HeaderText;
                            }
                            //
                            for (int i = 0; i < dgvTotais.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < dgvTotais.Columns.Count; j++)
                                {
                                    XcelApp.Cells[i + 2, j + 1] = dgvTotais.Rows[i].Cells[j].Value.ToString();
                                }
                            }
                            //
                            XcelApp.Columns.AutoFit();
                            //
                            XcelApp.Visible = true;
                            this.Cursor = Cursors.Default;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro : " + ex.Message);
                            XcelApp.Quit();
                            this.Cursor = Cursors.Default;
                        }
                    };
                    break;
               
                    
                    
            }
        }

        private void dgvFunci2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtBase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
