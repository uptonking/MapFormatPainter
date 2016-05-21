using System;
using System.Drawing;
using System.Windows.Forms;

namespace MapFormatPainter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolbarPanel = new System.Windows.Forms.Panel();
            this.editPanel = new System.Windows.Forms.Panel();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.startForm2Btn = new Button();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.toolbarPanel.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.Controls.Add(this.axToolbarControl1);
            this.toolbarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Size = new System.Drawing.Size(480, 36);
            this.toolbarPanel.TabIndex = 0;
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.axMapControl1);
            this.editPanel.Location = new System.Drawing.Point(0, 36);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(480, 360);
            this.editPanel.TabIndex = 1;
            // 
            // toolsPanel
            // 
            this.toolsPanel.Controls.Add(this.axTOCControl1);
            this.toolsPanel.Location = new System.Drawing.Point(480, 0);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(120, 396);
            this.toolsPanel.TabIndex = 2;
            //
            //startForm2Btn
            //
            this.startForm2Btn.Location = new Point(640,96);
            this.startForm2Btn.Text = "打开Form2";
            this.startForm2Btn.Name = "startForm2Btn";
            this.startForm2Btn.Size = new System.Drawing.Size(64, 36);
            this.startForm2Btn.TabIndex = 3;
            this.startForm2Btn.UseVisualStyleBackColor = true;
            this.startForm2Btn.Click += new EventHandler(this.startForm2BtnClick);

            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(0, 0);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(480, 360);
            this.axMapControl1.TabIndex = 0;
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.axToolbarControl1.Location = new System.Drawing.Point(0, 0);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(480, 28);
            this.axToolbarControl1.TabIndex = 0;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTOCControl1.Location = new System.Drawing.Point(0, 0);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(120, 396);
            this.axTOCControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.toolsPanel);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.toolbarPanel);
            this.Controls.Add(this.startForm2Btn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.toolbarPanel.ResumeLayout(false);
            this.editPanel.ResumeLayout(false);
            this.toolsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //组件的定义
        private System.Windows.Forms.Panel toolbarPanel;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.Button startForm2Btn;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;

    }
}

