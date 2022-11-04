using Manager.model;
using Manager.presenter;
using Manager.view.interfaces;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ManagerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window , IDataView
    {
        DatabasePresenter databasePresenter;
        public MainWindow()
        {
            databasePresenter = new DatabasePresenter(this);
            InitializeComponent();
            //dataGrid.DataContext = new NhanVien();
            //dataGrid.AutoGenerateColumns = true;
            for (int i = 0; i < GetAuthors<NhanVien>().Length; i++)
            {
                var column = new DataGridTextColumn();
                column.Header = GetAuthors<NhanVien>()[i].Name;
                column.Binding = new Binding(GetAuthors<NhanVien>()[i].Name);
                dataGrid.Columns.Add(column);
            }
            databasePresenter.getManagerDao().getNhanVienList();
            dataGrid.IsReadOnly = true;
            //dataGrid.Items.Add(new NhanVien());
        }
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public PropertyInfo[] GetAuthors<T>()
        {
            PropertyInfo[] props = typeof(T).GetProperties();
            return props;
        }

        public void onResultSuccess(object data)
        {
            List<NhanVien> nhanViens = (List<NhanVien>)data;
            nhanViens.ForEach(nh =>
            {
                dataGrid.Items.Add(nh);
            });
        }

        public void onResultError(string message)
        {
            MessageBox.Show(message);
        }
    }
}
