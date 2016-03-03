using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BotanicalReferenceStandardsEditor
{
    public partial class EditPopUp : Form
    {
        List<TextBox> editBoxes = new List<TextBox>();

        public EditPopUp()
        {
            InitializeComponent();

            //adds the textboxes to editBoxes for easy access later on
            editBoxes.Add(commonTextEdit);
            editBoxes.Add(botanicalTextEdit);
            editBoxes.Add(partTextEdit);
            editBoxes.Add(providerTextEdit);
            editBoxes.Add(catalogTextEdit);
            editBoxes.Add(lotTextEdit);
            editBoxes.Add(amountTextEdit);
            editBoxes.Add(purityTextEdit);
            editBoxes.Add(receivedTextEdit);
            editBoxes.Add(expireTextEdit);
            editBoxes.Add(locationTextEdit);
            editBoxes.Add(barCodeTextEdit);
        }

        //fills the text boxes with the respective text in input
        public void fillEntries(ListViewItem input)
        {       
            for (int i = 0; i < editBoxes.Count; i++)
                editBoxes[i].Text = input.SubItems[i].Text;
        }

        //accessor method that returns a list of the text box entries
        public List<String> getEdits()
        {
            List<String> edits = new List<String>();

            foreach (TextBox etb in editBoxes)
                edits.Add(etb.Text);

            return edits;
        }
    }
}