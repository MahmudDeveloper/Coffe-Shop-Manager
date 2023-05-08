namespace Coffe_Shop_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(CoffeNamecombo.SelectedItem.ToString()) 
            {
                case "Latte":
                    switch(Typecombo.SelectedItem)
                    {
                        case "Frapp":
                            Paymenttxt.Text=(int.Parse(Quantitycombo.Text)*5000).ToString();
                        break;

                        case "Ice":
                            Paymenttxt.Text = (int.Parse(Quantitycombo.Text) * 4000).ToString();
                        break;

                        case "Hot":
                            Paymenttxt.Text = (int.Parse(Quantitycombo.Text) * 6000).ToString();
                        break;

                    }
                    dataGridView1.Rows.Add(CoffeNamecombo.Text,Typecombo.Text,Quantitycombo.Text,Paymenttxt.Text);
                break;
                case "Chappuccino":
                    switch (Typecombo.SelectedItem)
                    {
                        case "Frapp":
                            Paymenttxt.Text = (int.Parse(Quantitycombo.Text) * 6000).ToString();
                            break;

                        case "Ice":
                            Paymenttxt.Text = (int.Parse(Quantitycombo.Text) * 5000).ToString();
                            break;

                        case "Hot":
                            Paymenttxt.Text = (int.Parse(Quantitycombo.Text) * 7000).ToString();
                            break;
                    }
                    dataGridView1.Rows.Add(CoffeNamecombo.Text, Typecombo.Text, Quantitycombo.Text, Paymenttxt.Text);
                    break;
                case "Chololate":
                    switch (Typecombo.SelectedItem)
                    {
                        case "Frapp":
                            Paymenttxt.Text = (int.Parse(Quantitycombo.Text) * 5000).ToString();
                            break;

                        case "Ice":
                            Paymenttxt.Text = (int.Parse(Quantitycombo.Text) * 4000).ToString();
                            break;

                        case "Hot":
                            Paymenttxt.Text = (int.Parse(Quantitycombo.Text) * 6000).ToString();
                            break;
                    }
                    dataGridView1.Rows.Add(CoffeNamecombo.Text, Typecombo.Text, Quantitycombo.Text, Paymenttxt.Text);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CoffeNamecombo.Text="";
            Typecombo.Text="";
            Quantitycombo.Text = "";
            Paymenttxt.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Paymenttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar)) 
            {
                
            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}