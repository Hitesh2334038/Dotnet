using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace MyFirstWebApp
{
    public class Global : System.Web.HttpApplication
    {
        public void WriteMessageToLogFile(string content)
        {
            using (FileStream fs = new FileStream(@"C:\Sharanth\TrainingContent\FirstWebApplog.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.BaseStream.Seek(0, SeekOrigin.End);
                sw.WriteLine(content);
                sw.Flush();
                sw.Close();
            }
        }

        public static string GetBrowserDetails()
        {
            string browserDetails = string.Empty;
            System.Web.HttpBrowserCapabilities browser = HttpContext.Current.Request.Browser;
            browserDetails =
            "Name = " + browser.Browser + "," +
            "Type = " + browser.Type + ","
            + "Version = " + browser.Version + ","
            + "Major Version = " + browser.MajorVersion + ","
            + "Minor Version = " + browser.MinorVersion + ","
            + "Platform = " + browser.Platform + ","
            + "Is Beta = " + browser.Beta + ","
            + "Is Crawler = " + browser.Crawler + ","
            + "Is AOL = " + browser.AOL + ","
            + "Is Win16 = " + browser.Win16 + ","
            + "Is Win32 = " + browser.Win32 + ","
            + "Supports Frames = " + browser.Frames + ","
            + "Supports Tables = " + browser.Tables + ","
            + "Supports Cookies = " + browser.Cookies + ","
            + "Supports VBScript = " + browser.VBScript + ","
            + "Supports JavaScript = " + "," +
            browser.EcmaScriptVersion.ToString() + ","
            + "Supports Java Applets = " + browser.JavaApplets + ","
            + "Supports ActiveX Controls = " + browser.ActiveXControls
            + ","
            + "Supports JavaScript Version = " +
            browser["JavaScriptVersion"];
            return browserDetails;
        } 

        protected void Application_Start(object sender, EventArgs e)
        {
            WriteMessageToLogFile("Application_Start:" + DateTime.Now.ToString());
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            WriteMessageToLogFile("Session_Start:" + DateTime.Now.ToString());
            WriteMessageToLogFile("Session Id:" + Session.SessionID);
            WriteMessageToLogFile(GetBrowserDetails());
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            WriteMessageToLogFile("Application_Error:" + DateTime.Now.ToString());
        }

        protected void Session_End(object sender, EventArgs e)
        {
            WriteMessageToLogFile("Session_End:" + DateTime.Now.ToString());
            WriteMessageToLogFile("Session Id:" + Session.SessionID);
        }

        protected void Application_End(object sender, EventArgs e)
        {
            WriteMessageToLogFile("Application_End:" + DateTime.Now.ToString());
        }
    }
}