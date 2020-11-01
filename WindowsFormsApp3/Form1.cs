using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string srcCode;
        string currUrl;
        string folname;
        string fullFileName;
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = GoBtn;
            this.srcCodeBx.AutoSize = true;
            this.srcCodeBx.ReadOnly = true;
            this.srcCodeBx.Multiline = true;
            webBrowser.ScriptErrorsSuppressed = true;
            DownBtn.Hide();
        }


        private void GoBtn_Click(object sender, EventArgs e)
        {

            string query = srchBx.Text;
            if (string.IsNullOrWhiteSpace(srchBx.Text))
            {
                MessageBox.Show("Enter a search term.");
                srchBx.Focus();
            }
            else
            {
                string webs = "https://twitchemotes.com/search?query=" + query;
                webBrowser.Navigate(webs);
                webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;

            }
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsolutePath != (sender as WebBrowser).Url.AbsolutePath)
                return;
            
            CurrUrlFunc();
        }

        private static string RetrieveData(string url)
        {

            // used to build entire input
            var sb = new StringBuilder();

            // used on each read operation
            var buf = new byte[8192];
            try
            {
                // prepare the web page we will be asking for
                var request = (HttpWebRequest)
                                         WebRequest.Create(url);

                /* Using the proxy class to access the site
                 * Uri proxyURI = new Uri("http://proxy.com:80");
                 request.Proxy = new WebProxy(proxyURI);
                 request.Proxy.Credentials = new NetworkCredential("proxyuser", "proxypassword");*/

                // execute the request
                var response = (HttpWebResponse)
                                           request.GetResponse();

                // we will read data via the response stream
                Stream resStream = response.GetResponseStream();

                string tempString = null;
                int count = 0;

                do
                {
                    // fill the buffer with data
                    count = resStream.Read(buf, 0, buf.Length);

                    // make sure we read some data
                    if (count != 0)
                    {
                        // translate from bytes to ASCII text
                        tempString = Encoding.ASCII.GetString(buf, 0, count);

                        // continue building the string
                        sb.Append(tempString);
                    }
                } while (count > 0); // any more data to read?

            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Failed to retrieve data from the network. Please check you internet connection: " +
                                exception);
            }
            return sb.ToString();
        }
        
        

        private void DownBtn_Click(object sender, EventArgs e)
        {
            try
            {
                

                srcCodeBx.Text = "Getting image URLs...";

                DownImgFunc();
                    srcCodeBx.Text += Environment.NewLine + "Done. Check your Desktop for respective folder.";
                
               
            }
            catch(Exception)
            {
                MessageBox.Show("Unkown error occured. Plese reopen the program.");
            }

        }


        void CurrUrlFunc()
        {

            currUrl = webBrowser.Url.ToString();
            if (Regex.Match(currUrl, ".*/search|(.*/)$").Success)
                MessageBox.Show("Make sure you click on the streamer name or an emote to download");
            else
            {
                srcCode = RetrieveData(currUrl);
                DownBtn.Show();
            }
        }

        

        void DownImgFunc()
        {

            srcCodeBx.Text += Environment.NewLine + Environment.NewLine+ "Downloading images...";
            string namepattern = "<h3><a href=\".*\".*>(.*)</a></h3>";
            string imgpattern = "<img\\s.*?src=(?:'|\")([^'\">]+)(?:'|(2.0)\") .* data-regex=\"(.*)\"";

            Match namatch = Regex.Match(srcCode, namepattern);

            if (namatch.Success)
            {
                folname = namatch.Groups[1].Value.ToString();
            }
            else
                srcCodeBx.Text += Environment.NewLine + Environment.NewLine + "Name not found";



            string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            System.IO.Directory.CreateDirectory(desktopFolder + "\\" + folname);


            MatchCollection matches = Regex.Matches(srcCode, imgpattern);

            foreach (Match match in matches)
            {

                fullFileName = Path.Combine(desktopFolder + "\\" + folname, match.Groups[3].Value + ".png");
                using (var client = new WebClient())
                {
                    client.DownloadFile(match.Groups[1].Value.ToString() + "3.0", fullFileName);
                }

            }
        }
    }
}
