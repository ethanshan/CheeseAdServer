namespace CheeseAdServer
{
    partial class TimePickerForm
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
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.ok_bt = new System.Windows.Forms.Button();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timePicker
            // 
            this.timePicker.Location = new System.Drawing.Point(49, 43);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(200, 21);
            this.timePicker.TabIndex = 0;
            // 
            // ok_bt
            // 
            this.ok_bt.Location = new System.Drawing.Point(103, 92);
            this.ok_bt.Name = "ok_bt";
            this.ok_bt.Size = new System.Drawing.Size(75, 23);
            this.ok_bt.TabIndex = 1;
            this.ok_bt.Text = "确认";
            this.ok_bt.UseVisualStyleBackColor = true;
            this.ok_bt.Click += new System.EventHandler(this.ok_bt_Click);
            // 
            // cancel_bt
            // 
            this.cancel_bt.Location = new System.Drawing.Point(199, 92);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.cancel_bt.TabIndex = 2;
            this.cancel_bt.Text = "取消";
            this.cancel_bt.UseVisualStyleBackColor = true;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "选取时间:";
            // 
            // TimePickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 138);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.ok_bt);
            this.Controls.Add(this.timePicker);
            this.Name = "TimePickerForm";
            this.Text = "TimePickerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button ok_bt;
        private System.Windows.Forms.Button cancel_bt;
        private System.Windows.Forms.Label label1;
    }
}