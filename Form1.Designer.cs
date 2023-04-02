namespace Dalaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picture = new PictureBox();
            open = new Button();
            save = new Button();
            file = new Button();
            nzx = new Button();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // picture
            // 
            picture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picture.BackgroundImageLayout = ImageLayout.Stretch;
            picture.BorderStyle = BorderStyle.FixedSingle;
            picture.Location = new Point(12, 10);
            picture.Name = "picture";
            picture.Size = new Size(512, 512);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.TabIndex = 0;
            picture.TabStop = false;
            picture.Paint += picture_Paint;
            // 
            // open
            // 
            open.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            open.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            open.Location = new Point(268, 528);
            open.Name = "open";
            open.Size = new Size(256, 50);
            open.TabIndex = 1;
            open.Text = "Open File";
            open.UseVisualStyleBackColor = true;
            open.Click += open_Click;
            // 
            // save
            // 
            save.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            save.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            save.Location = new Point(12, 578);
            save.Name = "save";
            save.Size = new Size(256, 50);
            save.TabIndex = 2;
            save.Text = "Save Image";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // file
            // 
            file.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            file.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            file.Location = new Point(268, 578);
            file.Name = "file";
            file.Size = new Size(256, 50);
            file.TabIndex = 3;
            file.Text = "Save File";
            file.UseVisualStyleBackColor = true;
            file.Click += file_Click;
            // 
            // nzx
            // 
            nzx.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nzx.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            nzx.Location = new Point(12, 528);
            nzx.Name = "nzx";
            nzx.Size = new Size(256, 50);
            nzx.TabIndex = 4;
            nzx.Text = "Open Image";
            nzx.UseVisualStyleBackColor = true;
            nzx.Click += nzx_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 637);
            Controls.Add(nzx);
            Controls.Add(file);
            Controls.Add(save);
            Controls.Add(open);
            Controls.Add(picture);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Dalaran";
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picture;
        private Button open;
        private Button save;
        private Button file;
        private Button nzx;
    }
}