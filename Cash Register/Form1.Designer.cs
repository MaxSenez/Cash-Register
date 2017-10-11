namespace Cash_Register
{
    partial class cashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashForm));
            this.bannerLabel = new System.Windows.Forms.Label();
            this.baconLabel = new System.Windows.Forms.Label();
            this.cheeseLabel = new System.Windows.Forms.Label();
            this.macLabel = new System.Windows.Forms.Label();
            this.baconBox = new System.Windows.Forms.TextBox();
            this.cheeseBox = new System.Windows.Forms.TextBox();
            this.macBox = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.subAmmountLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.taxAmmountLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalAmmountLabel = new System.Windows.Forms.Label();
            this.deviderLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeAmmountLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bannerLabel
            // 
            this.bannerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bannerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.bannerLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bannerLabel.Location = new System.Drawing.Point(-15, -5);
            this.bannerLabel.Name = "bannerLabel";
            this.bannerLabel.Size = new System.Drawing.Size(708, 48);
            this.bannerLabel.TabIndex = 0;
            this.bannerLabel.Text = "    Burger Joint";
            this.bannerLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // baconLabel
            // 
            this.baconLabel.Location = new System.Drawing.Point(39, 54);
            this.baconLabel.Name = "baconLabel";
            this.baconLabel.Size = new System.Drawing.Size(137, 24);
            this.baconLabel.TabIndex = 2;
            this.baconLabel.Text = "Baconators";
            // 
            // cheeseLabel
            // 
            this.cheeseLabel.Location = new System.Drawing.Point(39, 88);
            this.cheeseLabel.Name = "cheeseLabel";
            this.cheeseLabel.Size = new System.Drawing.Size(137, 24);
            this.cheeseLabel.TabIndex = 3;
            this.cheeseLabel.Text = "Double Cheeses";
            // 
            // macLabel
            // 
            this.macLabel.Location = new System.Drawing.Point(39, 123);
            this.macLabel.Name = "macLabel";
            this.macLabel.Size = new System.Drawing.Size(137, 24);
            this.macLabel.TabIndex = 4;
            this.macLabel.Text = "Big Macs";
            // 
            // baconBox
            // 
            this.baconBox.Location = new System.Drawing.Point(203, 48);
            this.baconBox.Name = "baconBox";
            this.baconBox.Size = new System.Drawing.Size(51, 26);
            this.baconBox.TabIndex = 5;
            // 
            // cheeseBox
            // 
            this.cheeseBox.Location = new System.Drawing.Point(203, 81);
            this.cheeseBox.Name = "cheeseBox";
            this.cheeseBox.Size = new System.Drawing.Size(51, 26);
            this.cheeseBox.TabIndex = 6;
            // 
            // macBox
            // 
            this.macBox.Location = new System.Drawing.Point(203, 116);
            this.macBox.Name = "macBox";
            this.macBox.Size = new System.Drawing.Size(51, 26);
            this.macBox.TabIndex = 7;
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(62, 160);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(192, 35);
            this.totalButton.TabIndex = 8;
            this.totalButton.Text = "Calculate Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.Location = new System.Drawing.Point(48, 198);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(93, 29);
            this.subTotalLabel.TabIndex = 9;
            this.subTotalLabel.Text = "Sub Total";
            this.subTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subAmmountLabel
            // 
            this.subAmmountLabel.Location = new System.Drawing.Point(200, 198);
            this.subAmmountLabel.Name = "subAmmountLabel";
            this.subAmmountLabel.Size = new System.Drawing.Size(89, 21);
            this.subAmmountLabel.TabIndex = 10;
            // 
            // taxLabel
            // 
            this.taxLabel.Location = new System.Drawing.Point(48, 227);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(93, 29);
            this.taxLabel.TabIndex = 11;
            this.taxLabel.Text = "Tax";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taxAmmountLabel
            // 
            this.taxAmmountLabel.Location = new System.Drawing.Point(200, 227);
            this.taxAmmountLabel.Name = "taxAmmountLabel";
            this.taxAmmountLabel.Size = new System.Drawing.Size(89, 21);
            this.taxAmmountLabel.TabIndex = 12;
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(48, 256);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(93, 29);
            this.totalLabel.TabIndex = 13;
            this.totalLabel.Text = "Total";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalAmmountLabel
            // 
            this.totalAmmountLabel.Location = new System.Drawing.Point(200, 256);
            this.totalAmmountLabel.Name = "totalAmmountLabel";
            this.totalAmmountLabel.Size = new System.Drawing.Size(89, 21);
            this.totalAmmountLabel.TabIndex = 14;
            // 
            // deviderLabel
            // 
            this.deviderLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deviderLabel.Location = new System.Drawing.Point(42, 285);
            this.deviderLabel.Name = "deviderLabel";
            this.deviderLabel.Size = new System.Drawing.Size(225, 15);
            this.deviderLabel.TabIndex = 15;
            this.deviderLabel.Text = "label11";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Location = new System.Drawing.Point(48, 315);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(122, 25);
            this.tenderedLabel.TabIndex = 16;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedBox
            // 
            this.tenderedBox.Location = new System.Drawing.Point(184, 312);
            this.tenderedBox.Name = "tenderedBox";
            this.tenderedBox.Size = new System.Drawing.Size(70, 26);
            this.tenderedBox.TabIndex = 17;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(62, 349);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(192, 38);
            this.changeButton.TabIndex = 18;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.Location = new System.Drawing.Point(48, 386);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(93, 29);
            this.changeLabel.TabIndex = 19;
            this.changeLabel.Text = "Change";
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeAmmountLabel
            // 
            this.changeAmmountLabel.Location = new System.Drawing.Point(199, 390);
            this.changeAmmountLabel.Name = "changeAmmountLabel";
            this.changeAmmountLabel.Size = new System.Drawing.Size(89, 21);
            this.changeAmmountLabel.TabIndex = 20;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(62, 418);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(192, 32);
            this.printButton.TabIndex = 21;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(412, 420);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(192, 30);
            this.resetButton.TabIndex = 22;
            this.resetButton.Text = "New Order";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // cashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(678, 454);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeAmmountLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedBox);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.deviderLabel);
            this.Controls.Add(this.totalAmmountLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxAmmountLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subAmmountLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.macBox);
            this.Controls.Add(this.cheeseBox);
            this.Controls.Add(this.baconBox);
            this.Controls.Add(this.macLabel);
            this.Controls.Add(this.cheeseLabel);
            this.Controls.Add(this.baconLabel);
            this.Controls.Add(this.bannerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cashForm";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bannerLabel;
        private System.Windows.Forms.Label baconLabel;
        private System.Windows.Forms.Label cheeseLabel;
        private System.Windows.Forms.Label macLabel;
        private System.Windows.Forms.TextBox baconBox;
        private System.Windows.Forms.TextBox cheeseBox;
        private System.Windows.Forms.TextBox macBox;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label subAmmountLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label taxAmmountLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalAmmountLabel;
        private System.Windows.Forms.Label deviderLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeAmmountLabel;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button resetButton;
    }
}

