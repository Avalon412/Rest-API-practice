using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using JSONParser.Models;

namespace JSONParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UI Events

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
        }

        private void btnDeserialise_Click(object sender, EventArgs e)
        {
            //DebugOutput(txtJSON.Text);
            DecerialiseJSON(txtJSON.Text);
        }

        #endregion

        #region JSON Functions

        private void DecerialiseJSON(string strJSON)
        {
            try
            {
                var jPerson = JsonConvert.DeserializeObject<Person>(strJSON);
                DebugOutput("Here`s our JSON object: " + jPerson.ToString());
                DebugOutput("Here`s our Person FirstName: " + jPerson.FirstName.ToString());

                //var jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON);
                //DebugOutput("Here`s our JSON object: " + jPerson.ToString());

                //DebugOutput("Here`s the First Name: " + jPerson.firstname);
                //DebugOutput("Here`s the Street Address: " + jPerson.streetaddress.house);
            }
            catch(Exception ex)
            {
                DebugOutput("We had a problem: " + ex.Message.ToString());
            }
        }

        #endregion

        #region Debug Output

        private void DebugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtOutput.Text = txtOutput.Text + strDebugText + Environment.NewLine;
                txtOutput.SelectionStart = txtOutput.TextLength;
                txtOutput.ScrollToCaret();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
            }
        }

        #endregion
    }
}
