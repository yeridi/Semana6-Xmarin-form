using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewView : ContentPage
    {
        public NewView()
        {
            InitializeComponent();
            this.BindingContext = new AlumnoVM();
        }
    }
}