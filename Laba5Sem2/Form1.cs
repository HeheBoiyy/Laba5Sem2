namespace Laba5Sem2
{
    public partial class ���������� : Form
    {
        private List<PacientClass> pacients;
        private List<PacientClass> govactina;
        private List<PacientClass> sertificate;
        public ����������()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pacients = new List<PacientClass>
            {
                new PacientClass("�������� ����� ���������",Vacitation.Zero),
                new PacientClass("����������� ������� ����������",Vacitation.Zero),
                new PacientClass("��������� ��������� ����������",Vacitation.Zero),
                new PacientClass("����� ������ ���������",Vacitation.Zero),
                new PacientClass("�������� ��������� ����������",Vacitation.Zero),
                new PacientClass("�������� �����",Vacitation.Zero),
                new PacientClass("����� ������ ��������������",Vacitation.Zero)
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
