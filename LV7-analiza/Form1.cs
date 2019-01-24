using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV7_analiza
{
    public partial class Form1 : Form
    {
        public GFX engine;
        
       public  Board board;

        

        public Form1()
        {
            InitializeComponent();
            lbl_playerturn.Text = "";
            btn_newPlayers.Enabled = false;
        }

        
        private void btn_start_Click(object sender, EventArgs e)
        {

            if (tb_name1.Text == "" || tb_name2.Text == "")
            {
                MessageBox.Show("Both names must be entered!", "Warning!");
                
                
            }
            else
            {
                btn_start.Enabled = false;
                tb_name1.Enabled = false;
                tb_name2.Enabled = false;
                btn_newPlayers.Enabled = true;
                Graphics toPass = pictureBox1.CreateGraphics();

                engine = new GFX(toPass);

                GFX.drawBoard();
                board = new Board();
                board.init();

                lbl_playerturn.Text = tb_name1.Text + " plays.";
                refreshLabel();

            }
        }

        private void btn_newPlayers_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = true;
            btn_newPlayers.Enabled = false;
            tb_name1.Enabled = true;
            tb_name1.Clear();
            tb_name2.Enabled = true;
            tb_name2.Clear();
            GFX.drawBoard();
            
        }

        //-----------------------------

        public void refreshLabel()
        {
            string tekst = "X won: " + board.Xwins + " times.\nTies: " + board.ties + " times.\n O won: " + board.Owins + " times.";
            lbl_result.Text = tekst.ToString();
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point mouse = new Point(e.X, e.Y);
            
          
            board.detectHit(mouse);
            if (board.movesCounter % 2 == 0)
            {
                lbl_playerturn.Text = tb_name1.Text + " plays.";
            }
            else
                lbl_playerturn.Text = tb_name2.Text + " plays.";
            refreshLabel();
        }
        
    }

}
