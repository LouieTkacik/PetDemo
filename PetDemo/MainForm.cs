using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetDemo
{
    //LOUIE TKACIK 0290449 class object example in a forms app with using a new class through the project drop down
    
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<Pet> petList = new List<Pet>();
        private void subButt_Click(object sender, EventArgs e)
        {
            string n, t;
            int a;
            //check for no empty field
            if(nameText.Text!="" && typeText.Text!="")
            {
                //check for valid age input
                if(int.TryParse(ageText.Text, out a))
                {
                    n = nameText.Text;
                    t = typeText.Text;
                    //age is already stored into a
                    //now to create a pet object

                    Pet myPet1 = new Pet(n, t, a);
                    // myPet1.Name = n;
                    // myPet1.Type = t;
                    // myPet1.Age = a;

                    //this method displays the info
                    //MessageBox.Show(myPet1.getData());

                    //add the pet object to the new form list
                    //  DisplayForm displayForm = new DisplayForm();
                    //  displayForm.displayList.Items.Add(myPet1.getData());
                    //  displayForm.ShowDialog(); //this shows the form
                    //this style will not let you alter the other 

                    //   DisplayForm displayForm = new DisplayForm();
                    //  displayForm.displayList.Items.Add(myPet1.getData());
                    //   displayForm.Show();

                    //This lets you alter the first form, but it will open up another one...
                    
                    petList.Add(myPet1);
                    clearInput();
                    
                }
                else
                {
                    MessageBox.Show("Invalid data entry");
                }
            }
            else { MessageBox.Show("Invalid data"); }

        }
        private void clearInput()
        {
            nameText.Text = "";
            typeText.Text = "";
            ageText.Text = "";
        }
        private void exitButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dispButt_Click(object sender, EventArgs e)
        {
            DisplayForm newForm = new DisplayForm();
            newForm.Show();
            for (int i=0; i <petList.Count; i++)
            {
                newForm.displayList.Items.Add(petList[i].getData());
            }
            
        }
    }
}
