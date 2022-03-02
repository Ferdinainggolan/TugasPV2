/*
 * Created by SharpDevelop.
 * User: FERDI NAINGGOLAN
 * Date: 3/2/2022
 * Time: 3:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace latihan_ferdi
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.KLIK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nama : ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(15, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 31);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nim : ";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(15, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 31);
			this.label3.TabIndex = 2;
			this.label3.Text = "Kom : ";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(15, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(119, 31);
			this.label4.TabIndex = 3;
			this.label4.Text = "Mata Kuliah : ";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(118, 14);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(206, 20);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "Ferdi Nainggolan";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(118, 58);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(206, 20);
			this.textBox2.TabIndex = 5;
			this.textBox2.Text = "201401145";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(118, 106);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(206, 20);
			this.textBox3.TabIndex = 6;
			this.textBox3.Text = "A";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(118, 155);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(206, 20);
			this.textBox4.TabIndex = 7;
			this.textBox4.Text = "Pemrograman Visual";
			// 
			// KLIK
			// 
			this.KLIK.Location = new System.Drawing.Point(444, 48);
			this.KLIK.Name = "KLIK";
			this.KLIK.Size = new System.Drawing.Size(188, 108);
			this.KLIK.TabIndex = 8;
			this.KLIK.Text = "KLIK SAYA";
			this.KLIK.UseVisualStyleBackColor = true;
			this.KLIK.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(694, 261);
			this.Controls.Add(this.KLIK);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "latihan_ferdi";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button KLIK;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
