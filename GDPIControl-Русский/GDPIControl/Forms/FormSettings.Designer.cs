﻿namespace GDPIControl.Forms
{
    partial class FormSettings
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
            CB_Minimized = new System.Windows.Forms.CheckBox();
            flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            CB_AutostartGDPIControl = new System.Windows.Forms.CheckBox();
            CB_AutostartGDPI = new System.Windows.Forms.CheckBox();
            CB_StopDriver = new System.Windows.Forms.CheckBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            B_OK = new System.Windows.Forms.Button();
            B_Cancel = new System.Windows.Forms.Button();
            flowLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // CB_Minimized
            // 
            CB_Minimized.AutoSize = true;
            CB_Minimized.Location = new System.Drawing.Point(3, 28);
            CB_Minimized.Name = "CB_Minimized";
            CB_Minimized.Size = new System.Drawing.Size(163, 19);
            CB_Minimized.TabIndex = 7;
            CB_Minimized.Text = "Запуск в свернутом виде";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.Controls.Add(CB_AutostartGDPIControl);
            flowLayoutPanel3.Controls.Add(CB_Minimized);
            flowLayoutPanel3.Controls.Add(CB_AutostartGDPI);
            flowLayoutPanel3.Controls.Add(CB_StopDriver);
            flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new System.Drawing.Size(295, 100);
            flowLayoutPanel3.TabIndex = 8;
            flowLayoutPanel3.WrapContents = false;
            // 
            // CB_AutostartGDPIControl
            // 
            CB_AutostartGDPIControl.AutoSize = true;
            CB_AutostartGDPIControl.Location = new System.Drawing.Point(3, 3);
            CB_AutostartGDPIControl.Name = "CB_AutostartGDPIControl";
            CB_AutostartGDPIControl.Size = new System.Drawing.Size(226, 19);
            CB_AutostartGDPIControl.TabIndex = 7;
            CB_AutostartGDPIControl.Text = "Автоматический запуск GDPIControl";
            // 
            // CB_AutostartGDPI
            // 
            CB_AutostartGDPI.AutoSize = true;
            CB_AutostartGDPI.Location = new System.Drawing.Point(3, 53);
            CB_AutostartGDPI.Name = "CB_AutostartGDPI";
            CB_AutostartGDPI.Size = new System.Drawing.Size(285, 19);
            CB_AutostartGDPI.TabIndex = 7;
            CB_AutostartGDPI.Text = "Запустить GoodbyeDPI при запуске GDPControl";
            // 
            // CB_StopDriver
            // 
            CB_StopDriver.AutoSize = true;
            CB_StopDriver.Location = new System.Drawing.Point(3, 78);
            CB_StopDriver.Name = "CB_StopDriver";
            CB_StopDriver.Size = new System.Drawing.Size(295, 19);
            CB_StopDriver.TabIndex = 7;
            CB_StopDriver.Text = "Остановить WinDivert при выходе из GDPIControl";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 128);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(295, 33);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(B_OK);
            flowLayoutPanel1.Controls.Add(B_Cancel);
            flowLayoutPanel1.Location = new System.Drawing.Point(156, 0);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(139, 33);
            flowLayoutPanel1.TabIndex = 9;
            flowLayoutPanel1.WrapContents = false;
            // 
            // B_OK
            // 
            B_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            B_OK.AutoSize = true;
            B_OK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            B_OK.Image = icons8.Ok16;
            B_OK.Location = new System.Drawing.Point(3, 3);
            B_OK.Name = "B_OK";
            B_OK.Padding = new System.Windows.Forms.Padding(1);
            B_OK.Size = new System.Drawing.Size(50, 27);
            B_OK.TabIndex = 1;
            B_OK.Text = "Ок";
            B_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            B_OK.UseVisualStyleBackColor = true;
            B_OK.Click += B_OK_Click;
            // 
            // B_Cancel
            // 
            B_Cancel.AutoSize = true;
            B_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            B_Cancel.Image = icons8.Cancel16;
            B_Cancel.Location = new System.Drawing.Point(59, 3);
            B_Cancel.Name = "B_Cancel";
            B_Cancel.Padding = new System.Windows.Forms.Padding(1);
            B_Cancel.Size = new System.Drawing.Size(77, 27);
            B_Cancel.TabIndex = 5;
            B_Cancel.Text = "Отмена";
            B_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            B_Cancel.UseVisualStyleBackColor = true;
            B_Cancel.Click += B_Cancel_Click;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            ClientSize = new System.Drawing.Size(295, 161);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel3);
            MaximumSize = new System.Drawing.Size(400, 200);
            MinimumSize = new System.Drawing.Size(300, 180);
            Name = "FormSettings";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Настройки";
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox CB_Minimized;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox CB_AutostartGDPIControl;
        private System.Windows.Forms.CheckBox CB_AutostartGDPI;
        private System.Windows.Forms.CheckBox CB_StopDriver;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button B_OK;
        private System.Windows.Forms.Button B_Cancel;
    }
}