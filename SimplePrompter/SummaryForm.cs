using System;
using System.Windows.Forms;
using static SimplePrompter.MainMenu;

namespace SimplePrompter
{
    public partial class SummaryForm : Form
    {
        public SummaryForm(StepInfo stepInfo)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            PopulateSummaryListView(stepInfo);
        }

        private void PopulateSummaryListView(StepInfo stepInfo)
        {
            foreach (var step in stepInfo.step)
            {
                var listItem = new ListViewItem(step.Title);
                listItem.SubItems.Add(step.check ? "Checked" : "Not Checked");
                summaryListView.Items.Add(listItem);
            }
        }
    }
}
