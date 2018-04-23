using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataSet1.DataTable1.AddDataTable1Row("row1", "row2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] rows = GetClipboardRows();
            if (rows != null)
                AddRowsToTreeList(rows);
        }

        private void AddRowsToTreeList(string[] rows)
        {
            for (int i = 0; i < rows.Length; i++)
            {
                TreeListNode node = AddNewTreeListNode(treeList1);
                node.SetValue("Column1",rows[i]);
            }
            treeList1.ExpandAll();
        }

        private string[] GetClipboardRows()
        {
            if (Clipboard.GetDataObject().GetDataPresent(typeof(string)))
            {

                string text = Clipboard.GetText();

                if (!String.IsNullOrEmpty(text))
                {

                    string[] s = text.Split(Environment.NewLine.ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                    return s;
                }

            }
            return null;
        }


        public TreeListNode AddNewTreeListNode(TreeList treeList)
        {
            //RaiseInputNullExceptionIfNull(treeList, "treeList");

            TreeListNode parentTreeListNode = treeList.FocusedNode ?? treeList.Nodes.FirstNode;

            object[] obj = new object[treeList.Columns.Count];
            TreeListNode newTreeListNode = treeList.AppendNode(obj, parentTreeListNode);
            return newTreeListNode;
            //treeList.FocusedNode = newTreeListNode;
            //treeList.ExpandAll();
        }

    }
}