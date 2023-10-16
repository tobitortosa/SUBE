namespace Interface
{
    partial class SuperAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            txtBuscarPersona = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            btnHacerAdmin = new Button();
            btnEliminarAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(328, 22);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 0;
            label1.Text = "SuperAdmin Menu";
            // 
            // txtBuscarPersona
            // 
            txtBuscarPersona.Location = new Point(12, 76);
            txtBuscarPersona.Name = "txtBuscarPersona";
            txtBuscarPersona.Size = new Size(546, 23);
            txtBuscarPersona.TabIndex = 2;
            txtBuscarPersona.TextChanged += txtBuscarPersona_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 3;
            label2.Text = "Buscar Persona:";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 105);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(546, 333);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnHacerAdmin
            // 
            btnHacerAdmin.Location = new Point(632, 140);
            btnHacerAdmin.Name = "btnHacerAdmin";
            btnHacerAdmin.Size = new Size(122, 23);
            btnHacerAdmin.TabIndex = 5;
            btnHacerAdmin.Text = "Hacer Admin";
            btnHacerAdmin.UseVisualStyleBackColor = true;
            btnHacerAdmin.Click += btnHacerAdmin_Click;
            // 
            // btnEliminarAdmin
            // 
            btnEliminarAdmin.Location = new Point(632, 202);
            btnEliminarAdmin.Name = "btnEliminarAdmin";
            btnEliminarAdmin.Size = new Size(122, 23);
            btnEliminarAdmin.TabIndex = 6;
            btnEliminarAdmin.Text = "Eliminar Admin";
            btnEliminarAdmin.UseVisualStyleBackColor = true;
            btnEliminarAdmin.Click += btnEliminarAdmin_Click;
            // 
            // SuperAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminarAdmin);
            Controls.Add(btnHacerAdmin);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(txtBuscarPersona);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SuperAdmin";
            Text = "SuperAdmin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscarPersona;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btnHacerAdmin;
        private Button btnEliminarAdmin;
    }
}