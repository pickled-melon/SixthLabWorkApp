namespace SixthLabWorkApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.lblDirPurpose = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.tbGraviton = new System.Windows.Forms.TrackBar();
            this.tbGraviton2 = new System.Windows.Forms.TrackBar();
            this.chkBoxDebug = new System.Windows.Forms.CheckBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnStepFrwd = new System.Windows.Forms.Button();
            this.tbSimSpeed = new System.Windows.Forms.TrackBar();
            this.lblSimSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSimSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(0, 0);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(800, 450);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDirection.Location = new System.Drawing.Point(12, 500);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(189, 56);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // lblDirPurpose
            // 
            this.lblDirPurpose.AutoSize = true;
            this.lblDirPurpose.Location = new System.Drawing.Point(12, 481);
            this.lblDirPurpose.Name = "lblDirPurpose";
            this.lblDirPurpose.Size = new System.Drawing.Size(97, 16);
            this.lblDirPurpose.TabIndex = 2;
            this.lblDirPurpose.Text = "Направление";
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(207, 500);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(14, 16);
            this.lblDirection.TabIndex = 3;
            this.lblDirection.Text = "0";
            // 
            // tbGraviton
            // 
            this.tbGraviton.Location = new System.Drawing.Point(251, 500);
            this.tbGraviton.Maximum = 100;
            this.tbGraviton.Name = "tbGraviton";
            this.tbGraviton.Size = new System.Drawing.Size(186, 56);
            this.tbGraviton.TabIndex = 4;
            this.tbGraviton.Value = 100;
            this.tbGraviton.Scroll += new System.EventHandler(this.tbGraviton_Scroll);
            // 
            // tbGraviton2
            // 
            this.tbGraviton2.Location = new System.Drawing.Point(443, 500);
            this.tbGraviton2.Maximum = 100;
            this.tbGraviton2.Name = "tbGraviton2";
            this.tbGraviton2.Size = new System.Drawing.Size(186, 56);
            this.tbGraviton2.TabIndex = 5;
            this.tbGraviton2.Value = 100;
            this.tbGraviton2.Scroll += new System.EventHandler(this.tbGraviton2_Scroll);
            // 
            // chkBoxDebug
            // 
            this.chkBoxDebug.AutoSize = true;
            this.chkBoxDebug.Location = new System.Drawing.Point(807, 12);
            this.chkBoxDebug.Name = "chkBoxDebug";
            this.chkBoxDebug.Size = new System.Drawing.Size(129, 20);
            this.chkBoxDebug.TabIndex = 6;
            this.chkBoxDebug.Text = "Режим отладки";
            this.chkBoxDebug.UseVisualStyleBackColor = true;
            this.chkBoxDebug.CheckedChanged += new System.EventHandler(this.chkBoxDebug_CheckedChanged);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(807, 412);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(153, 38);
            this.btnStartStop.TabIndex = 7;
            this.btnStartStop.Text = "Запуск/Остановка";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnStepFrwd
            // 
            this.btnStepFrwd.Location = new System.Drawing.Point(810, 368);
            this.btnStepFrwd.Name = "btnStepFrwd";
            this.btnStepFrwd.Size = new System.Drawing.Size(153, 38);
            this.btnStepFrwd.TabIndex = 8;
            this.btnStepFrwd.Text = "Шаг вперёд";
            this.btnStepFrwd.UseVisualStyleBackColor = true;
            // 
            // tbSimSpeed
            // 
            this.tbSimSpeed.Location = new System.Drawing.Point(806, 72);
            this.tbSimSpeed.Maximum = 200;
            this.tbSimSpeed.Minimum = 10;
            this.tbSimSpeed.Name = "tbSimSpeed";
            this.tbSimSpeed.Size = new System.Drawing.Size(140, 56);
            this.tbSimSpeed.TabIndex = 9;
            this.tbSimSpeed.Value = 10;
            // 
            // lblSimSpeed
            // 
            this.lblSimSpeed.AutoSize = true;
            this.lblSimSpeed.Location = new System.Drawing.Point(804, 44);
            this.lblSimSpeed.Name = "lblSimSpeed";
            this.lblSimSpeed.Size = new System.Drawing.Size(142, 16);
            this.lblSimSpeed.TabIndex = 10;
            this.lblSimSpeed.Text = "Скорость симуляции";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 568);
            this.Controls.Add(this.lblSimSpeed);
            this.Controls.Add(this.tbSimSpeed);
            this.Controls.Add(this.btnStepFrwd);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.chkBoxDebug);
            this.Controls.Add(this.tbGraviton2);
            this.Controls.Add(this.tbGraviton);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.lblDirPurpose);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Обработка событий";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSimSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label lblDirPurpose;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TrackBar tbGraviton;
        private System.Windows.Forms.TrackBar tbGraviton2;
        private System.Windows.Forms.CheckBox chkBoxDebug;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnStepFrwd;
        private System.Windows.Forms.TrackBar tbSimSpeed;
        private System.Windows.Forms.Label lblSimSpeed;
    }
}

