namespace Assignment_Basic_Registration_Form
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSubmitClicked(object sender, EventArgs e)
        {
            string name = nameEntry.Text;
            string course = courseEntry.Text;
            string year = yearEntry.Text;

            DisplayAlert("Registration Form", $"Name: {name}\nCourse: {course}\nYear: {year}", "OK");
        }
    }
}