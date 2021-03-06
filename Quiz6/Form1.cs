﻿using System;
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
            Umpire umpire = new Umpire(field);
            Pitcher pitcher = new Pitcher(int.Parse(txt_PitcherDistanceLow.Text),int.Parse(txt_PitcherDistanceHigh.Text), 
                int.Parse(txt_PitcherAngleLeft.Text), int.Parse(txt_PitcherAngleRight.Text));
            SecondBaseMan secondBaseMan = new SecondBaseMan(int.Parse(txt_SecondBaseManDistanceLow.Text), int.Parse(txt_SecondBaseManDistanceHigh.Text),
                int.Parse(txt_SecondBaseManAngleLeft.Text), int.Parse(txt_SecondBaseManAngleRight.Text));
            CenterFielder centerFielder = new CenterFielder(int.Parse(txt_CenterFielderDistanceLow.Text), int.Parse(txt_CenterFielderDistanceHigh.Text),
                int.Parse(txt_CenterFielderAngleLeft.Text), int.Parse(txt_CenterFielderAngleRight.Text));

            ball.message = ShowMessage;
            umpire.message = ShowMessage;
            pitcher.message = ShowMessage;
            secondBaseMan.message = ShowMessage;
            centerFielder.message = ShowMessage;
            
            ball.hitOrOut += new Ball.HitOrOutEventHandler(umpire.HitOrOut);
            ball.inField += new Ball.CatchEventHandler(pitcher.OnCatch);
            ball.inField += new Ball.CatchEventHandler(secondBaseMan.OnCatch);
            ball.inField += new Ball.CatchEventHandler(centerFielder.OnCatch);

            ball.isInRange += new Ball.RangeEventHandler(umpire.RangeInOrOut);
            
            ball.OnBallInPlay();
            txt_Message.AppendText("=============================\r\n");
        }

        private void btn_ClearMessage_Click(object sender, EventArgs e)
        {
            txt_Message.Clear();
        }

        private void txt_AngleOfBaseballField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
