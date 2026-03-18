namespace lab3
{
    partial class Pracownicy
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnDodaj = new Button();
            btnUsun = new Button();
            btnZapisz = new Button();
            btnOdczytaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Location = new Point(10, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(543, 300);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(10, 316);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(90, 25);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.Click += BtnDodaj_Click;
            // 
            // btnUsun
            // 
            btnUsun.Location = new Point(106, 316);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(90, 25);
            btnUsun.TabIndex = 2;
            btnUsun.Text = "Usuń";
            btnUsun.Click += BtnUsun_Click;
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(367, 316);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(90, 25);
            btnZapisz.TabIndex = 3;
            btnZapisz.Text = "Zapisz";
            btnZapisz.Click += BtnZapisz_Click;
            // 
            // btnOdczytaj
            // 
            btnOdczytaj.Location = new Point(463, 316);
            btnOdczytaj.Name = "btnOdczytaj";
            btnOdczytaj.Size = new Size(90, 25);
            btnOdczytaj.TabIndex = 4;
            btnOdczytaj.Text = "Wczytaj";
            btnOdczytaj.Click += BtnOdczytaj_Click;
            // 
            // Pracownicy
            // 
            ClientSize = new Size(563, 350);
            Controls.Add(dataGridView1);
            Controls.Add(btnDodaj);
            Controls.Add(btnUsun);
            Controls.Add(btnZapisz);
            Controls.Add(btnOdczytaj);
            Name = "Pracownicy";
            Text = "Zarządzanie pracownikami";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnOdczytaj;
    }
}