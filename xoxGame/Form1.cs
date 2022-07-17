using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xoxGame
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int sayaç = 1;
		Random r = new Random();

		
		private void button1_Click(object sender, EventArgs e)
		{
			button1.Text = "X";
			button1.Enabled = false;
			button1.BackColor = Color.Green;
			sayaç += 1;
			
				while (true)
				{
					int rasgele = r.Next(0, 8);
					if (rasgele == 1) { rasgele = r.Next(0, 8);	return; }

					if (rasgele == 2 && button2.Enabled == true) { button2.Enabled = false; button2.BackColor = Color.Red; button2.Text = "O"; break; }
					if (rasgele == 3 && button3.Enabled == true) { button3.Enabled = false; button3.BackColor = Color.Red; button3.Text = "O"; break; }
					if (rasgele == 4 && button4.Enabled == true) { button4.Enabled = false; button4.BackColor = Color.Red; button4.Text = "O"; break; }
					if (rasgele == 5 && button5.Enabled == true) { button5.Enabled = false; button5.BackColor = Color.Red; button5.Text = "O"; break; }
					if (rasgele == 6 && button6.Enabled == true) { button6.Enabled = false; button6.BackColor = Color.Red; button6.Text = "O"; break; }
					if (rasgele == 7 && button7.Enabled == true) { button7.Enabled = false; button7.BackColor = Color.Red; button7.Text = "O"; break; }
					if (rasgele == 8 && button8.Enabled == true) { button8.Enabled = false; button8.BackColor = Color.Red; button8.Text = "O"; break; }
					if (rasgele == 9 && button9.Enabled == true) { button9.Enabled = false; button9.BackColor = Color.Red; button9.Text = "O"; break; }

				}

				//----------------------------------------------------------------------------
				if (button1.Text=="X" && button4.Text == "X" && button7.Text == "X")
				{	MessageBox.Show("Game Over");}
				if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }
				//------------------------------------------------------------------------
				if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }


			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			button2.Text = "X";
			button2.Enabled = false;
			button2.BackColor = Color.Green;
			sayaç += 1;
			
				while (true)
				{
					int rasgele = r.Next(0, 8);
					if (rasgele == 2) { rasgele = r.Next(0, 8); return; }

					if (rasgele == 1 && button1.Enabled == true) { button1.Enabled = false; button1.BackColor = Color.Red; button1.Text = "O"; break; }
					if (rasgele == 3 && button3.Enabled == true) { button3.Enabled = false; button3.BackColor = Color.Red; button3.Text = "O"; break; }
					if (rasgele == 4 && button4.Enabled == true) { button4.Enabled = false; button4.BackColor = Color.Red; button4.Text = "O"; break; }
					if (rasgele == 5 && button5.Enabled == true) { button5.Enabled = false; button5.BackColor = Color.Red; button5.Text = "O"; break; }
					if (rasgele == 6 && button6.Enabled == true) { button6.Enabled = false; button6.BackColor = Color.Red; button6.Text = "O"; break; }
					if (rasgele == 7 && button7.Enabled == true) { button7.Enabled = false; button7.BackColor = Color.Red; button7.Text = "O"; break; }
					if (rasgele == 8 && button8.Enabled == true) { button8.Enabled = false; button8.BackColor = Color.Red; button8.Text = "O"; break; }
					if (rasgele == 9 && button9.Enabled == true) { button9.Enabled = false; button9.BackColor = Color.Red; button9.Text = "O"; break; }
				}

				//----------------------------------------------------------------------------
				if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }
				//------------------------------------------------------------------------
				if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }



			

		}

		private void button3_Click(object sender, EventArgs e)
		{
			button3.Text = "X";
			button3.Enabled = false;
			button3.BackColor = Color.Green;
			sayaç += 1;
			
				while (true)
				{
					int rasgele = r.Next(0, 8);
					if (rasgele == 3) { rasgele = r.Next(0, 8); return; }

					if (rasgele == 2 && button2.Enabled == true) { button2.Enabled = false; button2.BackColor = Color.Red; button2.Text = "O"; break; }
					if (rasgele == 1 && button1.Enabled == true) { button1.Enabled = false; button1.BackColor = Color.Red; button1.Text = "O"; break; }
					if (rasgele == 4 && button4.Enabled == true) { button4.Enabled = false; button4.BackColor = Color.Red; button4.Text = "O"; break; }
					if (rasgele == 5 && button5.Enabled == true) { button5.Enabled = false; button5.BackColor = Color.Red; button5.Text = "O"; break; }
					if (rasgele == 6 && button6.Enabled == true) { button6.Enabled = false; button6.BackColor = Color.Red; button6.Text = "O"; break; }
					if (rasgele == 7 && button7.Enabled == true) { button7.Enabled = false; button7.BackColor = Color.Red; button7.Text = "O"; break; }
					if (rasgele == 8 && button8.Enabled == true) { button8.Enabled = false; button8.BackColor = Color.Red; button8.Text = "O"; break; }
					if (rasgele == 9 && button9.Enabled == true) { button9.Enabled = false; button9.BackColor = Color.Red; button9.Text = "O"; break; }
				}

				//----------------------------------------------------------------------------
				if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }
				//------------------------------------------------------------------------
				if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }



			
		}

		private void button6_Click(object sender, EventArgs e)
		{
			button6.Text = "X";
			button6.Enabled = false;
			button6.BackColor = Color.Green;
			sayaç += 1;
			
				while (true)
				{
					int rasgele = r.Next(0, 8);
					if (rasgele == 6) { rasgele = r.Next(0, 8); return; }

					if (rasgele == 2 && button2.Enabled == true) { button2.Enabled = false; button2.BackColor = Color.Red; button2.Text = "O"; break; }
					if (rasgele == 3 && button3.Enabled == true) { button3.Enabled = false; button3.BackColor = Color.Red; button3.Text = "O"; break; }
					if (rasgele == 4 && button4.Enabled == true) { button4.Enabled = false; button4.BackColor = Color.Red; button4.Text = "O"; break; }
					if (rasgele == 5 && button5.Enabled == true) { button5.Enabled = false; button5.BackColor = Color.Red; button5.Text = "O"; break; }
					if (rasgele == 1 && button1.Enabled == true) { button1.Enabled = false; button1.BackColor = Color.Red; button1.Text = "O"; break; }
					if (rasgele == 7 && button7.Enabled == true) { button7.Enabled = false; button7.BackColor = Color.Red; button7.Text = "O"; break; }
					if (rasgele == 8 && button8.Enabled == true) { button8.Enabled = false; button8.BackColor = Color.Red; button8.Text = "O"; break; }
					if (rasgele == 9 && button9.Enabled == true) { button9.Enabled = false; button9.BackColor = Color.Red; button9.Text = "O"; break; }
				}

				//----------------------------------------------------------------------------
				if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }
				//------------------------------------------------------------------------
				if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }



			
		}

		private void button5_Click(object sender, EventArgs e)
		{
			button5.Text = "X";
			button5.Enabled = false;
			button5.BackColor = Color.Green;
			sayaç += 1;
			
				while (true)
				{
					int rasgele = r.Next(0, 8);
					if (rasgele == 5) { rasgele = r.Next(0, 8); return; }

					if (rasgele == 2 && button2.Enabled == true) { button2.Enabled = false; button2.BackColor = Color.Red; button2.Text = "O"; break; }
					if (rasgele == 3 && button3.Enabled == true) { button3.Enabled = false; button3.BackColor = Color.Red; button3.Text = "O"; break; }
					if (rasgele == 4 && button4.Enabled == true) { button4.Enabled = false; button4.BackColor = Color.Red; button4.Text = "O"; break; }
					if (rasgele == 1 && button1.Enabled == true) { button1.Enabled = false; button1.BackColor = Color.Red; button1.Text = "O"; break; }
					if (rasgele == 6 && button6.Enabled == true) { button6.Enabled = false; button6.BackColor = Color.Red; button6.Text = "O"; break; }
					if (rasgele == 7 && button7.Enabled == true) { button7.Enabled = false; button7.BackColor = Color.Red; button7.Text = "O"; break; }
					if (rasgele == 8 && button8.Enabled == true) { button8.Enabled = false; button8.BackColor = Color.Red; button8.Text = "O"; break; }
					if (rasgele == 9 && button9.Enabled == true) { button9.Enabled = false; button9.BackColor = Color.Red; button9.Text = "O"; break; }
				}

				//----------------------------------------------------------------------------
				if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }
				//------------------------------------------------------------------------
				if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }



			
		}

		private void button4_Click(object sender, EventArgs e)
		{

			button4.Text = "X";
			button4.Enabled = false;
			button4.BackColor = Color.Green;
			sayaç += 1;
			
				while (true)
				{
					int rasgele = r.Next(0, 8);
					if (rasgele == 4) { rasgele = r.Next(0, 8); return; }

					if (rasgele == 2 && button2.Enabled == true) { button2.Enabled = false; button2.BackColor = Color.Red; button2.Text = "O"; break; }
					if (rasgele == 3 && button3.Enabled == true) { button3.Enabled = false; button3.BackColor = Color.Red; button3.Text = "O"; break; }
					if (rasgele == 1 && button1.Enabled == true) { button1.Enabled = false; button1.BackColor = Color.Red; button1.Text = "O"; break; }
					if (rasgele == 5 && button5.Enabled == true) { button5.Enabled = false; button5.BackColor = Color.Red; button5.Text = "O"; break; }
					if (rasgele == 6 && button6.Enabled == true) { button6.Enabled = false; button6.BackColor = Color.Red; button6.Text = "O"; break; }
					if (rasgele == 7 && button7.Enabled == true) { button7.Enabled = false; button7.BackColor = Color.Red; button7.Text = "O"; break; }
					if (rasgele == 8 && button8.Enabled == true) { button8.Enabled = false; button8.BackColor = Color.Red; button8.Text = "O"; break; }
					if (rasgele == 9 && button9.Enabled == true) { button9.Enabled = false; button9.BackColor = Color.Red; button9.Text = "O"; break; }
				}

				//----------------------------------------------------------------------------
				if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }
				//------------------------------------------------------------------------
				if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }



			
		}

		private void button9_Click(object sender, EventArgs e)
		{

			button9.Text = "X";
			button9.Enabled = false;
			button9.BackColor = Color.Green;
			sayaç += 1;
			
				while (true)
				{
					int rasgele = r.Next(0, 8);
					if (rasgele == 9) { rasgele = r.Next(0, 8); return; }

					if (rasgele == 2 && button2.Enabled == true) { button2.Enabled = false; button2.BackColor = Color.Red; button2.Text = "O"; break; }
					if (rasgele == 3 && button3.Enabled == true) { button3.Enabled = false; button3.BackColor = Color.Red; button3.Text = "O"; break; }
					if (rasgele == 4 && button4.Enabled == true) { button4.Enabled = false; button4.BackColor = Color.Red; button4.Text = "O"; break; }
					if (rasgele == 5 && button5.Enabled == true) { button5.Enabled = false; button5.BackColor = Color.Red; button5.Text = "O"; break; }
					if (rasgele == 6 && button6.Enabled == true) { button6.Enabled = false; button6.BackColor = Color.Red; button6.Text = "O"; break; }
					if (rasgele == 7 && button7.Enabled == true) { button7.Enabled = false; button7.BackColor = Color.Red; button7.Text = "O"; break; }
					if (rasgele == 8 && button8.Enabled == true) { button8.Enabled = false; button8.BackColor = Color.Red; button8.Text = "O"; break; }
					if (rasgele == 1 && button1.Enabled == true) { button1.Enabled = false; button1.BackColor = Color.Red; button1.Text = "O"; break; }
				}

				//----------------------------------------------------------------------------
				if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }
				//------------------------------------------------------------------------
				if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }



			
		}

		private void button8_Click(object sender, EventArgs e)
		{

			button8.Text = "X";
			button8.Enabled = false;
			button8.BackColor = Color.Green;
			sayaç += 1;
				while (true)
				{
					int rasgele = r.Next(0, 8);
					if (rasgele == 8) { rasgele = r.Next(0, 8); return; }

					if (rasgele == 2 && button2.Enabled == true) { button2.Enabled = false; button2.BackColor = Color.Red; button2.Text = "O"; break; }
					if (rasgele == 3 && button3.Enabled == true) { button3.Enabled = false; button3.BackColor = Color.Red; button3.Text = "O"; break; }
					if (rasgele == 4 && button4.Enabled == true) { button4.Enabled = false; button4.BackColor = Color.Red; button4.Text = "O"; break; }
					if (rasgele == 5 && button5.Enabled == true) { button5.Enabled = false; button5.BackColor = Color.Red; button5.Text = "O"; break; }
					if (rasgele == 6 && button6.Enabled == true) { button6.Enabled = false; button6.BackColor = Color.Red; button6.Text = "O"; break; }
					if (rasgele == 7 && button7.Enabled == true) { button7.Enabled = false; button7.BackColor = Color.Red; button7.Text = "O"; break; }
					if (rasgele == 1 && button1.Enabled == true) { button1.Enabled = false; button1.BackColor = Color.Red; button1.Text = "O"; break; }
					if (rasgele == 9 && button9.Enabled == true) { button9.Enabled = false; button9.BackColor = Color.Red; button9.Text = "O"; break; }
				}

				//----------------------------------------------------------------------------
				if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }
				//------------------------------------------------------------------------
				if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }


		}

		private void button7_Click(object sender, EventArgs e)
		{

			button7.Text = "X";
			button7.Enabled = false;
			button7.BackColor = Color.Green;
			sayaç += 1;
			
				while (true)
				{
					int rasgele = r.Next(0, 8);
					if (rasgele == 7) { rasgele = r.Next(0, 8); return; }

					if (rasgele == 2 && button2.Enabled == true) { button2.Enabled = false; button2.BackColor = Color.Red; button2.Text = "O"; break; }
					if (rasgele == 3 && button3.Enabled == true) { button3.Enabled = false; button3.BackColor = Color.Red; button3.Text = "O"; break; }
					if (rasgele == 4 && button4.Enabled == true) { button4.Enabled = false; button4.BackColor = Color.Red; button4.Text = "O"; break; }
					if (rasgele == 5 && button5.Enabled == true) { button5.Enabled = false; button5.BackColor = Color.Red; button5.Text = "O"; break; }
					if (rasgele == 6 && button6.Enabled == true) { button6.Enabled = false; button6.BackColor = Color.Red; button6.Text = "O"; break; }
					if (rasgele == 1 && button1.Enabled == true) { button1.Enabled = false; button1.BackColor = Color.Red; button1.Text = "O"; break; }
					if (rasgele == 8 && button8.Enabled == true) { button8.Enabled = false; button8.BackColor = Color.Red; button8.Text = "O"; break; }
					if (rasgele == 9 && button9.Enabled == true) { button9.Enabled = false; button9.BackColor = Color.Red; button9.Text = "O"; break; }
				}

				//----------------------------------------------------------------------------
				if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
				{ MessageBox.Show("Game Over"); }
				if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
				{ MessageBox.Show("Game Over"); }
				//------------------------------------------------------------------------
				if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
				{ MessageBox.Show("Game Over"); }

				if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
				{ MessageBox.Show("Game Over"); }
				if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
				{ MessageBox.Show("Game Over"); }



			
		}

		private void button10_Click(object sender, EventArgs e)
		{
			button1.BackColor = Color.White;
			button2.BackColor = Color.White;
			button3.BackColor = Color.White;
			button4.BackColor = Color.White;
			button5.BackColor = Color.White;
			button6.BackColor = Color.White;
			button7.BackColor = Color.White;
			button8.BackColor = Color.White;
			button9.BackColor = Color.White;

			button1.Text = "";
			button2.Text = "";
			button3.Text = "";
			button4.Text = "";
			button5.Text = "";
			button6.Text = "";
			button7.Text = "";
			button8.Text = "";
			button9.Text = "";

			button1.Enabled = true;
			button2.Enabled = true;
			button3.Enabled = true;
			button4.Enabled = true;
			button5.Enabled = true;
			button6.Enabled = true;
			button7.Enabled = true;
			button8.Enabled = true;
			button9.Enabled = true;

			sayaç = 0;
		}
	}
}
