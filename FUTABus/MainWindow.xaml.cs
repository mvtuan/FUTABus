using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FUTABus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> Destinations;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Save(object sender, RoutedEventArgs e)
        {

        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Destinations = new List<string>()
            {
                "An Giang", "Bà Rịa - Vũng Tàu", "Bắc Giang", "Bắc Kạn", "Bạc Liêu", "Bắc Ninh", "Bến Tre", "Bình Định", "Bình Dương", "Bình Phước", "Bình Thuận",
                "Cà Mau", "Cao Bằng", "Đắk Lắk", "Đắk Nông", "Điện Biên", "Đồng Nai", "Đồng Tháp", "Gia Lai", "Hà Giang", "Hà Nam", "Hà Tĩnh", "Hải Dương", "Hậu Giang",
                "Hòa Bình", "Hưng Yên", "Khánh Hòa", "Kiên Giang", "Kon Tum", "Lai Châu", "Lâm Đồng", "Lạng Sơn", "Lào Cai", "Long An", "Nam Định", "Nghệ An",
                "Ninh Bình", "Ninh Thuận", "Phú Thọ", "Quảng Bình", "Quảng Nam", "Quảng Ngãi", "Quảng Ninh", "Quảng Trị", "Sóc Trăng", "Sơn La", "Tây Ninh",
                "Thái Bình", "Thái Nguyên", "Thanh Hóa", "Thừa Thiên Huế", "Tiền Giang", "Trà Vinh", "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái", "Phú Yên",
                "Cần Thơ", "Đà Nẵng", "Hải Phòng", "Hà Nội", "TP HCM"
            };
            cbDiemKhoiHanh.ItemsSource = Destinations;
            cbDiemDen.ItemsSource = Destinations;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            GridMain.Children.Clear();
        }
        
        private void BtnDangNhap(object sender, RoutedEventArgs e)
        {
            LogInWindow login = new LogInWindow();
            login.ShowDialog();
        }

        private void BtnDangKy(object sender, RoutedEventArgs e)
        {
            SignUpWindow signUp = new SignUpWindow();
            signUp.ShowDialog();
        }

        private void BtnDatVe(object sender, RoutedEventArgs e)
        {
            SeatPicking seat = new SeatPicking();
            seat.ShowDialog();
        }
    }
}
