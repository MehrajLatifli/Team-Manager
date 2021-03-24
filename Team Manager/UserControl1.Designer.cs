
namespace Team_Manager
{
    partial class MemberOfTeam
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PositiontextBox = new System.Windows.Forms.TextBox();
            this.NumbertextBox = new System.Windows.Forms.TextBox();
            this.FullNametextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PositiontextBox
            // 
            this.PositiontextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositiontextBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.PositiontextBox.Location = new System.Drawing.Point(40, 40);
            this.PositiontextBox.Name = "PositiontextBox";
            this.PositiontextBox.ReadOnly = true;
            this.PositiontextBox.Size = new System.Drawing.Size(229, 38);
            this.PositiontextBox.TabIndex = 24;
            // 
            // NumbertextBox
            // 
            this.NumbertextBox.AcceptsReturn = true;
            this.NumbertextBox.AcceptsTab = true;
            this.NumbertextBox.AllowDrop = true;
            this.NumbertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumbertextBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.NumbertextBox.HideSelection = false;
            this.NumbertextBox.Location = new System.Drawing.Point(343, 40);
            this.NumbertextBox.MaxLength = 2;
            this.NumbertextBox.Name = "NumbertextBox";
            this.NumbertextBox.Size = new System.Drawing.Size(112, 38);
            this.NumbertextBox.TabIndex = 35;
            this.NumbertextBox.TextChanged += new System.EventHandler(this.NtextBox22_TextChanged);
            this.NumbertextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NtextBox22_KeyPress);
            // 
            // FullNametextBox
            // 
            this.FullNametextBox.AcceptsReturn = true;
            this.FullNametextBox.AcceptsTab = true;
            this.FullNametextBox.AllowDrop = true;
            this.FullNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNametextBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.FullNametextBox.HideSelection = false;
            this.FullNametextBox.Location = new System.Drawing.Point(527, 40);
            this.FullNametextBox.MaxLength = 20;
            this.FullNametextBox.Name = "FullNametextBox";
            this.FullNametextBox.Size = new System.Drawing.Size(355, 38);
            this.FullNametextBox.TabIndex = 46;
            this.FullNametextBox.TextChanged += new System.EventHandler(this.FullNametextBox_TextChanged);
            // 
            // MemberOfTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.Controls.Add(this.FullNametextBox);
            this.Controls.Add(this.NumbertextBox);
            this.Controls.Add(this.PositiontextBox);
            this.Name = "MemberOfTeam";
            this.Size = new System.Drawing.Size(1030, 119);
      
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox PositiontextBox;
        public System.Windows.Forms.TextBox NumbertextBox;
        public System.Windows.Forms.TextBox FullNametextBox;
    }
}
