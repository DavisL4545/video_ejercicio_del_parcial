namespace doctoreslist
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
            gbdoctores = new GroupBox();
            lbdoctores = new ListBox();
            gbndoctores = new GroupBox();
            btnagregar = new Button();
            tbemail = new TextBox();
            tbtelefono = new TextBox();
            tbdoctor = new TextBox();
            label5 = new Label();
            label4 = new Label();
            lblemail = new Label();
            lbltelefono = new Label();
            lbldoctor = new Label();
            gbacciones = new GroupBox();
            btneditar = new Button();
            btneliminar = new Button();
            gbdoctores.SuspendLayout();
            gbndoctores.SuspendLayout();
            gbacciones.SuspendLayout();
            SuspendLayout();
            // 
            // gbdoctores
            // 
            gbdoctores.Controls.Add(lbdoctores);
            gbdoctores.Location = new Point(45, 73);
            gbdoctores.Name = "gbdoctores";
            gbdoctores.Size = new Size(245, 269);
            gbdoctores.TabIndex = 0;
            gbdoctores.TabStop = false;
            gbdoctores.Text = "Doctores";
            // 
            // lbdoctores
            // 
            lbdoctores.FormattingEnabled = true;
            lbdoctores.ItemHeight = 20;
            lbdoctores.Location = new Point(36, 49);
            lbdoctores.Name = "lbdoctores";
            lbdoctores.Size = new Size(150, 104);
            lbdoctores.TabIndex = 0;
            lbdoctores.SelectedIndexChanged += lbdoctores_SelectedIndexChanged;
            // 
            // gbndoctores
            // 
            gbndoctores.Controls.Add(btnagregar);
            gbndoctores.Controls.Add(tbemail);
            gbndoctores.Controls.Add(tbtelefono);
            gbndoctores.Controls.Add(tbdoctor);
            gbndoctores.Controls.Add(label5);
            gbndoctores.Controls.Add(label4);
            gbndoctores.Controls.Add(lblemail);
            gbndoctores.Controls.Add(lbltelefono);
            gbndoctores.Controls.Add(lbldoctor);
            gbndoctores.Location = new Point(437, 73);
            gbndoctores.Name = "gbndoctores";
            gbndoctores.Size = new Size(352, 213);
            gbndoctores.TabIndex = 1;
            gbndoctores.TabStop = false;
            gbndoctores.Text = "Nuevo Doctores";
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(134, 183);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(94, 29);
            btnagregar.TabIndex = 8;
            btnagregar.Text = "Agregar Hospital";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // tbemail
            // 
            tbemail.Location = new Point(140, 138);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(125, 27);
            tbemail.TabIndex = 7;
            // 
            // tbtelefono
            // 
            tbtelefono.Location = new Point(140, 87);
            tbtelefono.Name = "tbtelefono";
            tbtelefono.Size = new Size(125, 27);
            tbtelefono.TabIndex = 6;
            // 
            // tbdoctor
            // 
            tbdoctor.Location = new Point(140, 25);
            tbdoctor.Name = "tbdoctor";
            tbdoctor.Size = new Size(125, 27);
            tbdoctor.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(199, 133);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(199, 39);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 3;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(28, 145);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(46, 20);
            lblemail.TabIndex = 2;
            lblemail.Text = "Email";
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Location = new Point(26, 94);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(65, 20);
            lbltelefono.TabIndex = 1;
            lbltelefono.Text = "telefono";
            // 
            // lbldoctor
            // 
            lbldoctor.AutoSize = true;
            lbldoctor.Location = new Point(26, 32);
            lbldoctor.Name = "lbldoctor";
            lbldoctor.Size = new Size(55, 20);
            lbldoctor.TabIndex = 0;
            lbldoctor.Text = "Doctor";
            // 
            // gbacciones
            // 
            gbacciones.Controls.Add(btneditar);
            gbacciones.Controls.Add(btneliminar);
            gbacciones.Location = new Point(426, 369);
            gbacciones.Name = "gbacciones";
            gbacciones.Size = new Size(282, 171);
            gbacciones.TabIndex = 2;
            gbacciones.TabStop = false;
            gbacciones.Text = "Acciones";
            // 
            // btneditar
            // 
            btneditar.Location = new Point(37, 94);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(94, 29);
            btneditar.TabIndex = 9;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btneditar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(162, 94);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(94, 29);
            btneliminar.TabIndex = 10;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 644);
            Controls.Add(gbacciones);
            Controls.Add(gbndoctores);
            Controls.Add(gbdoctores);
            Name = "Form1";
            Text = "Form1";
            gbdoctores.ResumeLayout(false);
            gbndoctores.ResumeLayout(false);
            gbndoctores.PerformLayout();
            gbacciones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbdoctores;
        private GroupBox gbndoctores;
        private Label label5;
        private Label label4;
        private Label lblemail;
        private Label lbltelefono;
        private Label lbldoctor;
        private GroupBox gbacciones;
        private TextBox tbemail;
        private TextBox tbtelefono;
        private TextBox tbdoctor;
        private Button btnagregar;
        private Button btneditar;
        private Button btneliminar;
        private ListBox lbdoctores;
    }
}