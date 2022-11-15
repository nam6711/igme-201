using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PE20Dom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            // add the delegate method to be called after the webpage loads, set this up before Navigate()
            this.WebBrowser1.DocumentCompleted += new
            WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);

            // or if you want to use the URL  (only use one of these Navigate() statements)
            this.WebBrowser1.Navigate("people.rit.edu/dxsigm/example.html");
        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            // Change the.InnerText of the first<h1> to "My UFO Page"
            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h1");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerText = "My UFO Page";

            // Change the.InnerText of the first<h2> to "My UFO Info"
            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h2");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerText = "My UFO Info";

            // Change the.InnerText of the 2nd<h2> to "My UFO Pictures"
            htmlElement = htmlElementCollection[1];
            htmlElement.InnerText = "My UFO Pictures";

            // Change the.InnerText of the 3rd<h2> to an empty string -""
            htmlElement = htmlElementCollection[2];
            htmlElement.InnerText = "";

            // Select the<body> element and make 2 style changes:
            //      The font-family shall be "sans-serif"
            //      The font color shall be "reddish"(specify a red shade in hexadecimal).
            htmlElementCollection = webBrowser.Document.GetElementsByTagName("body");
            htmlElement = htmlElementCollection[0];
            htmlElement.Style = "font-family: sans-serif; color: #aa0000";

            // Select the first paragraph and make some changes:
            //      The inner HTML will contain the text "Report your UFO sightings here:" and have a working link to http://www.nuforc.org
            //      There will be.Style changes:
            //          the font color is "green"
            //          the font-weight is "bold"
            //          the font-size is "2em"
            //          the text-transform is "uppercase"
            //          the text-shadow is "3px 2px #A44"
            htmlElementCollection = webBrowser.Document.GetElementsByTagName("p");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerHtml = "Report your UFO sightings here: <a href=\"http://www.nuforc.org\">www.nuforc.org</a>";
            htmlElement.Style = "color: green;" +
                "font-weight: 600;" +
                "font-size: 2em;" +
                "text-transform: uppercase;" +
                "text-shadow: 3px 2px #a44";

            // Change the.InnerText of the 2nd paragraph to an empty string -""
            htmlElementCollection = webBrowser.Document.GetElementsByTagName("p");
            htmlElement = htmlElementCollection[1];
            htmlElement.InnerText = "";

            // Insert an<img> element in the beginning of the 3rd paragraph to show an image of a UFO that is out on the web
            htmlElementCollection = webBrowser.Document.GetElementsByTagName("p");
            htmlElement = htmlElementCollection[2];
            HtmlElement img = webBrowser.Document.CreateElement("img");
            img.SetAttribute("src", "data:image/jpeg;base64,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");
            img.SetAttribute("alt", "UFO Sighting");
            htmlElement.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterBegin, img);

            // Add a footer element to the end of the page which has a copyright(&copy;) notice, the current year and your name.
            htmlElement = webBrowser.Document.CreateElement("footer");   
            htmlElement.InnerHtml = "&copy; 2022 Nat/Noah Manoucheri";

            HtmlElement body = webBrowser.Document.GetElementsByTagName("body")[0];
            body.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeEnd, htmlElement);
        }
    }
}
