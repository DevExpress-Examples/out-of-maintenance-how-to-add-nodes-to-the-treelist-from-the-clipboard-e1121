Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			dataSet1.DataTable1.AddDataTable1Row("row1", "row2")
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim rows() As String = GetClipboardRows()
			If rows IsNot Nothing Then
				AddRowsToTreeList(rows)
			End If
		End Sub

		Private Sub AddRowsToTreeList(ByVal rows() As String)
			For i As Integer = 0 To rows.Length - 1
				Dim node As TreeListNode = AddNewTreeListNode(treeList1)
				node.SetValue("Column1",rows(i))
			Next i
			treeList1.ExpandAll()
		End Sub

		Private Function GetClipboardRows() As String()
			If Clipboard.GetDataObject().GetDataPresent(GetType(String)) Then

				Dim text As String = Clipboard.GetText()

				If (Not String.IsNullOrEmpty(text)) Then

					Dim s() As String = text.Split(Environment.NewLine.ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
					Return s
				End If

			End If
			Return Nothing
		End Function


		Public Function AddNewTreeListNode(ByVal treeList As TreeList) As TreeListNode
			'RaiseInputNullExceptionIfNull(treeList, "treeList");

			Dim parentTreeListNode As TreeListNode
            If Not (treeList.FocusedNode Is Nothing) Then
                parentTreeListNode = treeList.FocusedNode
            Else
                parentTreeListNode = treeList.Nodes.FirstNode
            End If

			Dim obj(treeList.Columns.Count - 1) As Object
			Dim newTreeListNode As TreeListNode = treeList.AppendNode(obj, parentTreeListNode)
			Return newTreeListNode
			'treeList.FocusedNode = newTreeListNode;
			'treeList.ExpandAll();
		End Function

	End Class
End Namespace