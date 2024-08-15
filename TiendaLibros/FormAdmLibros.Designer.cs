
namespace TiendaLibros
{
    partial class FormAdmLibros
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
            dgvLibros = new DataGridView();
            lblMensaje = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btModificar = new Button();
            btAgregar = new Button();
            txtStock = new TextBox();
            txtAutor = new TextBox();
            txtGenero = new TextBox();
            txtPrecio = new TextBox();
            txtTitulo = new TextBox();
            txtCodLibro = new TextBox();
            label1 = new Label();
            label3 = new Label();
            lblAutor = new Label();
            label5 = new Label();
            lblTitulo = new Label();
            lblCodigo = new Label();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(458, 52);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(300, 171);
            dgvLibros.TabIndex = 0;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(576, 244);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(71, 21);
            lblMensaje.TabIndex = 1;
            lblMensaje.Text = "Mensaje";
            lblMensaje.Click += lblMensaje_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(70, 26);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(367, 387);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btModificar);
            tabPage1.Controls.Add(btAgregar);
            tabPage1.Controls.Add(txtStock);
            tabPage1.Controls.Add(txtAutor);
            tabPage1.Controls.Add(txtGenero);
            tabPage1.Controls.Add(txtPrecio);
            tabPage1.Controls.Add(txtTitulo);
            tabPage1.Controls.Add(txtCodLibro);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(lblAutor);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(lblTitulo);
            tabPage1.Controls.Add(lblCodigo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(359, 359);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Gestión de Libros";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btModificar
            // 
            btModificar.Location = new Point(151, 263);
            btModificar.Name = "btModificar";
            btModificar.Size = new Size(75, 23);
            btModificar.TabIndex = 19;
            btModificar.Text = "Modificar";
            btModificar.UseVisualStyleBackColor = true;
            // 
            // btAgregar
            // 
            btAgregar.Location = new Point(49, 263);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(75, 23);
            btAgregar.TabIndex = 9;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = true;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(191, 208);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 18;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(191, 122);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(100, 23);
            txtAutor.TabIndex = 17;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(191, 150);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(100, 23);
            txtGenero.TabIndex = 16;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(191, 179);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 15;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(191, 93);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 14;
            // 
            // txtCodLibro
            // 
            txtCodLibro.Location = new Point(191, 64);
            txtCodLibro.Name = "txtCodLibro";
            txtCodLibro.Size = new Size(100, 23);
            txtCodLibro.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(33, 210);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 13;
            label1.Text = "Cantidad en Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(33, 152);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 12;
            label3.Text = "Género";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAutor.Location = new Point(33, 124);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(52, 21);
            lblAutor.TabIndex = 11;
            lblAutor.Text = "Autor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(33, 181);
            label5.Name = "label5";
            label5.Size = new Size(56, 21);
            label5.TabIndex = 10;
            label5.Text = "Precio";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(33, 95);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(52, 21);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "Titulo";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCodigo.Location = new Point(33, 66);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(64, 21);
            lblCodigo.TabIndex = 8;
            lblCodigo.Text = "Código";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(359, 359);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormAdmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(lblMensaje);
            Controls.Add(dgvLibros);
            Name = "FormAdmLibros";
            Text = "Gestión de Libros";
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        

        #endregion

        private DataGridView dgvLibros;
        private Label lblMensaje;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtTitulo;
        private TextBox txtCodLibro;
        private Label label1;
        private Label label3;
        private Label lblAutor;
        private Label label5;
        private Label lblTitulo;
        private Label lblCodigo;
        private TextBox txtStock;
        private TextBox txtAutor;
        private TextBox txtGenero;
        private TextBox txtPrecio;
        private Button btAgregar;
        private Button btModificar;
    }
}
