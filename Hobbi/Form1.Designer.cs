namespace Hobbi
{
    partial class Form1
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
            this.mentesButton = new System.Windows.Forms.Button();
            this.betoltesButton = new System.Windows.Forms.Button();
            this.hozzaadButton = new System.Windows.Forms.Button();
            this.ferfiRadio = new System.Windows.Forms.RadioButton();
            this.noiRadio = new System.Windows.Forms.RadioButton();
            this.radioLabel = new System.Windows.Forms.Label();
            this.datumLabel = new System.Windows.Forms.Label();
            this.nevLabel = new System.Windows.Forms.Label();
            this.kedvenchobbiLabel = new System.Windows.Forms.Label();
            this.ujhobbiLabel = new System.Windows.Forms.Label();
            this.nevText = new System.Windows.Forms.TextBox();
            this.szulDatum = new System.Windows.Forms.DateTimePicker();
            this.hobbiText = new System.Windows.Forms.TextBox();
            this.hobbiBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // mentesButton
            // 
            this.mentesButton.Location = new System.Drawing.Point(19, 258);
            this.mentesButton.Name = "mentesButton";
            this.mentesButton.Size = new System.Drawing.Size(231, 52);
            this.mentesButton.TabIndex = 0;
            this.mentesButton.Text = "Mentés";
            this.mentesButton.UseVisualStyleBackColor = true;
            // 
            // betoltesButton
            // 
            this.betoltesButton.Location = new System.Drawing.Point(256, 258);
            this.betoltesButton.Name = "betoltesButton";
            this.betoltesButton.Size = new System.Drawing.Size(242, 52);
            this.betoltesButton.TabIndex = 1;
            this.betoltesButton.Text = "Betöltés";
            this.betoltesButton.UseVisualStyleBackColor = true;
            // 
            // hozzaadButton
            // 
            this.hozzaadButton.Location = new System.Drawing.Point(423, 196);
            this.hozzaadButton.Name = "hozzaadButton";
            this.hozzaadButton.Size = new System.Drawing.Size(75, 23);
            this.hozzaadButton.TabIndex = 2;
            this.hozzaadButton.Text = "Hozzáadás";
            this.hozzaadButton.UseVisualStyleBackColor = true;
            // 
            // ferfiRadio
            // 
            this.ferfiRadio.AutoSize = true;
            this.ferfiRadio.Location = new System.Drawing.Point(83, 79);
            this.ferfiRadio.Name = "ferfiRadio";
            this.ferfiRadio.Size = new System.Drawing.Size(45, 17);
            this.ferfiRadio.TabIndex = 3;
            this.ferfiRadio.TabStop = true;
            this.ferfiRadio.Text = "Férfi";
            this.ferfiRadio.UseVisualStyleBackColor = true;
            // 
            // noiRadio
            // 
            this.noiRadio.AutoSize = true;
            this.noiRadio.Location = new System.Drawing.Point(174, 79);
            this.noiRadio.Name = "noiRadio";
            this.noiRadio.Size = new System.Drawing.Size(39, 17);
            this.noiRadio.TabIndex = 4;
            this.noiRadio.TabStop = true;
            this.noiRadio.Text = "Nő";
            this.noiRadio.UseVisualStyleBackColor = true;
            // 
            // radioLabel
            // 
            this.radioLabel.AutoSize = true;
            this.radioLabel.Location = new System.Drawing.Point(13, 81);
            this.radioLabel.Name = "radioLabel";
            this.radioLabel.Size = new System.Drawing.Size(32, 13);
            this.radioLabel.TabIndex = 5;
            this.radioLabel.Text = "Nem:";
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Location = new System.Drawing.Point(13, 56);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(62, 13);
            this.datumLabel.TabIndex = 6;
            this.datumLabel.Text = "Szül. dátum";
            // 
            // nevLabel
            // 
            this.nevLabel.AutoSize = true;
            this.nevLabel.Location = new System.Drawing.Point(13, 30);
            this.nevLabel.Name = "nevLabel";
            this.nevLabel.Size = new System.Drawing.Size(33, 13);
            this.nevLabel.TabIndex = 7;
            this.nevLabel.Text = "Név: ";
            // 
            // kedvenchobbiLabel
            // 
            this.kedvenchobbiLabel.AutoSize = true;
            this.kedvenchobbiLabel.Location = new System.Drawing.Point(348, 30);
            this.kedvenchobbiLabel.Name = "kedvenchobbiLabel";
            this.kedvenchobbiLabel.Size = new System.Drawing.Size(84, 13);
            this.kedvenchobbiLabel.TabIndex = 8;
            this.kedvenchobbiLabel.Text = "Kedvenc Hobbi:";
            // 
            // ujhobbiLabel
            // 
            this.ujhobbiLabel.AutoSize = true;
            this.ujhobbiLabel.Location = new System.Drawing.Point(236, 173);
            this.ujhobbiLabel.Name = "ujhobbiLabel";
            this.ujhobbiLabel.Size = new System.Drawing.Size(109, 13);
            this.ujhobbiLabel.TabIndex = 9;
            this.ujhobbiLabel.Text = "Új hobbi hozzáadása:";
            // 
            // nevText
            // 
            this.nevText.Location = new System.Drawing.Point(83, 27);
            this.nevText.Name = "nevText";
            this.nevText.Size = new System.Drawing.Size(100, 20);
            this.nevText.TabIndex = 10;
            // 
            // szulDatum
            // 
            this.szulDatum.Location = new System.Drawing.Point(83, 53);
            this.szulDatum.Name = "szulDatum";
            this.szulDatum.Size = new System.Drawing.Size(200, 20);
            this.szulDatum.TabIndex = 11;
            // 
            // hobbiText
            // 
            this.hobbiText.Location = new System.Drawing.Point(351, 170);
            this.hobbiText.Name = "hobbiText";
            this.hobbiText.Size = new System.Drawing.Size(147, 20);
            this.hobbiText.TabIndex = 12;
            // 
            // hobbiBox
            // 
            this.hobbiBox.FormattingEnabled = true;
            this.hobbiBox.Items.AddRange(new object[] {
            "Pecázás",
            "Futás",
            "Gépezés",
            "Kábszi"});
            this.hobbiBox.Location = new System.Drawing.Point(351, 56);
            this.hobbiBox.Name = "hobbiBox";
            this.hobbiBox.Size = new System.Drawing.Size(147, 95);
            this.hobbiBox.TabIndex = 13;
            this.hobbiBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 322);
            this.Controls.Add(this.hobbiBox);
            this.Controls.Add(this.hobbiText);
            this.Controls.Add(this.szulDatum);
            this.Controls.Add(this.nevText);
            this.Controls.Add(this.ujhobbiLabel);
            this.Controls.Add(this.kedvenchobbiLabel);
            this.Controls.Add(this.nevLabel);
            this.Controls.Add(this.datumLabel);
            this.Controls.Add(this.radioLabel);
            this.Controls.Add(this.noiRadio);
            this.Controls.Add(this.ferfiRadio);
            this.Controls.Add(this.hozzaadButton);
            this.Controls.Add(this.betoltesButton);
            this.Controls.Add(this.mentesButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mentesButton;
        private System.Windows.Forms.Button betoltesButton;
        private System.Windows.Forms.Button hozzaadButton;
        private System.Windows.Forms.RadioButton ferfiRadio;
        private System.Windows.Forms.RadioButton noiRadio;
        private System.Windows.Forms.Label radioLabel;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.Label nevLabel;
        private System.Windows.Forms.Label kedvenchobbiLabel;
        private System.Windows.Forms.Label ujhobbiLabel;
        private System.Windows.Forms.TextBox nevText;
        private System.Windows.Forms.DateTimePicker szulDatum;
        private System.Windows.Forms.TextBox hobbiText;
        private System.Windows.Forms.ListBox hobbiBox;
    }
}

