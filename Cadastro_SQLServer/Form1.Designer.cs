
namespace Cadastro_SQLServer
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_New = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Consult = new System.Windows.Forms.Button();
            this.Btn_Display = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_New
            // 
            this.Btn_New.Location = new System.Drawing.Point(29, 107);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(75, 23);
            this.Btn_New.TabIndex = 0;
            this.Btn_New.Text = "Novo";
            this.Btn_New.UseVisualStyleBackColor = true;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Location = new System.Drawing.Point(110, 107);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Edit.TabIndex = 1;
            this.Btn_Edit.Text = "Editar";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Consult
            // 
            this.Btn_Consult.Location = new System.Drawing.Point(191, 107);
            this.Btn_Consult.Name = "Btn_Consult";
            this.Btn_Consult.Size = new System.Drawing.Size(75, 23);
            this.Btn_Consult.TabIndex = 2;
            this.Btn_Consult.Text = "Consultar";
            this.Btn_Consult.UseVisualStyleBackColor = true;
            this.Btn_Consult.Click += new System.EventHandler(this.Btn_Consult_Click);
            // 
            // Btn_Display
            // 
            this.Btn_Display.Location = new System.Drawing.Point(272, 107);
            this.Btn_Display.Name = "Btn_Display";
            this.Btn_Display.Size = new System.Drawing.Size(75, 23);
            this.Btn_Display.TabIndex = 3;
            this.Btn_Display.Text = "Exibir";
            this.Btn_Display.UseVisualStyleBackColor = true;
            this.Btn_Display.Click += new System.EventHandler(this.Btn_Display_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(353, 107);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 4;
            this.Btn_Delete.Text = "Excluir";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(79, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(79, 70);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Número:";
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(29, 136);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(399, 130);
            this.dgvData.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 287);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Display);
            this.Controls.Add(this.Btn_Consult);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_New);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_New;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Consult;
        private System.Windows.Forms.Button Btn_Display;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvData;
    }
}

