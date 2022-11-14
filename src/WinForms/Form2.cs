namespace WinForms;

public partial class Form2 : Form
{
    System.Windows.Forms.BindingSource viewModelBindingSource;

    public Form2()
    {
        InitializeComponent();

        ((System.ComponentModel.ISupportInitialize)(viewModelBindingSource)).BeginInit();
        viewModelBindingSource.DataSource = new Mvvm.ViewModel();
        ((System.ComponentModel.ISupportInitialize)(viewModelBindingSource)).EndInit();
        this.DataContext = viewModelBindingSource;

        AddBinding(textBox1, "Text", "Num1");
        AddBinding(textBox2, "Text", "Num2");
        AddBinding(textBox3, "Text", "Num3");
        AddBinding(textBox4, "Text", "Num3");
        AddBinding(textBox5, "Text", "Num3");
        AddBinding(button1, "Command", "Command");

        void AddBinding(Control control, string property, string dataMember) => control.DataBindings.Add(property, control.DataContext, dataMember, true);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var viewModelBindingSource = ((System.Windows.Forms.BindingSource)this.DataContext!);
        viewModelBindingSource.DataSource = viewModelBindingSource.DataSource is Mvvm.ViewModel ? new Mvvm.ViewModel2() : new Mvvm.ViewModel();

    }
}
