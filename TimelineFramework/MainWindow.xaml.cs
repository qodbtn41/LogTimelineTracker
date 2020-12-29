using System.Windows;

namespace TimelineFramework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*-----| Demonstrate the Timeline |-----*/
            Timeline tl = new Timeline();
            tl.Setup(0, 60, 10, 150);
            host1.Children.Add(tl);
            tl.AddElement(13);
            tl.AddElement(25);
            tl.AddElement(26);

            Timeline t2 = new Timeline();
            t2.Setup(30, 45, 1, 50);
            host2.Children.Add(t2);
            t2.AddElement(33);
            t2.AddElement(37);
            t2.AddElement(44);

            Timeline t3 = new Timeline();
            t3.Setup(0, 600, 15, 50);
            host3.Children.Add(t3);
            t3.AddElement(57);
            t3.AddElement(455);
            t3.AddElement(510);

        }
    }
}
