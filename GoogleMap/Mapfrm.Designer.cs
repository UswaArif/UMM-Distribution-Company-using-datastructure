﻿
namespace GoogleMap
{
    partial class Mapfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Lattxt = new System.Windows.Forms.TextBox();
            this.btnLoadMap = new System.Windows.Forms.Button();
            this.Longtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gMapDisplayArea = new GMap.NET.WindowsForms.GMapControl();
            this.long2txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lat2txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GetRoute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1109, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Lattxt
            // 
            this.Lattxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lattxt.Location = new System.Drawing.Point(1115, 118);
            this.Lattxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Lattxt.Name = "Lattxt";
            this.Lattxt.Size = new System.Drawing.Size(180, 29);
            this.Lattxt.TabIndex = 3;
            // 
            // btnLoadMap
            // 
            this.btnLoadMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadMap.Location = new System.Drawing.Point(1157, 639);
            this.btnLoadMap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLoadMap.Name = "btnLoadMap";
            this.btnLoadMap.Size = new System.Drawing.Size(138, 42);
            this.btnLoadMap.TabIndex = 4;
            this.btnLoadMap.Text = "button1";
            this.btnLoadMap.UseVisualStyleBackColor = true;
            this.btnLoadMap.Click += new System.EventHandler(this.btnLoadMap_Click);
            // 
            // Longtxt
            // 
            this.Longtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Longtxt.Location = new System.Drawing.Point(1115, 234);
            this.Longtxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Longtxt.Name = "Longtxt";
            this.Longtxt.Size = new System.Drawing.Size(180, 29);
            this.Longtxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1109, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // gMapDisplayArea
            // 
            this.gMapDisplayArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gMapDisplayArea.Bearing = 0F;
            this.gMapDisplayArea.CanDragMap = true;
            this.gMapDisplayArea.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapDisplayArea.GrayScaleMode = false;
            this.gMapDisplayArea.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapDisplayArea.LevelsKeepInMemory = 5;
            this.gMapDisplayArea.Location = new System.Drawing.Point(6, 0);
            this.gMapDisplayArea.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gMapDisplayArea.MarkersEnabled = true;
            this.gMapDisplayArea.MaxZoom = 2;
            this.gMapDisplayArea.MinZoom = 2;
            this.gMapDisplayArea.MouseWheelZoomEnabled = true;
            this.gMapDisplayArea.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapDisplayArea.Name = "gMapDisplayArea";
            this.gMapDisplayArea.NegativeMode = false;
            this.gMapDisplayArea.PolygonsEnabled = true;
            this.gMapDisplayArea.RetryLoadTile = 0;
            this.gMapDisplayArea.RoutesEnabled = true;
            this.gMapDisplayArea.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapDisplayArea.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapDisplayArea.ShowTileGridLines = false;
            this.gMapDisplayArea.Size = new System.Drawing.Size(1036, 836);
            this.gMapDisplayArea.TabIndex = 7;
            this.gMapDisplayArea.Zoom = 0D;
            // 
            // long2txt
            // 
            this.long2txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.long2txt.Location = new System.Drawing.Point(1116, 550);
            this.long2txt.Margin = new System.Windows.Forms.Padding(6);
            this.long2txt.Name = "long2txt";
            this.long2txt.Size = new System.Drawing.Size(180, 29);
            this.long2txt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1110, 493);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // lat2txt
            // 
            this.lat2txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lat2txt.Location = new System.Drawing.Point(1116, 434);
            this.lat2txt.Margin = new System.Windows.Forms.Padding(6);
            this.lat2txt.Name = "lat2txt";
            this.lat2txt.Size = new System.Drawing.Size(180, 29);
            this.lat2txt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1110, 377);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // GetRoute
            // 
            this.GetRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetRoute.Location = new System.Drawing.Point(1158, 693);
            this.GetRoute.Margin = new System.Windows.Forms.Padding(6);
            this.GetRoute.Name = "GetRoute";
            this.GetRoute.Size = new System.Drawing.Size(138, 42);
            this.GetRoute.TabIndex = 12;
            this.GetRoute.Text = "button1";
            this.GetRoute.UseVisualStyleBackColor = true;
            this.GetRoute.Click += new System.EventHandler(this.GetRoute_Click);
            // 
            // Mapfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.GetRoute);
            this.Controls.Add(this.long2txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lat2txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gMapDisplayArea);
            this.Controls.Add(this.Longtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoadMap);
            this.Controls.Add(this.Lattxt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Mapfrm";
            this.Text = "Mapfrm";
            this.Load += new System.EventHandler(this.Mapfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Lattxt;
        private System.Windows.Forms.Button btnLoadMap;
        private System.Windows.Forms.TextBox Longtxt;
        private System.Windows.Forms.Label label2;
        private GMap.NET.WindowsForms.GMapControl gMapDisplayArea;
        private System.Windows.Forms.TextBox long2txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lat2txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GetRoute;
    }
}