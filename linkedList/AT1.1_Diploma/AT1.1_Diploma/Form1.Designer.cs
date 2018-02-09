namespace AT1._1_Diploma
{
	partial class LinkedLists
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinkedLists));
			this.listBoxOutput = new System.Windows.Forms.ListBox();
			this.AddFirstBtn = new System.Windows.Forms.Button();
			this.textBoxCarName = new System.Windows.Forms.TextBox();
			this.AddLastBtn = new System.Windows.Forms.Button();
			this.AddBeforeBtn = new System.Windows.Forms.Button();
			this.ClearBtn = new System.Windows.Forms.Button();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxNodePosition = new System.Windows.Forms.TextBox();
			this.AddAfterBtn = new System.Windows.Forms.Button();
			this.textBoxNumOfNodes = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.FindBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBoxOutput
			// 
			this.listBoxOutput.AllowDrop = true;
			this.listBoxOutput.FormattingEnabled = true;
			this.listBoxOutput.Location = new System.Drawing.Point(6, 10);
			this.listBoxOutput.Name = "listBoxOutput";
			this.listBoxOutput.Size = new System.Drawing.Size(205, 264);
			this.listBoxOutput.TabIndex = 0;
			this.listBoxOutput.Click += new System.EventHandler(this.listBoxOutput_Click);
			//this.listBoxOutput.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxOutput_DragDrop_1);
			//this.listBoxOutput.DragOver += new System.Windows.Forms.DragEventHandler(this.listBoxOutput_DragOver_1);
			//this.listBoxOutput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxOutput_MouseDown_1);
			// 
			// AddFirstBtn
			// 
			this.AddFirstBtn.Location = new System.Drawing.Point(220, 61);
			this.AddFirstBtn.Name = "AddFirstBtn";
			this.AddFirstBtn.Size = new System.Drawing.Size(75, 23);
			this.AddFirstBtn.TabIndex = 1;
			this.AddFirstBtn.Text = "Add First";
			this.AddFirstBtn.UseVisualStyleBackColor = true;
			this.AddFirstBtn.Click += new System.EventHandler(this.AddFirstBtn_Click);
			// 
			// textBoxCarName
			// 
			this.textBoxCarName.Location = new System.Drawing.Point(220, 26);
			this.textBoxCarName.Name = "textBoxCarName";
			this.textBoxCarName.Size = new System.Drawing.Size(93, 20);
			this.textBoxCarName.TabIndex = 1;
			// 
			// AddLastBtn
			// 
			this.AddLastBtn.Location = new System.Drawing.Point(220, 102);
			this.AddLastBtn.Name = "AddLastBtn";
			this.AddLastBtn.Size = new System.Drawing.Size(75, 23);
			this.AddLastBtn.TabIndex = 3;
			this.AddLastBtn.Text = "Add Last";
			this.AddLastBtn.UseVisualStyleBackColor = true;
			this.AddLastBtn.Click += new System.EventHandler(this.AddLastBtn_Click);
			// 
			// AddBeforeBtn
			// 
			this.AddBeforeBtn.Location = new System.Drawing.Point(387, 61);
			this.AddBeforeBtn.Name = "AddBeforeBtn";
			this.AddBeforeBtn.Size = new System.Drawing.Size(75, 23);
			this.AddBeforeBtn.TabIndex = 4;
			this.AddBeforeBtn.Text = "Add Before";
			this.AddBeforeBtn.UseVisualStyleBackColor = true;
			this.AddBeforeBtn.Click += new System.EventHandler(this.AddBeforeBtn_Click);
			// 
			// ClearBtn
			// 
			this.ClearBtn.Location = new System.Drawing.Point(220, 249);
			this.ClearBtn.Name = "ClearBtn";
			this.ClearBtn.Size = new System.Drawing.Size(75, 23);
			this.ClearBtn.TabIndex = 5;
			this.ClearBtn.Text = "Clear";
			this.ClearBtn.UseVisualStyleBackColor = true;
			this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.Location = new System.Drawing.Point(220, 208);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
			this.DeleteBtn.TabIndex = 6;
			this.DeleteBtn.Text = "Delete";
			this.DeleteBtn.UseVisualStyleBackColor = true;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(217, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Car Name";
			// 
			// textBoxNodePosition
			// 
			this.textBoxNodePosition.Location = new System.Drawing.Point(387, 26);
			this.textBoxNodePosition.Name = "textBoxNodePosition";
			this.textBoxNodePosition.ReadOnly = true;
			this.textBoxNodePosition.Size = new System.Drawing.Size(93, 20);
			this.textBoxNodePosition.TabIndex = 8;
			this.textBoxNodePosition.TabStop = false;
			// 
			// AddAfterBtn
			// 
			this.AddAfterBtn.Location = new System.Drawing.Point(387, 102);
			this.AddAfterBtn.Name = "AddAfterBtn";
			this.AddAfterBtn.Size = new System.Drawing.Size(75, 23);
			this.AddAfterBtn.TabIndex = 9;
			this.AddAfterBtn.Text = "Add After";
			this.AddAfterBtn.UseVisualStyleBackColor = true;
			this.AddAfterBtn.Click += new System.EventHandler(this.AddAfterBtn_Click);
			// 
			// textBoxNumOfNodes
			// 
			this.textBoxNumOfNodes.Location = new System.Drawing.Point(387, 208);
			this.textBoxNumOfNodes.Name = "textBoxNumOfNodes";
			this.textBoxNumOfNodes.ReadOnly = true;
			this.textBoxNumOfNodes.Size = new System.Drawing.Size(93, 20);
			this.textBoxNumOfNodes.TabIndex = 10;
			this.textBoxNumOfNodes.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(384, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Node Position";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(384, 192);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Number of Nodes";
			// 
			// FindBtn
			// 
			this.FindBtn.Location = new System.Drawing.Point(220, 140);
			this.FindBtn.Name = "FindBtn";
			this.FindBtn.Size = new System.Drawing.Size(75, 23);
			this.FindBtn.TabIndex = 13;
			this.FindBtn.Text = "Find";
			this.FindBtn.UseVisualStyleBackColor = true;
			this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
			// 
			// LinkedLists
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(500, 284);
			this.Controls.Add(this.FindBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxNumOfNodes);
			this.Controls.Add(this.AddAfterBtn);
			this.Controls.Add(this.textBoxNodePosition);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.DeleteBtn);
			this.Controls.Add(this.ClearBtn);
			this.Controls.Add(this.AddBeforeBtn);
			this.Controls.Add(this.AddLastBtn);
			this.Controls.Add(this.textBoxCarName);
			this.Controls.Add(this.AddFirstBtn);
			this.Controls.Add(this.listBoxOutput);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LinkedLists";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Linked Lists";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxOutput;
		private System.Windows.Forms.Button AddFirstBtn;
		private System.Windows.Forms.TextBox textBoxCarName;
		private System.Windows.Forms.Button AddLastBtn;
		private System.Windows.Forms.Button AddBeforeBtn;
		private System.Windows.Forms.Button ClearBtn;
		private System.Windows.Forms.Button DeleteBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button AddAfterBtn;
		private System.Windows.Forms.TextBox textBoxNumOfNodes;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button FindBtn;
		internal System.Windows.Forms.TextBox textBoxNodePosition;
	}
}

