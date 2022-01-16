using System;
using System.Windows.Forms;
using static RestClient.Infrastructure.Enums;

namespace RestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRunRequest_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();
            rClient.EndPoint = txtRequestURI.Text;
            rClient.AuthType = AuthenticationType.Basic;
            rClient.UserName = txtUserName.Text;
            rClient.UserPassword = txtPassword.Text;

            debugOutput("Rest Client Created");
            string strResponse = rClient.MakeRequest();
            debugOutput(strResponse);
        }

        #region Debug functions
        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
        #endregion
    }
}
