namespace Art_Gallery.UI_Layer
{
    partial class UploadWork
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
            this.upload = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fineArt = new System.Windows.Forms.RadioButton();
            this.visual = new System.Windows.Forms.RadioButton();
            this.decorative = new System.Windows.Forms.RadioButton();
            this.appliedart = new System.Windows.Forms.RadioButton();
            this.load = new System.Windows.Forms.Button();
            this.imagepath = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(138, 371);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(103, 44);
            this.upload.TabIndex = 0;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(380, 371);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(106, 44);
            this.back_button.TabIndex = 1;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Art Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Art type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(100, 289);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 22);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Art";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(70, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 116);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // fineArt
            // 
            this.fineArt.AutoSize = true;
            this.fineArt.Location = new System.Drawing.Point(414, 46);
            this.fineArt.Name = "fineArt";
            this.fineArt.Size = new System.Drawing.Size(78, 21);
            this.fineArt.TabIndex = 11;
            this.fineArt.TabStop = true;
            this.fineArt.Text = "Fine Art";
            this.fineArt.UseVisualStyleBackColor = true;
            // 
            // visual
            // 
            this.visual.AutoSize = true;
            this.visual.Location = new System.Drawing.Point(413, 72);
            this.visual.Name = "visual";
            this.visual.Size = new System.Drawing.Size(89, 21);
            this.visual.TabIndex = 12;
            this.visual.TabStop = true;
            this.visual.Text = "Visual Art";
            this.visual.UseVisualStyleBackColor = true;
            // 
            // decorative
            // 
            this.decorative.AutoSize = true;
            this.decorative.Location = new System.Drawing.Point(413, 99);
            this.decorative.Name = "decorative";
            this.decorative.Size = new System.Drawing.Size(119, 21);
            this.decorative.TabIndex = 13;
            this.decorative.TabStop = true;
            this.decorative.Text = "Decorative Art";
            this.decorative.UseVisualStyleBackColor = true;
            // 
            // appliedart
            // 
            this.appliedart.AutoSize = true;
            this.appliedart.Location = new System.Drawing.Point(413, 126);
            this.appliedart.Name = "appliedart";
            this.appliedart.Size = new System.Drawing.Size(98, 21);
            this.appliedart.TabIndex = 14;
            this.appliedart.TabStop = true;
            this.appliedart.Text = "Applied Art";
            this.appliedart.UseVisualStyleBackColor = true;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(125, 178);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(76, 28);
            this.load.TabIndex = 15;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // imagepath
            // 
            this.imagepath.Location = new System.Drawing.Point(70, 150);
            this.imagepath.Name = "imagepath";
            this.imagepath.Size = new System.Drawing.Size(201, 22);
            this.imagepath.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(432, 237);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date";
            // 
            // UploadWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 469);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.imagepath);
            this.Controls.Add(this.load);
            this.Controls.Add(this.appliedart);
            this.Controls.Add(this.decorative);
            this.Controls.Add(this.visual);
            this.Controls.Add(this.fineArt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.upload);
            this.Name = "UploadWork";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UploadWork_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton fineArt;
        private System.Windows.Forms.RadioButton visual;
        private System.Windows.Forms.RadioButton decorative;
        private System.Windows.Forms.RadioButton appliedart;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.TextBox imagepath;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
    }
}