namespace HtmlEditor
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.htmlTxt = new System.Windows.Forms.RichTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.htmlTxt);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.SplitterDistance = 69;
            this.splitContainer1.TabIndex = 3;
            // 
            // htmlTxt
            // 
            this.htmlTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.htmlTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.htmlTxt.Location = new System.Drawing.Point(0, 0);
            this.htmlTxt.Name = "htmlTxt";
            this.htmlTxt.Size = new System.Drawing.Size(347, 98);
            this.htmlTxt.TabIndex = 2;
            this.htmlTxt.Text = "<html>\n<body>\n  <h1> Kağıt Editor </h1>\n  <p>HTML kodlarla geliştirdiğiniz kağıdı" +
    "nızı istediğiniz gibi şekillendirin veya görsel ekleyin.</p>\n</body>\n</html>";
            this.htmlTxt.TextChanged += new System.EventHandler(this.htmlTxt_TextChanged);
            this.htmlTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.htmlTxt_KeyDown);
            this.htmlTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.htmlTxt_KeyUp);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Right;
            this.webBrowser1.Location = new System.Drawing.Point(-114, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(189, 98);
            this.webBrowser1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(193, 137);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox htmlTxt;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}
