using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project_Daisy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Root : MasterDetailPage
    {
        public Root()
        {
            InitializeComponent();
            MasterBehavior = MasterBehavior.Popover;
        }
    }
}