namespace KeyAuth
{
	// Token: 0x02000006 RID: 6
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00005A34 File Offset: 0x00003C34
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			bool flag2 = flag;
			if (flag2)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005A70 File Offset: 0x00003C70
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::KeyAuth.Login));
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label1 = new global::System.Windows.Forms.Label();
			this.key = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.siticoneRoundedGradientButton2 = new global::Siticone.UI.WinForms.SiticoneRoundedGradientButton();
			this.siticoneCustomGradientPanel3 = new global::Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
			this.label13 = new global::System.Windows.Forms.Label();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.siticoneDragControl1.TargetControl = this;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.Animated = false;
			this.siticoneControlBox1.BorderColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.siticoneControlBox1.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(344, 4);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox1.TabIndex = 1;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.siticoneTransition1.AnimationType = global::Siticone.UI.AnimatorNS.AnimationType.Rotate;
			this.siticoneTransition1.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.siticoneTransition1.DefaultAnimation = animation;
			this.label1.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Light", 10f);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(-1, 136);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 19);
			this.label1.TabIndex = 22;
			this.key.AllowDrop = true;
			this.key.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.key.BorderColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.key.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.key, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.key.DefaultText = "Key";
			this.key.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.key.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.key.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.key.DisabledState.Parent = this.key;
			this.key.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.key.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.key.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.key.FocusedState.Parent = this.key;
			this.key.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.key.HoveredState.Parent = this.key;
			this.key.Location = new global::System.Drawing.Point(65, 205);
			this.key.Margin = new global::System.Windows.Forms.Padding(4);
			this.key.Name = "key";
			this.key.PasswordChar = '\0';
			this.key.PlaceholderText = "";
			this.key.SelectedText = "";
			this.key.ShadowDecoration.Parent = this.key;
			this.key.Size = new global::System.Drawing.Size(273, 40);
			this.key.TabIndex = 32;
			this.key.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.key.TextChanged += new global::System.EventHandler(this.key_TextChanged);
			this.siticoneTransition1.SetDecoration(this.pictureBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(-2, -3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(410, 171);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 36;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.siticoneRoundedGradientButton2.CheckedState.Parent = this.siticoneRoundedGradientButton2;
			this.siticoneRoundedGradientButton2.CustomImages.Parent = this.siticoneRoundedGradientButton2;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedGradientButton2.FillColor = global::System.Drawing.Color.FromArgb(14, 15, 9);
			this.siticoneRoundedGradientButton2.FillColor2 = global::System.Drawing.Color.FromArgb(254, 254, 252);
			this.siticoneRoundedGradientButton2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneRoundedGradientButton2.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedGradientButton2.HoveredState.Parent = this.siticoneRoundedGradientButton2;
			this.siticoneRoundedGradientButton2.Location = new global::System.Drawing.Point(86, 263);
			this.siticoneRoundedGradientButton2.Name = "siticoneRoundedGradientButton2";
			this.siticoneRoundedGradientButton2.ShadowDecoration.Parent = this.siticoneRoundedGradientButton2;
			this.siticoneRoundedGradientButton2.Size = new global::System.Drawing.Size(230, 45);
			this.siticoneRoundedGradientButton2.TabIndex = 38;
			this.siticoneRoundedGradientButton2.Text = "Login";
			this.siticoneRoundedGradientButton2.Click += new global::System.EventHandler(this.siticoneRoundedGradientButton2_Click);
			this.siticoneCustomGradientPanel3.BackColor = global::System.Drawing.Color.FromArgb(254, 254, 252);
			this.siticoneTransition1.SetDecoration(this.siticoneCustomGradientPanel3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneCustomGradientPanel3.FillColor = global::System.Drawing.Color.FromArgb(14, 15, 9);
			this.siticoneCustomGradientPanel3.FillColor2 = global::System.Drawing.Color.FromArgb(254, 254, 252);
			this.siticoneCustomGradientPanel3.FillColor3 = global::System.Drawing.Color.FromArgb(254, 254, 252);
			this.siticoneCustomGradientPanel3.FillColor4 = global::System.Drawing.Color.FromArgb(254, 254, 252);
			this.siticoneCustomGradientPanel3.Location = new global::System.Drawing.Point(56, 192);
			this.siticoneCustomGradientPanel3.Name = "siticoneCustomGradientPanel3";
			this.siticoneCustomGradientPanel3.ShadowDecoration.Parent = this.siticoneCustomGradientPanel3;
			this.siticoneCustomGradientPanel3.Size = new global::System.Drawing.Size(287, 4);
			this.siticoneCustomGradientPanel3.TabIndex = 41;
			this.label13.AutoSize = true;
			this.label13.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.label13, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label13.Font = new global::System.Drawing.Font("Consolas", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label13.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label13.Location = new global::System.Drawing.Point(53, 171);
			this.label13.Margin = new global::System.Windows.Forms.Padding(9, 0, 9, 0);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(48, 18);
			this.label13.TabIndex = 55;
			this.label13.Text = "Login";
			this.siticoneBorderlessForm1.BorderRadius = 30;
			this.siticoneBorderlessForm1.ContainerControl = this;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			base.ClientSize = new global::System.Drawing.Size(393, 342);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.siticoneCustomGradientPanel3);
			base.Controls.Add(this.siticoneRoundedGradientButton2);
			base.Controls.Add(this.key);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneControlBox1);
			base.Controls.Add(this.pictureBox1);
			this.siticoneTransition1.SetDecoration(this, global::Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Login";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Loader";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.Load += new global::System.EventHandler(this.Login_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400003B RID: 59
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400003C RID: 60
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x0400003D RID: 61
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x0400003E RID: 62
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000040 RID: 64
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x04000041 RID: 65
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox key;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000043 RID: 67
		private global::Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton2;

		// Token: 0x04000044 RID: 68
		private global::Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel3;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000046 RID: 70
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
	}
}
