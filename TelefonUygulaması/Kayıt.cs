using System;
using System.Collections.Generic;
using System.Text;

namespace TelefonUygulamasıDersteYapılan
{
   public class Kayıt
    {
        public string adisoyadi;
        public string telno;
        public Kayıt(string ads, string tl)
        {

            adisoyadi = ads;
            telno = tl;
            
        }
        public override string ToString()
        {
            return adisoyadi + "----->" + telno;
        }




    }
}
