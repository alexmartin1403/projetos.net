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
        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

        public dvgFunci()
        {
            InitializeComponent();

        }
        private void atualizarExibicao()
        {
            dgvFunci2.Columns.Clear();
            dgvFunci2.DataSource = acesso.GetTodosRegistros();

            dgvFunci2.Columns["qtd_2_meses_atras"].DefaultCellStyle.Font = new Font("default", 11.0f, FontStyle.Underline, GraphicsUnit.World);
            dgvFunci2.Columns["qtd_2_meses_atras"].DefaultCellStyle.ForeColor = Color.Blue;
            dgvFunci2.Columns["qtd_mes_anterior"].DefaultCellStyle.Font = new Font("default", 11.0f, FontStyle.Underline, GraphicsUnit.World);
            dgvFunci2.Columns["qtd_mes_anterior"].DefaultCellStyle.ForeColor = Color.Blue;
            dgvFunci2.Columns["qtd_mes_atual"].DefaultCellStyle.Font = new Font("default", 11.0f, FontStyle.Underline, GraphicsUnit.World);
            dgvFunci2.Columns["qtd_mes_atual"].DefaultCellStyle.ForeColor = Color.Blue;
            dgvFunci2.Columns["total_2_meses_atras"].DefaultCellStyle.Font = new Font("default", 11.0f, FontStyle.Underline, GraphicsUnit.World);
            dgvFunci2.Columns["total_2_meses_atras"].DefaultCellStyle.ForeColor = Color.Blue;
            dgvFunci2.Columns["total_mes_anterior"].DefaultCellStyle.Font = new Font("default", 11.0f, FontStyle.Underline, GraphicsUnit.World);
            dgvFunci2.Columns["total_mes_anterior"].DefaultCellStyle.ForeColor = Color.Blue;
            dgvFunci2.Columns["total_mes_atual"].DefaultCellStyle.Font = new Font("default", 11.0f, FontStyle.Underline, GraphicsUnit.World);
            dgvFunci2.Columns["total_mes_atual"].DefaultCellStyle.ForeColor = Color.Blue;
            dgvFunci2.Columns["Alarme_qtd"].DefaultCellStyle.Font = new Font("default", 18.0f, FontStyle.Regular, GraphicsUnit.World);
            dgvFunci2.Columns["Alarme_qtd"].DefaultCellStyle.ForeColor = Color.Red;
            dgvFunci2.Columns["Alarme_tot"].DefaultCellStyle.Font = new Font("default", 18.0f, FontStyle.Regular, GraphicsUnit.World);
            dgvFunci2.Columns["Alarme_tot"].DefaultCellStyle.ForeColor = Color.Red;
            dgvFunci2.Columns["qtd_var"].DefaultCellStyle.Font = new Font("default", 15.0f, FontStyle.Regular, GraphicsUnit.World);
            dgvFunci2.Columns["qtd_var"].DefaultCellStyle.ForeColor = Color.Purple;
            dgvFunci2.Columns["tot_var"].DefaultCellStyle.Font = new Font("default", 15.0f, FontStyle.Regular, GraphicsUnit.World);
            dgvFunci2.Columns["tot_var"].DefaultCellStyle.ForeColor = Color.Purple;
            dgvFunciQ.DataSource = acesso.GetQuantidadeItens();
            dgvFunciQ.Columns["qtd_var"].DefaultCellStyle.Font = new Font("default", 15.0f, FontStyle.Regular, GraphicsUnit.World);
            dgvFunciQ.Columns["qtd_var"].DefaultCellStyle.ForeColor = Color.Purple;
            dgvFunciV.DataSource = acesso.GetValorItens();
            dgvFunciV.Columns["total_var"].DefaultCellStyle.Font = new Font("default", 15.0f, FontStyle.Regular, GraphicsUnit.World);
            dgvFunciV.Columns["total_var"].DefaultCellStyle.ForeColor = Color.Purple;
            dgvFunciT.DataSource = acesso.GetSoma();
            dgvFunciZ.DataSource = acesso.GetZeradas();
            dgvFunciZ.Columns["Alarme_qtd"].DefaultCellStyle.Font = new Font("default", 18.0f, FontStyle.Regular, GraphicsUnit.World);
            dgvFunciZ.Columns["Alarme_qtd"].DefaultCellStyle.ForeColor = Color.Red;
            dgvFunciZ.Columns["qtd_var"].DefaultCellStyle.Font = new Font("default", 15.0f, FontStyle.Regular, GraphicsUnit.World);
            dgvFunciZ.Columns["qtd_var"].DefaultCellStyle.ForeColor = Color.Purple;
            dgvFunciZ.Columns["qtd_2_meses_atras"].DefaultCellStyle.Font = new Font("default", 11.0f, FontStyle.Underline, GraphicsUnit.World);
            dgvFunciZ.Columns["qtd_2_meses_atras"].DefaultCellStyle.ForeColor = Color.Blue;
            dgvFunciZ.Columns["qtd_mes_anterior"].DefaultCellStyle.Font = new Font("default", 11.0f, FontStyle.Underline, GraphicsUnit.World);
            dgvFunciZ.Columns["qtd_mes_anterior"].DefaultCellStyle.ForeColor = Color.Blue;
            dgvFunciZ.Columns["qtd_mes_atual"].DefaultCellStyle.Font = new Font("default", 11.0f, FontStyle.Underline, GraphicsUnit.World);
            dgvFunciZ.Columns["qtd_mes_atual"].DefaultCellStyle.ForeColor = Color.Blue;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtBase.Text == string.Empty || txtCiclo.Text == string.Empty || txtMes.Text == string.Empty || txtAno.Text == string.Empty || txtPorc.Text == string.Empty)
            {
                txtBase.Focus();
                return;
            }

            try
            {
                this.Cursor = Cursors.WaitCursor;
                numCiclo = txtCiclo.Text;
                numAno = txtAno.Text;
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
                if (txtBase.Text == "TUDO")
                {
                    acesso.AtualizarRegistroTudo(numCiclo, numMes, numAno, txtPorc.Text);
                }
                else
                {
                    acesso.AtualizarRegistro(txtBase.Text, numCiclo, numMes, numAno, txtPorc.Text);
                }
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
                string dBase;
                string dCiclo;
                string dNomeOper;
                string dCodOper;
                string dIdTipo;
                string dDescr;
                string dTipo;
                int aMes = 0;



                switch (dgvFunci2.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex)
                {
                    case 9:
                        aMes = 3;
                        break;
                    case 10:
                        aMes = 2;
                        break;
                    case 11:
                        aMes = 1;
                        break;
                    case 15:
                        aMes = 3;
                        break;
                    case 16:
                        aMes = 2;
                        break;
                    case 17:
                        aMes = 1;
                        break;
                    default:
                        goto fim;
                }

                dBase = dgvFunci2.Rows[e.RowIndex].Cells["base"].FormattedValue.ToString();
                switch (numCiclo)
                {
                    case "5-8":
                        dCiclo = "5_a_8";
                        break;
                    case "25-28":
                        dCiclo = "25_a_28";
                        break;
                    default:
                        dCiclo = numCiclo + "_a_" + numCiclo;
                        break;

                }
                int iMes = Int32.Parse(numMes);
                int iAno = Int32.Parse(numAno);
                DateTime dData = new DateTime(iAno, iMes, 1);
                var rData = dData.AddMonths(-aMes);
                //string dResust = string.Concat(teste);
                int dMes = rData.Month;
                //MessageBox.Show(dResust);
                int dAno = rData.Year;
                var vAdic = dData.AddMonths(1);
                int vMes = vAdic.Month;
                int dFiltro = 0;
                string vVenc = dgvFunci2.Rows[e.RowIndex].Cells["mes_venc"].FormattedValue.ToString();
                int dVenc = Int32.Parse(vVenc);
                string fMes = "0";

                if (dMes <= 9)
                {
                    fMes = "0" + string.Concat(dMes);
                }
                else
                {
                    fMes = string.Concat(dMes);
                }

                if (vMes == dVenc)
                {
                    var vFiltro = rData.AddMonths(2);
                    dFiltro = vFiltro.Month;
                }
                else
                {
                    var vFiltro = rData.AddMonths(1);
                    dFiltro = vFiltro.Month;
                }



                dNomeOper = dgvFunci2.Rows[e.RowIndex].Cells["nome_operadora"].FormattedValue.ToString();
                dCodOper = dgvFunci2.Rows[e.RowIndex].Cells["codigo_operadora"].FormattedValue.ToString();
                dIdTipo = dgvFunci2.Rows[e.RowIndex].Cells["id_tipo_item_extrato"].FormattedValue.ToString();
                dDescr = dgvFunci2.Rows[e.RowIndex].Cells["descricao_item_extrato"].FormattedValue.ToString();
                dTipo = dgvFunci2.Rows[e.RowIndex].Cells["tipo_valor"].FormattedValue.ToString();
                selNew.SelectedIndex = 1;                
                dgvFunciD.DataSource = acesso.GetDetalhe(dBase, dCiclo, fMes, dAno, dNomeOper, dCodOper, dIdTipo, dDescr, dTipo, dFiltro);
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

        private void dgvFunciZ_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string dBase;
                string dCiclo;
                string dNomeOper;
                string dCodOper;
                string dIdTipo;
                string dDescr;
                string dTipo;
                int aMes = 0;



                switch (dgvFunciZ.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex)
                {
                    case 8:
                        aMes = 3;
                        break;
                    case 9:
                        aMes = 2;
                        break;
                    case 10:
                        aMes = 1;
                        break;
                    default:
                        goto fim;
                }

                dBase = dgvFunciZ.Rows[e.RowIndex].Cells["base"].FormattedValue.ToString();
                switch (numCiclo)
                {
                    case "5-8":
                        dCiclo = "5_a_8";
                        break;
                    case "25-28":
                        dCiclo = "25_a_28";
                        break;
                    default:
                        dCiclo = numCiclo + "_a_" + numCiclo;
                        break;

                }
                int iMes = Int32.Parse(numMes);
                int iAno = Int32.Parse(numAno);
                DateTime dData = new DateTime(iAno, iMes, 1);
                var rData = dData.AddMonths(-aMes);
                //string dResust = string.Concat(teste);
                int dMes = rData.Month;
                //MessageBox.Show(dResust);
                int dAno = rData.Year;
                var vAdic = dData.AddMonths(1);
                int vMes = vAdic.Month;
                int dFiltro = 0;
                string vVenc = dgvFunciZ.Rows[e.RowIndex].Cells["mes_venc"].FormattedValue.ToString();
                int dVenc = Int32.Parse(vVenc);
                string fMes = "0";

                if (dMes <= 9)
                {
                    fMes = "0" + string.Concat(dMes);
                }
                else
                {
                    fMes = string.Concat(dMes);
                }

                if (vMes == dVenc)
                {
                    var vFiltro = rData.AddMonths(2);
                    dFiltro = vFiltro.Month;
                }
                else
                {
                    var vFiltro = rData.AddMonths(1);
                    dFiltro = vFiltro.Month;
                }



                dNomeOper = dgvFunciZ.Rows[e.RowIndex].Cells["nome_operadora"].FormattedValue.ToString();
                dCodOper = dgvFunciZ.Rows[e.RowIndex].Cells["codigo_operadora"].FormattedValue.ToString();
                dIdTipo = dgvFunciZ.Rows[e.RowIndex].Cells["id_tipo_item_extrato"].FormattedValue.ToString();
                dDescr = dgvFunciZ.Rows[e.RowIndex].Cells["descricao_item_extrato"].FormattedValue.ToString();
                dTipo = dgvFunciZ.Rows[e.RowIndex].Cells["tipo_valor"].FormattedValue.ToString();
                selNew.SelectedIndex = 1;
                dgvFunciD.DataSource = acesso.GetDetalhe(dBase, dCiclo, fMes, dAno, dNomeOper, dCodOper, dIdTipo, dDescr, dTipo, dFiltro);
            fim:;
                this.Cursor = Cursors.Default;
            }
            catch
            {

            }
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
                case 2:
                    if (dgvFunciQ.Rows.Count > 0)
                    {
                        try
                        {
                            this.Cursor = Cursors.WaitCursor;
                            XcelApp.Application.Workbooks.Add(Type.Missing);
                            for (int i = 1; i < dgvFunciQ.Columns.Count + 1; i++)
                            {
                                XcelApp.Cells[1, i] = dgvFunciQ.Columns[i - 1].HeaderText;
                            }
                            //
                            for (int i = 0; i < dgvFunciQ.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < dgvFunciQ.Columns.Count; j++)
                                {
                                    XcelApp.Cells[i + 2, j + 1] = dgvFunciQ.Rows[i].Cells[j].Value.ToString();
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
                case 3:
                    if (dgvFunciV.Rows.Count > 0)
                    {
                        try
                        {
                            this.Cursor = Cursors.WaitCursor;
                            XcelApp.Application.Workbooks.Add(Type.Missing);
                            for (int i = 1; i < dgvFunciV.Columns.Count + 1; i++)
                            {
                                XcelApp.Cells[1, i] = dgvFunciV.Columns[i - 1].HeaderText;
                            }
                            //
                            for (int i = 0; i < dgvFunciV.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < dgvFunciV.Columns.Count; j++)
                                {
                                    XcelApp.Cells[i + 2, j + 1] = dgvFunciV.Rows[i].Cells[j].Value.ToString();
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
                case 4:
                    if (dgvFunciZ.Rows.Count > 0)
                    {
                        try
                        {
                            this.Cursor = Cursors.WaitCursor;
                            XcelApp.Application.Workbooks.Add(Type.Missing);
                            for (int i = 1; i < dgvFunciZ.Columns.Count + 1; i++)
                            {
                                XcelApp.Cells[1, i] = dgvFunciZ.Columns[i - 1].HeaderText;
                            }
                            //
                            for (int i = 0; i < dgvFunciZ.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < dgvFunciZ.Columns.Count; j++)
                                {
                                    XcelApp.Cells[i + 2, j + 1] = dgvFunciZ.Rows[i].Cells[j].Value.ToString();
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
                case 5:
                    if (dgvFunciT.Rows.Count > 0)
                    {
                        try
                        {
                            this.Cursor = Cursors.WaitCursor;
                            XcelApp.Application.Workbooks.Add(Type.Missing);
                            for (int i = 1; i < dgvFunciT.Columns.Count + 1; i++)
                            {
                                XcelApp.Cells[1, i] = dgvFunciT.Columns[i - 1].HeaderText;
                            }
                            //
                            for (int i = 0; i < dgvFunciT.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < dgvFunciT.Columns.Count; j++)
                                {
                                    XcelApp.Cells[i + 2, j + 1] = dgvFunciT.Rows[i].Cells[j].Value.ToString();
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
    }
}
