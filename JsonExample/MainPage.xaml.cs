using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Data.Json;
using System.Net.Http;
using Newtonsoft.Json;

namespace JsonExample
{
    public sealed partial class MainPage : Page
    {
        public string myURI = "http://data.mtgox.com/api/1/BTCUSD/ticker";

        public MainPage()
        {
            this.InitializeComponent();
            GetJSON();
        }

        private async void GetJSON()
        {
            var http = new HttpClient();
            //http.MaxResponseContentBufferSize = Int32.MaxValue;
            var response = await http.GetStringAsync(myURI);

            MyClass.RootObject rootObject = JsonConvert.DeserializeObject<MyClass.RootObject>(response);

            //txtBlockResult.Text = rootObject.result; //success
            txtBlockResult.Text = rootObject.@return.avg.display_short.ToString();
        }
    }
}
