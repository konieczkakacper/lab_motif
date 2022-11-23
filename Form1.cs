namespace fastamotif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string s = "";

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            StreamReader stream = File.OpenText(ofd.FileName);

            string ss = "";
            textBox1.Text = stream.ReadLine();

            while((ss = stream.ReadLine()) != null)
            {
                s = s + ss;
                textBox2.Text = s;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s = textBox2.Text; // wczytane nukleotydy
            
            string res = "";

            List<string> list = new List<string>();
            List<int> lst = new List<int>();

            for (int i = s.Length; i > 4; i--)
            {
                string ss = (s[i - 4].ToString() + s[i - 3].ToString() + s[i - 2].ToString() + s[i - 1].ToString());

                if (list.Contains(ss))
                {
                    int check = list.IndexOf(ss);
                    lst[check] = lst[check] + 1;
                }
                else
                {
                    list.Add(ss);
                    lst.Add(1);
                }
            }

            for(int x = lst.Count; x > 0; x--)
            {
                if(lst[x - 1] > 1)
                {
                    res = res + list[x - 1] + ": " + lst[x - 1] + "\r\t";
                }
            }
            textBox3.Text = res;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}