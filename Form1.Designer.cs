namespace Lab7
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            tabPage2 = new TabPage();
            listView1 = new ListView();
            plantsBindingSource2 = new BindingSource(components);
            plantsBindingSource1 = new BindingSource(components);
            plantsBindingSource = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)plantsBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plantsBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plantsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(5, 4, 5, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(881, 625);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox6);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(button2);
            tabPage1.Location = new Point(4, 35);
            tabPage1.Margin = new Padding(5, 4, 5, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5, 4, 5, 4);
            tabPage1.Size = new Size(873, 586);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Додати";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 385);
            label5.Name = "label5";
            label5.Size = new Size(193, 26);
            label5.TabIndex = 10;
            label5.Text = "Потреба у добриві";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 258);
            label4.Name = "label4";
            label4.Size = new Size(156, 26);
            label4.TabIndex = 9;
            label4.Text = "Потреба у воді";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 205);
            label3.Name = "label3";
            label3.Size = new Size(164, 26);
            label3.TabIndex = 8;
            label3.Text = "Період цвітіння";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 53);
            label2.Name = "label2";
            label2.Size = new Size(181, 26);
            label2.TabIndex = 7;
            label2.Text = "Умови зростання";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 10);
            label1.Name = "label1";
            label1.Size = new Size(50, 26);
            label1.TabIndex = 6;
            label1.Text = "Вид";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(248, 385);
            textBox6.Margin = new Padding(5, 4, 5, 4);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Є/Немає, Кількість, вид (якщо є)";
            textBox6.Size = new Size(595, 107);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(248, 258);
            textBox5.Margin = new Padding(5, 4, 5, 4);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Є/Немає, Кількість (якщо є)";
            textBox5.Size = new Size(595, 108);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(248, 205);
            textBox4.Margin = new Padding(5, 4, 5, 4);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "весна-літо або датами 12.03.20nn-12.08.20nn";
            textBox4.Size = new Size(595, 34);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(248, 53);
            textBox3.Margin = new Padding(5, 4, 5, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Росписати, що треба робити для успішного вирощення";
            textBox3.Size = new Size(595, 143);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(248, 10);
            textBox2.Margin = new Padding(5, 4, 5, 4);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Повна назва, вид";
            textBox2.Size = new Size(595, 34);
            textBox2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(248, 505);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(153, 77);
            button2.TabIndex = 0;
            button2.Text = "Додати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listView1);
            tabPage2.Location = new Point(4, 35);
            tabPage2.Margin = new Padding(5, 4, 5, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(5, 4, 5, 4);
            tabPage2.Size = new Size(873, 586);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Список";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(5, 4);
            listView1.Margin = new Padding(5, 4, 5, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(863, 578);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // plantsBindingSource2
            // 
            plantsBindingSource2.DataSource = typeof(DB.Plants);
            // 
            // plantsBindingSource1
            // 
            plantsBindingSource1.DataSource = typeof(DB.Plants);
            // 
            // plantsBindingSource
            // 
            plantsBindingSource.DataSource = typeof(DB.Plants);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 625);
            Controls.Add(tabControl1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)plantsBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)plantsBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)plantsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource plantsBindingSource;
        private BindingSource plantsBindingSource1;
        private BindingSource plantsBindingSource2;
        private ListView listView1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
