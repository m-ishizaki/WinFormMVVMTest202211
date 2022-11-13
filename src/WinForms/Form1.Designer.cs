namespace WinForms;

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
        this.components = new System.ComponentModel.Container();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.viewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.textBox3 = new System.Windows.Forms.TextBox();
        this.textBox4 = new System.Windows.Forms.TextBox();
        this.textBox5 = new System.Windows.Forms.TextBox();
        this.button1 = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.viewModelBindingSource)).BeginInit();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(131, 3);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(19, 20);
        this.label1.TabIndex = 0;
        this.label1.Text = "+";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(287, 3);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(19, 20);
        this.label2.TabIndex = 1;
        this.label2.Text = "=";
        // 
        // textBox1
        // 
        //            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewModelBindingSource, "Num1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
        //            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("DataContext", this.viewModelBindingSource1, "Num1", true));
        this.textBox1.Location = new System.Drawing.Point(0, 0);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(125, 27);
        this.textBox1.TabIndex = 2;
        // 
        // viewModelBindingSource
        // 
        //            this.viewModelBindingSource.DataSource = typeof(Mvvm.ViewModel);
        // 
        // textBox2
        // 
        //            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewModelBindingSource, "Num2", true));
        this.textBox2.Location = new System.Drawing.Point(156, 0);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new System.Drawing.Size(125, 27);
        this.textBox2.TabIndex = 3;
        // 
        // textBox3
        // 
        //            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewModelBindingSource, "Num3", true));
        this.textBox3.Location = new System.Drawing.Point(312, 3);
        this.textBox3.Name = "textBox3";
        this.textBox3.Size = new System.Drawing.Size(125, 27);
        this.textBox3.TabIndex = 4;
        // 
        // textBox4
        // 
        //            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewModelBindingSource, "Num3", true));
        this.textBox4.Location = new System.Drawing.Point(312, 36);
        this.textBox4.Name = "textBox4";
        this.textBox4.Size = new System.Drawing.Size(125, 27);
        this.textBox4.TabIndex = 5;
        // 
        // textBox5
        // 
        //            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewModelBindingSource, "Num3", true));
        this.textBox5.Location = new System.Drawing.Point(312, 69);
        this.textBox5.Name = "textBox5";
        this.textBox5.Size = new System.Drawing.Size(125, 27);
        this.textBox5.TabIndex = 6;
        // 
        // button1
        // 
        //            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("DataContext", this.viewModelBindingSource, "Command", true));
        this.button1.Location = new System.Drawing.Point(12, 67);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(94, 29);
        this.button1.TabIndex = 7;
        this.button1.Text = "button1";
        this.button1.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.textBox5);
        this.Controls.Add(this.textBox4);
        this.Controls.Add(this.textBox3);
        this.Controls.Add(this.textBox2);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "Form1";
        this.Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)(this.viewModelBindingSource)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox4;
    private TextBox textBox5;
    private Button button1;
    private BindingSource viewModelBindingSource;
}
