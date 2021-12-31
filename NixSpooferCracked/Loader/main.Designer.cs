namespace KeyAuth
{
	// Token: 0x02000005 RID: 5
	public partial class main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00003680 File Offset: 0x00001880
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

		// Token: 0x06000032 RID: 50 RVA: 0x000036BC File Offset: 0x000018BC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::KeyAuth.main));
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.label13 = new global::System.Windows.Forms.Label();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.label17 = new global::System.Windows.Forms.Label();
			this.free = new global::System.Windows.Forms.Panel();
			this.label14 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.panel7 = new global::System.Windows.Forms.Panel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel6 = new global::System.Windows.Forms.Panel();
			this.panel5 = new global::System.Windows.Forms.Panel();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.siticoneRoundedGradientButton1 = new global::Siticone.UI.WinForms.SiticoneRoundedGradientButton();
			this.siticoneRoundedGradientButton2 = new global::Siticone.UI.WinForms.SiticoneRoundedGradientButton();
			this.siticoneRoundedGradientButton3 = new global::Siticone.UI.WinForms.SiticoneRoundedGradientButton();
			this.siticoneRoundedGradientButton4 = new global::Siticone.UI.WinForms.SiticoneRoundedGradientButton();
			this.siticoneRoundedGradientButton5 = new global::Siticone.UI.WinForms.SiticoneRoundedGradientButton();
			this.siticoneRoundedGradientButton6 = new global::Siticone.UI.WinForms.SiticoneRoundedGradientButton();
			this.siticoneRoundedGradientButton7 = new global::Siticone.UI.WinForms.SiticoneRoundedGradientButton();
			this.siticoneRoundedGradientButton8 = new global::Siticone.UI.WinForms.SiticoneRoundedGradientButton();
			this.siticoneElipse1 = new global::Siticone.Desktop.UI.WinForms.SiticoneElipse(this.components);
			this.siticoneElipse2 = new global::Siticone.Desktop.UI.WinForms.SiticoneElipse(this.components);
			this.siticoneElipse3 = new global::Siticone.Desktop.UI.WinForms.SiticoneElipse(this.components);
			this.siticoneElipse4 = new global::Siticone.Desktop.UI.WinForms.SiticoneElipse(this.components);
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel2.SuspendLayout();
			this.free.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
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
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(775, 4);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox1.TabIndex = 1;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.siticoneTransition1.AnimationType = global::Siticone.UI.AnimatorNS.AnimationType.Rotate;
			this.siticoneTransition1.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.SlideCoeff");
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
			this.siticoneTransition1.SetDecoration(this.pictureBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(33, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(730, 126);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 25;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.panel2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.label17);
			this.siticoneTransition1.SetDecoration(this.panel2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel2.ForeColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.panel2.Location = new global::System.Drawing.Point(336, 138);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(449, 197);
			this.panel2.TabIndex = 39;
			this.panel2.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			this.label13.AutoSize = true;
			this.label13.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.label13, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label13.Font = new global::System.Drawing.Font("Berlin Sans FB", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label13.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label13.Location = new global::System.Drawing.Point(25, 15);
			this.label13.Margin = new global::System.Windows.Forms.Padding(9, 0, 9, 0);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(201, 23);
			this.label13.TabIndex = 54;
			this.label13.Text = "What is Nix's Spoofer ?";
			this.label13.Click += new global::System.EventHandler(this.label13_Click);
			this.panel4.BackColor = global::System.Drawing.Color.FromArgb(254, 254, 252);
			this.siticoneTransition1.SetDecoration(this.panel4, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel4.ForeColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.panel4.Location = new global::System.Drawing.Point(20, 16);
			this.panel4.Name = "panel4";
			this.panel4.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.panel4.Size = new global::System.Drawing.Size(4, 23);
			this.panel4.TabIndex = 39;
			this.label17.AutoSize = true;
			this.label17.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.label17, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label17.Font = new global::System.Drawing.Font("Verdana", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label17.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label17.Location = new global::System.Drawing.Point(4, 62);
			this.label17.Margin = new global::System.Windows.Forms.Padding(9, 0, 9, 0);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(442, 108);
			this.label17.TabIndex = 30;
			this.label17.Text = "Basically Nix's Spoofer is a HWID Spoofer and is able to \r\nget you  unbanned from some games. This is a tool that\r\ncan change your Serial ID's and remove a ban traces from\r\n games.\r\n\r\n\r\n";
			this.free.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.free.Controls.Add(this.label14);
			this.free.Controls.Add(this.label5);
			this.free.Controls.Add(this.label7);
			this.free.Controls.Add(this.label4);
			this.free.Controls.Add(this.label11);
			this.free.Controls.Add(this.label12);
			this.free.Controls.Add(this.panel3);
			this.free.Controls.Add(this.label9);
			this.free.Controls.Add(this.label10);
			this.free.Controls.Add(this.label6);
			this.free.Controls.Add(this.label8);
			this.free.Controls.Add(this.label3);
			this.siticoneTransition1.SetDecoration(this.free, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.free.ForeColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.free.Location = new global::System.Drawing.Point(43, 137);
			this.free.Name = "free";
			this.free.Size = new global::System.Drawing.Size(265, 350);
			this.free.TabIndex = 40;
			this.label14.AutoSize = true;
			this.label14.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.label14, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label14.Font = new global::System.Drawing.Font("Berlin Sans FB", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label14.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label14.Location = new global::System.Drawing.Point(22, 22);
			this.label14.Margin = new global::System.Windows.Forms.Padding(9, 0, 9, 0);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(184, 23);
			this.label14.TabIndex = 55;
			this.label14.Text = "System Informations";
			this.label5.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label5, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new global::System.Drawing.Point(19, 251);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(50, 20);
			this.label5.TabIndex = 57;
			this.label5.Text = "NULL";
			this.label7.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label7, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label7.Location = new global::System.Drawing.Point(19, 201);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(167, 20);
			this.label7.TabIndex = 56;
			this.label7.Text = "BFEBFBFF000206A7";
			this.label4.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label4, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new global::System.Drawing.Point(19, 140);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(86, 20);
			this.label4.TabIndex = 55;
			this.label4.Text = "73A64D88";
			this.label11.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label11, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label11.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label11.Location = new global::System.Drawing.Point(18, 84);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(108, 20);
			this.label11.TabIndex = 54;
			this.label11.Text = "AC0158BEZ9";
			this.label12.AutoSize = true;
			this.label12.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.label12, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label12.Font = new global::System.Drawing.Font("Verdana", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label12.ForeColor = global::System.Drawing.Color.White;
			this.label12.Location = new global::System.Drawing.Point(18, 25);
			this.label12.Margin = new global::System.Windows.Forms.Padding(9, 0, 9, 0);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(0, 18);
			this.label12.TabIndex = 41;
			this.panel3.BackColor = global::System.Drawing.Color.Gray;
			this.panel3.Controls.Add(this.panel7);
			this.panel3.Controls.Add(this.panel1);
			this.siticoneTransition1.SetDecoration(this.panel3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel3.ForeColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.panel3.Location = new global::System.Drawing.Point(17, 22);
			this.panel3.Name = "panel3";
			this.panel3.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.panel3.Size = new global::System.Drawing.Size(5, 26);
			this.panel3.TabIndex = 38;
			this.panel7.BackColor = global::System.Drawing.Color.FromArgb(254, 254, 252);
			this.siticoneTransition1.SetDecoration(this.panel7, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel7.ForeColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.panel7.Location = new global::System.Drawing.Point(0, 1);
			this.panel7.Name = "panel7";
			this.panel7.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.panel7.Size = new global::System.Drawing.Size(4, 23);
			this.panel7.TabIndex = 40;
			this.panel1.BackColor = global::System.Drawing.Color.Gray;
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Controls.Add(this.panel5);
			this.siticoneTransition1.SetDecoration(this.panel1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel1.ForeColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.panel1.Location = new global::System.Drawing.Point(1, 3);
			this.panel1.Name = "panel1";
			this.panel1.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.panel1.Size = new global::System.Drawing.Size(4, 23);
			this.panel1.TabIndex = 40;
			this.panel6.BackColor = global::System.Drawing.Color.Gray;
			this.siticoneTransition1.SetDecoration(this.panel6, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel6.ForeColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.panel6.Location = new global::System.Drawing.Point(0, 1);
			this.panel6.Name = "panel6";
			this.panel6.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.panel6.Size = new global::System.Drawing.Size(4, 23);
			this.panel6.TabIndex = 68;
			this.panel5.BackColor = global::System.Drawing.Color.Gray;
			this.siticoneTransition1.SetDecoration(this.panel5, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel5.ForeColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.panel5.Location = new global::System.Drawing.Point(2, 1);
			this.panel5.Name = "panel5";
			this.panel5.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.panel5.Size = new global::System.Drawing.Size(4, 23);
			this.panel5.TabIndex = 40;
			this.label9.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label9, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.ForeColor = global::System.Drawing.Color.White;
			this.label9.Location = new global::System.Drawing.Point(18, 251);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(42, 16);
			this.label9.TabIndex = 37;
			this.label9.Text = "NULL";
			this.label10.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label10, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.ForeColor = global::System.Drawing.Color.Gray;
			this.label10.Location = new global::System.Drawing.Point(18, 236);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(71, 15);
			this.label10.TabIndex = 36;
			this.label10.Text = "Base Board";
			this.label6.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label6, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.Gray;
			this.label6.Location = new global::System.Drawing.Point(18, 183);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(32, 15);
			this.label6.TabIndex = 34;
			this.label6.Text = "CPU";
			this.label8.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label8, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.Color.Gray;
			this.label8.Location = new global::System.Drawing.Point(18, 123);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(49, 15);
			this.label8.TabIndex = 32;
			this.label8.Text = "Volume";
			this.label3.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Gray;
			this.label3.Location = new global::System.Drawing.Point(18, 69);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(80, 15);
			this.label3.TabIndex = 28;
			this.label3.Text = "MAC Address";
			this.siticoneRoundedGradientButton1.CheckedState.Parent = this.siticoneRoundedGradientButton1;
			this.siticoneRoundedGradientButton1.CustomImages.Parent = this.siticoneRoundedGradientButton1;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedGradientButton1.FillColor = global::System.Drawing.Color.FromArgb(14, 15, 9);
			this.siticoneRoundedGradientButton1.FillColor2 = global::System.Drawing.Color.FromArgb(254, 254, 252);
			this.siticoneRoundedGradientButton1.Font = new global::System.Drawing.Font("Microsoft JhengHei", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedGradientButton1.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.siticoneRoundedGradientButton1.HoveredState.Parent = this.siticoneRoundedGradientButton1;
			this.siticoneRoundedGradientButton1.Location = new global::System.Drawing.Point(343, 386);
			this.siticoneRoundedGradientButton1.Name = "siticoneRoundedGradientButton1";
			this.siticoneRoundedGradientButton1.ShadowDecoration.Parent = this.siticoneRoundedGradientButton1;
			this.siticoneRoundedGradientButton1.Size = new global::System.Drawing.Size(109, 45);
			this.siticoneRoundedGradientButton1.TabIndex = 53;
			this.siticoneRoundedGradientButton1.Text = "Disk Drive";
			this.siticoneRoundedGradientButton1.Click += new global::System.EventHandler(this.siticoneRoundedGradientButton1_Click);
			this.siticoneRoundedGradientButton2.CheckedState.Parent = this.siticoneRoundedGradientButton2;
			this.siticoneRoundedGradientButton2.CustomImages.Parent = this.siticoneRoundedGradientButton2;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedGradientButton2.FillColor = global::System.Drawing.Color.FromArgb(14, 15, 9);
			this.siticoneRoundedGradientButton2.FillColor2 = global::System.Drawing.Color.FromArgb(254, 254, 252);
			this.siticoneRoundedGradientButton2.Font = new global::System.Drawing.Font("Microsoft JhengHei", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedGradientButton2.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.siticoneRoundedGradientButton2.HoveredState.Parent = this.siticoneRoundedGradientButton2;
			this.siticoneRoundedGradientButton2.Location = new global::System.Drawing.Point(455, 386);
			this.siticoneRoundedGradientButton2.Name = "siticoneRoundedGradientButton2";
			this.siticoneRoundedGradientButton2.ShadowDecoration.Parent = this.siticoneRoundedGradientButton2;
			this.siticoneRoundedGradientButton2.Size = new global::System.Drawing.Size(108, 45);
			this.siticoneRoundedGradientButton2.TabIndex = 61;
			this.siticoneRoundedGradientButton2.Text = "RAM";
			this.siticoneRoundedGradientButton2.Click += new global::System.EventHandler(this.siticoneRoundedGradientButton2_Click);
			this.siticoneRoundedGradientButton3.CheckedState.Parent = this.siticoneRoundedGradientButton3;
			this.siticoneRoundedGradientButton3.CustomImages.Parent = this.siticoneRoundedGradientButton3;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedGradientButton3.FillColor = global::System.Drawing.Color.FromArgb(14, 15, 9);
			this.siticoneRoundedGradientButton3.FillColor2 = global::System.Drawing.Color.FromArgb(254, 254, 252);
			this.siticoneRoundedGradientButton3.Font = new global::System.Drawing.Font("Microsoft JhengHei", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedGradientButton3.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.siticoneRoundedGradientButton3.HoveredState.Parent = this.siticoneRoundedGradientButton3;
			this.siticoneRoundedGradientButton3.Location = new global::System.Drawing.Point(566, 386);
			this.siticoneRoundedGradientButton3.Name = "siticoneRoundedGradientButton3";
			this.siticoneRoundedGradientButton3.ShadowDecoration.Parent = this.siticoneRoundedGradientButton3;
			this.siticoneRoundedGradientButton3.Size = new global::System.Drawing.Size(108, 45);
			this.siticoneRoundedGradientButton3.TabIndex = 62;
			this.siticoneRoundedGradientButton3.Text = "Bios";
			this.siticoneRoundedGradientButton3.Click += new global::System.EventHandler(this.siticoneRoundedGradientButton3_Click);
			this.siticoneRoundedGradientButton4.CheckedState.Parent = this.siticoneRoundedGradientButton4;
			this.siticoneRoundedGradientButton4.CustomImages.Parent = this.siticoneRoundedGradientButton4;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton4, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedGradientButton4.FillColor = global::System.Drawing.Color.FromArgb(14, 15, 9);
			this.siticoneRoundedGradientButton4.FillColor2 = global::System.Drawing.Color.FromArgb(254, 254, 252);
			this.siticoneRoundedGradientButton4.Font = new global::System.Drawing.Font("Microsoft JhengHei", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedGradientButton4.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.siticoneRoundedGradientButton4.HoveredState.Parent = this.siticoneRoundedGradientButton4;
			this.siticoneRoundedGradientButton4.Location = new global::System.Drawing.Point(677, 387);
			this.siticoneRoundedGradientButton4.Name = "siticoneRoundedGradientButton4";
			this.siticoneRoundedGradientButton4.ShadowDecoration.Parent = this.siticoneRoundedGradientButton4;
			this.siticoneRoundedGradientButton4.Size = new global::System.Drawing.Size(108, 45);
			this.siticoneRoundedGradientButton4.TabIndex = 63;
			this.siticoneRoundedGradientButton4.Text = "MAC";
			this.siticoneRoundedGradientButton4.Click += new global::System.EventHandler(this.siticoneRoundedGradientButton4_Click);
			this.siticoneRoundedGradientButton5.CheckedState.Parent = this.siticoneRoundedGradientButton5;
			this.siticoneRoundedGradientButton5.CustomImages.Parent = this.siticoneRoundedGradientButton5;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton5, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedGradientButton5.FillColor = global::System.Drawing.Color.FromArgb(14, 15, 9);
			this.siticoneRoundedGradientButton5.FillColor2 = global::System.Drawing.Color.FromArgb(254, 254, 252);
			this.siticoneRoundedGradientButton5.Font = new global::System.Drawing.Font("Microsoft JhengHei", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedGradientButton5.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.siticoneRoundedGradientButton5.HoveredState.Parent = this.siticoneRoundedGradientButton5;
			this.siticoneRoundedGradientButton5.Location = new global::System.Drawing.Point(344, 438);
			this.siticoneRoundedGradientButton5.Name = "siticoneRoundedGradientButton5";
			this.siticoneRoundedGradientButton5.ShadowDecoration.Parent = this.siticoneRoundedGradientButton5;
			this.siticoneRoundedGradientButton5.Size = new global::System.Drawing.Size(108, 45);
			this.siticoneRoundedGradientButton5.TabIndex = 64;
			this.siticoneRoundedGradientButton5.Text = "VolumeID";
			this.siticoneRoundedGradientButton5.Click += new global::System.EventHandler(this.siticoneRoundedGradientButton5_Click);
			this.siticoneRoundedGradientButton6.CheckedState.Parent = this.siticoneRoundedGradientButton6;
			this.siticoneRoundedGradientButton6.CustomImages.Parent = this.siticoneRoundedGradientButton6;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton6, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedGradientButton6.FillColor = global::System.Drawing.Color.FromArgb(14, 15, 9);
			this.siticoneRoundedGradientButton6.FillColor2 = global::System.Drawing.Color.FromArgb(254, 254, 252);
			this.siticoneRoundedGradientButton6.Font = new global::System.Drawing.Font("Microsoft JhengHei", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedGradientButton6.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.siticoneRoundedGradientButton6.HoveredState.Parent = this.siticoneRoundedGradientButton6;
			this.siticoneRoundedGradientButton6.Location = new global::System.Drawing.Point(455, 438);
			this.siticoneRoundedGradientButton6.Name = "siticoneRoundedGradientButton6";
			this.siticoneRoundedGradientButton6.ShadowDecoration.Parent = this.siticoneRoundedGradientButton6;
			this.siticoneRoundedGradientButton6.Size = new global::System.Drawing.Size(108, 45);
			this.siticoneRoundedGradientButton6.TabIndex = 65;
			this.siticoneRoundedGradientButton6.Text = "GPU";
			this.siticoneRoundedGradientButton6.Click += new global::System.EventHandler(this.siticoneRoundedGradientButton6_Click);
			this.siticoneRoundedGradientButton7.CheckedState.Parent = this.siticoneRoundedGradientButton7;
			this.siticoneRoundedGradientButton7.CustomImages.Parent = this.siticoneRoundedGradientButton7;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton7, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedGradientButton7.FillColor = global::System.Drawing.Color.FromArgb(14, 15, 9);
			this.siticoneRoundedGradientButton7.FillColor2 = global::System.Drawing.Color.FromArgb(254, 254, 252);
			this.siticoneRoundedGradientButton7.Font = new global::System.Drawing.Font("Microsoft JhengHei", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedGradientButton7.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.siticoneRoundedGradientButton7.HoveredState.Parent = this.siticoneRoundedGradientButton7;
			this.siticoneRoundedGradientButton7.Location = new global::System.Drawing.Point(566, 438);
			this.siticoneRoundedGradientButton7.Name = "siticoneRoundedGradientButton7";
			this.siticoneRoundedGradientButton7.ShadowDecoration.Parent = this.siticoneRoundedGradientButton7;
			this.siticoneRoundedGradientButton7.Size = new global::System.Drawing.Size(108, 45);
			this.siticoneRoundedGradientButton7.TabIndex = 66;
			this.siticoneRoundedGradientButton7.Text = "CPU";
			this.siticoneRoundedGradientButton7.Click += new global::System.EventHandler(this.siticoneRoundedGradientButton7_Click);
			this.siticoneRoundedGradientButton8.CheckedState.Parent = this.siticoneRoundedGradientButton8;
			this.siticoneRoundedGradientButton8.CustomImages.Parent = this.siticoneRoundedGradientButton8;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton8, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedGradientButton8.FillColor = global::System.Drawing.Color.FromArgb(14, 15, 9);
			this.siticoneRoundedGradientButton8.FillColor2 = global::System.Drawing.Color.FromArgb(254, 254, 252);
			this.siticoneRoundedGradientButton8.Font = new global::System.Drawing.Font("Microsoft JhengHei", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedGradientButton8.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.siticoneRoundedGradientButton8.HoveredState.Parent = this.siticoneRoundedGradientButton8;
			this.siticoneRoundedGradientButton8.Location = new global::System.Drawing.Point(677, 438);
			this.siticoneRoundedGradientButton8.Name = "siticoneRoundedGradientButton8";
			this.siticoneRoundedGradientButton8.ShadowDecoration.Parent = this.siticoneRoundedGradientButton8;
			this.siticoneRoundedGradientButton8.Size = new global::System.Drawing.Size(108, 45);
			this.siticoneRoundedGradientButton8.TabIndex = 67;
			this.siticoneRoundedGradientButton8.Text = "Clean Traces";
			this.siticoneRoundedGradientButton8.Click += new global::System.EventHandler(this.siticoneRoundedGradientButton8_Click_1);
			this.siticoneElipse1.BorderRadius = 30;
			this.siticoneElipse1.TargetControl = this.free;
			this.siticoneElipse2.TargetControl = this.panel3;
			this.siticoneElipse3.BorderRadius = 30;
			this.siticoneElipse3.TargetControl = this.panel2;
			this.siticoneBorderlessForm1.BorderRadius = 30;
			this.siticoneBorderlessForm1.ContainerControl = this;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			base.ClientSize = new global::System.Drawing.Size(824, 511);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.siticoneRoundedGradientButton8);
			base.Controls.Add(this.siticoneRoundedGradientButton7);
			base.Controls.Add(this.siticoneRoundedGradientButton6);
			base.Controls.Add(this.siticoneRoundedGradientButton5);
			base.Controls.Add(this.siticoneRoundedGradientButton4);
			base.Controls.Add(this.siticoneRoundedGradientButton3);
			base.Controls.Add(this.siticoneRoundedGradientButton2);
			base.Controls.Add(this.siticoneRoundedGradientButton1);
			base.Controls.Add(this.free);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneControlBox1);
			base.Controls.Add(this.pictureBox1);
			this.siticoneTransition1.SetDecoration(this, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.ForeColor = global::System.Drawing.SystemColors.Control;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "main";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loader";
			base.TransparencyKey = global::System.Drawing.Color.White;
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.free.ResumeLayout(false);
			this.free.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000E RID: 14
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400000F RID: 15
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000010 RID: 16
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000011 RID: 17
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Panel free;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Label label17;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x0400001E RID: 30
		private global::Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton1;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000025 RID: 37
		private global::Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton4;

		// Token: 0x04000026 RID: 38
		private global::Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton3;

		// Token: 0x04000027 RID: 39
		private global::Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton2;

		// Token: 0x04000028 RID: 40
		private global::Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton8;

		// Token: 0x04000029 RID: 41
		private global::Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton7;

		// Token: 0x0400002A RID: 42
		private global::Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton6;

		// Token: 0x0400002B RID: 43
		private global::Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton5;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Panel panel7;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Panel panel6;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000031 RID: 49
		private global::Siticone.Desktop.UI.WinForms.SiticoneElipse siticoneElipse1;

		// Token: 0x04000032 RID: 50
		private global::Siticone.Desktop.UI.WinForms.SiticoneElipse siticoneElipse2;

		// Token: 0x04000033 RID: 51
		private global::Siticone.Desktop.UI.WinForms.SiticoneElipse siticoneElipse3;

		// Token: 0x04000034 RID: 52
		private global::Siticone.Desktop.UI.WinForms.SiticoneElipse siticoneElipse4;

		// Token: 0x04000035 RID: 53
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
	}
}
