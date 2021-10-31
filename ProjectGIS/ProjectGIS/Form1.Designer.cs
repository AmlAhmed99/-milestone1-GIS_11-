namespace ProjectGIS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addmaps = new System.Windows.Forms.Button();
            this.cordinatexy = new System.Windows.Forms.Label();
            this.listShowMaps = new System.Windows.Forms.ListBox();
            this.loadlayers = new System.Windows.Forms.Button();
            this.listLayers = new System.Windows.Forms.ListBox();
            this.addlayerbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.visiblebutton = new System.Windows.Forms.Button();
            this.visibality_check = new System.Windows.Forms.CheckBox();
            this.removelayer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.zoomin = new System.Windows.Forms.Button();
            this.extent = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.defquery = new System.Windows.Forms.Button();
            this.userquery = new System.Windows.Forms.TextBox();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // addmaps
            // 
            this.addmaps.Location = new System.Drawing.Point(163, 49);
            this.addmaps.Name = "addmaps";
            this.addmaps.Size = new System.Drawing.Size(113, 49);
            this.addmaps.TabIndex = 0;
            this.addmaps.Text = "Load Map";
            this.addmaps.UseVisualStyleBackColor = true;
            this.addmaps.Click += new System.EventHandler(this.addmaps_Click);
            // 
            // cordinatexy
            // 
            this.cordinatexy.AutoSize = true;
            this.cordinatexy.Location = new System.Drawing.Point(62, 19);
            this.cordinatexy.Name = "cordinatexy";
            this.cordinatexy.Size = new System.Drawing.Size(64, 13);
            this.cordinatexy.TabIndex = 2;
            this.cordinatexy.Text = "cordinatexy";
            // 
            // listShowMaps
            // 
            this.listShowMaps.FormattingEnabled = true;
            this.listShowMaps.Location = new System.Drawing.Point(23, 28);
            this.listShowMaps.Name = "listShowMaps";
            this.listShowMaps.Size = new System.Drawing.Size(120, 95);
            this.listShowMaps.TabIndex = 3;
            // 
            // loadlayers
            // 
            this.loadlayers.Location = new System.Drawing.Point(163, 177);
            this.loadlayers.Name = "loadlayers";
            this.loadlayers.Size = new System.Drawing.Size(120, 45);
            this.loadlayers.TabIndex = 4;
            this.loadlayers.Text = "Load Layers";
            this.loadlayers.UseVisualStyleBackColor = true;
            this.loadlayers.Click += new System.EventHandler(this.loadlayers_Click);
            // 
            // listLayers
            // 
            this.listLayers.FormattingEnabled = true;
            this.listLayers.Location = new System.Drawing.Point(23, 156);
            this.listLayers.Name = "listLayers";
            this.listLayers.Size = new System.Drawing.Size(120, 95);
            this.listLayers.TabIndex = 6;
            // 
            // addlayerbtn
            // 
            this.addlayerbtn.Location = new System.Drawing.Point(23, 337);
            this.addlayerbtn.Name = "addlayerbtn";
            this.addlayerbtn.Size = new System.Drawing.Size(120, 46);
            this.addlayerbtn.TabIndex = 7;
            this.addlayerbtn.Text = "Add New Layer";
            this.addlayerbtn.UseVisualStyleBackColor = true;
            this.addlayerbtn.Click += new System.EventHandler(this.addlayerbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.visiblebutton);
            this.groupBox1.Controls.Add(this.visibality_check);
            this.groupBox1.Controls.Add(this.removelayer);
            this.groupBox1.Controls.Add(this.loadlayers);
            this.groupBox1.Controls.Add(this.addlayerbtn);
            this.groupBox1.Controls.Add(this.addmaps);
            this.groupBox1.Controls.Add(this.listLayers);
            this.groupBox1.Controls.Add(this.listShowMaps);
            this.groupBox1.Location = new System.Drawing.Point(847, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 401);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Map";
            // 
            // visiblebutton
            // 
            this.visiblebutton.Location = new System.Drawing.Point(163, 264);
            this.visiblebutton.Name = "visiblebutton";
            this.visiblebutton.Size = new System.Drawing.Size(120, 46);
            this.visiblebutton.TabIndex = 10;
            this.visiblebutton.Text = "Apply Visibility";
            this.visiblebutton.UseVisualStyleBackColor = true;
            this.visiblebutton.Click += new System.EventHandler(this.visiblebutton_Click);
            // 
            // visibality_check
            // 
            this.visibality_check.AutoSize = true;
            this.visibality_check.Location = new System.Drawing.Point(37, 280);
            this.visibality_check.Name = "visibality_check";
            this.visibality_check.Size = new System.Drawing.Size(91, 17);
            this.visibality_check.TabIndex = 9;
            this.visibality_check.Text = "Hide visibality";
            this.visibality_check.UseVisualStyleBackColor = true;
            this.visibality_check.CheckedChanged += new System.EventHandler(this.visibality_check_CheckedChanged);
            // 
            // removelayer
            // 
            this.removelayer.Location = new System.Drawing.Point(163, 337);
            this.removelayer.Name = "removelayer";
            this.removelayer.Size = new System.Drawing.Size(120, 46);
            this.removelayer.TabIndex = 8;
            this.removelayer.Text = "Remove New Layer";
            this.removelayer.UseVisualStyleBackColor = true;
            this.removelayer.Click += new System.EventHandler(this.removelayer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cordinatexy);
            this.groupBox2.Location = new System.Drawing.Point(29, 527);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 43);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cordinates";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.zoomin);
            this.groupBox3.Controls.Add(this.extent);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 56);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zoom";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(117, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 31);
            this.button2.TabIndex = 15;
            this.button2.Text = "Zoom Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // zoomin
            // 
            this.zoomin.BackColor = System.Drawing.Color.White;
            this.zoomin.FlatAppearance.BorderSize = 0;
            this.zoomin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomin.Location = new System.Drawing.Point(31, 16);
            this.zoomin.Name = "zoomin";
            this.zoomin.Size = new System.Drawing.Size(68, 31);
            this.zoomin.TabIndex = 14;
            this.zoomin.Text = "Zoom In";
            this.zoomin.UseVisualStyleBackColor = false;
            this.zoomin.Click += new System.EventHandler(this.zoomin_Click_1);
            // 
            // extent
            // 
            this.extent.BackColor = System.Drawing.Color.White;
            this.extent.FlatAppearance.BorderSize = 0;
            this.extent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extent.Location = new System.Drawing.Point(201, 16);
            this.extent.Name = "extent";
            this.extent.Size = new System.Drawing.Size(70, 31);
            this.extent.TabIndex = 13;
            this.extent.Text = "Full Extent";
            this.extent.UseVisualStyleBackColor = false;
            this.extent.Click += new System.EventHandler(this.extent_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.defquery);
            this.groupBox4.Controls.Add(this.userquery);
            this.groupBox4.Location = new System.Drawing.Point(845, 419);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 159);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Defination Query";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Where Clause:";
            // 
            // defquery
            // 
            this.defquery.Location = new System.Drawing.Point(191, 108);
            this.defquery.Name = "defquery";
            this.defquery.Size = new System.Drawing.Size(120, 45);
            this.defquery.TabIndex = 10;
            this.defquery.Text = "Make Defination Query";
            this.defquery.UseVisualStyleBackColor = true;
            this.defquery.Click += new System.EventHandler(this.defquery_Click);
            // 
            // userquery
            // 
            this.userquery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userquery.Location = new System.Drawing.Point(6, 59);
            this.userquery.Multiline = true;
            this.userquery.Name = "userquery";
            this.userquery.Size = new System.Drawing.Size(196, 43);
            this.userquery.TabIndex = 0;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Location = new System.Drawing.Point(12, 77);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(827, 444);
            this.axMapControl1.TabIndex = 1;
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_OnMouseDown);
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 590);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.axMapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addmaps;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private System.Windows.Forms.Label cordinatexy;
        private System.Windows.Forms.ListBox listShowMaps;
        private System.Windows.Forms.Button loadlayers;
        private System.Windows.Forms.ListBox listLayers;
        private System.Windows.Forms.Button addlayerbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox visibality_check;
        private System.Windows.Forms.Button removelayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button defquery;
        private System.Windows.Forms.TextBox userquery;
        private System.Windows.Forms.Button visiblebutton;
        private System.Windows.Forms.Button extent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button zoomin;
    }
}

