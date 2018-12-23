using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermekKezelo
{
    public class Gun
    {
        private int id;
        private string gyarto;
        private string nev;
        private int tipus;
        private int fps;
        private int suly;
        private string anyag;
        private int ar;
        private int varians;

        public Gun(int id, string gyarto, string nev, int tipus, int fps, int suly, string anyag, int ar, int varians)
        {
            this.id = id;
            this.gyarto = gyarto;
            this.nev=nev;
            this.tipus = tipus;
            this.fps = fps;
            this.suly = suly;
            this.anyag = anyag;
            this.ar = ar;
            this.varians = varians;
        }

        public Gun()
        {

        }

        //get methods
        public int getId()
        {
            return id;
        }

        public string getGyarto()
        {
            return gyarto;
        }

        public string getNev()
        {
            return nev;
        }

        public int getTipus()
        {
            return tipus;
        }

        public int getFPS()
        {
            return fps;
        }

        public int getSuly()
        {
            return suly;
        }

        public string getAnyag()
        {
            return anyag;
        }

        public int getAr()
        {
            return ar;
        }

        public int getVarians()
        {
            return varians;
        }

        //set methods
        public void setId(int id)
        {
            this.id = id;
        }

        public void setGyarto(string gyarto)
        {
            this.gyarto = gyarto;
        }

        public void setNev(string nev)
        {
            this.nev = nev;
        }

        public void setTipus(int tipus)
        {
            this.tipus = tipus;
        }

        public void setFPS(int fps)
        {
            this.fps = fps;
        }

        public void setSuly(int suly)
        {
            this.suly = suly;
        }

        public void setAnyag(string anyag)
        {
            this.anyag = anyag;
        }

        public void setAr(int ar)
        {
            this.ar = ar;
        }

        public void setVarians(int varians)
        {
            this.varians = varians;
        }
    }
}
