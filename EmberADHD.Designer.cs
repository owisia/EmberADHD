namespace EmberADHD
{
    partial class EmberADHD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            exit = new Button();
            minimize = new Button();
            title = new Label();
            version = new Label();
            todotab = new Panel();
            activeTaskTabButton = new Button();
            newTaskTabButton = new Button();
            newTaskTab = new Panel();
            button1 = new Button();
            doeTask = new DateTimePicker();
            weightTask = new NumericUpDown();
            dosTask = new DateTimePicker();
            taskName = new TextBox();
            weightTaskLabel = new Label();
            doeTaskLabel = new Label();
            dosTaskLabel = new Label();
            taskNameLabel = new Label();
            tasksLayoutPanel = new FlowLayoutPanel();
            todotabbutton = new Button();
            moneytabbutton = new Button();
            settingstabbutton = new Button();
            moneytab = new Panel();
            moneylabel = new Label();
            settingstab = new Panel();
            secondarycolorbutton = new Button();
            bluesecondarycolortext = new Label();
            greensecondarycolortext = new Label();
            redsecondarycolortext = new Label();
            bluesecondarycolor = new TextBox();
            greensecondarycolor = new TextBox();
            redsecondarycolor = new TextBox();
            secondarycolortext = new Label();
            changefontcolorbutton = new Button();
            changebackgroundcolorbutton = new Button();
            bluefontcolortext = new Label();
            greenfontcolortext = new Label();
            redfontcolortext = new Label();
            bluefontcolor = new TextBox();
            greenfontcolor = new TextBox();
            redfontcolor = new TextBox();
            fontcolortext = new Label();
            bluebackgroundcolortext = new Label();
            greenbackgroundcolortext = new Label();
            redbackgroundcolortext = new Label();
            bluebackgroundcolor = new TextBox();
            greenbackgroundcolor = new TextBox();
            redbackgroundcolor = new TextBox();
            backgroundcolortext = new Label();
            todotab.SuspendLayout();
            newTaskTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weightTask).BeginInit();
            moneytab.SuspendLayout();
            settingstab.SuspendLayout();
            SuspendLayout();
            // 
            // exit
            // 
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            exit.ForeColor = SystemColors.Window;
            exit.Location = new Point(656, 9);
            exit.Margin = new Padding(0);
            exit.Name = "exit";
            exit.RightToLeft = RightToLeft.No;
            exit.Size = new Size(25, 25);
            exit.TabIndex = 1;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exitButtonClick;
            // 
            // minimize
            // 
            minimize.FlatAppearance.BorderSize = 0;
            minimize.FlatStyle = FlatStyle.Flat;
            minimize.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            minimize.ForeColor = SystemColors.Window;
            minimize.Location = new Point(620, 9);
            minimize.Margin = new Padding(0);
            minimize.Name = "minimize";
            minimize.RightToLeft = RightToLeft.No;
            minimize.Size = new Size(25, 25);
            minimize.TabIndex = 2;
            minimize.Text = "_";
            minimize.UseVisualStyleBackColor = false;
            minimize.Click += minimizeButtonClick;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(11, 11);
            title.Name = "title";
            title.Size = new Size(80, 17);
            title.TabIndex = 3;
            title.Text = "EmberADHD";
            title.Click += titleClick;
            // 
            // version
            // 
            version.AutoSize = true;
            version.Location = new Point(88, 11);
            version.Name = "version";
            version.Size = new Size(64, 17);
            version.TabIndex = 4;
            version.Text = "version";
            // 
            // todotab
            // 
            todotab.Controls.Add(activeTaskTabButton);
            todotab.Controls.Add(newTaskTabButton);
            todotab.Controls.Add(newTaskTab);
            todotab.Controls.Add(tasksLayoutPanel);
            todotab.Location = new Point(0, 72);
            todotab.Name = "todotab";
            todotab.Size = new Size(690, 303);
            todotab.TabIndex = 5;
            // 
            // activeTaskTabButton
            // 
            activeTaskTabButton.FlatAppearance.BorderSize = 0;
            activeTaskTabButton.FlatStyle = FlatStyle.Flat;
            activeTaskTabButton.ForeColor = SystemColors.Window;
            activeTaskTabButton.Location = new Point(0, 0);
            activeTaskTabButton.Name = "activeTaskTabButton";
            activeTaskTabButton.Size = new Size(345, 33);
            activeTaskTabButton.TabIndex = 8;
            activeTaskTabButton.Text = "Tasks";
            activeTaskTabButton.UseVisualStyleBackColor = true;
            activeTaskTabButton.Click += activeTaskTabButton_Click;
            // 
            // newTaskTabButton
            // 
            newTaskTabButton.FlatAppearance.BorderSize = 0;
            newTaskTabButton.FlatStyle = FlatStyle.Flat;
            newTaskTabButton.ForeColor = SystemColors.Window;
            newTaskTabButton.Location = new Point(345, 0);
            newTaskTabButton.Name = "newTaskTabButton";
            newTaskTabButton.Size = new Size(345, 33);
            newTaskTabButton.TabIndex = 10;
            newTaskTabButton.Text = "New task";
            newTaskTabButton.UseVisualStyleBackColor = true;
            newTaskTabButton.Click += newTaskTabButton_Click;
            // 
            // newTaskTab
            // 
            newTaskTab.Controls.Add(button1);
            newTaskTab.Controls.Add(doeTask);
            newTaskTab.Controls.Add(weightTask);
            newTaskTab.Controls.Add(dosTask);
            newTaskTab.Controls.Add(taskName);
            newTaskTab.Controls.Add(weightTaskLabel);
            newTaskTab.Controls.Add(doeTaskLabel);
            newTaskTab.Controls.Add(dosTaskLabel);
            newTaskTab.Controls.Add(taskNameLabel);
            newTaskTab.ForeColor = SystemColors.Window;
            newTaskTab.Location = new Point(0, 33);
            newTaskTab.Name = "newTaskTab";
            newTaskTab.Size = new Size(690, 270);
            newTaskTab.TabIndex = 11;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(531, 233);
            button1.Name = "button1";
            button1.Size = new Size(150, 25);
            button1.TabIndex = 11;
            button1.Text = "Create new task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonAddTask_Click;
            // 
            // doeTask
            // 
            doeTask.CalendarForeColor = SystemColors.Window;
            doeTask.CalendarTitleBackColor = SystemColors.Window;
            doeTask.CalendarTitleForeColor = SystemColors.Window;
            doeTask.CalendarTrailingForeColor = SystemColors.Window;
            doeTask.Font = new Font("ShureTechMono NFM", 7.75F);
            doeTask.Location = new Point(479, 59);
            doeTask.Margin = new Padding(0);
            doeTask.Name = "doeTask";
            doeTask.Size = new Size(200, 19);
            doeTask.TabIndex = 8;
            doeTask.Value = new DateTime(2001, 9, 11, 0, 0, 0, 0);
            // 
            // weightTask
            // 
            weightTask.BorderStyle = BorderStyle.None;
            weightTask.Font = new Font("Microsoft Sans Serif", 10F);
            weightTask.ForeColor = SystemColors.Window;
            weightTask.Location = new Point(650, 86);
            weightTask.Name = "weightTask";
            weightTask.Size = new Size(29, 19);
            weightTask.TabIndex = 7;
            weightTask.ValueChanged += weightTask_ValueChanged;
            // 
            // dosTask
            // 
            dosTask.CalendarForeColor = SystemColors.Window;
            dosTask.CalendarTitleBackColor = SystemColors.Window;
            dosTask.CalendarTitleForeColor = SystemColors.Window;
            dosTask.CalendarTrailingForeColor = SystemColors.Window;
            dosTask.Font = new Font("ShureTechMono NFM", 7.75F);
            dosTask.Location = new Point(479, 34);
            dosTask.Margin = new Padding(0);
            dosTask.Name = "dosTask";
            dosTask.Size = new Size(200, 19);
            dosTask.TabIndex = 5;
            dosTask.Value = new DateTime(1939, 9, 1, 0, 0, 0, 0);
            // 
            // taskName
            // 
            taskName.BackColor = Color.FromArgb(45, 45, 45);
            taskName.BorderStyle = BorderStyle.None;
            taskName.Font = new Font("ShureTechMono NFM", 12F);
            taskName.ForeColor = SystemColors.Window;
            taskName.Location = new Point(578, 9);
            taskName.Name = "taskName";
            taskName.Size = new Size(100, 19);
            taskName.TabIndex = 4;
            // 
            // weightTaskLabel
            // 
            weightTaskLabel.AutoSize = true;
            weightTaskLabel.Location = new Point(12, 85);
            weightTaskLabel.Name = "weightTaskLabel";
            weightTaskLabel.Size = new Size(64, 17);
            weightTaskLabel.TabIndex = 3;
            weightTaskLabel.Text = "Weight:";
            // 
            // doeTaskLabel
            // 
            doeTaskLabel.AutoSize = true;
            doeTaskLabel.Location = new Point(11, 61);
            doeTaskLabel.Name = "doeTaskLabel";
            doeTaskLabel.Size = new Size(104, 17);
            doeTaskLabel.TabIndex = 2;
            doeTaskLabel.Text = "Date of End:";
            // 
            // dosTaskLabel
            // 
            dosTaskLabel.AutoSize = true;
            dosTaskLabel.Location = new Point(11, 36);
            dosTaskLabel.Name = "dosTaskLabel";
            dosTaskLabel.Size = new Size(120, 17);
            dosTaskLabel.TabIndex = 1;
            dosTaskLabel.Text = "Date of Start:";
            // 
            // taskNameLabel
            // 
            taskNameLabel.AutoSize = true;
            taskNameLabel.Location = new Point(11, 11);
            taskNameLabel.Name = "taskNameLabel";
            taskNameLabel.Size = new Size(88, 17);
            taskNameLabel.TabIndex = 0;
            taskNameLabel.Text = "Task name:";
            // 
            // tasksLayoutPanel
            // 
            tasksLayoutPanel.Location = new Point(0, 33);
            tasksLayoutPanel.Margin = new Padding(0);
            tasksLayoutPanel.Name = "tasksLayoutPanel";
            tasksLayoutPanel.Size = new Size(690, 270);
            tasksLayoutPanel.TabIndex = 0;
            // 
            // todotabbutton
            // 
            todotabbutton.FlatAppearance.BorderSize = 0;
            todotabbutton.FlatStyle = FlatStyle.Flat;
            todotabbutton.ForeColor = SystemColors.Window;
            todotabbutton.Location = new Point(0, 39);
            todotabbutton.Name = "todotabbutton";
            todotabbutton.Size = new Size(230, 33);
            todotabbutton.TabIndex = 6;
            todotabbutton.Text = "To-Do";
            todotabbutton.UseVisualStyleBackColor = true;
            todotabbutton.Click += todotabbuttonClick;
            // 
            // moneytabbutton
            // 
            moneytabbutton.FlatAppearance.BorderSize = 0;
            moneytabbutton.FlatStyle = FlatStyle.Flat;
            moneytabbutton.ForeColor = SystemColors.Window;
            moneytabbutton.Location = new Point(230, 39);
            moneytabbutton.Name = "moneytabbutton";
            moneytabbutton.Size = new Size(230, 33);
            moneytabbutton.TabIndex = 7;
            moneytabbutton.Text = "Money";
            moneytabbutton.UseVisualStyleBackColor = true;
            moneytabbutton.Click += moneytabbuttonClick;
            // 
            // settingstabbutton
            // 
            settingstabbutton.FlatAppearance.BorderSize = 0;
            settingstabbutton.FlatStyle = FlatStyle.Flat;
            settingstabbutton.ForeColor = SystemColors.Window;
            settingstabbutton.Location = new Point(460, 39);
            settingstabbutton.Name = "settingstabbutton";
            settingstabbutton.Size = new Size(230, 33);
            settingstabbutton.TabIndex = 8;
            settingstabbutton.Text = "Settings";
            settingstabbutton.UseVisualStyleBackColor = true;
            settingstabbutton.Click += settingstabbuttonClick;
            // 
            // moneytab
            // 
            moneytab.Controls.Add(moneylabel);
            moneytab.Location = new Point(0, 72);
            moneytab.Name = "moneytab";
            moneytab.Size = new Size(690, 303);
            moneytab.TabIndex = 9;
            // 
            // moneylabel
            // 
            moneylabel.AutoSize = true;
            moneylabel.Location = new Point(11, 14);
            moneylabel.Name = "moneylabel";
            moneylabel.Size = new Size(256, 17);
            moneylabel.TabIndex = 2;
            moneylabel.Text = "Money tab is currently in work!";
            // 
            // settingstab
            // 
            settingstab.Controls.Add(secondarycolorbutton);
            settingstab.Controls.Add(bluesecondarycolortext);
            settingstab.Controls.Add(greensecondarycolortext);
            settingstab.Controls.Add(redsecondarycolortext);
            settingstab.Controls.Add(bluesecondarycolor);
            settingstab.Controls.Add(greensecondarycolor);
            settingstab.Controls.Add(redsecondarycolor);
            settingstab.Controls.Add(secondarycolortext);
            settingstab.Controls.Add(changefontcolorbutton);
            settingstab.Controls.Add(changebackgroundcolorbutton);
            settingstab.Controls.Add(bluefontcolortext);
            settingstab.Controls.Add(greenfontcolortext);
            settingstab.Controls.Add(redfontcolortext);
            settingstab.Controls.Add(bluefontcolor);
            settingstab.Controls.Add(greenfontcolor);
            settingstab.Controls.Add(redfontcolor);
            settingstab.Controls.Add(fontcolortext);
            settingstab.Controls.Add(bluebackgroundcolortext);
            settingstab.Controls.Add(greenbackgroundcolortext);
            settingstab.Controls.Add(redbackgroundcolortext);
            settingstab.Controls.Add(bluebackgroundcolor);
            settingstab.Controls.Add(greenbackgroundcolor);
            settingstab.Controls.Add(redbackgroundcolor);
            settingstab.Controls.Add(backgroundcolortext);
            settingstab.Location = new Point(0, 72);
            settingstab.Name = "settingstab";
            settingstab.Size = new Size(690, 303);
            settingstab.TabIndex = 10;
            // 
            // secondarycolorbutton
            // 
            secondarycolorbutton.FlatAppearance.BorderSize = 0;
            secondarycolorbutton.FlatStyle = FlatStyle.Flat;
            secondarycolorbutton.Font = new Font("ShureTechMono NFM", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondarycolorbutton.ForeColor = SystemColors.Window;
            secondarycolorbutton.Location = new Point(620, 34);
            secondarycolorbutton.Name = "secondarycolorbutton";
            secondarycolorbutton.Size = new Size(58, 18);
            secondarycolorbutton.TabIndex = 23;
            secondarycolorbutton.Text = "Apply";
            secondarycolorbutton.UseVisualStyleBackColor = true;
            secondarycolorbutton.Click += secondarycolorbutton_Click;
            // 
            // bluesecondarycolortext
            // 
            bluesecondarycolortext.AutoSize = true;
            bluesecondarycolortext.Location = new Point(539, 34);
            bluesecondarycolortext.Name = "bluesecondarycolortext";
            bluesecondarycolortext.Size = new Size(24, 17);
            bluesecondarycolortext.TabIndex = 22;
            bluesecondarycolortext.Text = "B:";
            // 
            // greensecondarycolortext
            // 
            greensecondarycolortext.AutoSize = true;
            greensecondarycolortext.Location = new Point(468, 34);
            greensecondarycolortext.Name = "greensecondarycolortext";
            greensecondarycolortext.Size = new Size(24, 17);
            greensecondarycolortext.TabIndex = 21;
            greensecondarycolortext.Text = "G:";
            // 
            // redsecondarycolortext
            // 
            redsecondarycolortext.AutoSize = true;
            redsecondarycolortext.Location = new Point(395, 34);
            redsecondarycolortext.Name = "redsecondarycolortext";
            redsecondarycolortext.Size = new Size(24, 17);
            redsecondarycolortext.TabIndex = 20;
            redsecondarycolortext.Text = "R:";
            // 
            // bluesecondarycolor
            // 
            bluesecondarycolor.BorderStyle = BorderStyle.None;
            bluesecondarycolor.Location = new Point(569, 34);
            bluesecondarycolor.MaxLength = 3;
            bluesecondarycolor.Name = "bluesecondarycolor";
            bluesecondarycolor.Size = new Size(35, 17);
            bluesecondarycolor.TabIndex = 19;
            bluesecondarycolor.TextChanged += colorTextChanged;
            // 
            // greensecondarycolor
            // 
            greensecondarycolor.BorderStyle = BorderStyle.None;
            greensecondarycolor.Location = new Point(498, 34);
            greensecondarycolor.MaxLength = 3;
            greensecondarycolor.Name = "greensecondarycolor";
            greensecondarycolor.Size = new Size(35, 17);
            greensecondarycolor.TabIndex = 18;
            greensecondarycolor.TextChanged += colorTextChanged;
            // 
            // redsecondarycolor
            // 
            redsecondarycolor.BorderStyle = BorderStyle.None;
            redsecondarycolor.Location = new Point(425, 34);
            redsecondarycolor.MaxLength = 3;
            redsecondarycolor.Name = "redsecondarycolor";
            redsecondarycolor.Size = new Size(35, 17);
            redsecondarycolor.TabIndex = 17;
            redsecondarycolor.TabStop = false;
            redsecondarycolor.TextChanged += colorTextChanged;
            // 
            // secondarycolortext
            // 
            secondarycolortext.AutoSize = true;
            secondarycolortext.Location = new Point(11, 34);
            secondarycolortext.Name = "secondarycolortext";
            secondarycolortext.Size = new Size(136, 17);
            secondarycolortext.TabIndex = 16;
            secondarycolortext.Text = "Secondary color:";
            // 
            // changefontcolorbutton
            // 
            changefontcolorbutton.FlatAppearance.BorderSize = 0;
            changefontcolorbutton.FlatStyle = FlatStyle.Flat;
            changefontcolorbutton.Font = new Font("ShureTechMono NFM", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changefontcolorbutton.ForeColor = SystemColors.Window;
            changefontcolorbutton.Location = new Point(620, 54);
            changefontcolorbutton.Name = "changefontcolorbutton";
            changefontcolorbutton.Size = new Size(58, 18);
            changefontcolorbutton.TabIndex = 15;
            changefontcolorbutton.Text = "Apply";
            changefontcolorbutton.UseVisualStyleBackColor = true;
            changefontcolorbutton.Click += changefontcolorbutton_Click;
            // 
            // changebackgroundcolorbutton
            // 
            changebackgroundcolorbutton.FlatAppearance.BorderSize = 0;
            changebackgroundcolorbutton.FlatStyle = FlatStyle.Flat;
            changebackgroundcolorbutton.Font = new Font("ShureTechMono NFM", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changebackgroundcolorbutton.ForeColor = SystemColors.Window;
            changebackgroundcolorbutton.Location = new Point(620, 14);
            changebackgroundcolorbutton.Margin = new Padding(1);
            changebackgroundcolorbutton.Name = "changebackgroundcolorbutton";
            changebackgroundcolorbutton.Size = new Size(58, 18);
            changebackgroundcolorbutton.TabIndex = 14;
            changebackgroundcolorbutton.Text = "Apply";
            changebackgroundcolorbutton.UseVisualStyleBackColor = true;
            changebackgroundcolorbutton.Click += changebackgroundcolorbutton_Click;
            // 
            // bluefontcolortext
            // 
            bluefontcolortext.AutoSize = true;
            bluefontcolortext.Location = new Point(539, 54);
            bluefontcolortext.Name = "bluefontcolortext";
            bluefontcolortext.Size = new Size(24, 17);
            bluefontcolortext.TabIndex = 13;
            bluefontcolortext.Text = "B:";
            // 
            // greenfontcolortext
            // 
            greenfontcolortext.AutoSize = true;
            greenfontcolortext.Location = new Point(468, 54);
            greenfontcolortext.Name = "greenfontcolortext";
            greenfontcolortext.Size = new Size(24, 17);
            greenfontcolortext.TabIndex = 12;
            greenfontcolortext.Text = "G:";
            // 
            // redfontcolortext
            // 
            redfontcolortext.AutoSize = true;
            redfontcolortext.Location = new Point(395, 54);
            redfontcolortext.Name = "redfontcolortext";
            redfontcolortext.Size = new Size(24, 17);
            redfontcolortext.TabIndex = 11;
            redfontcolortext.Text = "R:";
            // 
            // bluefontcolor
            // 
            bluefontcolor.BorderStyle = BorderStyle.None;
            bluefontcolor.Location = new Point(569, 54);
            bluefontcolor.MaxLength = 3;
            bluefontcolor.Name = "bluefontcolor";
            bluefontcolor.Size = new Size(35, 17);
            bluefontcolor.TabIndex = 10;
            bluefontcolor.TextChanged += colorTextChanged;
            // 
            // greenfontcolor
            // 
            greenfontcolor.BorderStyle = BorderStyle.None;
            greenfontcolor.Location = new Point(498, 54);
            greenfontcolor.MaxLength = 3;
            greenfontcolor.Name = "greenfontcolor";
            greenfontcolor.Size = new Size(35, 17);
            greenfontcolor.TabIndex = 9;
            greenfontcolor.TextChanged += colorTextChanged;
            // 
            // redfontcolor
            // 
            redfontcolor.BorderStyle = BorderStyle.None;
            redfontcolor.Location = new Point(425, 54);
            redfontcolor.MaxLength = 3;
            redfontcolor.Name = "redfontcolor";
            redfontcolor.Size = new Size(35, 17);
            redfontcolor.TabIndex = 8;
            redfontcolor.TextChanged += colorTextChanged;
            // 
            // fontcolortext
            // 
            fontcolortext.AutoSize = true;
            fontcolortext.Location = new Point(11, 54);
            fontcolortext.Name = "fontcolortext";
            fontcolortext.Size = new Size(96, 17);
            fontcolortext.TabIndex = 7;
            fontcolortext.Text = "Font color:";
            // 
            // bluebackgroundcolortext
            // 
            bluebackgroundcolortext.AutoSize = true;
            bluebackgroundcolortext.Location = new Point(539, 14);
            bluebackgroundcolortext.Name = "bluebackgroundcolortext";
            bluebackgroundcolortext.Size = new Size(24, 17);
            bluebackgroundcolortext.TabIndex = 6;
            bluebackgroundcolortext.Text = "B:";
            // 
            // greenbackgroundcolortext
            // 
            greenbackgroundcolortext.AutoSize = true;
            greenbackgroundcolortext.Location = new Point(468, 14);
            greenbackgroundcolortext.Name = "greenbackgroundcolortext";
            greenbackgroundcolortext.Size = new Size(24, 17);
            greenbackgroundcolortext.TabIndex = 5;
            greenbackgroundcolortext.Text = "G:";
            // 
            // redbackgroundcolortext
            // 
            redbackgroundcolortext.AutoSize = true;
            redbackgroundcolortext.Location = new Point(395, 14);
            redbackgroundcolortext.Name = "redbackgroundcolortext";
            redbackgroundcolortext.Size = new Size(24, 17);
            redbackgroundcolortext.TabIndex = 4;
            redbackgroundcolortext.Text = "R:";
            // 
            // bluebackgroundcolor
            // 
            bluebackgroundcolor.BorderStyle = BorderStyle.None;
            bluebackgroundcolor.Location = new Point(569, 14);
            bluebackgroundcolor.MaxLength = 3;
            bluebackgroundcolor.Name = "bluebackgroundcolor";
            bluebackgroundcolor.Size = new Size(35, 17);
            bluebackgroundcolor.TabIndex = 3;
            bluebackgroundcolor.TextChanged += colorTextChanged;
            // 
            // greenbackgroundcolor
            // 
            greenbackgroundcolor.BorderStyle = BorderStyle.None;
            greenbackgroundcolor.Location = new Point(498, 14);
            greenbackgroundcolor.MaxLength = 3;
            greenbackgroundcolor.Name = "greenbackgroundcolor";
            greenbackgroundcolor.Size = new Size(35, 17);
            greenbackgroundcolor.TabIndex = 2;
            greenbackgroundcolor.TextChanged += colorTextChanged;
            // 
            // redbackgroundcolor
            // 
            redbackgroundcolor.BorderStyle = BorderStyle.None;
            redbackgroundcolor.Location = new Point(425, 14);
            redbackgroundcolor.MaxLength = 3;
            redbackgroundcolor.Name = "redbackgroundcolor";
            redbackgroundcolor.Size = new Size(35, 17);
            redbackgroundcolor.TabIndex = 1;
            redbackgroundcolor.TabStop = false;
            redbackgroundcolor.TextChanged += colorTextChanged;
            // 
            // backgroundcolortext
            // 
            backgroundcolortext.AutoSize = true;
            backgroundcolortext.Location = new Point(11, 14);
            backgroundcolortext.Name = "backgroundcolortext";
            backgroundcolortext.Size = new Size(120, 17);
            backgroundcolortext.TabIndex = 0;
            backgroundcolortext.Text = "Primary color:";
            // 
            // EmberADHD
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(690, 375);
            ControlBox = false;
            Controls.Add(settingstabbutton);
            Controls.Add(moneytabbutton);
            Controls.Add(todotabbutton);
            Controls.Add(version);
            Controls.Add(title);
            Controls.Add(minimize);
            Controls.Add(exit);
            Controls.Add(todotab);
            Controls.Add(settingstab);
            Controls.Add(moneytab);
            Font = new Font("ShureTechMono NFM", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmberADHD";
            Text = "EmberADHD";
            Load += EmberADHD_Load;
            todotab.ResumeLayout(false);
            newTaskTab.ResumeLayout(false);
            newTaskTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)weightTask).EndInit();
            moneytab.ResumeLayout(false);
            moneytab.PerformLayout();
            settingstab.ResumeLayout(false);
            settingstab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button exit;
        public Button minimize;
        public Label title;
        public Label version;
        public Panel moneytab;
        public Panel settingstab;
        public Button todotabbutton;
        public Button moneytabbutton;
        public Button settingstabbutton;
        public Label moneylabel;
        public Label backgroundcolortext;
        public TextBox redbackgroundcolor;
        public TextBox bluebackgroundcolor;
        public TextBox greenbackgroundcolor;
        public Label bluefontcolortext;
        public Label greenfontcolortext;
        public Label redfontcolortext;
        public TextBox bluefontcolor;
        public TextBox greenfontcolor;
        public TextBox redfontcolor;
        public Label fontcolortext;
        public Label bluebackgroundcolortext;
        public Label greenbackgroundcolortext;
        public Label redbackgroundcolortext;
        public Button changefontcolorbutton;
        public Button changebackgroundcolorbutton;
        public Button secondarycolorbutton;
        public Label bluesecondarycolortext;
        public Label greensecondarycolortext;
        public Label redsecondarycolortext;
        public TextBox bluesecondarycolor;
        public TextBox greensecondarycolor;
        public TextBox redsecondarycolor;
        public Label secondarycolortext;
        public Panel todotab;
        public FlowLayoutPanel tasksLayoutPanel;
        public Button newTaskTabButton;
        public Button activeTaskTabButton;
        private Panel newTaskTab;
        private Label taskNameLabel;
        private Label dosTaskLabel;
        private Label doeTaskLabel;
        private Label weightTaskLabel;
        private NumericUpDown weightTask;
        private DateTimePicker dosTask;
        private TextBox taskName;
        private DateTimePicker doeTask;
        public Button button1;
    }
}
