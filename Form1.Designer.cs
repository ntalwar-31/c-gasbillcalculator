namespace GasBillCalc
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
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtTotalDistance = new System.Windows.Forms.TextBox();
            this.txtGasPrice = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblTotalDistance = new System.Windows.Forms.Label();
            this.lblGasPerGallon = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.chkRound = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(369, 65);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(225, 35);
            this.txtCity.TabIndex = 0;
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(369, 148);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(225, 35);
            this.txtState.TabIndex = 1;
            // 
            // txtTotalDistance
            // 
            this.txtTotalDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDistance.Location = new System.Drawing.Point(369, 231);
            this.txtTotalDistance.Name = "txtTotalDistance";
            this.txtTotalDistance.Size = new System.Drawing.Size(225, 35);
            this.txtTotalDistance.TabIndex = 2;
            // 
            // txtGasPrice
            // 
            this.txtGasPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGasPrice.Location = new System.Drawing.Point(369, 314);
            this.txtGasPrice.Name = "txtGasPrice";
            this.txtGasPrice.Size = new System.Drawing.Size(225, 35);
            this.txtGasPrice.TabIndex = 3;
            this.txtGasPrice.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(201, 406);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(148, 66);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "C&alculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(429, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 66);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(126, 71);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(53, 29);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(126, 154);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(68, 29);
            this.lblState.TabIndex = 7;
            this.lblState.Text = "State";
            // 
            // lblTotalDistance
            // 
            this.lblTotalDistance.AutoSize = true;
            this.lblTotalDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDistance.Location = new System.Drawing.Point(126, 237);
            this.lblTotalDistance.Name = "lblTotalDistance";
            this.lblTotalDistance.Size = new System.Drawing.Size(167, 29);
            this.lblTotalDistance.TabIndex = 0;
            this.lblTotalDistance.Text = "Total Distance";
            // 
            // lblGasPerGallon
            // 
            this.lblGasPerGallon.AutoSize = true;
            this.lblGasPerGallon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGasPerGallon.Location = new System.Drawing.Point(126, 320);
            this.lblGasPerGallon.Name = "lblGasPerGallon";
            this.lblGasPerGallon.Size = new System.Drawing.Size(144, 29);
            this.lblGasPerGallon.TabIndex = 9;
            this.lblGasPerGallon.Text = "Price of Gas";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(131, 510);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(582, 116);
            this.lblResult.TabIndex = 10;
            // 
            // chkRound
            // 
            this.chkRound.AutoSize = true;
            this.chkRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRound.Location = new System.Drawing.Point(650, 415);
            this.chkRound.Name = "chkRound";
            this.chkRound.Size = new System.Drawing.Size(336, 33);
            this.chkRound.TabIndex = 11;
            this.chkRound.Text = "Round to the Nearest Dollar";
            this.chkRound.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1123, 653);
            this.Controls.Add(this.chkRound);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblGasPerGallon);
            this.Controls.Add(this.lblTotalDistance);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtGasPrice);
            this.Controls.Add(this.txtTotalDistance);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Name = "Form1";
            this.Text = " Gas Bill Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtTotalDistance;
        private System.Windows.Forms.TextBox txtGasPrice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblTotalDistance;
        private System.Windows.Forms.Label lblGasPerGallon;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.CheckBox chkRound;
    }
}

