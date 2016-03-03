/*Author: James Liao
 * 
 * This program is for searching through and adding to the Reference Standard Log.
 * This program will directly modify the Excel spreadsheet the standard log is recorded on.
 * The user does not need to access the spreadsheet him/herself to use this program.
 * Please use responsibly and productively.
 * 
 * Troubleshooting:
 * If the program should raise exceptions stating that the Excel spreadsheet is "read-only," simply
 * open the Task Manager, go to Processes, and end all EXCEL.EXE processes. Close and re-run the
 * program and it should work.
 * 
 * Questions/concerns regarding this program can be relayed through Monika Arrhenius in QC Lab
 * or to me directly at jamesli@herbalife.com.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BotanicalReferenceStandardsEditor
{
    public partial class MainForm : Form
    {
        //accesses the reference standard log spreadsheet
        static Excel.Application excelApp = new Excel.Application();
        static Excel.Workbook excelWorkBook = excelApp.Workbooks.Open(Properties.Settings.Default.workbookPath);
        Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkBook.Worksheets.get_Item("Sheet1");

        DateTime today = DateTime.Today;
        ListViewItem selected;
        List<TextBox> textBoxes = new List<TextBox>();
        Dictionary<ListViewItem, int> rowIndices = new Dictionary<ListViewItem,int>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //initializes the first option in the search dropdown options to the first option
            searchStyleBox.Text = searchStyleBox.Items[0].ToString();

            //fills textBoxes with the TextBox objects
            textBoxes.Add(commonText);
            textBoxes.Add(botanicalText);
            textBoxes.Add(partText);
            textBoxes.Add(providerText);
            textBoxes.Add(catalogText);
            textBoxes.Add(lotText);
            textBoxes.Add(amountText);
            textBoxes.Add(purityText);
            textBoxes.Add(receivedText);
            textBoxes.Add(expireText);
            textBoxes.Add(locationText);
            textBoxes.Add(barCodeText);

            //checks if the source collections have been initialized yet
            if (Properties.Settings.Default.commonSource == null)
                Properties.Settings.Default.commonSource = new AutoCompleteStringCollection();
            if (Properties.Settings.Default.botanicalSource == null)
                Properties.Settings.Default.botanicalSource = new AutoCompleteStringCollection();
            if (Properties.Settings.Default.providerSource == null)
                Properties.Settings.Default.providerSource = new AutoCompleteStringCollection();
            if (Properties.Settings.Default.partSource == null)
                Properties.Settings.Default.partSource = new AutoCompleteStringCollection();
            if (Properties.Settings.Default.locationSource == null)
                Properties.Settings.Default.locationSource = new AutoCompleteStringCollection();
            if (((Excel.Range) excelWorksheet.Cells[Properties.Settings.Default.lastRow - 1, 1]).Value2 == null ||
                ((Excel.Range)excelWorksheet.Cells[Properties.Settings.Default.lastRow, 1]).Value2 != null)
            {
                //this section is rather hard-coded, if someone could find a way to change this as well please do
                int row = 3;
                Excel.Range firstBlank = (Excel.Range)excelWorksheet.Cells[row, 1];

                //runs through the log until it finds a blank cell i.e. the end of the log
                while (firstBlank.Value2 != null)
                {
                    row += 1;
                    firstBlank = (Excel.Range)excelWorksheet.Cells[row, 1];
                }

                //sets lastRow in Settings as the first empty row in the reference standard log
                Properties.Settings.Default.lastRow = row;
            }

            //assigns each collection to its respective text box
            commonText.AutoCompleteCustomSource = Properties.Settings.Default.commonSource;
            botanicalText.AutoCompleteCustomSource = Properties.Settings.Default.botanicalSource;
            providerText.AutoCompleteCustomSource = Properties.Settings.Default.providerSource;
            partText.AutoCompleteCustomSource = Properties.Settings.Default.partSource;
            locationText.AutoCompleteCustomSource = Properties.Settings.Default.locationSource;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //The following two functions (search and searchButton_Clicked) are related to the "Search Reference" tab.//
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //search function called by searchButton_Click in order to find reference standards with the given criteria
        private void search(Excel.Worksheet excelSheet, String searchStyle, String searchTerm)
        {
            //clears the results of the last search, if any
            if (resultListView.Items.Count != 0) { resultListView.Items.Clear(); }

            //clears the row indices dictionary
            rowIndices.Clear();

            //initializes a list of ListViewItems for possible matches to searchTerm
            var matched = new List<ListViewItem>();
            
            //finds the column header associated with searchStyle, which is the category to be searched under
            Excel.Range headerCell = (Excel.Range)excelSheet.get_Range("A2", "L2").Find(searchStyle);
            
            //initializes an Excel.Range object to represent single cells under the given column
            int row = headerCell.Row + 1;
            int column = headerCell.Column;
            Excel.Range currentCell = (Excel.Range)excelSheet.Cells[row, column];

            //will run until the current cell is blank i.e. the end of the reference standards list
            while (currentCell.Value != null)
            {
                //checks if the value in the current cell matches the term being searched
                if (currentCell.Value.ToString().ToLower().Contains(searchTerm.ToLower()))
                {
                    int targetRow = currentCell.Row;

                    //initializes a list for the properties of the found reference standard (besides common name)
                    var subItems = new List<String>();

                    //adds the reference standard's properties to subItems
                    //(this loop is rather hard-coded, if someone has a better way of running this, please replace)
                    foreach (Excel.Range e in (Excel.Range)excelSheet.get_Range("B" + targetRow, "L" + targetRow))
                        subItems.Add(e.Value.ToString());

                    //creates a new ListViewItem representing the reference standard
                    var item = new ListViewItem(((Excel.Range)excelSheet.Cells[targetRow, 1]).Value.ToString());
                    item.SubItems.AddRange(subItems.ToArray());

                    //adds the reference standard to the list of matched results
                    matched.Add(item);

                    //adds the ListViewItem and its row to a dictionary (for use in editing)
                    rowIndices.Add(item, targetRow);
                }

                //if current cell is not a match, move on to the next cell in the column
                row += 1;
                currentCell = (Excel.Range)excelSheet.Cells[row, column];
            }

            //if no results were found, dislays such to the user, otherwise displays the results found
            if (matched.Count == 0) { resultFailedLabel.Text = "No results found."; }
            else { resultListView.Items.AddRange(matched.ToArray()); }
        }

        //runs when the user clicks the Search button
        private void searchButton_Click(object sender, EventArgs e)
        {
            //reset the progress bar value
            progressBar.Value = 0;

            //pulls search category and search term from user inputs
            String selected = searchStyleBox.SelectedItem.ToString();
            String searchText = searchBox.Text;

            //searches the reference standard log under the given criteria and displays results accordingly
            search(excelWorksheet, selected, searchText);
            
            //progress bar fills when process is complete
            progressBar.Value = 100;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        //The following two methods (add and addButton_Click) is related to the "Add Reference" tab.//
        //////////////////////////////////////////////////////////////////////////////////////////////

        //adds the reference standard represented by inputs to the log
        private void add(List<String> inputs)
        {
            int col = 1;

            //adds the reference to the log spreadsheet
            foreach (String userInput in inputs)
            {
                excelWorksheet.Cells[Properties.Settings.Default.lastRow, col].Value2 = userInput;
                col++;
            }

            //increments the last row pointer
            Properties.Settings.Default.lastRow += 1;
            Properties.Settings.Default.Save();
        }

        //runs when the user clicks the Add button
        private void addButton_Click(object sender, EventArgs e)
        {
            //Prevents the user from entering an entry full of N/A's
            if (commonText.Text == "") { addSuccessLabel.Text = "Please enter a common name."; }
            else if (locationText.Text == "") { addSuccessLabel.Text = "Please enter a location."; }
            else
            {
                //resets the progress bar value
                progressBar.Value = 0;

                //creates and populates a list of the user's inputs for the reference standard to be added
                List<String> inputs = new List<String>();

                foreach (TextBox tb in textBoxes) inputs.Add(tb.Text);

                //adds user's inputs to respective autocomplete lists for easier future data entry
                Properties.Settings.Default.commonSource.Add(commonText.Text);
                Properties.Settings.Default.botanicalSource.Add(botanicalText.Text);
                Properties.Settings.Default.providerSource.Add(providerText.Text);
                Properties.Settings.Default.partSource.Add(partText.Text);
                Properties.Settings.Default.locationSource.Add(locationText.Text);

                //iterates through the list and replaces empty strings with "N/A"
                //prevents premature termination before reaching the end of the log
                for (int i = 0; i < inputs.Count; i++)
                    if (inputs[i].Equals("")) { inputs[i] = "N/A"; }

                //uses the user's inputs to add to the reference standard log
                add(inputs);

                //updates the "Last Updated" date
                excelWorksheet.get_Range("B1", "B1").Value2 = "Last Updated: " + today.ToString("d");

                //saves the log spreadsheet
                excelWorkBook.Save();

                addSuccessLabel.Text = "Reference added successfully.";

                //clears the entries the user inputted
                foreach (TextBox tb in textBoxes) tb.Text = "";

                //prgress bar fills when process is complete
                progressBar.Value = 100;
            }
        }
        
        //clears "Results not found" text when starting a new search
        private void searchStyleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultFailedLabel.Text = "";
        }

        //clears "Results not found" text when starting a new search
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            resultFailedLabel.Text = "";
            removeSuccessLabel.Text = "";
            editSuccessLabel.Text = "";
        }

        //runs when the user selects an entry from the ListView box
        private void resultListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sets selected as the highlighted entry
            if (resultListView.SelectedItems.Count > 0) { selected = resultListView.SelectedItems[0]; }
        }

        //runs when the user clicks the Edit button
        private void editButton_Click(object sender, EventArgs e)
        {
            //only runs code if an item is selected, otherwise do nothing
            if (selected != null)
            {
                //creates a new instance of EditPopUp (see Form3 for details)
                EditPopUp editWindow = new EditPopUp();

                //fills the text boxes in the popup window with the entry's values (see Form3 for details)
                editWindow.fillEntries(selected);

                DialogResult dialogresult = editWindow.ShowDialog();

                //if the user presses the OK button in the popup
                if (dialogresult == DialogResult.OK)
                {
                    progressBar.Value = 0;
                    List<String> edits = editWindow.getEdits();

                    //finds the row number of the reference standard being edited
                    int replaceRow = rowIndices[selected];

                    //checks if any of the new entries are blank, if so, replace them with "N/A" before replacing entry
                    for (int i = 0; i < edits.Count; i++)
                    {
                        if (edits[i] == "") { edits[i] = "N/A"; }

                        excelWorksheet.Cells[replaceRow, i + 1].Value = edits[i];
                    }

                    //updates the "Last Updated" date
                    excelWorksheet.get_Range("B1", "B1").Value2 = "Last Updated: " + today.ToString("d");

		            //saves the Excel Workbook
                    excelWorkBook.Save();

                    editSuccessLabel.Text = "Reference edited successfully.";
                    progressBar.Value = 100;
                }

                //closes the "Edit Reference" popup
                editWindow.Dispose();
            }
        }

        //runs when the user clicks the Remove button
        private void removeButton_Click(object sender, EventArgs e)
        {
            //only runs code if an entry is highlighted, otherwise do nothing
            if (selected != null)
            {
                //creates new instance of RemovePopup (see Form2 for details)
                RemovePopUp removeWindow = new RemovePopUp();

                DialogResult dialogresult = removeWindow.ShowDialog();

                //runs when the user clicks the OK button in the popup
                if (dialogresult == DialogResult.OK)
                {
                    progressBar.Value = 0;

                    //removes the item from the results view
                    resultListView.Items.Remove(selected);

                    //finds the row of the reference standard being removed
                    Excel.Range replaceRow = excelWorksheet.Cells.Find(selected.SubItems[0].Text, excelWorksheet.Cells[2, 1], 
                                Type.Missing, Excel.XlLookAt.xlWhole, Excel.XlSearchOrder.xlByColumns).EntireRow;
                    
                    //removes the reference standard from the log and shifts the lower entries up
                    replaceRow.Delete(Excel.XlDirection.xlUp);

		            //updates the "Last Updated" date
                    excelWorksheet.get_Range("B1", "B1").Value2 = "Last Updated: " + today.ToString("d");

                    //saves the Excel Workbook
                    excelWorkBook.Save();

                    //decrements the last row pointer
                    Properties.Settings.Default.lastRow -= 1;

                    removeSuccessLabel.Text = "Reference removed successfully.";
                    progressBar.Value = 100;
                }

                //closes the "Remove Reference" popup
                removeWindow.Dispose();
            }
        }

        //runs when the user clicks the Close button
        private void closeButton_Click(object sender, EventArgs e)
        {
            //creates new instance of RemovePopup (see Form2 for details)
            ClosePopUp closeWindow = new ClosePopUp();

            DialogResult dialogresult = closeWindow.ShowDialog();

            if (dialogresult == DialogResult.OK)
            {
                //closes the log WorkBook
                excelWorkBook.Close();

                //removes EXCEL.EXE from the list of running processes
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkBook);

                //closes the application
                Close();
            }
        }
    }
}