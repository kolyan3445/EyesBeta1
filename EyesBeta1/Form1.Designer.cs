namespace EyesBeta1
{
    partial class EyeSelector
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
            this.EyeSelectResultLabel = new System.Windows.Forms.Label();
            this.EyeSelectorButton = new System.Windows.Forms.Button();
            this.DoubleEyeDiceButton = new System.Windows.Forms.Button();
            this.DoubleEyeLabel = new System.Windows.Forms.Label();
            this.EyeCountSelectCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // EyeSelectResultLabel
            // 
            this.EyeSelectResultLabel.AutoSize = true;
            this.EyeSelectResultLabel.Location = new System.Drawing.Point(228, 123);
            this.EyeSelectResultLabel.Name = "EyeSelectResultLabel";
            this.EyeSelectResultLabel.Size = new System.Drawing.Size(16, 13);
            this.EyeSelectResultLabel.TabIndex = 0;
            this.EyeSelectResultLabel.Text = "...";
            // 
            // EyeSelectorButton
            // 
            this.EyeSelectorButton.Location = new System.Drawing.Point(41, 118);
            this.EyeSelectorButton.Name = "EyeSelectorButton";
            this.EyeSelectorButton.Size = new System.Drawing.Size(122, 23);
            this.EyeSelectorButton.TabIndex = 2;
            this.EyeSelectorButton.Text = "Выбрать глаз(а)";
            this.EyeSelectorButton.UseVisualStyleBackColor = true;
            this.EyeSelectorButton.Click += new System.EventHandler(this.EyeSelectorButton_Click);
            // 
            // DoubleEyeDiceButton
            // 
            this.DoubleEyeDiceButton.Location = new System.Drawing.Point(362, 118);
            this.DoubleEyeDiceButton.Name = "DoubleEyeDiceButton";
            this.DoubleEyeDiceButton.Size = new System.Drawing.Size(127, 23);
            this.DoubleEyeDiceButton.TabIndex = 3;
            this.DoubleEyeDiceButton.Text = "Куб на двойной глаз";
            this.DoubleEyeDiceButton.UseVisualStyleBackColor = true;
            this.DoubleEyeDiceButton.Click += new System.EventHandler(this.DoubleEyeDiceButton_Click);
            // 
            // DoubleEyeLabel
            // 
            this.DoubleEyeLabel.AutoSize = true;
            this.DoubleEyeLabel.Location = new System.Drawing.Point(359, 200);
            this.DoubleEyeLabel.Name = "DoubleEyeLabel";
            this.DoubleEyeLabel.Size = new System.Drawing.Size(84, 13);
            this.DoubleEyeLabel.TabIndex = 4;
            this.DoubleEyeLabel.Text = "Двойной глаз: ";
            // 
            // EyeCountSelectCheckBox
            // 
            this.EyeCountSelectCheckBox.AutoSize = true;
            this.EyeCountSelectCheckBox.Location = new System.Drawing.Point(41, 200);
            this.EyeCountSelectCheckBox.Name = "EyeCountSelectCheckBox";
            this.EyeCountSelectCheckBox.Size = new System.Drawing.Size(155, 17);
            this.EyeCountSelectCheckBox.TabIndex = 5;
            this.EyeCountSelectCheckBox.Text = "Выбрать сразу два глаза";
            this.EyeCountSelectCheckBox.UseVisualStyleBackColor = true;
            this.EyeCountSelectCheckBox.CheckStateChanged += new System.EventHandler(this.EyeCountSelectCheckBox_CheckStateChanged);
            // 
            // EyeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 264);
            this.Controls.Add(this.EyeCountSelectCheckBox);
            this.Controls.Add(this.DoubleEyeLabel);
            this.Controls.Add(this.DoubleEyeDiceButton);
            this.Controls.Add(this.EyeSelectorButton);
            this.Controls.Add(this.EyeSelectResultLabel);
            this.Name = "EyeSelector";
            this.Text = "Глазобор 9000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EyeSelectResultLabel;
        private System.Windows.Forms.Button EyeSelectorButton;
        private System.Windows.Forms.Button DoubleEyeDiceButton;
        private System.Windows.Forms.Label DoubleEyeLabel;
        private System.Windows.Forms.CheckBox EyeCountSelectCheckBox;
    }
}

