namespace BitmapFiltres
{
    partial class BitmapFiltres
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.filtresTrackBar = new System.Windows.Forms.TrackBar();
            this.openFileDialogForOpenButton = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogForSaveButton = new System.Windows.Forms.SaveFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.ChooseFilterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtresTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Location = new System.Drawing.Point(13, 13);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(354, 359);
            this.photoPictureBox.TabIndex = 0;
            this.photoPictureBox.TabStop = false;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(387, 13);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "Открыть";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // filtresTrackBar
            // 
            this.filtresTrackBar.Location = new System.Drawing.Point(387, 72);
            this.filtresTrackBar.Name = "filtresTrackBar";
            this.filtresTrackBar.Size = new System.Drawing.Size(104, 45);
            this.filtresTrackBar.TabIndex = 2;
            this.filtresTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(387, 123);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ChooseFilterLabel
            // 
            this.ChooseFilterLabel.AutoSize = true;
            this.ChooseFilterLabel.Location = new System.Drawing.Point(384, 56);
            this.ChooseFilterLabel.Name = "ChooseFilterLabel";
            this.ChooseFilterLabel.Size = new System.Drawing.Size(91, 13);
            this.ChooseFilterLabel.TabIndex = 4;
            this.ChooseFilterLabel.Text = "Выбрать фильтр";
            // 
            // BitmapFiltres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.ChooseFilterLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.filtresTrackBar);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.photoPictureBox);
            this.Name = "BitmapFiltres";
            this.Text = "Bitmap Filtres";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtresTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.TrackBar filtresTrackBar;
        private System.Windows.Forms.OpenFileDialog openFileDialogForOpenButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialogForSaveButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label ChooseFilterLabel;
    }
}

