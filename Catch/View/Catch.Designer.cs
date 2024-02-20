namespace Catch
{
    partial class Catch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuFül = new System.Windows.Forms.ToolStripMenuItem();
            this.New_game = new System.Windows.Forms.ToolStripMenuItem();
            this.Small = new System.Windows.Forms.ToolStripMenuItem();
            this.savedGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Medium = new System.Windows.Forms.ToolStripMenuItem();
            this.savedGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Large = new System.Windows.Forms.ToolStripMenuItem();
            this.savedGameToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Pause = new System.Windows.Forms.ToolStripMenuItem();
            this.Time = new System.Windows.Forms.Label();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.t_l_p = new System.Windows.Forms.TableLayoutPanel();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFül});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.Menu.Size = new System.Drawing.Size(525, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // MenuFül
            // 
            this.MenuFül.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_game,
            this.Exit,
            this.Pause});
            this.MenuFül.Name = "MenuFül";
            this.MenuFül.Size = new System.Drawing.Size(50, 20);
            this.MenuFül.Text = "Menü";
            // 
            // New_game
            // 
            this.New_game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Small,
            this.Medium,
            this.Large});
            this.New_game.Name = "New_game";
            this.New_game.Size = new System.Drawing.Size(180, 22);
            this.New_game.Text = "Új játék";
            // 
            // Small
            // 
            this.Small.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savedGameToolStripMenuItem,
            this.newGameToolStripMenuItem});
            this.Small.Name = "Small";
            this.Small.Size = new System.Drawing.Size(180, 22);
            this.Small.Text = "11 x 11";
            // 
            // savedGameToolStripMenuItem
            // 
            this.savedGameToolStripMenuItem.Name = "savedGameToolStripMenuItem";
            this.savedGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.savedGameToolStripMenuItem.Text = "Saved Game";
            this.savedGameToolStripMenuItem.Click += new System.EventHandler(this.saved11);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGame11);
            // 
            // Medium
            // 
            this.Medium.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savedGameToolStripMenuItem1,
            this.newGameToolStripMenuItem1});
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(180, 22);
            this.Medium.Text = "15 x 15";
            // 
            // savedGameToolStripMenuItem1
            // 
            this.savedGameToolStripMenuItem1.Name = "savedGameToolStripMenuItem1";
            this.savedGameToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.savedGameToolStripMenuItem1.Text = "Saved Game";
            this.savedGameToolStripMenuItem1.Click += new System.EventHandler(this.saved15);
            // 
            // newGameToolStripMenuItem1
            // 
            this.newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            this.newGameToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem1.Text = "New Game";
            this.newGameToolStripMenuItem1.Click += new System.EventHandler(this.newGame15);
            // 
            // Large
            // 
            this.Large.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savedGameToolStripMenuItem2,
            this.newGameToolStripMenuItem2});
            this.Large.Name = "Large";
            this.Large.Size = new System.Drawing.Size(180, 22);
            this.Large.Text = "21 x 21";
            // 
            // savedGameToolStripMenuItem2
            // 
            this.savedGameToolStripMenuItem2.Name = "savedGameToolStripMenuItem2";
            this.savedGameToolStripMenuItem2.Size = new System.Drawing.Size(139, 22);
            this.savedGameToolStripMenuItem2.Text = "Saved Game";
            this.savedGameToolStripMenuItem2.Click += new System.EventHandler(this.saved21);
            // 
            // newGameToolStripMenuItem2
            // 
            this.newGameToolStripMenuItem2.Name = "newGameToolStripMenuItem2";
            this.newGameToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem2.Text = "New Game";
            this.newGameToolStripMenuItem2.Click += new System.EventHandler(this.newGame21);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 22);
            this.Exit.Text = "Kilépés";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Pause
            // 
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(180, 22);
            this.Pause.Text = "Szünet";
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Time
            // 
            this.Time.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(242, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(36, 15);
            this.Time.TabIndex = 1;
            this.Time.Text = "Time:";
            // 
            // tlp
            // 
            this.tlp.AutoSize = true;
            this.tlp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp.ColumnCount = 1;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 1;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp.Size = new System.Drawing.Size(200, 100);
            this.tlp.TabIndex = 0;
            // 
            // t_l_p
            // 
            this.t_l_p.ColumnCount = 1;
            this.t_l_p.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.t_l_p.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_l_p.Location = new System.Drawing.Point(0, 24);
            this.t_l_p.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.t_l_p.Name = "t_l_p";
            this.t_l_p.RowCount = 1;
            this.t_l_p.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.t_l_p.Size = new System.Drawing.Size(525, 447);
            this.t_l_p.TabIndex = 2;
            this.t_l_p.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tlp_CellPaint);
            // 
            // Catch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 471);
            this.Controls.Add(this.t_l_p);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Catch";
            this.Text = "Catch Me If You Can";
            this.Load += new System.EventHandler(this.InitalizeForm);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Catch_KeyDown);
            //this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Catch_KeyUp);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem MenuFül;
        private ToolStripMenuItem New_game;
        private ToolStripMenuItem Small;
        private ToolStripMenuItem Medium;
        private ToolStripMenuItem Large;
        private ToolStripMenuItem Exit;
        private ToolStripMenuItem Pause;
        private Label Time;
        private TableLayoutPanel tlp;
        private TableLayoutPanel t_l_p;
        private ToolStripMenuItem savedGameToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem savedGameToolStripMenuItem1;
        private ToolStripMenuItem newGameToolStripMenuItem1;
        private ToolStripMenuItem savedGameToolStripMenuItem2;
        private ToolStripMenuItem newGameToolStripMenuItem2;
    }
}