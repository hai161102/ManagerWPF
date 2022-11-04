using Manager.model;
using Manager.model.instance;
using Manager.model.model;
using Manager.model.model.account;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.db
{
    public class ManagerDao
    {
        private SqlConnection connection;
        private IDatabaseModel iDatabaseModel;
        private ILoginModel iLoginModel;
        private string connectionString = "Data Source=HAI;Initial Catalog=Manager_gr_12;Integrated Security=True";
        private string DATE_FORMAT = "yyyy-MM-dd";

        public void setIDatabaseModel(IDatabaseModel databaseModel)
        {
            this.iDatabaseModel = databaseModel;
        }

        public void setILoginModel(ILoginModel loginModel)
        {
            this.iLoginModel = loginModel;
        }
        public ManagerDao()

        {
        }

        private SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            return connection;
        }

        public void insertData(object data)
        {
            if (data == null) return;
            if (data.GetType() == typeof(NhanVien))
            {
                insertManager((NhanVien)data);
            }
        }

        private void insertManager(NhanVien nhanvien)
        {
            try
            {
                connection = GetConnection();
                string query = "insert into Manager values (N'" + nhanvien.HoTen
                    + "', N'" + nhanvien.SoDienThoai
                    + "', '" + nhanvien.NgaySinh.ToString(DATE_FORMAT)
                    + "', N'" + nhanvien.GioiTinh
                    + "', N'" + nhanvien.QueQuan
                    + "', N'" + nhanvien.ChiNhanh.MaChiNhanh
                    + "', N'" + nhanvien.ChucVu.MaChucVu + "', " 
                    + nhanvien.BacLuong.BacLuong + ")";
                SqlCommand command = new SqlCommand(query, connection);
                if (command.ExecuteNonQuery() < 0)
                {
                    iDatabaseModel.onFailure("Some error!");
                }
                else
                {
                    getNhanVienList();
                }

            }
            catch (Exception e)
            {

                iDatabaseModel.onFailure(e.Message);
            }
            
            
        }

        public void getNhanVienList()
        {
            List<NhanVien> list = new List<NhanVien>();
            try
            {
                connection = GetConnection();
                string query = "Select * from Manager";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader oReader = cmd.ExecuteReader();
                while (oReader.Read())
                {
                    try
                    {

                        ChiNhanh chinhanh = new ChiNhanh();
                        ChucVu chucVu = new ChucVu();
                        Luong luong = new Luong();

                        chinhanh.MaChiNhanh = oReader["stateId"].ToString();
                        chucVu.MaChucVu = oReader["levelId"].ToString();
                        luong.BacLuong = Int32.Parse(oReader["salaryId"].ToString());

                        list.Add(new NhanVien(
                        Int32.Parse(oReader["managerId"].ToString()),
                        oReader["managerName"].ToString(),
                        oReader["managerNumber"].ToString(),
                        DateTime.Parse(oReader["managerDob"].ToString()),
                        oReader["managerSex"].ToString(),
                        oReader["managerHometown"].ToString(),
                        chinhanh,
                        chucVu,
                        luong)
                        );

                    }
                    catch (Exception e)
                    {
                        iDatabaseModel.onFailure(e.Message);
                    }

                }
                cmd.Dispose();

                connection.Close();

            }
            catch (Exception e)
            {
                iDatabaseModel.onFailure(e.Message);
            }
            list.ForEach(o =>
            {
                o.ChiNhanh = getChiNhanh("Select * from StateCompany where stateId = '" + o.ChiNhanh.MaChiNhanh + "'");
                o.ChucVu = getChucVu("Select * from LevelManager where levelId = '" + o.ChucVu.MaChucVu + "'");
                o.BacLuong = getLuong("Select * from Salary where salaryId = " + o.BacLuong.BacLuong);
            });
            iDatabaseModel.onSuccess(list);

        }
        public void getNhanVienList(int id)
        {
            List<NhanVien> list = new List<NhanVien>();
            try
            {
                connection = GetConnection();
                string query = "Select * from Manager where managerId = " + id;
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader oReader = cmd.ExecuteReader();
                while (oReader.Read())
                {
                    try
                    {

                        ChiNhanh chinhanh = new ChiNhanh();
                        ChucVu chucVu = new ChucVu();
                        Luong luong = new Luong();

                        chinhanh.MaChiNhanh = oReader["stateId"].ToString();
                        chucVu.MaChucVu = oReader["levelId"].ToString();
                        luong.BacLuong = Int32.Parse(oReader["salaryId"].ToString());

                        list.Add(new NhanVien(
                        Int32.Parse(oReader["managerId"].ToString()),
                        oReader["managerName"].ToString(),
                        oReader["managerNumber"].ToString(),
                        DateTime.Parse(oReader["managerDob"].ToString()),
                        oReader["managerSex"].ToString(),
                        oReader["managerHometown"].ToString(),
                        chinhanh,
                        chucVu,
                        luong)
                        );

                    }
                    catch (Exception e)
                    {
                        iDatabaseModel.onFailure(e.Message);
                    }

                }
                cmd.Dispose();

                connection.Close();
            }
            catch (Exception e)
            {
                iDatabaseModel.onFailure(e.Message);
            }
            list.ForEach(o =>
            {
                o.ChiNhanh = getChiNhanh("Select * from StateCompany where stateId = '" + o.ChiNhanh.MaChiNhanh + "'");
                o.ChucVu = getChucVu("Select * from LevelManager where levelId = '" + o.ChucVu.MaChucVu + "'");
                o.BacLuong = getLuong("Select * from Salary where salaryId = " + o.BacLuong.BacLuong);
            });
            iDatabaseModel.onSuccess(list);
        }

        public NhanVien getNhanVien(int id)
        {
            NhanVien nhanVien = new NhanVien();
            try
            {
                connection = GetConnection();
                string query = "Select * from Manager where managerId = " + id;
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader oReader = cmd.ExecuteReader();
                while (oReader.Read())
                {
                    try
                    {

                        ChiNhanh chinhanh = new ChiNhanh();
                        ChucVu chucVu = new ChucVu();
                        Luong luong = new Luong();

                        chinhanh.MaChiNhanh = oReader["stateId"].ToString();
                        chucVu.MaChucVu = oReader["levelId"].ToString();
                        luong.BacLuong = Int32.Parse(oReader["salaryId"].ToString());

                        nhanVien = new NhanVien(
                        Int32.Parse(oReader["managerId"].ToString()),
                        oReader["managerName"].ToString(),
                        oReader["managerNumber"].ToString(),
                        DateTime.Parse(oReader["managerDob"].ToString()),
                        oReader["managerSex"].ToString(),
                        oReader["managerHometown"].ToString(),
                        chinhanh,
                        chucVu,
                        luong);

                    }
                    catch (Exception e)
                    {
                    }

                }
                cmd.Dispose();
                connection.Close();

            }
            catch (Exception e)
            {
            }

            nhanVien.ChiNhanh = getChiNhanh("Select * from StateCompany where stateId = '" + nhanVien.ChiNhanh.MaChiNhanh + "'");
            nhanVien.ChucVu = getChucVu("Select * from LevelManager where levelId = '" + nhanVien.ChucVu.MaChucVu + "'");
            nhanVien.BacLuong = getLuong("Select * from Salary where salaryId = " + nhanVien.BacLuong.BacLuong);
            return nhanVien;
        }

        public void login(object obj)
        {

            AccountManager account = obj as AccountManager;
            if (account != null)
            {
                UserAccount userAccount = new UserAccount();
                try
                {
                    connection = GetConnection();
                    string query = "Select * from Account where username = '" + account.getUserName() + "' and pass = '"
                        + account.getPassword() + "'";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader oReader = cmd.ExecuteReader();
                    while (oReader.Read())
                    {
                        try
                        {
                            NhanVien nhanVien = new NhanVien();
                            nhanVien.Id = Int32.Parse(oReader["managerId"].ToString());
                            userAccount = new UserAccount(
                                    oReader["username"].ToString(),
                                    oReader["pass"].ToString(),
                                    Int32.Parse(oReader["permission"].ToString()),
                                    nhanVien
                                );

                        }
                        catch (Exception e)
                        {
                            iLoginModel.onLoginFailure(e.Message);
                        }
                    }
                    cmd.Dispose();
                    connection.Close();
                    iLoginModel.onLoginSuccess(userAccount);


                }
                catch (Exception e)
                {

                    iLoginModel.onLoginFailure(e.Message);
                }


            }
        }

        private Luong getLuong(string sub3)
        {
            Luong luong = new Luong();

            connection = GetConnection();
            SqlCommand cmd = new SqlCommand(sub3, connection);
            SqlDataReader oReader = cmd.ExecuteReader();
                while (oReader.Read())
            {
                try
                {
                    luong = new Luong(
                            Int32.Parse(oReader["salaryId"].ToString()),
                            float.Parse(oReader["baseSalary"].ToString()),
                            float.Parse(oReader["indexSalary"].ToString()),
                            float.Parse(oReader["bonusSalary"].ToString())
                        );
                }
                catch (Exception e)
                {
                    iDatabaseModel.onFailure(e.Message);
                }

            }
            cmd.Dispose();
            connection.Close();

            return luong;
        }

        private ChucVu getChucVu(string sub2)
        {
            ChucVu chuc = new ChucVu();
            connection = GetConnection();
            SqlCommand cmd = new SqlCommand(sub2, connection);
            SqlDataReader oReader = cmd.ExecuteReader();
            while (oReader.Read())
            {
                try
                {
                    chuc = new ChucVu(
                            oReader["levelId"].ToString(),
                            oReader["levelName"].ToString()
                            );
                }
                catch (Exception e)
                {
                    iDatabaseModel.onFailure(e.Message);
                }

            }
            cmd.Dispose();
            connection.Close();
            return chuc;
        }

        private ChiNhanh getChiNhanh(string sub1)
        {
            ChiNhanh chiNhanh = new ChiNhanh();
            connection = GetConnection();
            SqlCommand cmd = new SqlCommand(sub1, connection);
            SqlDataReader oReader = cmd.ExecuteReader();
            while (oReader.Read())
            {
                try
                {
                    chiNhanh = new ChiNhanh(
                            oReader["stateId"].ToString(),
                            oReader["stateName"].ToString(),
                            oReader["stateAddress"].ToString(),
                            oReader["stateHotline"].ToString()
                        );
                }
                catch (Exception e)
                {
                    iDatabaseModel.onFailure(e.Message);
                }

            }
            cmd.Dispose();
            connection.Close();
            return chiNhanh;
        }
    }
}
