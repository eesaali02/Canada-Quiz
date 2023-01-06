namespace Canada_QuizGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name");
                return;
            }

            string name = txtName.Text.Trim();

            if (name.Length > 20)
            {
                MessageBox.Show("Name length must be less than 20 characters");
                return;
            }

            foreach (char c in name)
            {
                if (char.IsDigit(c) || char.IsPunctuation(c) || char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Name cannot contain puncuation, spaces, or numbers.");
                    return;
                }
            }

            Form2 f2 = new Form2(txtName.Text);
            f2.Show();
            this.Hide();
        }
    }
}