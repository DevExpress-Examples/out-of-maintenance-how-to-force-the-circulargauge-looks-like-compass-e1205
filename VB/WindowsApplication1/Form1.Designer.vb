Imports Microsoft.VisualBasic
Imports System
Namespace Compass
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
			Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
			Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.trackBarControl1 = New DevExpress.XtraEditors.TrackBarControl()
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gaugeControl1
			' 
			Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.circularGauge1})
			Me.gaugeControl1.Location = New System.Drawing.Point(12, 12)
			Me.gaugeControl1.Name = "gaugeControl1"
			Me.gaugeControl1.Size = New System.Drawing.Size(365, 310)
			Me.gaugeControl1.TabIndex = 0
			' 
			' circularGauge1
			' 
			Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() { Me.arcScaleBackgroundLayerComponent1})
			Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 353, 298)
			Me.circularGauge1.Name = "Gauge0"
			Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() { Me.arcScaleNeedleComponent1})
			Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() { Me.arcScaleComponent1})
			' 
			' arcScaleBackgroundLayerComponent1
			' 
			Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleBackgroundLayerComponent1.Name = "Gauge0_BackgroundLayer1"
			Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
			' 
			' arcScaleComponent1
			' 
			Me.arcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 11F)
			Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
			Me.arcScaleComponent1.EndAngle = 90F
			Me.arcScaleComponent1.MajorTickCount = 13
			Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -3.5F
			Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
			Me.arcScaleComponent1.MajorTickmark.ShowFirst = False
			Me.arcScaleComponent1.MajorTickmark.TextOffset = -15F
			Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent1.MaxValue = 360F
			Me.arcScaleComponent1.MinorTickCount = 4
			Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
			Me.arcScaleComponent1.Name = "Gauge0_Scale1"
			Me.arcScaleComponent1.StartAngle = -270F
'			Me.arcScaleComponent1.CustomTickmarkText += New DevExpress.XtraGauges.Core.Model.CustomTickmarkTextEventHandler(Me.OnCustomTickmarkText);
			' 
			' arcScaleNeedleComponent1
			' 
			Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleNeedleComponent1.EndOffset = 25F
			Me.arcScaleNeedleComponent1.Name = "Gauge0_Needle1"
			Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style3
			Me.arcScaleNeedleComponent1.StartOffset = -60F
			Me.arcScaleNeedleComponent1.ZOrder = -50
			' 
			' trackBarControl1
			' 
			Me.trackBarControl1.EditValue = Nothing
			Me.trackBarControl1.Location = New System.Drawing.Point(12, 344)
			Me.trackBarControl1.Name = "trackBarControl1"
			Me.trackBarControl1.Properties.Maximum = 500
			Me.trackBarControl1.Properties.Minimum = -500
			Me.trackBarControl1.Properties.TickFrequency = 25
			Me.trackBarControl1.Size = New System.Drawing.Size(365, 45)
			Me.trackBarControl1.TabIndex = 1
'			Me.trackBarControl1.EditValueChanged += New System.EventHandler(Me.trackBarControl1_EditValueChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(401, 401)
			Me.Controls.Add(Me.trackBarControl1)
			Me.Controls.Add(Me.gaugeControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
		Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private WithEvents arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private WithEvents trackBarControl1 As DevExpress.XtraEditors.TrackBarControl
	End Class
End Namespace

