namespace TSP
{
    partial class ChartPlotter
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
            this.plotViewOptimal = new OxyPlot.WindowsForms.PlotView();
            this.txtOptimal = new System.Windows.Forms.TextBox();
            this.plotViewInitial = new OxyPlot.WindowsForms.PlotView();
            this.txtInitialRoute = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtDistanceInitial = new System.Windows.Forms.TextBox();
            this.txtDistanceOptimal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // plotViewOptimal
            // 
            this.plotViewOptimal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.plotViewOptimal.Location = new System.Drawing.Point(660, 29);
            this.plotViewOptimal.Name = "plotViewOptimal";
            this.plotViewOptimal.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotViewOptimal.Size = new System.Drawing.Size(638, 467);
            this.plotViewOptimal.TabIndex = 0;
            this.plotViewOptimal.Text = "plotView1";
            this.plotViewOptimal.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotViewOptimal.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotViewOptimal.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // txtOptimal
            // 
            this.txtOptimal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptimal.Location = new System.Drawing.Point(660, 519);
            this.txtOptimal.Name = "txtOptimal";
            this.txtOptimal.Size = new System.Drawing.Size(638, 25);
            this.txtOptimal.TabIndex = 1;
            // 
            // plotViewInitial
            // 
            this.plotViewInitial.BackColor = System.Drawing.SystemColors.Info;
            this.plotViewInitial.Location = new System.Drawing.Point(12, 29);
            this.plotViewInitial.Name = "plotViewInitial";
            this.plotViewInitial.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotViewInitial.Size = new System.Drawing.Size(638, 467);
            this.plotViewInitial.TabIndex = 2;
            this.plotViewInitial.Text = "plotView2";
            this.plotViewInitial.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotViewInitial.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotViewInitial.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // txtInitialRoute
            // 
            this.txtInitialRoute.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitialRoute.Location = new System.Drawing.Point(12, 519);
            this.txtInitialRoute.Name = "txtInitialRoute";
            this.txtInitialRoute.Size = new System.Drawing.Size(638, 25);
            this.txtInitialRoute.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox3.Location = new System.Drawing.Point(12, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(638, 33);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Initial Route";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox4.Location = new System.Drawing.Point(660, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(638, 33);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Optimal Route";
            // 
            // txtDistanceInitial
            // 
            this.txtDistanceInitial.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistanceInitial.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDistanceInitial.Location = new System.Drawing.Point(13, 560);
            this.txtDistanceInitial.Name = "txtDistanceInitial";
            this.txtDistanceInitial.Size = new System.Drawing.Size(638, 35);
            this.txtDistanceInitial.TabIndex = 6;
            // 
            // txtDistanceOptimal
            // 
            this.txtDistanceOptimal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistanceOptimal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDistanceOptimal.Location = new System.Drawing.Point(660, 560);
            this.txtDistanceOptimal.Name = "txtDistanceOptimal";
            this.txtDistanceOptimal.Size = new System.Drawing.Size(638, 35);
            this.txtDistanceOptimal.TabIndex = 7;
            // 
            // ChartPlotter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1310, 613);
            this.Controls.Add(this.txtDistanceOptimal);
            this.Controls.Add(this.txtDistanceInitial);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtInitialRoute);
            this.Controls.Add(this.plotViewInitial);
            this.Controls.Add(this.txtOptimal);
            this.Controls.Add(this.plotViewOptimal);
            this.Name = "ChartPlotter";
            this.Text = "TSP Chart ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotViewOptimal;
        private System.Windows.Forms.TextBox txtOptimal;
        private OxyPlot.WindowsForms.PlotView plotViewInitial;
        private System.Windows.Forms.TextBox txtInitialRoute;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtDistanceInitial;
        private System.Windows.Forms.TextBox txtDistanceOptimal;
    }
}