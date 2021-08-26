using DemoStrideGame;
using Stride.Engine;
using Stride.Games;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoNet5StrideGameWinform
{
    public partial class Form1 : Form
    {
        private Game _game;
        private GameContext _gameContext;

        public Form1()
        {
            InitializeComponent();
            _gameContext = new GameContextWinforms(this);
            _game = new TeapotDemo();
            _game.WindowCreated += (sender, args) => {
                if (sender is Game game)
                {
                    game.Window.AllowUserResizing = true;
                }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _game.Run(_gameContext);
        }
    }
}
