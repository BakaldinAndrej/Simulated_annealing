namespace Otzig
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
            this._picbxTable = new System.Windows.Forms.PictureBox();
            this._btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._lbErr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._picbxTable)).BeginInit();
            this.SuspendLayout();
            // 
            // _picbxTable
            // 
            this._picbxTable.Location = new System.Drawing.Point(12, 12);
            this._picbxTable.Name = "_picbxTable";
            this._picbxTable.Size = new System.Drawing.Size(400, 400);
            this._picbxTable.TabIndex = 1;
            this._picbxTable.TabStop = false;
            this._picbxTable.Tag = "";
            // 
            // _btnStart
            // 
            this._btnStart.Location = new System.Drawing.Point(13, 417);
            this._btnStart.Name = "_btnStart";
            this._btnStart.Size = new System.Drawing.Size(75, 23);
            this._btnStart.TabIndex = 2;
            this._btnStart.Text = "Отжигаем";
            this._btnStart.UseVisualStyleBackColor = true;
            this._btnStart.Click += new System.EventHandler(this._btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество ошибок";
            // 
            // _lbErr
            // 
            this._lbErr.AutoSize = true;
            this._lbErr.Location = new System.Drawing.Point(208, 422);
            this._lbErr.Name = "_lbErr";
            this._lbErr.Size = new System.Drawing.Size(0, 13);
            this._lbErr.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 452);
            this.Controls.Add(this._lbErr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnStart);
            this.Controls.Add(this._picbxTable);
            this.Name = "Form1";
            this.Text = "Отжиг";
            ((System.ComponentModel.ISupportInitialize)(this._picbxTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox _picbxTable;
        private System.Windows.Forms.Button _btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lbErr;
    }
}

