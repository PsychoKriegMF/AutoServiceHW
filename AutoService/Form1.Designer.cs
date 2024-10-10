namespace AutoService
{
    partial class Form1
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
            this.cmbMechanic = new System.Windows.Forms.ComboBox();
            this.lbMechanic = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddMechanic = new System.Windows.Forms.Button();
            this.picBoxAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMechanic
            // 
            this.cmbMechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbMechanic.FormattingEnabled = true;
            this.cmbMechanic.Location = new System.Drawing.Point(32, 58);
            this.cmbMechanic.Name = "cmbMechanic";
            this.cmbMechanic.Size = new System.Drawing.Size(175, 41);
            this.cmbMechanic.TabIndex = 0;
            // 
            // lbMechanic
            // 
            this.lbMechanic.AutoSize = true;
            this.lbMechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMechanic.Location = new System.Drawing.Point(32, 13);
            this.lbMechanic.Name = "lbMechanic";
            this.lbMechanic.Size = new System.Drawing.Size(87, 26);
            this.lbMechanic.TabIndex = 1;
            this.lbMechanic.Text = "Мастер";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(122, 124);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 41);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddMechanic
            // 
            this.btnAddMechanic.Location = new System.Drawing.Point(28, 124);
            this.btnAddMechanic.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMechanic.Name = "btnAddMechanic";
            this.btnAddMechanic.Size = new System.Drawing.Size(84, 41);
            this.btnAddMechanic.TabIndex = 4;
            this.btnAddMechanic.Text = "Добавить";
            this.btnAddMechanic.UseVisualStyleBackColor = true;
            this.btnAddMechanic.Click += new System.EventHandler(this.btnAddMechanic_Click);
            // 
            // picBoxAvatar
            // 
            this.picBoxAvatar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picBoxAvatar.Location = new System.Drawing.Point(256, 58);
            this.picBoxAvatar.Name = "picBoxAvatar";
            this.picBoxAvatar.Size = new System.Drawing.Size(120, 120);
            this.picBoxAvatar.TabIndex = 2;
            this.picBoxAvatar.TabStop = false;
            this.picBoxAvatar.Click += new System.EventHandler(this.picBoxAvatar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBoxAvatar);
            this.Controls.Add(this.btnAddMechanic);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbMechanic);
            this.Controls.Add(this.cmbMechanic);
            this.Name = "Form1";
            this.Text = "Autoservice";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMechanic;
        private System.Windows.Forms.Label lbMechanic;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddMechanic;
        private System.Windows.Forms.PictureBox picBoxAvatar;
    }
}

