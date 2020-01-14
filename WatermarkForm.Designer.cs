namespace Overlay_Watermark
{
    partial class WatermarkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddTrackButton = new System.Windows.Forms.Button();
            this.OverlayButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MusicList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WatermarkList = new System.Windows.Forms.ComboBox();
            this.WatermarkPathLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WatermarkRepeat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WatermarkOffset = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RemoveTrackButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.PauseBetweenTrack = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddTrackButton
            // 
            this.AddTrackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTrackButton.Location = new System.Drawing.Point(501, 142);
            this.AddTrackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddTrackButton.Name = "AddTrackButton";
            this.AddTrackButton.Size = new System.Drawing.Size(87, 28);
            this.AddTrackButton.TabIndex = 0;
            this.AddTrackButton.Text = "Add";
            this.AddTrackButton.UseVisualStyleBackColor = true;
            this.AddTrackButton.Click += new System.EventHandler(this.AddTrackButtonClick);
            // 
            // OverlayButton
            // 
            this.OverlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OverlayButton.Location = new System.Drawing.Point(35, 500);
            this.OverlayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OverlayButton.Name = "OverlayButton";
            this.OverlayButton.Size = new System.Drawing.Size(621, 50);
            this.OverlayButton.TabIndex = 4;
            this.OverlayButton.Text = "Наложить водяной знак";
            this.OverlayButton.UseVisualStyleBackColor = true;
            this.OverlayButton.Click += new System.EventHandler(this.OverlayButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.MusicList);
            this.groupBox1.Location = new System.Drawing.Point(33, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.MinimumSize = new System.Drawing.Size(251, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(571, 110);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите WAV файлы с треком:";
            // 
            // MusicList
            // 
            this.MusicList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MusicList.FormattingEnabled = true;
            this.MusicList.ItemHeight = 16;
            this.MusicList.Location = new System.Drawing.Point(13, 26);
            this.MusicList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MusicList.Name = "MusicList";
            this.MusicList.Size = new System.Drawing.Size(543, 68);
            this.MusicList.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.WatermarkList);
            this.groupBox2.Location = new System.Drawing.Point(35, 199);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.MinimumSize = new System.Drawing.Size(251, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(621, 60);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите файл водяного знака:";
            // 
            // WatermarkList
            // 
            this.WatermarkList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WatermarkList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WatermarkList.FormattingEnabled = true;
            this.WatermarkList.Items.AddRange(new object[] {
            "Audio Jungle",
            "Выбрать водяной знак..."});
            this.WatermarkList.Location = new System.Drawing.Point(13, 25);
            this.WatermarkList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WatermarkList.Name = "WatermarkList";
            this.WatermarkList.Size = new System.Drawing.Size(599, 24);
            this.WatermarkList.TabIndex = 9;
            this.WatermarkList.SelectedIndexChanged += new System.EventHandler(this.WatermarkListSelectedIndexChanged);
            // 
            // WatermarkPathLabel
            // 
            this.WatermarkPathLabel.AutoSize = true;
            this.WatermarkPathLabel.Location = new System.Drawing.Point(12, 351);
            this.WatermarkPathLabel.Name = "WatermarkPathLabel";
            this.WatermarkPathLabel.Size = new System.Drawing.Size(25, 17);
            this.WatermarkPathLabel.TabIndex = 0;
            this.WatermarkPathLabel.Text = "C:\\";
            this.WatermarkPathLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Повторять водяной знак каждые";
            // 
            // WatermarkRepeat
            // 
            this.WatermarkRepeat.Location = new System.Drawing.Point(261, 279);
            this.WatermarkRepeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WatermarkRepeat.Name = "WatermarkRepeat";
            this.WatermarkRepeat.Size = new System.Drawing.Size(39, 22);
            this.WatermarkRepeat.TabIndex = 7;
            this.WatermarkRepeat.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "сек";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Сместить водяной знак на";
            // 
            // WatermarkOffset
            // 
            this.WatermarkOffset.Location = new System.Drawing.Point(220, 310);
            this.WatermarkOffset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WatermarkOffset.Name = "WatermarkOffset";
            this.WatermarkOffset.Size = new System.Drawing.Size(39, 22);
            this.WatermarkOffset.TabIndex = 7;
            this.WatermarkOffset.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "секунд от начала";
            // 
            // RemoveTrackButton
            // 
            this.RemoveTrackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveTrackButton.Location = new System.Drawing.Point(413, 142);
            this.RemoveTrackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveTrackButton.Name = "RemoveTrackButton";
            this.RemoveTrackButton.Size = new System.Drawing.Size(83, 28);
            this.RemoveTrackButton.TabIndex = 9;
            this.RemoveTrackButton.Text = "Remove";
            this.RemoveTrackButton.UseVisualStyleBackColor = true;
            this.RemoveTrackButton.Click += new System.EventHandler(this.RemoveTrackButtonClick);
            // 
            // UpButton
            // 
            this.UpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpButton.Location = new System.Drawing.Point(611, 53);
            this.UpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(68, 28);
            this.UpButton.TabIndex = 10;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButtonClick);
            // 
            // DownButton
            // 
            this.DownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DownButton.Location = new System.Drawing.Point(611, 94);
            this.DownButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(68, 28);
            this.DownButton.TabIndex = 11;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButtonClick);
            // 
            // PauseBetweenTrack
            // 
            this.PauseBetweenTrack.Location = new System.Drawing.Point(189, 151);
            this.PauseBetweenTrack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PauseBetweenTrack.Name = "PauseBetweenTrack";
            this.PauseBetweenTrack.Size = new System.Drawing.Size(35, 22);
            this.PauseBetweenTrack.TabIndex = 12;
            this.PauseBetweenTrack.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Пауза между треками";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "сек";
            // 
            // WatermarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PauseBetweenTrack);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.RemoveTrackButton);
            this.Controls.Add(this.WatermarkPathLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WatermarkOffset);
            this.Controls.Add(this.WatermarkRepeat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OverlayButton);
            this.Controls.Add(this.AddTrackButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(18, 363);
            this.Name = "WatermarkForm";
            this.Text = "WM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTrackButton;
        private System.Windows.Forms.Button OverlayButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label WatermarkPathLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WatermarkRepeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox WatermarkOffset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox WatermarkList;
        private System.Windows.Forms.ListBox MusicList;
        private System.Windows.Forms.Button RemoveTrackButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.TextBox PauseBetweenTrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}

