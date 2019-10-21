using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitTest;
using NUnit.Framework;
namespace NUnitTest.Test
{
    [TestFixture]
    public class TestPhanSo
    {
        [Test]
        public void TestHamMacDinh()
        {
            PhanSo p=new PhanSo();
            Assert.AreEqual(0, p.Tu, "Loi o tu so");
            Assert.AreEqual(1, p.Mau, "Loi o mau so");
        }

        [Test]
        public void TestHamDung2ThamSo()
        {
            PhanSo p;
            p = new PhanSo(3, 4);
            Assert.AreEqual(3, p.Tu, "Loi o tu so");
            Assert.AreEqual(4,p.Mau,"loi o mau so");
        }

        [Test]
        public void TestCong_PhanSoDuong()
        {
            PhanSo p1=new PhanSo(1,2);
            PhanSo p2 = new PhanSo(3, 4);
            PhanSo p3 = p1.Cong(p2);
            Assert.AreEqual(10, p3.Tu, "Loi o tu so");
            Assert.AreEqual(8, p3.Mau, "loi o mau so");
        }
        [Test]
        public void TestCong_PhanSoAm()
        {
            PhanSo p1 = new PhanSo(-1, 2);
            PhanSo p2 = new PhanSo(3, 4);
            PhanSo p3 = p1.Cong(p2);
            Assert.AreEqual(2, p3.Tu, "Loi o tu so");
            Assert.AreEqual(8, p3.Mau, "loi o mau so");
        }
        [Test]
        public void TestTru()
        {
            PhanSo p1 = new PhanSo(1, 2);
            PhanSo p2 = new PhanSo(3, 4);
            PhanSo p3 = p1.Tru(p2);
            Assert.AreEqual(-2, p3.Tu, "Loi o tu so");
            Assert.AreEqual(8, p3.Mau, "loi o mau so");
        }
        [Test]
        public void TestChia()
        {
            PhanSo p1 = new PhanSo(1, 2);
            PhanSo p2 = new PhanSo(3, 4);
            PhanSo p3 = p1.Chia(p2);
            Assert.AreEqual(4, p3.Tu, "Loi o tu so");
            Assert.AreEqual(6, p3.Mau, "loi o mau so");
        }
        [Test,ExpectedException(typeof(DivideByZeroException))]
        public void TestChia0()
        {
            PhanSo p1 = new PhanSo(1, 2);
            PhanSo p2 = new PhanSo(0, 4);
            PhanSo p3 = p1.Chia(p2);
        }

        public void TestToString()
        {
            PhanSo kq = new PhanSo(3, 4);
            string s = kq.ToString();
            Assert.AreEqual("3/4", s, "loi ket qua xuat chuoi");
        }
    }
}
