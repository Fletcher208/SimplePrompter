using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SimplePrompter
{
    public partial class MainMenu : Form
    {
        public StepInfo stepInfo;

        public MainMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Directorylbl.Text = Directory.GetCurrentDirectory();
            PopulateFileList();
        }

        private void PopulateFileList()
        {
            foreach (string file in Directory.GetFiles(".", "*.txt"))
            {
                fileListBox.Items.Add(file);
            }
        }

        private void StartPrompterBtn_Click(object sender, EventArgs e)
        {
            if (fileListBox.SelectedItem != null)
            {
                string selectedFilePath = fileListBox.SelectedItem.ToString();
                stepInfo = new StepInfo
                {
                    fileName = Path.GetFileNameWithoutExtension(selectedFilePath),
                    step = ExtractSteps(selectedFilePath)
                };
                ShowCurrentStep();
            }
        }

        private void ShowCurrentStep()
        {
            StepForm stepForm = new StepForm(stepInfo);
            stepForm.Show();
        }

        private List<Step> ExtractSteps(string filePath)
        {
            var lines = File.ReadAllLines(filePath).ToList();
            var steps = new List<Step>();
            

            for (int i = 0; i < lines.Count; i++)
            {
                if (IsTitleLine(lines[i]))
                {
                    var step = new Step
                    {
                        Title = lines[i],
                        Descriptions = new List<SubStep>() // Initialize the list
                    };

                    int j = i + 1;
                    while (j < lines.Count && !IsTitleLine(lines[j]))
                    {
                        step.Descriptions.Add(new SubStep { Description = lines[j].Trim(), IsChecked = false });
                        j++;
                    }

                    steps.Add(step);
                    i = j - 1;
                }
            }

            return steps;
        }


        private bool IsTitleLine(string line)
        {
            var titlePattern = @"^\d+\. .*";
            return Regex.IsMatch(line, titlePattern);
        }

        public StepInfo LoadStepInfo(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<StepInfo>(json);
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (fileListBox.SelectedItem != null)
            {
                string selectedFilePath = fileListBox.SelectedItem.ToString();
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(selectedFilePath);
                string savedFilePath = $".\\Saves\\{fileNameWithoutExtension}";

                if (File.Exists(savedFilePath))
                {
                    stepInfo = LoadStepInfo(savedFilePath);
                    ShowCurrentStep();
                }
                else
                {
                    MessageBox.Show($"The file '{fileNameWithoutExtension}' does not exist in the Saves folder.",
                                    "File Not Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }

        public class StepInfo
        {
            public string fileName { get; set; }
            public DateTime LastAccessed { get; set; }
            public DateTime ExpectedNextAccess { get; set; }
            public List<Step> step { get; set; }
        }

        public class Step
        {
            public string Title { get; set; }
            public List<SubStep> Descriptions { get; set; } = new List<SubStep>();
            public bool check
            {
                get
                {
                    return Descriptions.All(d => d.IsChecked); // Returns true if all SubSteps are checked
                }
            }
        }
        public class SubStep
        {
            public string Description { get; set; }
            public bool IsChecked { get; set; }
        }

        private void calendarBtn_Click(object sender, EventArgs e)
        {
            CalendarForm calendarForm = new CalendarForm();
            calendarForm.Show();
        }
    }
}
