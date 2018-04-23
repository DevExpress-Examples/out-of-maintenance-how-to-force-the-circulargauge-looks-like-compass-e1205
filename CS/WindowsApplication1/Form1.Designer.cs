namespace Compass {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
			this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
			this.arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
			this.arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
			this.arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
			this.trackBarControl1 = new DevExpress.XtraEditors.TrackBarControl();
			((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gaugeControl1
			// 
			this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge1});
			this.gaugeControl1.Location = new System.Drawing.Point(12, 12);
			this.gaugeControl1.Name = "gaugeControl1";
			this.gaugeControl1.Size = new System.Drawing.Size(365, 310);
			this.gaugeControl1.TabIndex = 0;
			// 
			// circularGauge1
			// 
			this.circularGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent1});
			this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 353, 298);
			this.circularGauge1.Name = "Gauge0";
			this.circularGauge1.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent1});
			this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent1});
			// 
			// arcScaleBackgroundLayerComponent1
			// 
			this.arcScaleBackgroundLayerComponent1.ArcScale = this.arcScaleComponent1;
			this.arcScaleBackgroundLayerComponent1.Name = "Gauge0_BackgroundLayer1";
			this.arcScaleBackgroundLayerComponent1.ZOrder = 1000;
			// 
			// arcScaleComponent1
			// 
			this.arcScaleComponent1.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 11F);
			this.arcScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
			this.arcScaleComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
			this.arcScaleComponent1.EndAngle = 90F;
			this.arcScaleComponent1.MajorTickCount = 13;
			this.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
			this.arcScaleComponent1.MajorTickmark.ShapeOffset = -3.5F;
			this.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4;
			this.arcScaleComponent1.MajorTickmark.ShowFirst = false;
			this.arcScaleComponent1.MajorTickmark.TextOffset = -15F;
			this.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
			this.arcScaleComponent1.MaxValue = 360F;
			this.arcScaleComponent1.MinorTickCount = 4;
			this.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3;
			this.arcScaleComponent1.Name = "Gauge0_Scale1";
			this.arcScaleComponent1.StartAngle = -270F;
			this.arcScaleComponent1.CustomTickmarkText += new DevExpress.XtraGauges.Core.Model.CustomTickmarkTextEventHandler(this.OnCustomTickmarkText);
			// 
			// arcScaleNeedleComponent1
			// 
			this.arcScaleNeedleComponent1.ArcScale = this.arcScaleComponent1;
			this.arcScaleNeedleComponent1.EndOffset = 25F;
			this.arcScaleNeedleComponent1.Name = "Gauge0_Needle1";
			this.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style3;
			this.arcScaleNeedleComponent1.StartOffset = -60F;
			this.arcScaleNeedleComponent1.ZOrder = -50;
			// 
			// trackBarControl1
			// 
			this.trackBarControl1.EditValue = null;
			this.trackBarControl1.Location = new System.Drawing.Point(12, 344);
			this.trackBarControl1.Name = "trackBarControl1";
			this.trackBarControl1.Properties.Maximum = 500;
			this.trackBarControl1.Properties.Minimum = -500;
			this.trackBarControl1.Properties.TickFrequency = 25;
			this.trackBarControl1.Size = new System.Drawing.Size(365, 45);
			this.trackBarControl1.TabIndex = 1;
			this.trackBarControl1.EditValueChanged += new System.EventHandler(this.trackBarControl1_EditValueChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 401);
			this.Controls.Add(this.trackBarControl1);
			this.Controls.Add(this.gaugeControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
        private DevExpress.XtraEditors.TrackBarControl trackBarControl1;
    }
}

