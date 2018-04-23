Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils

Namespace DrawItem
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private WithEvents checkedListBoxControl1 As DevExpress.XtraEditors.CheckedListBoxControl
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.checkedListBoxControl1 = New DevExpress.XtraEditors.CheckedListBoxControl()
			CType(Me.checkedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' checkedListBoxControl1
			' 
			Me.checkedListBoxControl1.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() { New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Red"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Green", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Blue")})
			Me.checkedListBoxControl1.Location = New System.Drawing.Point(7, 7)
			Me.checkedListBoxControl1.Name = "checkedListBoxControl1"
			Me.checkedListBoxControl1.Size = New System.Drawing.Size(185, 129)
			Me.checkedListBoxControl1.TabIndex = 0
'			Me.checkedListBoxControl1.DrawItem += New DevExpress.XtraEditors.ListBoxDrawItemEventHandler(Me.checkedListBoxControl1_DrawItem);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(200, 146)
			Me.Controls.Add(Me.checkedListBoxControl1)
			Me.Name = "Form1"
			Me.Text = "How to change the color of ListBox items"
			CType(Me.checkedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub checkedListBoxControl1_DrawItem(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.ListBoxDrawItemEventArgs) Handles checkedListBoxControl1.DrawItem
			Select Case TryCast(e.Item, String)
				Case "Red"
					e.Appearance.ForeColor = Color.Red
				Case "Green"
					e.Appearance.ForeColor = Color.Green
					If (e.State And DrawItemState.Selected) = 0 Then
						e.Appearance.BackColor = Color.Yellow
					End If
				Case "Blue"
					e.Appearance.ForeColor = Color.Blue
			End Select
		End Sub
	End Class
End Namespace
