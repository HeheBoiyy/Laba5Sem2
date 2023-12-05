namespace Laba5Sem2
{
    public partial class Вакцинация : Form
    {
        private List<PacientClass> pacients;
        private List<PacientClass> govactina;
        private List<PacientClass> sertificate;
        public Вакцинация()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pacients = new List<PacientClass>
            {
                new PacientClass("Дарбинян Давид Арманович",Vacitation.Zero),
                new PacientClass("Красноборов Евгений Евгеньевич",Vacitation.Zero),
                new PacientClass("Бельтюков Александр Николаевич",Vacitation.Zero),
                new PacientClass("Рыбин Максим Андреевич",Vacitation.Zero),
                new PacientClass("Савченко Александр Алексеевич",Vacitation.Zero),
                new PacientClass("Павленко Артур",Vacitation.Zero),
                new PacientClass("Сурин Никита Константинович",Vacitation.Zero)
            };
            listBox1.DataSource = pacients;
            listBox1.DisplayMember = "FullName";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                govactina.Add(new PacientClass(listBox1.SelectedItem.ToString()));
            }
            
        }
    }
}
