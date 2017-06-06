namespace InstrumentacionGUI
{
	partial class Calc_tab
	{
		/// <summary> 
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de componentes

		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
			this.Resultado = new ns1.BunifuMetroTextbox();
			this.Valor2 = new ns1.BunifuMetroTextbox();
			this.Valor1 = new ns1.BunifuMetroTextbox();
			this.bunifuCustomLabel7 = new ns1.BunifuCustomLabel();
			this.bunifuDropdown1 = new ns1.BunifuDropdown();
			this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
			this.SuspendLayout();
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(424, 42);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(0, 13);
			this.bunifuCustomLabel1.TabIndex = 0;
			// 
			// Resultado
			// 
			this.Resultado.BorderColorFocused = System.Drawing.Color.Black;
			this.Resultado.BorderColorIdle = System.Drawing.Color.Black;
			this.Resultado.BorderColorMouseHover = System.Drawing.Color.Black;
			this.Resultado.BorderThickness = 1;
			this.Resultado.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Resultado.Font = new System.Drawing.Font("Century Gothic", 19.75F);
			this.Resultado.ForeColor = System.Drawing.Color.Black;
			this.Resultado.isPassword = false;
			this.Resultado.Location = new System.Drawing.Point(493, 110);
			this.Resultado.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.Resultado.Name = "Resultado";
			this.Resultado.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
			this.Resultado.Size = new System.Drawing.Size(182, 43);
			this.Resultado.TabIndex = 27;
			this.Resultado.Text = "Resultado";
			this.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// Valor2
			// 
			this.Valor2.BorderColorFocused = System.Drawing.Color.Black;
			this.Valor2.BorderColorIdle = System.Drawing.Color.Black;
			this.Valor2.BorderColorMouseHover = System.Drawing.Color.Black;
			this.Valor2.BorderThickness = 1;
			this.Valor2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Valor2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.Valor2.ForeColor = System.Drawing.Color.Black;
			this.Valor2.isPassword = false;
			this.Valor2.Location = new System.Drawing.Point(376, 110);
			this.Valor2.Margin = new System.Windows.Forms.Padding(4);
			this.Valor2.Name = "Valor2";
			this.Valor2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.Valor2.Size = new System.Drawing.Size(56, 44);
			this.Valor2.TabIndex = 26;
			this.Valor2.Text = "0";
			this.Valor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.Valor2.OnValueChanged += new System.EventHandler(this.Valor2_OnValueChanged);
			// 
			// Valor1
			// 
			this.Valor1.BorderColorFocused = System.Drawing.Color.Black;
			this.Valor1.BorderColorIdle = System.Drawing.Color.Black;
			this.Valor1.BorderColorMouseHover = System.Drawing.Color.Black;
			this.Valor1.BorderThickness = 1;
			this.Valor1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Valor1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.Valor1.ForeColor = System.Drawing.Color.Black;
			this.Valor1.isPassword = false;
			this.Valor1.Location = new System.Drawing.Point(154, 110);
			this.Valor1.Margin = new System.Windows.Forms.Padding(4);
			this.Valor1.Name = "Valor1";
			this.Valor1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.Valor1.Size = new System.Drawing.Size(58, 44);
			this.Valor1.TabIndex = 25;
			this.Valor1.Text = "0";
			this.Valor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuCustomLabel7
			// 
			this.bunifuCustomLabel7.AutoSize = true;
			this.bunifuCustomLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.bunifuCustomLabel7.Location = new System.Drawing.Point(19, 22);
			this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
			this.bunifuCustomLabel7.Size = new System.Drawing.Size(275, 33);
			this.bunifuCustomLabel7.TabIndex = 24;
			this.bunifuCustomLabel7.Text = "Calculadora básica";
			// 
			// bunifuDropdown1
			// 
			this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuDropdown1.BorderRadius = 3;
			this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
			this.bunifuDropdown1.Items = new string[] {
        "Suma",
        "Resta",
        "División",
        "Multiplicación"};
			this.bunifuDropdown1.Location = new System.Drawing.Point(219, 112);
			this.bunifuDropdown1.Name = "bunifuDropdown1";
			this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(112)))), ((int)(((byte)(217)))));
			this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(112)))), ((int)(((byte)(217)))));
			this.bunifuDropdown1.selectedIndex = 0;
			this.bunifuDropdown1.Size = new System.Drawing.Size(150, 42);
			this.bunifuDropdown1.TabIndex = 23;
			// 
			// bunifuCustomLabel2
			// 
			this.bunifuCustomLabel2.AutoSize = true;
			this.bunifuCustomLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.bunifuCustomLabel2.Location = new System.Drawing.Point(451, 116);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new System.Drawing.Size(31, 33);
			this.bunifuCustomLabel2.TabIndex = 28;
			this.bunifuCustomLabel2.Text = "=";
			// 
			// Calc_tab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Controls.Add(this.bunifuCustomLabel2);
			this.Controls.Add(this.Resultado);
			this.Controls.Add(this.Valor2);
			this.Controls.Add(this.Valor1);
			this.Controls.Add(this.bunifuCustomLabel7);
			this.Controls.Add(this.bunifuDropdown1);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Name = "Calc_tab";
			this.Size = new System.Drawing.Size(839, 255);
			this.Load += new System.EventHandler(this.Calc_tab_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ns1.BunifuCustomLabel bunifuCustomLabel1;
		private ns1.BunifuMetroTextbox Resultado;
		private ns1.BunifuMetroTextbox Valor2;
		private ns1.BunifuMetroTextbox Valor1;
		private ns1.BunifuCustomLabel bunifuCustomLabel7;
		private ns1.BunifuDropdown bunifuDropdown1;
		private ns1.BunifuCustomLabel bunifuCustomLabel2;
	}
}
