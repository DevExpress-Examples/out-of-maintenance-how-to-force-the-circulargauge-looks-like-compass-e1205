Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace Compass
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub OnCustomTickmarkText(ByVal ea As DevExpress.XtraGauges.Core.Model.CustomTickmarkTextEventArgs) Handles arcScaleComponent1.CustomTickmarkText
			Dim text As String = ea.Text
			Select Case ea.Text
				Case "360"
					text = "-N-"
				Case "270"
					text = "-W-"
				Case "180"
					text = "-S-"
				Case "90"
					text = "-E-"
			End Select
			ea.Result = text
		End Sub

		Private Function ToAngle(ByVal angle As Integer) As Single
			If angle > 0 Then
				angle = angle Mod 360
			Else
				angle = 360 - Math.Abs(angle) Mod 360
			End If
			Return CSng(angle)
		End Function

		Private Sub trackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBarControl1.EditValueChanged
			Me.arcScaleComponent1.Value = ToAngle(trackBarControl1.Value)

		End Sub
	End Class
End Namespace