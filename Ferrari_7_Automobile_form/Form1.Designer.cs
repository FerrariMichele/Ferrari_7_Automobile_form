namespace Ferrari_7_Automobile_form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBrake = new System.Windows.Forms.Button();
            this.buttonThrottle = new System.Windows.Forms.Button();
            this.buttonOnOff = new System.Windows.Forms.Button();
            this.buttonUpShift = new System.Windows.Forms.Button();
            this.buttonDownShift = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelGear = new System.Windows.Forms.Label();
            this.labelOnOff = new System.Windows.Forms.Label();
            this.buttonOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBrake
            // 
            this.buttonBrake.Location = new System.Drawing.Point(91, 377);
            this.buttonBrake.Name = "buttonBrake";
            this.buttonBrake.Size = new System.Drawing.Size(86, 23);
            this.buttonBrake.TabIndex = 0;
            this.buttonBrake.Text = "Freno";
            this.buttonBrake.UseVisualStyleBackColor = true;
            this.buttonBrake.Click += new System.EventHandler(this.buttonBrake_Click);
            // 
            // buttonThrottle
            // 
            this.buttonThrottle.Location = new System.Drawing.Point(224, 377);
            this.buttonThrottle.Name = "buttonThrottle";
            this.buttonThrottle.Size = new System.Drawing.Size(86, 23);
            this.buttonThrottle.TabIndex = 1;
            this.buttonThrottle.Text = "Acceleratore";
            this.buttonThrottle.UseVisualStyleBackColor = true;
            this.buttonThrottle.Click += new System.EventHandler(this.buttonThrottle_Click);
            // 
            // buttonOnOff
            // 
            this.buttonOnOff.Location = new System.Drawing.Point(511, 194);
            this.buttonOnOff.Name = "buttonOnOff";
            this.buttonOnOff.Size = new System.Drawing.Size(86, 23);
            this.buttonOnOff.TabIndex = 2;
            this.buttonOnOff.Text = "Accensione";
            this.buttonOnOff.UseVisualStyleBackColor = true;
            this.buttonOnOff.Click += new System.EventHandler(this.buttonOnOff_Click);
            // 
            // buttonUpShift
            // 
            this.buttonUpShift.Location = new System.Drawing.Point(511, 317);
            this.buttonUpShift.Name = "buttonUpShift";
            this.buttonUpShift.Size = new System.Drawing.Size(86, 23);
            this.buttonUpShift.TabIndex = 3;
            this.buttonUpShift.Text = "Marcia SU";
            this.buttonUpShift.UseVisualStyleBackColor = true;
            this.buttonUpShift.Click += new System.EventHandler(this.buttonUpShift_Click);
            // 
            // buttonDownShift
            // 
            this.buttonDownShift.Location = new System.Drawing.Point(511, 346);
            this.buttonDownShift.Name = "buttonDownShift";
            this.buttonDownShift.Size = new System.Drawing.Size(86, 23);
            this.buttonDownShift.TabIndex = 4;
            this.buttonDownShift.Text = "MarciaGiu";
            this.buttonDownShift.UseVisualStyleBackColor = true;
            this.buttonDownShift.Click += new System.EventHandler(this.buttonDownShift_Click);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSpeed.Location = new System.Drawing.Point(152, 141);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(106, 65);
            this.labelSpeed.TabIndex = 5;
            this.labelSpeed.Text = "000";
            // 
            // labelGear
            // 
            this.labelGear.AutoSize = true;
            this.labelGear.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGear.Location = new System.Drawing.Point(603, 310);
            this.labelGear.Name = "labelGear";
            this.labelGear.Size = new System.Drawing.Size(54, 65);
            this.labelGear.TabIndex = 6;
            this.labelGear.Text = "0";
            // 
            // labelOnOff
            // 
            this.labelOnOff.AutoSize = true;
            this.labelOnOff.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOnOff.Location = new System.Drawing.Point(603, 194);
            this.labelOnOff.Name = "labelOnOff";
            this.labelOnOff.Size = new System.Drawing.Size(64, 45);
            this.labelOnOff.TabIndex = 7;
            this.labelOnOff.Text = "Off";
            // 
            // buttonOff
            // 
            this.buttonOff.Location = new System.Drawing.Point(511, 223);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(86, 23);
            this.buttonOff.TabIndex = 8;
            this.buttonOff.Text = "Spegnimento";
            this.buttonOff.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.labelOnOff);
            this.Controls.Add(this.labelGear);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.buttonDownShift);
            this.Controls.Add(this.buttonUpShift);
            this.Controls.Add(this.buttonOnOff);
            this.Controls.Add(this.buttonThrottle);
            this.Controls.Add(this.buttonBrake);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonBrake;
        private Button buttonThrottle;
        private Button buttonOnOff;
        private Button buttonUpShift;
        private Button buttonDownShift;
        private Label labelSpeed;
        private Label labelGear;
        private Label labelOnOff;
        private Button buttonOff;
    }
}