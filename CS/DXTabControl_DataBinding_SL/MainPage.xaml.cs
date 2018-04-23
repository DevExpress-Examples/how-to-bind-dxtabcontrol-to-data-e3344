using System.Windows;
using System.Windows.Controls;
using DXExample.DemoData;

namespace DXTabControl_DataBinding_SL {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }
        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e) {
            tabControl.ItemsSource = Invoice.GetData();
        }
    }
}
