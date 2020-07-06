using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp2
{
    class lib
    {
        public static bool XuatDuLieuSangExcel(System.Windows.Forms.DataGridView dgv)
        {
            try
            {
                {
                    Microsoft.Office.Interop.Excel.ApplicationClass Excel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                    Excel.Application.Workbooks.Add(Type.Missing); 


                    int Col = 0;
                    for (int i = 0; i <= dgv.ColumnCount - 1; i++)
                    {
                        if (!dgv.Columns[i].Visible)
                            continue;
                        Col ++;
                        Excel.Cells[2, Col] = dgv.Columns[i].HeaderText; //Lấy header của từng cột tại DataGridView
                        Excel.Range[Excel.Cells[2, Col], Excel.Cells[2, Col]].Font.Bold = true; //Excel.Cells: mảng 2 chiều [hàng, cột]
                        Excel.Range[Excel.Cells[2, Col], Excel.Cells[2, Col]].Interior.ThemeColor = ConsoleColor.Gray;
                    }
                    string readData = "";
                    Col = 0;
                    for (int i = 0; i <= dgv.ColumnCount - 1; i++) //Lấy dữ liệu từ DataGridView
                    {
                        if (!dgv.Columns[i].Visible)
                            continue;
                        Col ++;
                        
                        for (int Row=0; Row <= dgv.RowCount - 1; Row++)
                        {
                            try
                            {
                                readData = dgv[i, Row].Value.ToString(); //dataGridView:mảng 2 chiều [cột, hàng] 
                            }
                            catch (Exception Ex)
                            {
                                readData = "";
                            }
                            Excel.Cells[Row + 3, Col] = readData;
                        }
                    }

                    #region format
                    Excel.Columns.EntireRow.AutoFit();
                    Excel.Columns.EntireColumn.AutoFit();
                    Excel.Rows.EntireColumn.AutoFit();
                    Excel.Rows.EntireRow.AutoFit();
                    Excel.Cells.VerticalAlignment = 2;
                    Excel.Cells.HorizontalAlignment = 3; //căn giữa
                    Excel.Cells.EntireColumn.AutoFit();
                    // Tạo đường bao
                    int width = dgv.ColumnCount;
                    int height = dgv.RowCount+1;
                    Excel.Range[Excel.Cells[1, 1], Excel.Cells[height, width]].Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                    //Merge ô đầu tiên
                    Excel.Range[Excel.Cells[1, 1], Excel.Cells[1, width]].Merge();
                    //In màu giá trị trung bình
                    if (dgv[0,height-3].Value.ToString() == "TB")
                    {
                        Excel.Range[Excel.Cells[height,1], Excel.Cells[height,width]].Font.Bold = true;
                        Excel.Range[Excel.Cells[height, 2], Excel.Cells[height, 2]].Font.Color = Color.Red;
                        Excel.Range[Excel.Cells[height, 3], Excel.Cells[height, 3]].Font.Color = Color.Blue;

                    }
                    #endregion
                    Excel.Visible = true;

                }
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Không tạo được file Excel\nXem lại code");
            }
            return false;
        }
    }
}
