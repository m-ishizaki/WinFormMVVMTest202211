namespace WinForms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        Mvvm.ViewModel dataSource = new();
        this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataSource, "Num1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
        this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataSource, "Num2", true));
        this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataSource, "Num3", true));
        this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataSource, "Num3", true));
        this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataSource, "Num3", true));
        this.button1.DataBindings.Add(new System.Windows.Forms.Binding("Command", dataSource, "Command", true));
    }
}
