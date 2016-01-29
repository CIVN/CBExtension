using System;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
	public partial class Form1 : Form
	{
		//通知表示時間(?)
		const int time = 1;

		//データ
		public HotKey[] ctrl;
		public HotKey[] alt;
		private TextBox[] textbox;

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
		private string apply = "適用が完了しました!";
		private string reset = "全ての内容をリセットします。\nよろしいですか?";

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

		private void Form1_Load(object sender, EventArgs e)
		{
			//ウィンドウの名前変更
			Text = "CBExtension (" + pre + ")";

			textbox = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9 };

			Pres();
			Pre1();

			HotKey c1 = new HotKey(MOD_KEY.CONTROL, Keys.D1);
			HotKey c2 = new HotKey(MOD_KEY.CONTROL, Keys.D2);
			HotKey c3 = new HotKey(MOD_KEY.CONTROL, Keys.D3);
			HotKey c4 = new HotKey(MOD_KEY.CONTROL, Keys.D4);
			HotKey c5 = new HotKey(MOD_KEY.CONTROL, Keys.D5);
			HotKey c6 = new HotKey(MOD_KEY.CONTROL, Keys.D6);
			HotKey c7 = new HotKey(MOD_KEY.CONTROL, Keys.D7);
			HotKey c8 = new HotKey(MOD_KEY.CONTROL, Keys.D8);
			HotKey c9 = new HotKey(MOD_KEY.CONTROL, Keys.D9);

			HotKey a1 = new HotKey(MOD_KEY.ALT, Keys.D1);
			HotKey a2 = new HotKey(MOD_KEY.ALT, Keys.D2);
			HotKey a3 = new HotKey(MOD_KEY.ALT, Keys.D3);
			HotKey a4 = new HotKey(MOD_KEY.ALT, Keys.D4);
			HotKey a5 = new HotKey(MOD_KEY.ALT, Keys.D5);

			ctrl = new HotKey[] { c1, c2, c3, c4, c5, c6, c7, c8, c9 };
			alt = new HotKey[] { a1, a2, a3, a4, a5 };

			ctrl[0].HotKeyPush += new EventHandler(c1_push);
			ctrl[1].HotKeyPush += new EventHandler(c2_push);
			ctrl[2].HotKeyPush += new EventHandler(c3_push);
			ctrl[3].HotKeyPush += new EventHandler(c4_push);
			ctrl[4].HotKeyPush += new EventHandler(c5_push);
			ctrl[5].HotKeyPush += new EventHandler(c6_push);
			ctrl[6].HotKeyPush += new EventHandler(c7_push);
			ctrl[7].HotKeyPush += new EventHandler(c8_push);
			ctrl[8].HotKeyPush += new EventHandler(c9_push);

			alt[0].HotKeyPush += new EventHandler(a1_push);
			alt[1].HotKeyPush += new EventHandler(a2_push);
			alt[2].HotKeyPush += new EventHandler(a3_push);
			alt[3].HotKeyPush += new EventHandler(a4_push);
			alt[4].HotKeyPush += new EventHandler(a5_push);
		}

		public void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			foreach (HotKey h in ctrl)
			{
				h.Dispose();
			}
		}

		//コンソールに設定の中身出力
		private void Debug()
		{
			int i = 1;

			foreach (string p in pre1)
			{
				Console.WriteLine("Pre1-" + i + ": " + p);
				i++;
			}

			i = 1;

			foreach (string p in pre2)
			{
				Console.WriteLine("Pre2-" + i + ": " + p);
				i++;
			}

			i = 1;

			foreach (string p in pre3)
			{
				Console.WriteLine("Pre3-" + i + ": " + p);
				i++;
			}

			i = 1;

			foreach (string p in pre4)
			{
				Console.WriteLine("Pre4-" + i + ": " + p);
				i++;
			}

			i = 1;

			foreach (string p in pre5)
			{
				Console.WriteLine("Pre5-" + i + ": " + p);
				i++;
			}
		}

		//設定のリセット
		private void Reset()
		{
			Properties.Settings.Default.Reset();
			Properties.Settings.Default.Save();

			Pres();

			Pre1();
			Pre2();
			Pre3();
			Pre4();
			Pre5();
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

			pre1 = new string[9] { p11, p12, p13, p14, p15, p16, p17, p18, p19 };
			pre2 = new string[9] { p21, p22, p23, p24, p25, p26, p27, p28, p29 };
			pre3 = new string[9] { p31, p32, p33, p34, p35, p36, p37, p38, p39 };
			pre4 = new string[9] { p41, p42, p43, p44, p45, p46, p47, p48, p49 };
			pre5 = new string[9] { p51, p52, p53, p54, p55, p56, p57, p58, p59 };
		}

		//色々
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

		//テキストボックスに反映
		private void Pre1()
		{
			int i = 0;

			foreach (TextBox t in textbox)
			{
				t.Text = pre1[i];
				i++;
			}
		}

		private void Pre2()
		{
			int i = 0;

			foreach (TextBox t in textbox)
			{
				t.Text = pre2[i];
				i++;
			}
		}

		private void Pre3()
		{
			int i = 0;

			foreach (TextBox t in textbox)
			{
				t.Text = pre3[i];
				i++;
			}
		}

		private void Pre4()
		{
			int i = 0;

			foreach (TextBox t in textbox)
			{
				t.Text = pre4[i];
				i++;
			}
		}

		private void Pre5()
		{
			int i = 0;

			foreach (TextBox t in textbox)
			{
				t.Text = pre5[i];
				i++;
			}
		}

		//プリセット変更処理
		private void pre_change_1()
		{
			pre = 1;
			Text = "CBExtension (" + pre + ")";

			Pre1();
		}

		private void pre_change_2()
		{
			pre = 2;
			Text = "CBExtension (" + pre + ")";

			Pre2();
		}

		private void pre_change_3()
		{
			pre = 3;
			Text = "CBExtension (" + pre + ")";

			Pre3();
		}

		private void pre_change_4()
		{
			pre = 4;
			Text = "CBExtension (" + pre + ")";

			Pre4();
		}

		private void pre_change_5()
		{
			pre = 5;
			Text = "CBExtension (" + pre + ")";

			Pre5();
		}

		//キーが押されたときのイベント
		public void c1_push(object sender, EventArgs e)
		{
			PRE();

			Clipboard.SetDataObject(one, true);

			try
			{
				notifyIcon1.BalloonTipText = one;
				notifyIcon1.ShowBalloonTip(time);
			}

			catch
			{
				return;
			}
		}

		public void c2_push(object sender, EventArgs e)
		{
			PRE();

			Clipboard.SetDataObject(two, true);

			try
			{
				notifyIcon1.BalloonTipText = two;
				notifyIcon1.ShowBalloonTip(time);
			}

			catch
			{
				return;
			}
		}

		public void c3_push(object sender, EventArgs e)
		{
			PRE();

			Clipboard.SetDataObject(three, true);

			try
			{
				notifyIcon1.BalloonTipText = three;
				notifyIcon1.ShowBalloonTip(time);
			}

			catch
			{
				return;
			}
		}

		public void c4_push(object sender, EventArgs e)
		{
			PRE();

			Clipboard.SetDataObject(four, true);

			try
			{
				notifyIcon1.BalloonTipText = four;
				notifyIcon1.ShowBalloonTip(time);
			}

			catch
			{
				return;
			}
		}

		public void c5_push(object sender, EventArgs e)
		{
			PRE();

			Clipboard.SetDataObject(five, true);

			try
			{
				notifyIcon1.BalloonTipText = five;
				notifyIcon1.ShowBalloonTip(time);
			}

			catch
			{
				return;
			}
		}

		public void c6_push(object sender, EventArgs e)
		{
			PRE();

			Clipboard.SetDataObject(six, true);

			try
			{
				notifyIcon1.BalloonTipText = six;
				notifyIcon1.ShowBalloonTip(time);
			}

			catch
			{
				return;
			}
		}

		public void c7_push(object sender, EventArgs e)
		{
			PRE();

			Clipboard.SetDataObject(seven, true);

			try
			{
				notifyIcon1.BalloonTipText = seven;
				notifyIcon1.ShowBalloonTip(time);
			}

			catch
			{
				return;
			}
		}

		public void c8_push(object sender, EventArgs e)
		{
			PRE();

			Clipboard.SetDataObject(eight, true);

			try
			{
				notifyIcon1.BalloonTipText = eight;
				notifyIcon1.ShowBalloonTip(time);
			}

			catch
			{
				return;
			}
		}

		public void c9_push(object sender, EventArgs e)
		{
			PRE();

			Clipboard.SetDataObject(nine, true);

			try
			{
				notifyIcon1.BalloonTipText = nine;
				notifyIcon1.ShowBalloonTip(time);
			}

			catch
			{
				return;
			}
		}

		public void a1_push(object sender, EventArgs e)
		{
			pre_change_1();

			try
			{
				notifyIcon1.BalloonTipText = "プリセット1";
				notifyIcon1.ShowBalloonTip(time);
			}

			catch
			{
				return;
			}
		}

		public void a2_push(object sender, EventArgs e)
		{
			pre_change_2();

			try
			{
				notifyIcon1.BalloonTipText = "プリセット2";
				notifyIcon1.ShowBalloonTip(time);
			}

			catch
			{
				return;
			}
		}

		public void a3_push(object sender, EventArgs e)
		{
			pre_change_3();

			try
			{
				notifyIcon1.BalloonTipText = "プリセット3";
				notifyIcon1.ShowBalloonTip(time);
			}

			catch
			{
				return;
			}
		}

		public void a4_push(object sender, EventArgs e)
		{
			pre_change_4();

			try
			{
				notifyIcon1.BalloonTipText = "プリセット4";
				notifyIcon1.ShowBalloonTip(time);
			}

			catch
			{
				return;
			}
		}

		public void a5_push(object sender, EventArgs e)
		{
			pre_change_5();

			try
			{
				notifyIcon1.BalloonTipText = "プリセット5";
				notifyIcon1.ShowBalloonTip(time);
			}

			catch
			{
				return;
			}
		}

		//適用ボタン
		private void button1_Click(object sender, EventArgs e)
		{
			switch (pre)
			{
				case 1:
					Properties.Settings.Default.pre11 = textbox[0].Text;
					Properties.Settings.Default.pre12 = textbox[1].Text;
					Properties.Settings.Default.pre13 = textbox[2].Text;
					Properties.Settings.Default.pre14 = textbox[3].Text;
					Properties.Settings.Default.pre15 = textbox[4].Text;
					Properties.Settings.Default.pre16 = textbox[5].Text;
					Properties.Settings.Default.pre17 = textbox[6].Text;
					Properties.Settings.Default.pre18 = textbox[7].Text;
					Properties.Settings.Default.pre19 = textbox[8].Text;
					break;

				case 2:
					Properties.Settings.Default.pre21 = textbox[0].Text;
					Properties.Settings.Default.pre22 = textbox[1].Text;
					Properties.Settings.Default.pre23 = textbox[2].Text;
					Properties.Settings.Default.pre24 = textbox[3].Text;
					Properties.Settings.Default.pre25 = textbox[4].Text;
					Properties.Settings.Default.pre26 = textbox[5].Text;
					Properties.Settings.Default.pre27 = textbox[6].Text;
					Properties.Settings.Default.pre28 = textbox[7].Text;
					Properties.Settings.Default.pre29 = textbox[8].Text;
					break;

				case 3:
					Properties.Settings.Default.pre31 = textbox[0].Text;
					Properties.Settings.Default.pre32 = textbox[1].Text;
					Properties.Settings.Default.pre33 = textbox[2].Text;
					Properties.Settings.Default.pre34 = textbox[3].Text;
					Properties.Settings.Default.pre35 = textbox[4].Text;
					Properties.Settings.Default.pre36 = textbox[5].Text;
					Properties.Settings.Default.pre37 = textbox[6].Text;
					Properties.Settings.Default.pre38 = textbox[7].Text;
					Properties.Settings.Default.pre39 = textbox[8].Text;
					break;

				case 4:
					Properties.Settings.Default.pre41 = textbox[0].Text;
					Properties.Settings.Default.pre42 = textbox[1].Text;
					Properties.Settings.Default.pre43 = textbox[2].Text;
					Properties.Settings.Default.pre44 = textbox[3].Text;
					Properties.Settings.Default.pre45 = textbox[4].Text;
					Properties.Settings.Default.pre46 = textbox[5].Text;
					Properties.Settings.Default.pre47 = textbox[6].Text;
					Properties.Settings.Default.pre48 = textbox[7].Text;
					Properties.Settings.Default.pre49 = textbox[8].Text;
					break;

				case 5:
					Properties.Settings.Default.pre51 = textbox[0].Text;
					Properties.Settings.Default.pre52 = textbox[1].Text;
					Properties.Settings.Default.pre53 = textbox[2].Text;
					Properties.Settings.Default.pre54 = textbox[3].Text;
					Properties.Settings.Default.pre55 = textbox[4].Text;
					Properties.Settings.Default.pre56 = textbox[5].Text;
					Properties.Settings.Default.pre57 = textbox[6].Text;
					Properties.Settings.Default.pre58 = textbox[7].Text;
					Properties.Settings.Default.pre59 = textbox[8].Text;
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

		private void 終了_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void リセットToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult mb1 = MessageBox.Show(reset, "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (mb1 == DialogResult.Yes)
			{
				Reset();
			}
		}

		private void プリセット1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pre_change_1();
		}

		private void プリセット2ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			pre_change_2();
		}

		private void プリセット3ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			pre_change_3();
		}

		private void プリセット4ToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			pre_change_4();
		}

		private void プリセット5ToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			pre_change_5();
		}

		private void プリセット1ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			pre_change_1();
		}

		private void プリセット2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pre_change_2();
		}

		private void プリセット3ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pre_change_3();
		}

		private void プリセット4ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pre_change_4();
		}

		private void プリセット5ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pre_change_5();
		}
	}
}