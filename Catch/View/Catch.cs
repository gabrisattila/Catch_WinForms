using Catch.Model;
using Catch.Persistence;

namespace Catch
{
    public partial class Catch : Form
    {
        private string path11 = "Catch/Catch/11.txt";      // wich = 1
        private string path15 = "Catch/Catch/15.txt";      // wich = 2
        private string path21 = "Catch/Catch/21.txt";      // wich = 3 
        private string pathDef11 = "Catch/Catch/def11.txt";// wich = 4
        private string pathDef15 = "Catch/Catch/def15.txt";// wich = 5
        private string pathDef21 = "Catch/Catch/def21.txt";// wich = 6

        private DataAccess _dataAccess;
        private GameModel _gameModel;
        private System.Windows.Forms.Timer _timer;
        private int sc;
        private Boolean onGame;
        private int wich = 5;
        private string path;

        public bool OnGame { get { return onGame; } set { onGame = value; } }
        public Catch()
        {
            InitializeComponent();
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += TimeDisp;
        }

        private void InitalizeForm(object sender, EventArgs e)
        {
            if (wich == 4)
            {
                path = pathdef11;
                t_l_p.Dock = DockStyle.Fill;
                _dataAccess = new DataAccess();
                _gameModel = new GameModel(_dataAccess);
                _gameModel.Table = _gameModel.Loaddef(path);
                t_l_p.RowCount = _gameModel.Table.M;
                t_l_p.ColumnCount = _gameModel.Table.M;
                this.Width = 458;
                this.Height = 513;
                t_l_p.Width = 440;
                t_l_p.Height = 440;
                for (int i = 0; i < _gameModel.Table.M - 1; i++)
                {
                    t_l_p.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                    t_l_p.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));
                }
                OnGame = true;
                sc = 0;
                Time.Text = $"Time: {sc}";
                _timer.Start();
            }
            else if (wich == 5)
            {
                path = pathdef15;
                t_l_p.Dock = DockStyle.Fill;
                _dataAccess = new DataAccess();
                _gameModel = new GameModel(_dataAccess);
                _gameModel.Table = _gameModel.Loaddef(path);
                t_l_p.RowCount = _gameModel.Table.M;
                t_l_p.ColumnCount = _gameModel.Table.M;
                this.Width = 618;
                this.Height = 673;
                t_l_p.Width = 600;
                t_l_p.Height = 600;
                for (int i = 0; i < _gameModel.Table.M - 1; i++)
                {
                    t_l_p.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                    t_l_p.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));
                }
                OnGame = true;
                sc = 0;
                Time.Text = $"Time: {sc}";
                _timer.Start();
            }
            else if (wich == 6)
            {
                path = path21;
                t_l_p.Dock = DockStyle.Fill;
                _dataAccess = new DataAccess();
                _gameModel = new GameModel(_dataAccess);
                _gameModel.Table = _gameModel.Loaddef(path);
                t_l_p.RowCount = _gameModel.Table.M;
                t_l_p.ColumnCount = _gameModel.Table.M;
                this.Width = 858;
                this.Height = 913;
                t_l_p.Width = 840;
                t_l_p.Height = 840;
                for (int i = 0; i < _gameModel.Table.M - 1; i++)
                {
                    t_l_p.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                    t_l_p.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));
                }
                OnGame = true;
                sc = 0;
                Time.Text = $"Time: {sc}";
                _timer.Start();
            }
            else if (wich == 1)
            {
                path = path11;
                t_l_p.Dock = DockStyle.Fill;
                _dataAccess = new DataAccess();
                _gameModel = new GameModel(_dataAccess);
                _gameModel.Table = _gameModel.Load(path);
                t_l_p.RowCount = _gameModel.Table.M;
                t_l_p.ColumnCount = _gameModel.Table.M;
                this.Width = 458;
                this.Height = 513;
                t_l_p.Width = 440;
                t_l_p.Height = 440;
                for (int i = 0; i < _gameModel.Table.M - 1; i++)
                {
                    t_l_p.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                    t_l_p.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));
                }
                OnGame = true;
                sc = 0;
                Time.Text = $"Time: {sc}";
                _timer.Start();
            }
            else if (wich == 2)
            {
                path = path15;
                t_l_p.Dock = DockStyle.Fill;
                _dataAccess = new DataAccess();
                _gameModel = new GameModel(_dataAccess);
                _gameModel.Table = _gameModel.Load(path);
                t_l_p.RowCount = _gameModel.Table.M;
                t_l_p.ColumnCount = _gameModel.Table.M;
                this.Width = 618;
                this.Height = 673;
                t_l_p.Width = 600;
                t_l_p.Height = 600;
                for (int i = 0; i < _gameModel.Table.M - 1; i++)
                {
                    t_l_p.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                    t_l_p.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));
                }
                OnGame = true;
                sc = 0;
                Time.Text = $"Time: {sc}";
                _timer.Start();
            }
            else if (wich == 3)
            {
                path = path21;
                t_l_p.Dock = DockStyle.Fill;
                _dataAccess = new DataAccess();
                _gameModel = new GameModel(_dataAccess);
                _gameModel.Table = _gameModel.Load(path);
                t_l_p.RowCount = _gameModel.Table.M;
                t_l_p.ColumnCount = _gameModel.Table.M;
                this.Width = 858;
                this.Height = 913;
                t_l_p.Width = 840;
                t_l_p.Height = 840;
                for (int i = 0; i < _gameModel.Table.M - 1; i++)
                {
                    t_l_p.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                    t_l_p.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));
                }
                OnGame = true;
                sc = 0;
                Time.Text = $"Time: {sc}";
                _timer.Start();
            }
            _gameModel.GameOver += new EventHandler<GameModelEventArgs>(Game_Over);
            _gameModel.Step += new EventHandler<GameModelEventArgs>(Step);
        }

        private void Step(object? sender, GameModelEventArgs e)
        {
            t_l_p.Refresh();
        }
        private void Game_Over(object? sender, GameModelEventArgs e)
        {
            t_l_p.Refresh();
            string message;
            string caption;
            _timer.Stop();
            onGame = false;
            if (e.WinLose == 1)
            {
                message = "Nyert�l, szeretn�l �j j�t�kot kezdeni?";
                caption = "GameOver";
            }
            else if(e.WinLose == 0)
            {
                message = "Vesztett�l, mert elkaptak.\nSzeretn�l �j j�t�kot kezdeni?";
                caption = "GameOver";
            }
            else 
            {
                message = "Vesztett�l, mert akn�ra l�pt�l.\nSzeretn�l �j j�t�kot kezdeni?";
                caption = "GameOver";
            }
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                _gameModel.GameOver -= Game_Over;
                _gameModel.Step -= Step;
            }
            else
            {
                this.Close();
            }
        }

        private void TimeDisp(object? sender, EventArgs e)
        {
            if (OnGame == true) 
            {
                sc++;
                Time.Text = $"Time: {sc}";
                if (_gameModel.E1)
                {
                    _gameModel.Enemy1Move(sc);
                }
                if (_gameModel.E2)
                {
                    _gameModel.Enemy2Move(sc);
                }
                if ((_gameModel.ENEMY1.Alive == false && _gameModel.ENEMY2.Alive == false) ||
                     _gameModel.PLAYER.Alive == false || _gameModel.PLAYER.Get_Caught == true)
                {
                    t_l_p.Refresh();
                    OnGame = false;
                }
                t_l_p.Refresh();
            }
        }

        private void tlp_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            for (int i = 0; i < t_l_p.RowCount; i++)
            {
                for (int j = 0; j < t_l_p.ColumnCount; j++)
                {
                    if (e.Column == j && e.Row == i && _gameModel.Table.T�bla[i, j] == 3)
                    {
                        e.Graphics.FillRectangle(Brushes.Orange, e.CellBounds);
                    }
                    if (e.Column == j && e.Row == i && _gameModel.Table.T�bla[i, j] == 2)
                    {
                        e.Graphics.FillRectangle(Brushes.Blue, e.CellBounds);
                    }
                    if (e.Column == j && e.Row == i && _gameModel.Table.T�bla[i, j] == 4)
                    {
                        e.Graphics.FillRectangle(Brushes.Blue, e.CellBounds);
                    }
                    if (e.Column == j && e.Row == i && _gameModel.Table.T�bla[i, j] == 0)
                    {
                        e.Graphics.FillRectangle(Brushes.DarkGreen, e.CellBounds);
                    }
                    if (e.Column == j && e.Row == i && _gameModel.Table.T�bla[i, j] == 1)
                    {
                        e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
                    }
                    if (e.Column == j && e.Row == i && _gameModel.Table.T�bla[i, j] == 5)
                    {
                        e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
                    }
                    if (e.Column == j && e.Row == i && _gameModel.Table.T�bla[i, j] == 6)
                    {
                        e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
                    }
                    if (e.Column == j && e.Row == i && _gameModel.Table.T�bla[i, j] == 7)
                    {
                        e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
                    }
                }
            }
        }

        private void Catch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                _gameModel.MovePlayer('a');
            }
            else if (e.KeyCode == Keys.W)
            {
                _gameModel.MovePlayer('w');
            }
            else if (e.KeyCode == Keys.S)
            {
                _gameModel.MovePlayer('s');
            }
            else if (e.KeyCode == Keys.D)
            {
                _gameModel.MovePlayer('d');
            }
        }
        private void saved11(object sender, EventArgs e)
        {
            OnGame = false;
            wich = 1;
            InitalizeForm(sender, e);
        }
        private void saved15(object sender, EventArgs e)
        {
            OnGame = false;
            wich = 2;
            InitalizeForm(sender, e);
        }
        private void saved21(object sender, EventArgs e)
        {
            OnGame = false;
            wich = 3;
            InitalizeForm(sender, e);
        }

        private void newGame11(object sender, EventArgs e)
        {
            OnGame = false;
            wich = 4;
            InitalizeForm(sender, e);
        }
        private void newGame15(object sender, EventArgs e)
        {
            OnGame = false;
            wich = 5;
            InitalizeForm(sender, e);
        }
        private void newGame21(object sender, EventArgs e)
        {
            OnGame = false;
            wich = 6;
            InitalizeForm(sender, e);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            OnGame = false;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show("Kil�psz, szeretn�d menteni a j�t�kot?\n", "Over for now", buttons);

            if (result == DialogResult.Yes)
            {
                if (wich == 1 || wich == 4)
                {
                    MessageBox.Show("El lesz mentve a 11.txt fileba az �ll�s\n");
                    _gameModel.Save(path11, _gameModel.Table);
                    this.Close();
                }
                else if (wich == 2 || wich == 5)
                {
                    MessageBox.Show("El lesz mentve a 15.txt fileba az �ll�s\n");
                    _gameModel.Save(path15, _gameModel.Table);
                    this.Close();
                }
                else if(wich == 3 || wich == 6)
                {
                    MessageBox.Show("El lesz mentve a 21.txt fileba az �ll�s\n");
                    _gameModel.Save(path21, _gameModel.Table);
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
        private void Pause_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            OnGame = false;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show("Sz�net, szeretn�d menteni a j�t�kot?\n", "Pause?", buttons);
            if (result == DialogResult.Yes)
            {
                if (wich == 1 || wich == 4)
                {
                    MessageBox.Show("El lesz mentve a 11.txt fileba az �ll�s\n");
                    _gameModel.Save(path11, _gameModel.Table);
                }
                else if (wich == 2 || wich == 5)
                {
                    MessageBox.Show("El lesz mentve a 15.txt fileba az �ll�s\n");
                    _gameModel.Save(path15, _gameModel.Table);
                }
                else if (wich == 3 || wich == 6)
                {
                    MessageBox.Show("El lesz mentve a 21.txt fileba az �ll�s\n");
                    _gameModel.Save(path21, _gameModel.Table);
                }
                MessageBoxButtons bs = MessageBoxButtons.YesNo;
                DialogResult res = MessageBox.Show("Elmentett�k. Folytatod?", "Over for now?", bs);
                if (res == DialogResult.Yes)
                {
                    _timer.Start();
                    OnGame = true;
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBoxButtons bs = MessageBoxButtons.YesNo;
                DialogResult res = MessageBox.Show("Nincs ment�s. Folytatod?", "Over for now?", bs);
                if (res == DialogResult.Yes)
                {
                    _timer.Start();
                    OnGame = true;
                }
                else
                {
                    this.Close();
                }
            }
        }

        
    }
}