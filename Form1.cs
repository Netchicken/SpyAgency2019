using SpyAgency.Business;
using SpyAgency.Data;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SpyAgency
{
    public partial class Form1 : Form
    {
        Spy DefaultSpy = new Spy();


        public Form1()
        {
            InitializeComponent();
            LoadSpyData();

            cbspylevel.SelectedIndex = 0; //Set the first option in the combobox
        }


        //pass the text data to the Default Spy Class
        private void LoadSpyData()
        {
            //add the code name and others from the form
            DefaultSpy.CodeName = txtCodeName.Text;

            DefaultSpy.Weapon = txtWeapon.Text;
            DefaultSpy.KillAbility = txtKillability.Text;
            DefaultSpy.Gadgets = txtGadgets.Text;
            DefaultSpy.Charmlevel = (int)numCharmLevel.Value;

            DefaultSpy.Agency.Country = txtAgencyCountry.Text;
            DefaultSpy.Agency.AgencyName = txtAgencyName.Text;
            DefaultSpy.Agency.NumberOfAgents = (int)numAgents.Value;

            FillListBox();
        }

        //takes all the data in the DefaultSpy class and writes it to the listbox
        private void FillListBox()
        {
            lbxSpy.Items.Clear();
            lbxSpy.Items.Add("Code name: " + DefaultSpy.CodeName);
            lbxSpy.Items.Add("Agent weapon is a " + DefaultSpy.Weapon);
            lbxSpy.Items.Add("Agent killability is " + DefaultSpy.KillAbility);
            lbxSpy.Items.Add("Agent can use a " + DefaultSpy.Gadgets);
            lbxSpy.Items.Add("Agent charm level is " + DefaultSpy.Charmlevel);

            lbxSpy.Items.Add("Home: " + DefaultSpy.Home());
            lbxSpy.Items.Add("Lives in " + DefaultSpy.Agency.Country);
            lbxSpy.Items.Add("Agency Name: " + DefaultSpy.Agency.AgencyName);



            //work out the age
            lbxSpy.Items.Add("Spy is " + DefaultSpy.YearsOld(dtpDOB.Value) + " years old");

            //work out how long since seen
            lbxSpy.Items.Add(DefaultSpy.DaysSinceLastSeen(dtpLastSeen.Value) + " days last seen");
            //How many agents in the spy group
            lbxSpy.Items.Add("There are " + DefaultSpy.Agency.NumberOfAgents + " agents");



        }

        private void DtpDOB_ValueChanged(object sender, EventArgs e)
        {
            LoadSpyData();
        }

        private void Cbspylevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChooseSpyLevel();

        }

        public void ChooseSpyLevel()
        {
            //select a level of spy and instantiate it
            var myChosenSpy = Factory.GetASpy(cbspylevel.SelectedIndex);
            //pass across the values to the default spy
            DefaultSpy = myChosenSpy;

            //if there is a new name use that instead of the default name
            if (!string.IsNullOrEmpty(txtCodeName.Text))
            {
                DefaultSpy.CodeName = txtCodeName.Text;
            }

            //pass the values to the Change Default Features section
            txtWeapon.Text = DefaultSpy.Weapon;
            txtKillability.Text = DefaultSpy.KillAbility;
            txtGadgets.Text = DefaultSpy.Gadgets;
            numCharmLevel.Value = DefaultSpy.Charmlevel;

            //see it on the listbox with default settings
            FillListBox();
        }

        //save your spy details
        private void btnSaveSpy_Click(object sender, EventArgs e)
        {

            //create and fill a list of data
            List<string> FileData = new List<string>();

            foreach (string line in lbxSpy.Items)
            {
                FileData.Add(line);
            }


            //print out if there is a codename as it will be used as the filename
            if (DefaultSpy.CodeName != null)
            {

                string filename = DefaultSpy.CodeName;
                Data.FileOperations.SaveFile(filename, FileData);
                MessageBox.Show("File named " + filename + ".txt" + " has been saved");
            }
            else
            {
                MessageBox.Show("Cannot save until you have a Code Name");
            }
        }



        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
            lbxFiles.Items.Clear();
            lbxFiles.Items.AddRange(FileOperations.ListAllFiles().ToArray());
        }

        private void lbxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {//get the name you click on
                string ChosenFileName = Convert.ToString(lbxFiles.SelectedItem);
                lbxSpy.Items.Clear();
                //load the file with that name
                lbxSpy.Items.AddRange(FileOperations.ReturnFileData(ChosenFileName).ToArray());
            }
            catch (Exception exception)
            {
                //lbxSpy.Items.Add("Error Occured");
                //MessageBox.Show(exception.ToString());
            }
        }



        private void AlltxtBoxChanges_TextChanged(object sender, EventArgs e)
        {
            LoadSpyData();
        }

        private void Allnum_ValueChanged(object sender, EventArgs e)
        {
            LoadSpyData();
        }


    }
}
