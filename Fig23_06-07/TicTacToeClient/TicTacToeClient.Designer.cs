partial class TicTacToeClientForm
{
   /// <summary>
   /// Required designer variable.
   /// </summary>
   private System.ComponentModel.IContainer components = null;

   /// <summary>
   /// Clean up any resources being used.
   /// </summary>
   /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
   protected override void Dispose( bool disposing )
   {
      if (disposing && (components != null))
      {
         components.Dispose();
      }
      base.Dispose( disposing );
   }

   #region Windows Form Designer generated code

   /// <summary>
   /// Required method for Designer support - do not modify
   /// the contents of this method with the code editor.
   /// </summary>
   private void InitializeComponent()
   {
            this.idLabel = new System.Windows.Forms.Label();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.board0Panel = new System.Windows.Forms.Panel();
            this.board3Panel = new System.Windows.Forms.Panel();
            this.board6Panel = new System.Windows.Forms.Panel();
            this.board7Panel = new System.Windows.Forms.Panel();
            this.board4Panel = new System.Windows.Forms.Panel();
            this.board1Panel = new System.Windows.Forms.Panel();
            this.board8Panel = new System.Windows.Forms.Panel();
            this.board5Panel = new System.Windows.Forms.Panel();
            this.board2Panel = new System.Windows.Forms.Panel();
            this.BT_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(17, 16);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(89, 17);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "connecting...";
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(16, 225);
            this.displayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayTextBox.Size = new System.Drawing.Size(356, 86);
            this.displayTextBox.TabIndex = 1;
            // 
            // board0Panel
            // 
            this.board0Panel.BackColor = System.Drawing.SystemColors.Window;
            this.board0Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board0Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.board0Panel.Location = new System.Drawing.Point(97, 37);
            this.board0Panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.board0Panel.Name = "board0Panel";
            this.board0Panel.Size = new System.Drawing.Size(59, 54);
            this.board0Panel.TabIndex = 2;
            this.board0Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.square_MouseUp);
            // 
            // board3Panel
            // 
            this.board3Panel.BackColor = System.Drawing.SystemColors.Window;
            this.board3Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board3Panel.Location = new System.Drawing.Point(97, 100);
            this.board3Panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.board3Panel.Name = "board3Panel";
            this.board3Panel.Size = new System.Drawing.Size(59, 54);
            this.board3Panel.TabIndex = 3;
            this.board3Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.square_MouseUp);
            // 
            // board6Panel
            // 
            this.board6Panel.BackColor = System.Drawing.SystemColors.Window;
            this.board6Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board6Panel.Location = new System.Drawing.Point(97, 162);
            this.board6Panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.board6Panel.Name = "board6Panel";
            this.board6Panel.Size = new System.Drawing.Size(59, 54);
            this.board6Panel.TabIndex = 3;
            this.board6Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.square_MouseUp);
            // 
            // board7Panel
            // 
            this.board7Panel.BackColor = System.Drawing.SystemColors.Window;
            this.board7Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board7Panel.Location = new System.Drawing.Point(165, 162);
            this.board7Panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.board7Panel.Name = "board7Panel";
            this.board7Panel.Size = new System.Drawing.Size(59, 54);
            this.board7Panel.TabIndex = 6;
            this.board7Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.square_MouseUp);
            // 
            // board4Panel
            // 
            this.board4Panel.BackColor = System.Drawing.SystemColors.Window;
            this.board4Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board4Panel.Location = new System.Drawing.Point(165, 100);
            this.board4Panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.board4Panel.Name = "board4Panel";
            this.board4Panel.Size = new System.Drawing.Size(59, 54);
            this.board4Panel.TabIndex = 5;
            this.board4Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.square_MouseUp);
            // 
            // board1Panel
            // 
            this.board1Panel.BackColor = System.Drawing.SystemColors.Window;
            this.board1Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board1Panel.Location = new System.Drawing.Point(165, 37);
            this.board1Panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.board1Panel.Name = "board1Panel";
            this.board1Panel.Size = new System.Drawing.Size(59, 54);
            this.board1Panel.TabIndex = 4;
            this.board1Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.square_MouseUp);
            // 
            // board8Panel
            // 
            this.board8Panel.BackColor = System.Drawing.SystemColors.Window;
            this.board8Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board8Panel.Location = new System.Drawing.Point(233, 162);
            this.board8Panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.board8Panel.Name = "board8Panel";
            this.board8Panel.Size = new System.Drawing.Size(59, 54);
            this.board8Panel.TabIndex = 6;
            this.board8Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.square_MouseUp);
            // 
            // board5Panel
            // 
            this.board5Panel.BackColor = System.Drawing.SystemColors.Window;
            this.board5Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board5Panel.Location = new System.Drawing.Point(233, 100);
            this.board5Panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.board5Panel.Name = "board5Panel";
            this.board5Panel.Size = new System.Drawing.Size(59, 54);
            this.board5Panel.TabIndex = 5;
            this.board5Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.square_MouseUp);
            // 
            // board2Panel
            // 
            this.board2Panel.BackColor = System.Drawing.SystemColors.Window;
            this.board2Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board2Panel.Location = new System.Drawing.Point(233, 37);
            this.board2Panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.board2Panel.Name = "board2Panel";
            this.board2Panel.Size = new System.Drawing.Size(59, 54);
            this.board2Panel.TabIndex = 4;
            this.board2Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.square_MouseUp);
            // 
            // BT_reset
            // 
            this.BT_reset.Location = new System.Drawing.Point(309, 37);
            this.BT_reset.Name = "BT_reset";
            this.BT_reset.Size = new System.Drawing.Size(63, 54);
            this.BT_reset.TabIndex = 7;
            this.BT_reset.Text = "Reset";
            this.BT_reset.UseVisualStyleBackColor = true;
            this.BT_reset.Click += new System.EventHandler(this.BT_reset_Click);
            // 
            // TicTacToeClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 327);
            this.Controls.Add(this.BT_reset);
            this.Controls.Add(this.board8Panel);
            this.Controls.Add(this.board7Panel);
            this.Controls.Add(this.board5Panel);
            this.Controls.Add(this.board6Panel);
            this.Controls.Add(this.board2Panel);
            this.Controls.Add(this.board4Panel);
            this.Controls.Add(this.board3Panel);
            this.Controls.Add(this.board1Panel);
            this.Controls.Add(this.board0Panel);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.idLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TicTacToeClientForm";
            this.Text = "Tic Tac Toe Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TicTacToeClientForm_FormClosing);
            this.Load += new System.EventHandler(this.TicTacToeClientForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TicTacToeClientForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

   }

   #endregion

   private System.Windows.Forms.Label idLabel;
   private System.Windows.Forms.TextBox displayTextBox;
   private System.Windows.Forms.Panel board0Panel;
   private System.Windows.Forms.Panel board3Panel;
   private System.Windows.Forms.Panel board6Panel;
   private System.Windows.Forms.Panel board7Panel;
   private System.Windows.Forms.Panel board4Panel;
   private System.Windows.Forms.Panel board1Panel;
   private System.Windows.Forms.Panel board8Panel;
   private System.Windows.Forms.Panel board5Panel;
   private System.Windows.Forms.Panel board2Panel;
    private System.Windows.Forms.Button BT_reset;
}

