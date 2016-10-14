using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    class Umpire
    {

        public delegate string BaseBallFieldInfo(int distance, int angle);
        public BaseBallFieldInfo fieldInfo;
        public delegate void Message(string str);
        public Message message;
        public Umpire()
        {
        }
        public bool OutField(object sender, BallInPlayEventArgs e)
        {
            string str = fieldInfo(e.distanceOfFly, e.angleOfFly);
            message("主審 : "+str+"!\r\n");
            switch (str)
            {
                case "全壘打":
                case "界外球":
                    return true;
                default:
                    return false;
            }
        }
        public void HitOrOut(bool isCatched)
        {
            if (isCatched)
                message("主審:接殺出局!\r\n");
            else
                message("主審:安打\r\n");
        }

        public void CallStrike()
        {
            message("主審:揮棒落空\n");
        }
    }
}
