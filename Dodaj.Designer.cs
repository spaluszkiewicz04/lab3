namespace lab3
{
    partial class Dodaj
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
            txtImie = new TextBox();
            txtNazwisko = new TextBox();
            numWiek = new NumericUpDown();
            cmbStanowisko = new ComboBox();
            btnZatwierdz = new Button();
            btnAnuluj = new Button();
            lblImie = new Label();
            lblNazwisko = new Label();
            lblWiek = new Label();
            lblStanowisko = new Label();
            ((System.ComponentModel.ISupportInitialize)numWiek).BeginInit();
            SuspendLayout();
            // 
            // txtImie
            // 
            txtImie.Location = new Point(86, 12);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(150, 23);
            txtImie.TabIndex = 1;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(86, 41);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(150, 23);
            txtNazwisko.TabIndex = 3;
            // 
            // numWiek
            // 
            numWiek.Location = new Point(86, 70);
            numWiek.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            numWiek.Name = "numWiek";
            numWiek.Size = new Size(150, 23);
            numWiek.TabIndex = 5;
            numWiek.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // cmbStanowisko
            // 
            cmbStanowisko.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStanowisko.Items.AddRange(new object[] { "Murarz", "Tynkarz", "Akrobata" });
            cmbStanowisko.Location = new Point(86, 99);
            cmbStanowisko.Name = "cmbStanowisko";
            cmbStanowisko.Size = new Size(150, 23);
            cmbStanowisko.TabIndex = 7;
            // 
            // btnZatwierdz
            // 
            btnZatwierdz.DialogResult = DialogResult.OK;
            btnZatwierdz.Location = new Point(86, 131);
            btnZatwierdz.Name = "btnZatwierdz";
            btnZatwierdz.Size = new Size(69, 23);
            btnZatwierdz.TabIndex = 8;
            btnZatwierdz.Text = "OK";
            btnZatwierdz.Click += btnZatwierdz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.DialogResult = DialogResult.Cancel;
            btnAnuluj.Location = new Point(167, 131);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(69, 23);
            btnAnuluj.TabIndex = 9;
            btnAnuluj.Text = "Anuluj";
            // 
            // lblImie
            // 
            lblImie.Location = new Point(10, 15);
            lblImie.Name = "lblImie";
            lblImie.Size = new Size(70, 23);
            lblImie.TabIndex = 0;
            lblImie.Text = "Imię:";
            // 
            // lblNazwisko
            // 
            lblNazwisko.Location = new Point(10, 45);
            lblNazwisko.Name = "lblNazwisko";
            lblNazwisko.Size = new Size(70, 23);
            lblNazwisko.TabIndex = 2;
            lblNazwisko.Text = "Nazwisko:";
            // 
            // lblWiek
            // 
            lblWiek.Location = new Point(10, 75);
            lblWiek.Name = "lblWiek";
            lblWiek.Size = new Size(70, 23);
            lblWiek.TabIndex = 4;
            lblWiek.Text = "Wiek:";
            // 
            // lblStanowisko
            // 
            lblStanowisko.Location = new Point(10, 105);
            lblStanowisko.Name = "lblStanowisko";
            lblStanowisko.Size = new Size(70, 23);
            lblStanowisko.TabIndex = 6;
            lblStanowisko.Text = "Stanowisko:";
            // 
            // Dodaj
            // 
            AcceptButton = btnZatwierdz;
            CancelButton = btnAnuluj;
            ClientSize = new Size(249, 164);
            Controls.Add(lblImie);
            Controls.Add(txtImie);
            Controls.Add(lblNazwisko);
            Controls.Add(txtNazwisko);
            Controls.Add(lblWiek);
            Controls.Add(numWiek);
            Controls.Add(lblStanowisko);
            Controls.Add(cmbStanowisko);
            Controls.Add(btnZatwierdz);
            Controls.Add(btnAnuluj);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Dodaj";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj pracownika";
            ((System.ComponentModel.ISupportInitialize)numWiek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.NumericUpDown numWiek;
        private System.Windows.Forms.ComboBox cmbStanowisko;
        private System.Windows.Forms.Button btnZatwierdz;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.Label lblWiek;
        private System.Windows.Forms.Label lblStanowisko;
    }
}