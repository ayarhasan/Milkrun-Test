using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkrunTest
{
    public partial class ActionWindow : Form
    {
        public int Quantity { get; set; }
        public string DeliveryNote { get; set; }

        public ActionWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            int Quantity = 0;
            bool tryparse = int.TryParse(txtQuantity.Text, out Quantity);
            if (tryparse)
            {
                DialogResult = DialogResult.OK;

                this.Quantity = Quantity;
                this.DeliveryNote = txtDeliveriNote.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Lütfen 0 dan büyük bir sayı giriniz");
                this.Quantity = 0;
                DialogResult = DialogResult.Continue;

                return;
            }
            
         
            
        }

        private void btnGenerateDeliveryNote_Click(object sender, EventArgs e)
        {
            txtDeliveriNote.Text = RandomString(15);
        }
        private readonly Random _random = new Random();

        public string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);

            // Unicode/ASCII Letters are divided into two blocks
            // (Letters 65–90 / 97–122):
            // The first group containing the uppercase letters and
            // the second group containing the lowercase.  

            // char is a single Unicode character  
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }
    }
}
