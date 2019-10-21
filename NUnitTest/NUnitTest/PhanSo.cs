using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest
{
    public class PhanSo
    {
        static void Main(string[] args)
        {
        }

        public PhanSo()
        {
            tu = 0;
            mau = 1;
        }
        public PhanSo(int tu,int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }
        private int tu;

        public int Tu
        {
            get { return tu; }
            set { tu = value; }
        }

        private int mau;

        public int Mau
        {
            get { return mau; }
            set { mau = value; }
        }

        public PhanSo Cong(PhanSo p)
        {
            PhanSo kq;
            kq = new PhanSo();
            kq.tu = tu * p.mau + mau * p.tu;
            kq.mau = mau * p.mau;
            return kq;
        }

        public PhanSo Tru(PhanSo p)
        {
            PhanSo kq;
            kq = new PhanSo();
            kq.tu = tu * p.mau - mau * p.tu;
            kq.mau = mau * p.mau;
            return kq;
        }

        public PhanSo Chia(PhanSo p)
        {
            if (p.tu == 0)
            {
                throw new DivideByZeroException();
            }
            PhanSo kq;
            kq = new PhanSo();
            kq.tu = tu * p.mau;
            kq.mau = mau * p.tu;
            return kq;
        }

        public override string ToString()
        {
            return tu + "/" + mau;
        }
        

    }
}
