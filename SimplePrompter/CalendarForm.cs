using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SimplePrompter.MainMenu;

namespace SimplePrompter
{
    public partial class CalendarForm : Form
    {
        public CalendarForm()
        {
            InitializeComponent();
            LoadAndHighlightDates();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private List<StepInfo> allSavedStepInfos = new List<StepInfo>();

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start; // Get the selected date
            PopulateHourlyTimestamps(selectedDate);
        }

        private void LoadAndHighlightDates()
        {

            foreach (string file in Directory.GetFiles(".\\Saves", "*"))
            {
                StepInfo stepInfo = LoadStepInfo(file);
                allSavedStepInfos.Add(stepInfo);

                if (stepInfo.LastAccessed != default(DateTime))
                    monthCalendar1.AddBoldedDate(stepInfo.LastAccessed);

                if (stepInfo.ExpectedNextAccess != default(DateTime))
                    monthCalendar1.AddBoldedDate(stepInfo.ExpectedNextAccess);
            }

            monthCalendar1.UpdateBoldedDates();
        }

        private StepInfo LoadStepInfo(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<StepInfo>(json);
        }

        private void PopulateHourlyTimestamps(DateTime selectedDate)
        {
            listBox1.Items.Clear(); // Clear any existing items

            Dictionary<DateTime, List<string>> lastAccessedFiles = new Dictionary<DateTime, List<string>>();
            Dictionary<DateTime, List<string>> expectedAccessFiles = new Dictionary<DateTime, List<string>>();

            // Initialize the dictionaries with hourly timeslots
            for (int hour = 0; hour < 24; hour++)
            {
                DateTime timestamp = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, hour, 0, 0);
                lastAccessedFiles[timestamp] = new List<string>();
                expectedAccessFiles[timestamp] = new List<string>();
            }

            // Populate the dictionaries based on stepInfo data
            foreach (var stepInfo in allSavedStepInfos)
            {
                if (stepInfo.LastAccessed.Date == selectedDate.Date)
                {
                    DateTime hourTimestamp = new DateTime(stepInfo.LastAccessed.Year, stepInfo.LastAccessed.Month, stepInfo.LastAccessed.Day, stepInfo.LastAccessed.Hour, 0, 0);
                    lastAccessedFiles[hourTimestamp].Add(stepInfo.fileName);
                }

                if (stepInfo.ExpectedNextAccess.Date == selectedDate.Date)
                {
                    DateTime hourTimestamp = new DateTime(stepInfo.ExpectedNextAccess.Year, stepInfo.ExpectedNextAccess.Month, stepInfo.ExpectedNextAccess.Day, stepInfo.ExpectedNextAccess.Hour, 0, 0);
                    expectedAccessFiles[hourTimestamp].Add(stepInfo.fileName);
                }
            }

            // Populate the listBox1 based on the dictionaries
            foreach (var timestamp in lastAccessedFiles.Keys)
            {
                StringBuilder sb = new StringBuilder($"{timestamp.ToString("HH:mm")}");

                if (lastAccessedFiles[timestamp].Any())
                {
                    sb.Append($" - Last Accessed: {string.Join(", ", lastAccessedFiles[timestamp])}");
                }

                if (expectedAccessFiles[timestamp].Any())
                {
                    sb.Append($" - Expected: {string.Join(", ", expectedAccessFiles[timestamp])}");
                }

                listBox1.Items.Add(sb.ToString());
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
