using Queens_University.BLL;
using Queens_University.Models;
using Queens_University.ValidateInput;
using System;
using System.Windows.Forms;

namespace Queens_University
{
    public partial class Form1 : Form
    {
        StdentBLL objStdentBLL = new StdentBLL();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load Saved Data in DB to Grid View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = objStdentBLL.GetAllStudentsDetails();
            }
            catch
            {
                MessageBox.Show(Constants.ERRPR_OCCURED);
            }
        }

        /// <summary>
        /// Set Visible Student Details Entry From 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        /// <summary>
        /// Add new Entry to Grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            ValidateInputTextField objValidateInputTextField = new ValidateInputTextField();
            if (objValidateInputTextField.IsValidInput(txtbxName.Text) && objValidateInputTextField.IsValidInput(txtbxAverage.Text))
            {
                Student objStudent = new Student();
                objStudent.Name = txtbxName.Text;
                objStudent.DateOfBirth = DateTime.Parse(dtPicDOB.Text);
                objStudent.Average = double.Parse(txtbxAverage.Text);
                objStudent.IsActive = chkbxIsActive.Checked;

                objStdentBLL.AddNewStudent(objStudent);
                this.dataGridView1.DataSource = objStdentBLL.UpdateGridView();
                ClearDataEntryPanel();
            }
            else
                MessageBox.Show(Constants.FILL_ALL_FIELDS);

        }

        /// <summary>
        /// Clear the Stdent Entry From --> Set All Fields to default values
        /// </summary>
        private void ClearDataEntryPanel()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    if (control is CheckBox)
                        (control as CheckBox).Checked = true;
                    if (control is DateTimePicker)
                        (control as DateTimePicker).Value = DateTime.Now.Date;
                  
                    else
                        func(control.Controls);
                }
            };

            func(Controls);
        }

        /// <summary>
        /// Save All Newly added Entries to DB 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool IsSuccess = objStdentBLL.UpdateDatabase();

            if (IsSuccess)
                MessageBox.Show(Constants.SUCCESS);
             else
                MessageBox.Show(Constants.ERRPR_OCCURED);
        }

        /// <summary>
        /// Work as the Exsit button of the menu
        /// Exit From the Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Call Numeric Validator After each key stroke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbxAverage_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericInputValidation objNumericInputValidation = new NumericInputValidation();
            objNumericInputValidation.IsValidNmericInput(sender,e);
        }

        /// <summary>
        /// Clear the Entry From 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearDataEntryPanel();
        }

       
    }
}
