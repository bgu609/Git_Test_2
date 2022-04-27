using System.Windows;
using Test_Module_2._1;

namespace Test_2._1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        Module_2_1 Module_2_1;

        public MainWindow()
        {
            InitializeComponent();

            Module_2_1 = new Module_2_1();

            View_Text.Text = $"{Module_2_1.Module_Name} ({Module_2_1.Module_Function(2, 1)})";
            //View_ShareText.Text = Test_Share_2_Source.Sharing_Name;
        }
    }
}
