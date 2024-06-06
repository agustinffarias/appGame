namespace TrackerUI
{
    partial class TournamentViewerForm
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
            headerLabel = new Label();
            label1 = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            matchupListbox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            teamTwoScoreValue = new TextBox();
            versusLabel = new Label();
            scoreBotton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(25, 40);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(171, 38);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(125, 201);
            label1.Name = "label1";
            label1.Size = new Size(0, 38);
            label1.TabIndex = 1;
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.ForeColor = SystemColors.MenuHighlight;
            tournamentName.Location = new Point(202, 40);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(118, 38);
            tournamentName.TabIndex = 2;
            tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            roundLabel.ForeColor = Color.Blue;
            roundLabel.Location = new Point(28, 103);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(80, 31);
            roundLabel.TabIndex = 3;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(137, 95);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(192, 45);
            roundDropDown.TabIndex = 4;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckBox.ForeColor = SystemColors.MenuHighlight;
            unplayedOnlyCheckBox.Location = new Point(137, 146);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(213, 42);
            unplayedOnlyCheckBox.TabIndex = 5;
            unplayedOnlyCheckBox.Text = "Unplayed only";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListbox
            // 
            matchupListbox.BorderStyle = BorderStyle.FixedSingle;
            matchupListbox.FormattingEnabled = true;
            matchupListbox.ItemHeight = 37;
            matchupListbox.Location = new Point(46, 201);
            matchupListbox.Name = "matchupListbox";
            matchupListbox.Size = new Size(292, 261);
            matchupListbox.TabIndex = 6;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneName.ForeColor = Color.Blue;
            teamOneName.Location = new Point(375, 202);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(144, 31);
            teamOneName.TabIndex = 7;
            teamOneName.Text = "<Team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreLabel.ForeColor = Color.Blue;
            teamOneScoreLabel.Location = new Point(375, 246);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(70, 31);
            teamOneScoreLabel.TabIndex = 8;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(484, 246);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(174, 43);
            teamOneScoreValue.TabIndex = 9;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoScoreLabel.ForeColor = Color.Blue;
            teamTwoScoreLabel.Location = new Point(375, 390);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(70, 31);
            teamTwoScoreLabel.TabIndex = 11;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoName.ForeColor = Color.Blue;
            teamTwoName.Location = new Point(375, 346);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(144, 31);
            teamTwoName.TabIndex = 10;
            teamTwoName.Text = "<Team one>";
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(484, 390);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(174, 43);
            teamTwoScoreValue.TabIndex = 12;
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            versusLabel.ForeColor = Color.Blue;
            versusLabel.Location = new Point(484, 305);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(58, 31);
            versusLabel.TabIndex = 13;
            versusLabel.Text = "-VS-";
            // 
            // scoreBotton
            // 
            scoreBotton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreBotton.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 102, 102);
            scoreBotton.FlatStyle = FlatStyle.Flat;
            scoreBotton.ForeColor = Color.CornflowerBlue;
            scoreBotton.Location = new Point(714, 305);
            scoreBotton.Name = "scoreBotton";
            scoreBotton.Size = new Size(131, 60);
            scoreBotton.TabIndex = 14;
            scoreBotton.Text = "Score";
            scoreBotton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(866, 479);
            Controls.Add(scoreBotton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListbox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(label1);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label label1;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchupListbox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoName;
        private TextBox teamTwoScoreValue;
        private Label versusLabel;
        private Button scoreBotton;
    }
}
