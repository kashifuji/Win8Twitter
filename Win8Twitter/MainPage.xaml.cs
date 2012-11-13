using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TwitterRtLibrary;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Win8Twitter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
      

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        public TwitterRt TwitterRtInstance { get; private set; }

        public MainPage()
        {
            this.InitializeComponent();
            TwitterRtInstance =
              new TwitterRt("woi9HLzDs4ku6sdVS1c98g",
              "M0TyeicA1bNkxyfqxkFfHGLrykNisY7QynzEBPJLQ",
              "http://www.riotgibbon.org");
        }

        private async void AuthenticationButton_Click_1(object sender, RoutedEventArgs e)
        {
            await TwitterRtInstance.GainAccessToTwitter();
            StatusTextBlock.Text = TwitterRtInstance.Status;
        }

        private async void TweetButton_Click(object sender, RoutedEventArgs e)
        {
            await TwitterRtInstance.UpdateStatus("Hello From GibbonTweet " + DateTime.Now);
            StatusTextBlock.Text = TwitterRtInstance.Status;
        }
    }
}
