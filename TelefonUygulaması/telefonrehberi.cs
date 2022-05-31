using System;
using System.Collections.Generic;
using System.Text;

namespace TelefonUygulamasıDersteYapılan
{
   public class telefonrehberi
    {

        public List<Kayıt> _tellist;

        public telefonrehberi()
        {
            _tellist = new List<Kayıt>();

        }

        public void Ekle(Kayıt k)
        {
            _tellist.Add(k);
        }
        public void Sil(int pos)
        {
            _tellist.RemoveAt(pos);
        }

        public void Duzelt(int pos, Kayıt k)
        {
            _tellist[pos] = k;
        }

        public Kayıt getKayıt(int pos)
        {
            return _tellist[pos];
        }
    }
}
