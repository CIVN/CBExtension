using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
	public partial class Form1 : Form
	{
		//ホットキー
		public HotKey c1;
		public HotKey c2;
		public HotKey c3;
		public HotKey c4;
		public HotKey c5;
		public HotKey c6;
		public HotKey c7;
		public HotKey c8;
		public HotKey c9;

		//選択中のプリセット
		private int pre = 1;

		//できればローカル変数
		private string one;
		private string two;
		private string three;
		private string four;
		private string five;
		private string six;
		private string seven;
		private string eight;
		private string nine;

		//メッセージボックス用
		private string apply = "適用が完了しました！\n";

		//プリセットに保存するやつ
		private string[] pre1;
		private string[] pre2;
		private string[] pre3;
		private string[] pre4;
		private string[] pre5;

		public Form1()
		{
			InitializeComponent();
		}

		private void Debug()
		{
			int i = 1;

			foreach (string p in pre1)
			{
				Console.WriteLine("プリセット1-" + i + ": " + p);

				i++;
			}

			i = 1;

			foreach (string p in pre2)
			{
				Console.WriteLine("プリセット2-" + i + ": " + p);

				i++;
			}

			i = 1;

			foreach (string p in pre3)
			{
				Console.WriteLine("プリセット3-" + i + ": " + p);

				i++;
			}

			i = 1;

			foreach (string p in pre4)
			{
				Console.WriteLine("プリセット4-" + i + ": " + p);

				i++;
			}

			i = 1;

			foreach (string p in pre5)
			{
				Console.WriteLine("プリセット5-" + i + ": " + p);

				i++;
			}
		}

		//配列を設定から取得
		private void Pres()
		{
			string p11 = Properties.Settings.Default.pre11;
			string p12 = Properties.Settings.Default.pre12;
			string p13 = Properties.Settings.Default.pre13;
			string p14 = Properties.Settings.Default.pre14;
			string p15 = Properties.Settings.Default.pre15;
			string p16 = Properties.Settings.Default.pre16;
			string p17 = Properties.Settings.Default.pre17;
			string p18 = Properties.Settings.Default.pre18;
			string p19 = Properties.Settings.Default.pre19;
			string p21 = Properties.Settings.Default.pre21;
			string p22 = Properties.Settings.Default.pre22;
			string p23 = Properties.Settings.Default.pre23;
			string p24 = Properties.Settings.Default.pre24;
			string p25 = Properties.Settings.Default.pre25;
			string p26 = Properties.Settings.Default.pre26;
			string p27 = Properties.Settings.Default.pre27;
			string p28 = Properties.Settings.Default.pre28;
			string p29 = Properties.Settings.Default.pre29;
			string p31 = Properties.Settings.Default.pre31;
			string p32 = Properties.Settings.Default.pre32;
			string p33 = Properties.Settings.Default.pre33;
			string p34 = Properties.Settings.Default.pre34;
			string p35 = Properties.Settings.Default.pre35;
			string p36 = Properties.Settings.Default.pre36;
			string p37 = Properties.Settings.Default.pre37;
			string p38 = Properties.Settings.Default.pre38;
			string p39 = Properties.Settings.Default.pre39;
			string p41 = Properties.Settings.Default.pre41;
			string p42 = Properties.Settings.Default.pre42;
			string p43 = Properties.Settings.Default.pre43;
			string p44 = Properties.Settings.Default.pre44;
			string p45 = Properties.Settings.Default.pre45;
			string p46 = Properties.Settings.Default.pre46;
			string p47 = Properties.Settings.Default.pre47;
			string p48 = Properties.Settings.Default.pre48;
			string p49 = Properties.Settings.Default.pre49;
			string p51 = Properties.Settings.Default.pre51;
			string p52 = Properties.Settings.Default.pre52;
			string p53 = Properties.Settings.Default.pre53;
			string p54 = Properties.Settings.Default.pre54;
			string p55 = Properties.Settings.Default.pre55;
			string p56 = Properties.Settings.Default.pre56;
			string p57 = Properties.Settings.Default.pre57;
			string p58 = Properties.Settings.Default.pre58;
			string p59 = Properties.Settings.Default.pre59;

			pre1 = new string [9] { p11, p12, p13, p14, p15, p16, p17, p18, p19 };
			pre2 = new string [9] { p21, p22, p23, p24, p25, p26, p27, p28, p29 };
			pre3 = new string [9] { p31, p32, p33, p34, p35, p36, p37, p38, p39 };
			pre4 = new string [9] { p41, p42, p43, p44, p45, p46, p47, p48, p49 };
			pre5 = new string [9] { p51, p52, p53, p54, p55, p56, p57, p58, p59 };
		}

		//テキストボックスに反映
		private void Pre1()
		{
			textBox1.Text = pre1[0];
			textBox2.Text = pre1[1];
			textBox3.Text = pre1[2];
			textBox4.Text = pre1[3];
			textBox5.Text = pre1[4];
			textBox6.Text = pre1[5];
			textBox7.Text = pre1[6];
			textBox8.Text = pre1[7];
			textBox9.Text = pre1[8];
		}

		private void Pre2()
		{
			textBox1.Text = pre2[0];
			textBox2.Text = pre2[1];
			textBox3.Text = pre2[2];
			textBox4.Text = pre2[3];
			textBox5.Text = pre2[4];
			textBox6.Text = pre2[5];
			textBox7.Text = pre2[6];
			textBox8.Text = pre2[7];
			textBox9.Text = pre2[8];
		}

		private void Pre3()
		{
			textBox1.Text = pre3[0];
			textBox2.Text = pre3[1];
			textBox3.Text = pre3[2];
			textBox4.Text = pre3[3];
			textBox5.Text = pre3[4];
			textBox6.Text = pre3[5];
			textBox7.Text = pre3[6];
			textBox8.Text = pre3[7];
			textBox9.Text = pre3[8];
		}

		private void Pre4()
		{
			textBox1.Text = pre4[0];
			textBox2.Text = pre4[1];
			textBox3.Text = pre4[2];
			textBox4.Text = pre4[3];
			textBox5.Text = pre4[4];
			textBox6.Text = pre4[5];
			textBox7.Text = pre4[6];
			textBox8.Text = pre4[7];
			textBox9.Text = pre4[8];
		}

		private void Pre5()
		{
			textBox1.Text = pre5[0];
			textBox2.Text = pre5[1];
			textBox3.Text = pre5[2];
			textBox4.Text = pre5[3];
			textBox5.Text = pre5[4];
			textBox6.Text = pre5[5];
			textBox7.Text = pre5[6];
			textBox8.Text = pre5[7];
			textBox9.Text = pre5[8];
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Pres();
			Pre1();

			c1 = new HotKey(MOD_KEY.CONTROL, Keys.D1);
			c2 = new HotKey(MOD_KEY.CONTROL, Keys.D2);
			c3 = new HotKey(MOD_KEY.CONTROL, Keys.D3);
			c4 = new HotKey(MOD_KEY.CONTROL, Keys.D4);
			c5 = new HotKey(MOD_KEY.CONTROL, Keys.D5);
			c6 = new HotKey(MOD_KEY.CONTROL, Keys.D6);
			c7 = new HotKey(MOD_KEY.CONTROL, Keys.D7);
			c8 = new HotKey(MOD_KEY.CONTROL, Keys.D8);
			c9 = new HotKey(MOD_KEY.CONTROL, Keys.D9);

			c1.HotKeyPush += new EventHandler(c1_push);
			c2.HotKeyPush += new EventHandler(c2_push);
			c3.HotKeyPush += new EventHandler(c3_push);
			c4.HotKeyPush += new EventHandler(c4_push);
			c5.HotKeyPush += new EventHandler(c5_push);
			c6.HotKeyPush += new EventHandler(c6_push);
			c7.HotKeyPush += new EventHandler(c7_push);
			c8.HotKeyPush += new EventHandler(c8_push);
			c9.HotKeyPush += new EventHandler(c9_push);
		}

		private void PRE()
		{
			switch (pre)
			{
				case 1:
					one = pre1[0];
					two = pre1[1];
					three = pre1[2];
					four = pre1[3];
					five = pre1[4];
					six = pre1[5];
					seven = pre1[6];
					eight = pre1[7];
					nine = pre1[8];
					break;

				case 2:
					one = pre2[0];
					two = pre2[1];
					three = pre2[2];
					four = pre2[3];
					five = pre2[4];
					six = pre2[5];
					seven = pre2[6];
					eight = pre2[7];
					nine = pre2[8];
					break;

				case 3:
					one = pre3[0];
					two = pre3[1];
					three = pre3[2];
					four = pre3[3];
					five = pre3[4];
					six = pre3[5];
					seven = pre3[6];
					eight = pre3[7];
					nine = pre3[8];
					break;

				case 4:
					one = pre4[0];
					two = pre4[1];
					three = pre4[2];
					four = pre4[3];
					five = pre4[4];
					six = pre4[5];
					seven = pre4[6];
					eight = pre4[7];
					nine = pre4[8];
					break;

				case 5:
					one = pre5[0];
					two = pre5[1];
					three = pre5[2];
					four = pre5[3];
					five = pre5[4];
					six = pre5[5];
					seven = pre5[6];
					eight = pre5[7];
					nine = pre5[8];
					break;
			}
		}

		public void c1_push(object sender, EventArgs e)
		{
			PRE();

			Clipboard.SetDataObject(one, true);
		}

		public void c2_push(object sender, EventArgs e)
		{
			PRE();

			Clipboard.SetDataObject(two, true);
		}

		public void c3_push(object sender, EventArgs e)
		{
			PRE();

			Clipboard.SetDataObject(three, true);
		}

		public void c4_push(object sender, EventArgs e)
		{
			PRE();

			Clipboard.SetDataObject(four, true);
		}

		public void c5_push(object sender, EventArgs e)
		{
			PRE();

			Clipboard.SetDataObject(five, true);
		}

		public void c6_push(object sender, EventArgs e)
		{
			PRE();

			Clipboard.SetDataObject(six, true);
		}

		public void c7_push(object sender, EventArgs e)
		{
			PRE();

			Clipboard.SetDataObject(seven, true);
		}

		public void c8_push(object sender, EventArgs e)
		{
			PRE();

			Clipboard.SetDataObject(eight, true);
		}

		public void c9_push(object sender, EventArgs e)
		{
			PRE();

			Clipboard.SetDataObject(nine, true);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			c1.Dispose();
			c2.Dispose();
			c3.Dispose();
			c4.Dispose();
			c5.Dispose();
			c6.Dispose();
			c7.Dispose();
			c8.Dispose();
			c9.Dispose();
		}

		private void プリセット1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pre = 1;

			Pre1();
		}

		private void プリセット2ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			pre = 2;

			Pre2();
		}

		private void プリセット3ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			pre = 3;

			Pre3();
		}

		private void プリセット4ToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			pre = 4;

			Pre4();
		}

		private void プリセット5ToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			pre = 5;

			Pre5();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			switch (pre)
			{
				case 1:
					Properties.Settings.Default.pre11 = textBox1.Text;
					Properties.Settings.Default.pre12 = textBox2.Text;
					Properties.Settings.Default.pre13 = textBox3.Text;
					Properties.Settings.Default.pre14 = textBox4.Text;
					Properties.Settings.Default.pre15 = textBox5.Text;
					Properties.Settings.Default.pre16 = textBox6.Text;
					Properties.Settings.Default.pre17 = textBox7.Text;
					Properties.Settings.Default.pre18 = textBox8.Text;
					Properties.Settings.Default.pre19 = textBox9.Text;
					break;

				case 2:
					Properties.Settings.Default.pre21 = textBox1.Text;
					Properties.Settings.Default.pre22 = textBox2.Text;
					Properties.Settings.Default.pre23 = textBox3.Text;
					Properties.Settings.Default.pre24 = textBox4.Text;
					Properties.Settings.Default.pre25 = textBox5.Text;
					Properties.Settings.Default.pre26 = textBox6.Text;
					Properties.Settings.Default.pre27 = textBox7.Text;
					Properties.Settings.Default.pre28 = textBox8.Text;
					Properties.Settings.Default.pre29 = textBox9.Text;
					break;

				case 3:
					Properties.Settings.Default.pre31 = textBox1.Text;
					Properties.Settings.Default.pre32 = textBox2.Text;
					Properties.Settings.Default.pre33 = textBox3.Text;
					Properties.Settings.Default.pre34 = textBox4.Text;
					Properties.Settings.Default.pre35 = textBox5.Text;
					Properties.Settings.Default.pre36 = textBox6.Text;
					Properties.Settings.Default.pre37 = textBox7.Text;
					Properties.Settings.Default.pre38 = textBox8.Text;
					Properties.Settings.Default.pre39 = textBox9.Text;
					break;

				case 4:
					Properties.Settings.Default.pre41 = textBox1.Text;
					Properties.Settings.Default.pre42 = textBox2.Text;
					Properties.Settings.Default.pre43 = textBox3.Text;
					Properties.Settings.Default.pre44 = textBox4.Text;
					Properties.Settings.Default.pre45 = textBox5.Text;
					Properties.Settings.Default.pre46 = textBox6.Text;
					Properties.Settings.Default.pre47 = textBox7.Text;
					Properties.Settings.Default.pre48 = textBox8.Text;
					Properties.Settings.Default.pre49 = textBox9.Text;
					break;

				case 5:
					Properties.Settings.Default.pre51 = textBox1.Text;
					Properties.Settings.Default.pre52 = textBox2.Text;
					Properties.Settings.Default.pre53 = textBox3.Text;
					Properties.Settings.Default.pre54 = textBox4.Text;
					Properties.Settings.Default.pre55 = textBox5.Text;
					Properties.Settings.Default.pre56 = textBox6.Text;
					Properties.Settings.Default.pre57 = textBox7.Text;
					Properties.Settings.Default.pre58 = textBox8.Text;
					Properties.Settings.Default.pre59 = textBox9.Text;
					break;
			}

			Pres();

			Properties.Settings.Default.Save();

			MessageBox.Show(apply, "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void デバッグ開発者用ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Debug();
		}
	}
}
