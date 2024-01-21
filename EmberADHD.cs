using System.Diagnostics;
using System.Drawing;
using System.Security.Policy;
using System.Text.Json;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EmberADHD
{
    public partial class EmberADHD : Form
    {

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        ///
        /// Handling the window messages
        ///
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        public EmberADHD()
        {
            InitializeComponent();

            setSecondaryColor(getColorFromJson("secondary"));
            ColorSetting primary = getColorFromJson("primary");
            BackColor = Color.FromArgb(primary.R, primary.G, primary.B);
            ColorSetting fontcolor = getColorFromJson("font");
            ForeColor = Color.FromArgb(fontcolor.R, fontcolor.G, fontcolor.B);
            string jsonString = File.ReadAllText(@"./config/internal_settings.json");

            JObject json = JObject.Parse(jsonString);

            string versiontext = (string)json["version"];
            this.version.Text = versiontext;

            todotab.Visible = true;
            todotab.Enabled = true;
            moneytab.Visible = false;
            moneytab.Enabled = false;
            settingstab.Visible = false;
            settingstab.Enabled = false;
            tasksLayoutPanel.Visible = true;
            tasksLayoutPanel.Enabled = true;
            newTaskTab.Visible = false;
            newTaskTab.Enabled = false;
            newTaskTabButton.Text = "New task";
            activeTaskTabButton.Text = "Active tasks •";
            todotabbutton.Text = "To-Do •";
            moneytabbutton.Text = "Money";
            settingstabbutton.Text = "Settings";

            tasks = LoadTasks();
            DisplayTasks();
        }

        private void EmberADHD_Load(object sender, EventArgs e)
        {

        }
        public class InternalSettings
        {
            public string version { get; set; }
        }

        void exitButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        void minimizeButtonClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void titleClick(object sender, EventArgs e)
        {
            Process.Start("explorer", "https://discord.gg/Srs2x659qQ");
        }

        private void todotabbuttonClick(object sender, EventArgs e)
        {
            todotab.Visible = true;
            todotab.Enabled = true;
            moneytab.Visible = false;
            moneytab.Enabled = false;
            settingstab.Visible = false;
            settingstab.Enabled = false;
            todotabbutton.Text = "To-Do •";
            moneytabbutton.Text = "Money";
            settingstabbutton.Text = "Settings";
        }

        private void moneytabbuttonClick(object sender, EventArgs e)
        {
            todotab.Visible = false;
            todotab.Enabled = false;
            moneytab.Visible = true;
            moneytab.Enabled = true;
            settingstab.Visible = false;
            settingstab.Enabled = false;
            todotabbutton.Text = "To-Do";
            moneytabbutton.Text = "Money •";
            settingstabbutton.Text = "Settings";
        }

        private void settingstabbuttonClick(object sender, EventArgs e)
        {
            todotab.Visible = false;
            todotab.Enabled = false;
            moneytab.Visible = false;
            moneytab.Enabled = false;
            settingstab.Visible = true;
            settingstab.Enabled = true;
            todotabbutton.Text = "To-Do";
            moneytabbutton.Text = "Money";
            settingstabbutton.Text = "Settings •";
        }
        private void colorTextChanged(object sender, EventArgs e)
        {
            // Get the TextBox that triggered the event
            TextBox currentTextBox = (TextBox)sender;

            // Check if the TextBox is not empty
            if (!string.IsNullOrEmpty(currentTextBox.Text))
            {
                // Try to parse the text as an integer
                if (int.TryParse(currentTextBox.Text, out int inputValue))
                {
                    // Check if the value is within the desired range (1-255)
                    if (inputValue >= 0 && inputValue <= 255)
                    {

                    }
                    else
                    {
                        currentTextBox.Text = "255";
                        MessageBox.Show($"Please enter a value between 0 and 255.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    currentTextBox.Text = string.Empty;
                    MessageBox.Show($"Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public class ColorSetting
        {
            public int R;
            public int G;
            public int B;
        }
        public class JsonStructure
        {
            public ColorSetting Primary { get; set; }
            public ColorSetting Secondary { get; set; }
            public ColorSetting Font { get; set; }
        }
        public class TaskContainer
        {
            [JsonProperty("uuid")]
            public string Uuid { get; set; }

            [JsonProperty("Task")]
            public Task Task { get; set; }
        }
        public class Task
        {
            public string Name { get; set; }
            public DateTime DOS { get; set; }
            public DateTime DOE { get; set; }
            public int Weight { get; set; }
            public bool CompletionStatus { get; set; }
        }

        private Dictionary<string, TaskContainer> tasks;

        List<Object> buttons = new List<Object>();

        private Dictionary<string, TaskContainer> LoadTasks()
        {
            string filePath = @"./config/tasks.json";
            string existingJson = File.Exists(filePath) ? File.ReadAllText(filePath) : "{}";
            return JsonConvert.DeserializeObject<Dictionary<string, TaskContainer>>(existingJson) ?? new Dictionary<string, TaskContainer>();
        }

        private void DisplayTasks()
        {
            // Clear existing controls
            tasksLayoutPanel.Controls.Clear();

            // Add controls for each task
            foreach (var taskEntry in tasks)
            {
                TaskContainer taskContainer = taskEntry.Value;

                // Create a label for each property
                Label nameLabel = new Label { Text = "Name: " + taskContainer.Task.Name, Margin = new Padding(0, 2, 0, 0), AutoEllipsis = true, Font = new Font("ShureTechMono NFM", 9F, FontStyle.Regular, GraphicsUnit.Point, 0) };
                Label dosLabel = new Label { Text = "DOS: " + taskContainer.Task.DOS.ToString("dd.MM.yyyy"), Margin = new Padding(0), AutoEllipsis = true, Font = new Font("ShureTechMono NFM", 9F, FontStyle.Regular, GraphicsUnit.Point, 0) };
                Label doeLabel = new Label { Text = "DOE: " + taskContainer.Task.DOE.ToString("dd.MM.yyyy"), Margin = new Padding(0), AutoEllipsis = true, Font = new Font("ShureTechMono NFM", 9F, FontStyle.Regular, GraphicsUnit.Point, 0) };
                Label weightLabel = new Label { Text = "Weight: " + taskContainer.Task.Weight.ToString(), Margin = new Padding(0), AutoEllipsis = true, Font = new Font("ShureTechMono NFM", 9F, FontStyle.Regular, GraphicsUnit.Point, 0) };
                Label completionStatusLabel = new Label { Text = "Complete: " + taskContainer.Task.CompletionStatus.ToString(), Margin = new Padding(0), AutoEllipsis = true, Font = new Font("ShureTechMono NFM", 9F, FontStyle.Regular, GraphicsUnit.Point, 0) };

                // Create buttons for completing and deleting tasks
                Button completeButton = new Button { Tag = taskContainer.Uuid };
                completeButton.Click += CompleteButton_Click;
                completeButton.FlatAppearance.BorderSize = 0;
                completeButton.FlatStyle = FlatStyle.Flat;
                completeButton.Font = new Font("ShureTechMono NFM", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
                completeButton.Size = new Size(78, 33);
                completeButton.Margin = new Padding(0, 0, 1, 0);
                completeButton.Anchor = AnchorStyles.Bottom;
                buttons.Add(completeButton);

                Button deleteButton = new Button { Text = "Delete", Tag = taskContainer.Uuid };
                deleteButton.Click += DeleteButton_Click;
                deleteButton.FlatAppearance.BorderSize = 0;
                deleteButton.FlatStyle = FlatStyle.Flat;
                deleteButton.Font = new Font("ShureTechMono NFM", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
                deleteButton.Size = new Size(78, 33);
                deleteButton.Margin = new Padding(1, 0, 0, 0);
                deleteButton.Anchor = AnchorStyles.Bottom;
                buttons.Add(deleteButton);

                // Create a panel to hold the labels and buttons
                FlowLayoutPanel taskPanel = new FlowLayoutPanel();
                taskPanel.Controls.AddRange(new Control[] { nameLabel, dosLabel, doeLabel, weightLabel, completionStatusLabel, completeButton, deleteButton });
                taskPanel.Size = new Size(160, 152);
                taskPanel.BorderStyle = BorderStyle.FixedSingle;
                ColorSetting fontcolor = getColorFromJson("font");
                deleteButton.ForeColor = Color.FromArgb(fontcolor.R, fontcolor.G, fontcolor.B);
                completeButton.ForeColor = Color.FromArgb(fontcolor.R, fontcolor.G, fontcolor.B);
                if (taskContainer.Task.CompletionStatus != null && taskContainer.Task.CompletionStatus)
                {
                    completeButton.Text = "Uncomplete";
                    taskPanel.ForeColor = Color.FromArgb(0, 255, 0);
                }
                else
                {
                    completeButton.Text = "Complete";
                    taskPanel.ForeColor = Color.FromArgb(fontcolor.R, fontcolor.G, fontcolor.B);
                }

                // Add the panel to the main flow layout panel
                tasksLayoutPanel.Controls.Add(taskPanel);
            }

            // Enable horizontal scrolling for the todotab
            tasksLayoutPanel.AutoScroll = true;
            tasksLayoutPanel.VerticalScroll.Enabled = true;
            setSecondaryColor(getColorFromJson("secondary"));
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            // Add a new task (similar to your previous button1_Click method)
            TaskContainer taskContainer = new TaskContainer
            {
                Uuid = Guid.NewGuid().ToString(),
                Task = new Task
                {
                    Name = taskName.Text,
                    DOS = dosTask.Value,
                    DOE = doeTask.Value,
                    Weight = ((int)weightTask.Value),
                    CompletionStatus = false
                }
            };

            tasks.Add(taskContainer.Uuid, taskContainer);
            SaveTasks();
            DisplayTasks();
        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string taskId = button.Tag.ToString();

            // Update the completion status of the task
            if (tasks.ContainsKey(taskId))
            {
                if (tasks[taskId] != null && tasks[taskId].Task.CompletionStatus)
                {
                    tasks[taskId].Task.CompletionStatus = false;
                }
                else
                {
                    tasks[taskId].Task.CompletionStatus = true;
                }

                SaveTasks();
                DisplayTasks();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string taskId = button.Tag.ToString();

            // Remove the task from the dictionary
            if (tasks.ContainsKey(taskId))
            {
                tasks.Remove(taskId);
                SaveTasks();
                DisplayTasks();
            }
        }

        private void SaveTasks()
        {
            string filePath = @"./config/tasks.json";
            string updatedJson = JsonConvert.SerializeObject(tasks, Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);
        }

        private void changebackgroundcolorbutton_Click(object sender, EventArgs e)
        {

            ColorSetting primarycolor = getPrimaryColor();
            BackColor = Color.FromArgb(primarycolor.R, primarycolor.G, primarycolor.B);

            string jsonString = File.ReadAllText(@"./config/settings.json");
            JsonStructure colors = JsonConvert.DeserializeObject<JsonStructure>(jsonString);

            colors.Primary = getPrimaryColor();

            string updatedJson = JsonConvert.SerializeObject(colors, Formatting.Indented);

            File.WriteAllText(@"./config/settings.json", updatedJson);
        }

        private void changefontcolorbutton_Click(object sender, EventArgs e)
        {
            ColorSetting fontcolor = getFontColor();
            ForeColor = Color.FromArgb(fontcolor.R, fontcolor.G, fontcolor.B);

            string jsonString = File.ReadAllText(@"./config/settings.json");
            JsonStructure colors = JsonConvert.DeserializeObject<JsonStructure>(jsonString);

            colors.Font = getFontColor();

            string updatedJson = JsonConvert.SerializeObject(colors, Formatting.Indented);

            File.WriteAllText(@"./config/settings.json", updatedJson);
        }

        private void secondarycolorbutton_Click(object sender, EventArgs e)
        {
            ColorSetting secondary = getSecondaryColor();
            setSecondaryColor(secondary);
            string jsonString = File.ReadAllText(@"./config/settings.json");
            JsonStructure colors = JsonConvert.DeserializeObject<JsonStructure>(jsonString);

            colors.Secondary = secondary;

            string updatedJson = JsonConvert.SerializeObject(colors, Formatting.Indented);

            File.WriteAllText(@"./config/settings.json", updatedJson);
        }
        private void setSecondaryColor(ColorSetting color)
        {
            exit.BackColor = Color.FromArgb(color.R, color.G, color.B);
            minimize.BackColor = Color.FromArgb(color.R, color.G, color.B);
            bluefontcolor.BackColor = Color.FromArgb(color.R, color.G, color.B);
            greenfontcolor.BackColor = Color.FromArgb(color.R, color.G, color.B);
            redfontcolor.BackColor = Color.FromArgb(color.R, color.G, color.B);
            redbackgroundcolor.BackColor = Color.FromArgb(color.R, color.G, color.B);
            greenbackgroundcolor.BackColor = Color.FromArgb(color.R, color.G, color.B);
            bluebackgroundcolor.BackColor = Color.FromArgb(color.R, color.G, color.B);
            redsecondarycolor.BackColor = Color.FromArgb(color.R, color.G, color.B);
            greensecondarycolor.BackColor = Color.FromArgb(color.R, color.G, color.B);
            bluesecondarycolor.BackColor = Color.FromArgb(color.R, color.G, color.B);
            taskName.BackColor = Color.FromArgb(color.R, color.G, color.B);
            weightTask.BackColor = Color.FromArgb(color.R, color.G, color.B);
            dosTask.CalendarTitleBackColor = Color.FromArgb(color.R, color.G, color.B);
            dosTask.CalendarMonthBackground = Color.FromArgb(color.R, color.G, color.B);
            doeTask.CalendarMonthBackground = Color.FromArgb(color.R, color.G, color.B);
            doeTask.CalendarTitleBackColor = Color.FromArgb(color.R, color.G, color.B);
            foreach (Button button in buttons)
            {
                button.BackColor = Color.FromArgb(color.R, color.G, color.B);
            }
        }
        public static ColorSetting getColorFromJson(string color)
        {
            string jsonString = File.ReadAllText(@"./config/settings.json");
            JsonStructure colors = JsonConvert.DeserializeObject<JsonStructure>(jsonString);

            switch (color.ToLower())
            {
                case "primary":
                    return colors.Primary;
                case "secondary":
                    return colors.Secondary;
                case "font":
                    return colors.Font;
                default:
                    throw new ArgumentException("Invalid color parameter");
            }
        }
        public ColorSetting getSecondaryColor()
        {
            ColorSetting color = new ColorSetting
            {
                R = int.Parse(redsecondarycolor.Text),
                G = int.Parse(greensecondarycolor.Text),
                B = int.Parse(bluesecondarycolor.Text)
            };
            return color;
        }
        public ColorSetting getPrimaryColor()
        {
            ColorSetting color = new ColorSetting
            {
                R = int.Parse(redbackgroundcolor.Text),
                G = int.Parse(greenbackgroundcolor.Text),
                B = int.Parse(bluebackgroundcolor.Text)
            };
            return color;
        }
        public ColorSetting getFontColor()
        {
            ColorSetting color = new ColorSetting
            {
                R = int.Parse(redfontcolor.Text),
                G = int.Parse(greenfontcolor.Text),
                B = int.Parse(bluefontcolor.Text)
            };
            return color;
        }

        private void weightTask_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(weightTask.Text))
            {
                // Try to parse the text as an integer
                if (int.TryParse(weightTask.Text, out int inputValue))
                {
                    // Check if the value is within the desired range (1-255)
                    if (inputValue >= 0 && inputValue <= 9)
                    {

                    }
                    else
                    {
                        weightTask.Value = 1;
                        MessageBox.Show($"Please enter a value between 0 and 9.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    weightTask.Text = string.Empty;
                    MessageBox.Show($"Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void activeTaskTabButton_Click(object sender, EventArgs e)
        {
            tasksLayoutPanel.Visible = true;
            tasksLayoutPanel.Enabled = true;
            newTaskTab.Visible = false;
            newTaskTab.Enabled = false;
            newTaskTabButton.Text = "New task";
            activeTaskTabButton.Text = "Active tasks •";
        }

        private void newTaskTabButton_Click(object sender, EventArgs e)
        {
            tasksLayoutPanel.Visible = false;
            tasksLayoutPanel.Enabled = false;
            newTaskTab.Visible = true;
            newTaskTab.Enabled = true;
            newTaskTabButton.Text = "New task •";
            activeTaskTabButton.Text = "Active tasks";
        }
    }


    //TO-DO: sort and seperate tasks based on weight and completionstate
    //TO-DO: repair font setting
    //TO-DO: add refresh button in active tasks
    //TO-DO: change newtonsoft.json to system.text.json
}
