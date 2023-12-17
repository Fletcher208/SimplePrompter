using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static SimplePrompter.MainMenu;

namespace SimplePrompter
{
    public partial class StepForm : Form
    {
        #region Fields
        private int currentStepIndex = 0;
        private readonly StepInfo stepInfo;
        #endregion

        #region Initialization
        public StepForm(StepInfo stepInfoData)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.stepInfo = stepInfoData;
            if(stepInfo.ExpectedNextAccess != DateTime.Parse("1/01/0001 12:00:00 AM")) 
            expectedNextAccessDateTimePicker.Value = stepInfo.ExpectedNextAccess;

            // Assuming you have this ListView defined in your designer. If not, create it programmatically
            subStepListView.View = View.Details;
            subStepListView.CheckBoxes = true;
            subStepListView.FullRowSelect = true;
            subStepListView.GridLines = true;

            subStepListView.Columns.Add("Sub-Step", 300, HorizontalAlignment.Left);
            subStepListView.ItemChecked += subStepListView_ItemChecked;

            expectedNextAccessDateTimePicker.Format = DateTimePickerFormat.Custom;
            expectedNextAccessDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";

            UpdateUI();
        }
        #endregion

        #region Button Click Handlers
        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (currentStepIndex < stepInfo.step.Count - 1)
            {
                currentStepIndex++;
                UpdateUI();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (currentStepIndex > 0)
            {
                currentStepIndex--;
                UpdateUI();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("./SaveStep"))
            {
                Directory.CreateDirectory("./Saves");
            }
            SaveStep(stepInfo, $"./Saves/{stepInfo.fileName}");
        }

        private void summaryBtn_Click(object sender, EventArgs e)
        {
            SummaryForm summary = new SummaryForm(stepInfo);
            summary.Show();
        }
        #endregion

        #region Helper Methods
        private void UpdateUI()
        {
            StepTitle.Text = stepInfo.step[currentStepIndex].Title;
            PopulateStepDetails(stepInfo.step[currentStepIndex]);
            checkBox1.Checked = stepInfo.step[currentStepIndex].check;
        }

        private void PopulateStepDetails(Step currentStep)
        {
            StepTitle.Text = currentStep.Title;
            subStepListView.Items.Clear(); // Clear existing items

            foreach (var subStep in currentStep.Descriptions)
            {
                ListViewItem listItem = new ListViewItem(subStep.Description);
                listItem.Checked = subStep.IsChecked;
                subStepListView.Items.Add(listItem);
            }
        }

        public void SaveStep(StepInfo stepInfo, string filePath)
        {
            stepInfo.LastAccessed = DateTime.Now;
            stepInfo.ExpectedNextAccess = expectedNextAccessDateTimePicker.Value;

            string json = JsonConvert.SerializeObject(stepInfo);
            File.WriteAllText(filePath, json);
        }
        #endregion

        #region Event Handlers
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in subStepListView.Items)
            {
                item.Checked = checkBox1.Checked;
            }

            // If you also want to update the 'IsChecked' property of all SubSteps in the current step:
            foreach (var subStep in stepInfo.step[currentStepIndex].Descriptions)
            {
                subStep.IsChecked = checkBox1.Checked;
            }
        }

        private void subStepListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int index = e.Item.Index;
            stepInfo.step[currentStepIndex].Descriptions[index].IsChecked = e.Item.Checked;
        }
        #endregion
    }
}
