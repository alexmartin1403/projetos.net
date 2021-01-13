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
        Boolean numCh = false;
        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

        public dvgFunci()
        {
            InitializeComponent();
            DateTime hoje = DateTime.Today;
            int ano = hoje.Year;
            int anoAdic = hoje.Year + 1;
            txtAno.Items.Add(ano);
            txtAno.Items.Add(anoAdic);

        }
        private void atualizarExibicao()
        {
            dgvFunci2.Columns.Clear();
            dgvFunci2.DataSource = acesso.GetTodosRegistros();
            
            dgvFunci2.Columns["qtde_ant"].DefaultCellStyle.Font = new Font("default", 11.0f, FontStyle.Bold, GraphicsUnit.World);
            dgvFunci2.Columns["qtde_ant"].DefaultCellStyle.ForeColor = Color.Blue;            
            dgvFunci2.Columns["valor_ant"].DefaultCellStyle.Font = new Font("default", 11.0f, FontStyle.Bold, GraphicsUnit.World);
            dgvFunci2.Columns["valor_ant"].DefaultCellStyle.ForeColor = Color.Blue;
            dgvFunci2.Columns["qtde_sel"].DefaultCellStyle.Font = new Font("default", 11.0f, FontStyle.Bold, GraphicsUnit.World);
            dgvFunci2.Columns["qtde_sel"].DefaultCellStyle.ForeColor = Color.Blue;
            dgvFunci2.Columns["valor_sel"].DefaultCellStyle.Font = new Font("default", 11.0f, FontStyle.Bold, GraphicsUnit.World);
            dgvFunci2.Columns["valor_sel"].DefaultCellStyle.ForeColor = Color.Blue;
            
          
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
                numCh = checkBox.Checked;
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
                }switch (txtMes.Text)
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
                acesso.AtualizarRegistro(numCiclo, numBase, numMes, numAno, numCh);                   
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
            try
            {
                this.Cursor = Cursors.WaitCursor;                
                string dCiclo;
                string dCiclo2;                
                string dDescr;               
                int selec = 0;



                switch (dgvFunci2.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex)
                {
                    case 1:
                        selec = -2;
                        break;
                    case 2:
                        selec = -2;
                        break;
                    case 3:
                        selec = -1;
                        break;
                    case 4:
                        selec = -1;
                        break;                    
                    default:
                        goto fim;
                }
                
                switch (numCiclo)
                {
                    case "5-8":
                        dCiclo = "5";
                        dCiclo2 = "8";
                        break;
                    case "25-28":
                        dCiclo = "25";
                        dCiclo2 = "28";
                        break;
                    default:
                        dCiclo = numCiclo;
                        dCiclo2 = "0";
                        break;

                }

                dDescr = dgvFunci2.Rows[e.RowIndex].Cells["descricao"].FormattedValue.ToString();
                
                selNew.SelectedIndex = 1;
                if (numBase == "TUDO")
                {
                    if (dDescr == "Total Geral")
                    {
                        dgvFunciD.DataSource = acesso.GetDetalheTudoTotal(dCiclo, dCiclo2, numMes, numAno, selec, numCh);
                    }
                    else
                    {
                        dgvFunciD.DataSource = acesso.GetDetalheTudo(dCiclo, dCiclo2, numMes, numAno, dDescr, selec); 
                    }
                       
                }
                else
                {
                    if (dDescr == "Total Geral")
                    {
                        if (numBase == "TUDO_S_CTV")
                        {
                            numBase = "BHZ' or base = 'BRA' or base = 'BRI' or base = 'ISP' or base = 'SOC' or base = 'SPO' or base = 'SUL";
                            dgvFunciD.DataSource = acesso.GetDetalheTudoSTotal(numBase, dCiclo, dCiclo2, numMes, numAno, selec, numCh);
                        }
                        else
                        {
                            dgvFunciD.DataSource = acesso.GetDetalheTudoSTotal(numBase, dCiclo, dCiclo2, numMes, numAno, selec, numCh);
                        }
                    }
                    else
                    {
                        if (numBase == "TUDO_S_CTV")
                        {
                            numBase = "BHZ' or base = 'BRA' or base = 'BRI' or base = 'ISP' or base = 'SOC' or base = 'SPO' or base = 'SUL";
                            dgvFunciD.DataSource = acesso.GetDetalhe(numBase, dCiclo, dCiclo2, numMes, numAno, dDescr, selec);
                        }
                        else
                        {
                            dgvFunciD.DataSource = acesso.GetDetalhe(numBase, dCiclo, dCiclo2, numMes, numAno, dDescr, selec);
                        }
                    }
                    
                }
            fim:;
                this.Cursor = Cursors.Default;
            }
            catch
            {

            }
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
                    if (dgvFunciD.Rows.Count > 0)
                    {
                        try
                        {
                            this.Cursor = Cursors.WaitCursor;
                            XcelApp.Application.Workbooks.Add(Type.Missing);
                            for (int i = 1; i < dgvFunciD.Columns.Count + 1; i++)
                            {
                                XcelApp.Cells[1, i] = dgvFunciD.Columns[i - 1].HeaderText;
                            }
                            //
                            for (int i = 0; i < dgvFunciD.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < dgvFunciD.Columns.Count; j++)
                                {
                                    XcelApp.Cells[i + 2, j + 1] = dgvFunciD.Rows[i].Cells[j].Value.ToString();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtBase.Text == string.Empty || txtCiclo.Text == string.Empty || txtMes.Text == string.Empty || txtAno.Text == string.Empty)
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
            numCh = checkBox.Checked;
            string dCiclo;
            string dCiclo2;

            switch (txtMes.Text)
            {
                case "Janeiro":
                    numMes = "01";
                    break;
                case "Fevereiro":
                    numMes = "02";
                    break;
                case "Março":
                    numMes = "03";
                    break;
                case "Abril":
                    numMes = "04";
                    break;
                case "Maio":
                    numMes = "05";
                    break;
                case "Junho":
                    numMes = "06";
                    break;
                case "Julho":
                    numMes = "07";
                    break;
                case "Agosto":
                    numMes = "08";
                    break;
                case "Setembro":
                    numMes = "09";
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

            switch (numCiclo)
            {
                case "5-8":
                    dCiclo = "05";
                    dCiclo2 = "08";
                    break;
                case "25-28":
                    dCiclo = "25";
                    dCiclo2 = "28";
                    break;
                default:
                    dCiclo = numCiclo;
                    dCiclo2 = "00";
                    break;

            }
            acesso.GeraArquivo(dCiclo, dCiclo2, numBase, numMes, numAno, numCh);
            this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Erro : " + ex.Message);
            }

        }
    }
}
