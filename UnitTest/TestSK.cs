using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class TestSK
    {
        BUS.NhanVienBUS NVBUS = new BUS.NhanVienBUS();
        BUS.DocGiaBUS DGBUS = new BUS.DocGiaBUS();
        BUS.ThuVienBUS TVBUS = new BUS.ThuVienBUS();
        BUS.PhieuMuonBUS PMBUS = new BUS.PhieuMuonBUS();
        [TestMethod]
        public void TestInsertNV()
        {
            string hoten = "Ứng Thành Long";
            string ngaysinh = "1998/1/2";
            string gioitinh = "Nam";
            string diachi = "371/16 Nguyễn Kiệm, P3, Q.Gò Vấp";
            string sdt = "01629234484";
            int cmnd = Convert.ToInt32("231251266");
            int id = Convert.ToInt32("49");
            bool kq = NVBUS.InsertNV(hoten, ngaysinh, gioitinh, diachi, sdt, cmnd, id);
            bool exp = true;
            Assert.AreEqual(exp, kq);
        }
        [TestMethod]
        public void TestUpdateNV()
        {
            string hoten = "Ứng Long";
            string ngaysinh = "1998/1/2";
            string gioitinh = "Nam";
            string diachi = "371/16 Nguyễn Kiệm, P3, Q.Gò Vấp";
            string sdt = "01629234484";
            int cmnd = Convert.ToInt32("231251266");
            int id = Convert.ToInt32("49");
            bool kq = NVBUS.UpdateNV(id, hoten, ngaysinh, gioitinh, diachi, sdt, cmnd);
            bool exp = true;
            Assert.AreEqual(exp, kq);
        }
        [TestMethod]
        public void TestDeleteNV()
        {
            int id = Convert.ToInt32("49");
            bool kq = NVBUS.DeleteNV(id);
            bool exp = true;
            Assert.AreEqual(exp, kq);
        }
        [TestMethod]
        public void TestInsertDG()
        {
            string hoten = "Ứng Thành Long";
            string ngaysinh = "1998/1/2";
            string gioitinh = "Nam";
            string diachi = "371/16 Nguyễn Kiệm, P3, Q.Gò Vấp";
            string sdt = "01629234484";
            int cmnd = Convert.ToInt32("231251266");
            int id = Convert.ToInt32("49");
            bool kq = DGBUS.InsertDG(hoten, ngaysinh, gioitinh, diachi, sdt, cmnd, id);
            bool exp = true;
            Assert.AreEqual(exp, kq);
        }
        [TestMethod]
        public void TestUpdateDG()
        {
            string hoten = "Ứng Long";
            string ngaysinh = "1998/1/2";
            string gioitinh = "Nam";
            string diachi = "371/16 Nguyễn Kiệm, P3, Q.Gò Vấp";
            string sdt = "01629234484";
            int cmnd = Convert.ToInt32("231251266");
            int id = Convert.ToInt32("49");
            bool kq = DGBUS.UpdateDG(id, hoten, ngaysinh, gioitinh, diachi, sdt, cmnd);
            bool exp = true;
            Assert.AreEqual(exp, kq);
        }
        [TestMethod]
        public void TestDeleteDG()
        {
            int id = Convert.ToInt32("49");
            bool kq = DGBUS.DeleteDG(id);
            bool exp = true;
            Assert.AreEqual(exp, kq);
        }
        [TestMethod]
        public void TestInsertSach()
        {
            int id = Convert.ToInt32("20");
            string tensach = "Vì Yêu Mà Đến";
            string tentg = "No Name";
            string nxb = "Kim Đồng";
            bool kq = TVBUS.InsertSach(id, tensach, tentg, nxb);
            bool exp = true;
            Assert.AreEqual(exp, kq);
        }
        [TestMethod]
        public void TestUpdateSach()
        {
            int id = Convert.ToInt32("20");
            string tensach = "Vì Yêu Mà Đến";
            string tentg = "No Name";
            string nxb = "Kim Đồng";
            bool kq = TVBUS.UpdateSach(id, tensach, tentg, nxb);
            bool exp = true;
            Assert.AreEqual(exp, kq);
        }
        
        [TestMethod]
        public void TestInsertViTri()
        {
            int id = Convert.ToInt32("20");
            string vitri = "Kệ số 1";
            int soluong = Convert.ToInt32("4");
            bool kq = TVBUS.InsertViTri(vitri, soluong, id);
            bool exp = true;
            Assert.AreEqual(exp, kq);
        }
        [TestMethod]
        public void TestUpdateViTri()
        {
            int id = Convert.ToInt32("20");
            string vitri = "Kệ số 2";
            int soluong = Convert.ToInt32("5");
            bool kq = TVBUS.UpdateViTri(vitri, soluong, id);
            bool exp = true;
            Assert.AreEqual(exp, kq);
        }
        [TestMethod]
        public void TestDeleteViTri()
        {
            int id = Convert.ToInt32("20");
            bool kq = TVBUS.DeleteVitri(id);
            bool exp = true;
            Assert.AreEqual(exp, kq);
        }
        [TestMethod]
        public void TestDeleteSach()
        {
            int id = Convert.ToInt32("20");
            bool kq = TVBUS.DeleteSach(id);
            bool exp = true;
            Assert.AreEqual(exp, kq);
        }
        [TestMethod]
        public void TestT_InsertPM()
        {
            int id = Convert.ToInt32("4");
            string tensach = "Dám Bị Ghét";
            int soluong = 1;
            bool kq = PMBUS.T_InsertPM(id,tensach,soluong);
            bool exp = true;
            Assert.AreEqual(exp, kq);
        }
        [TestMethod]
        public void TestT_UpdateDS()
        {
            int id = Convert.ToInt32("4");
            bool kq = PMBUS.T_UpdateDS(id);
            bool exp = true;
            Assert.AreEqual(exp, kq);
        }
        [TestMethod]
        public void TestB_UpdateBill()
        {
            int id = Convert.ToInt32("4");
            bool kq = PMBUS.B_UpdateBill(id);
            bool exp = true;
            Assert.AreEqual(exp, kq);
        }
        [TestMethod]
        public void TestB_UpdateDS()
        {
            int id = Convert.ToInt32("4");
            bool kq = PMBUS.T_UpdateDS(id);
            bool exp = true;
            Assert.AreEqual(exp, kq);
        }
        [TestMethod]
        public void TestB_DeleteBill()
        {
            int id = Convert.ToInt32("4");
            bool kq = PMBUS.B_DeleteBill(id);
            bool exp = true;
            Assert.AreEqual(exp, kq);
        }
        

    }
}
