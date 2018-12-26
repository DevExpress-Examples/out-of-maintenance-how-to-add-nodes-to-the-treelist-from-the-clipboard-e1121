Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.dataSet1 = New DataSet1()
            Me.dataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.colColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.button1 = New System.Windows.Forms.Button()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' memoEdit1
			' 
			Me.memoEdit1.EditValue = "Luis" & Constants.vbCrLf & "John" & Constants.vbCrLf & "Mary" & Constants.vbCrLf & "Simon"
			Me.memoEdit1.Location = New System.Drawing.Point(8, 8)
			Me.memoEdit1.Name = "memoEdit1"
			Me.memoEdit1.Size = New System.Drawing.Size(168, 208)
			Me.memoEdit1.TabIndex = 0
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colColumn1, Me.colColumn2})
			Me.treeList1.DataSource = Me.dataTable1BindingSource
			Me.treeList1.Location = New System.Drawing.Point(184, 8)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.Size = New System.Drawing.Size(528, 392)
			Me.treeList1.TabIndex = 1
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "DataSet1"
			Me.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' dataTable1BindingSource
			' 
			Me.dataTable1BindingSource.DataMember = "DataTable1"
			Me.dataTable1BindingSource.DataSource = Me.dataSet1
			' 
			' colColumn1
			' 
			Me.colColumn1.Caption = "Column1"
			Me.colColumn1.FieldName = "Column1"
			Me.colColumn1.Name = "colColumn1"
			Me.colColumn1.Visible = True
			Me.colColumn1.VisibleIndex = 0
			Me.colColumn1.Width = 254
			' 
			' colColumn2
			' 
			Me.colColumn2.Caption = "Column2"
			Me.colColumn2.FieldName = "Column2"
			Me.colColumn2.Name = "colColumn2"
			Me.colColumn2.Visible = True
			Me.colColumn2.VisibleIndex = 1
			Me.colColumn2.Width = 253
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(152, 216)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(27, 23)
			Me.button1.TabIndex = 2
			Me.button1.Text = "->"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(727, 412)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.memoEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private colColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private dataTable1BindingSource As System.Windows.Forms.BindingSource
		Private dataSet1 As DataSet1
		Private WithEvents button1 As System.Windows.Forms.Button
	End Class
End Namespace

