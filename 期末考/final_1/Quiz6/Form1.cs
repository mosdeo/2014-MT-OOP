using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ShowMessage(string str)
        {
            txt_Message.AppendText(str);
        }

        private void btn_Hit_Click(object sender, EventArgs e)
        {

            Ball ball = new Ball(int.Parse(txt_DistanceOfFly.Text), int.Parse(txt_AngleOfFly.Text));
            BaseBallField field = new BaseBallField(int.Parse(txt_SizeOfBaseballField.Text), int.Parse(txt_AngleOfBaseballField.Text));
            Umpire umpire = new Umpire();
            Pitcher pitcher = new Pitcher(int.Parse(txt_PitcherDistanceLow.Text),int.Parse(txt_PitcherDistanceHigh.Text), 
                int.Parse(txt_PitcherAngleLeft.Text), int.Parse(txt_PitcherAngleRight.Text));
            SecondBaseMan secondBaseMan = new SecondBaseMan(int.Parse(txt_SecondBaseManDistanceLow.Text), int.Parse(txt_SecondBaseManDistanceHigh.Text),
                int.Parse(txt_SecondBaseManAngleLeft.Text), int.Parse(txt_SecondBaseManAngleRight.Text));
            CenterFielder centerFielder = new CenterFielder(int.Parse(txt_CenterFielderDistanceLow.Text), int.Parse(txt_CenterFielderDistanceHigh.Text),
                int.Parse(txt_CenterFielderAngleLeft.Text), int.Parse(txt_CenterFielderAngleRight.Text));
            Batter batter = new Batter(Convert.ToInt32(txtBoxSpeedLimit.Text), int.Parse(txt_PitcherDistanceLow.Text), int.Parse(txt_PitcherDistanceHigh.Text), 
                int.Parse(txt_PitcherAngleLeft.Text), int.Parse(txt_PitcherAngleRight.Text)); //建構打擊者

            ball.message = ShowMessage;
            umpire.message = ShowMessage;
            umpire.fieldInfo = field.Info;
            pitcher.message = ShowMessage;
            secondBaseMan.message = ShowMessage;
            centerFielder.message = ShowMessage;
            
            ball.hitOrOut += new Ball.HitOrOutEventHandler(umpire.HitOrOut);
            ball.outField += new Ball.OutFieldEventHandler(umpire.OutField);
            ball.inField += new Ball.CatchEventHandler(pitcher.OnCatch);
            ball.inField += new Ball.CatchEventHandler(secondBaseMan.OnCatch);
            ball.inField += new Ball.CatchEventHandler(centerFielder.OnCatch);

            txt_Message.AppendText("投出!\n");
            txt_Message.AppendText("球速" + pitcher.JetSpeed + "\n");

            if (pitcher.JetSpeed <= batter.Upper)
            {
                ball.OnBallInPlay();
            }
            else
            {
                umpire.CallStrike();
            }
            
            txt_Message.AppendText("=============================\r\n");
        }

        private void btn_ClearMessage_Click(object sender, EventArgs e)
        {
            txt_Message.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
