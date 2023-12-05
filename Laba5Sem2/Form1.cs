namespace Laba5Sem2
{
    public partial class ���������� : Form
    {
        private List<PacientClass> pacients;
        private List<PacientClass> govactina = new List<PacientClass>();
        private List<PacientClass> sertificate = new List<PacientClass>();
        public ����������()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pacients = new List<PacientClass>
            {
                new PacientClass("�������� ����� ���������",Vacitation.One),
                new PacientClass("����������� ������� ����������",Vacitation.Zero),
                new PacientClass("��������� ��������� ����������",Vacitation.Zero),
                new PacientClass("����� ������ ���������",Vacitation.Zero),
                new PacientClass("�������� ��������� ����������",Vacitation.Zero),
                new PacientClass("�������� �����",Vacitation.Zero),
                new PacientClass("����� ������ ��������������",Vacitation.Zero)
            };
            listBox1.DataSource = pacients;
            listBox1.DisplayMember = "FullNameVacitation";    //
            listBox2.DataSource = govactina;                  // �������� ������ � listbox
            listBox2.DisplayMember = "FullNameVacitation";    //
            listBox3.DataSource = sertificate;
            listBox2.DisplayMember = "FullNameVacitation";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (((PacientClass)listBox1.SelectedItem).Vacitation == Vacitation.One)
                {
                    MessageBox.Show("��������� ������� ��� ������ ��������� ����������", "������� � �����������!");
                }
                else
                {
                    govactina.Add((PacientClass)listBox1.SelectedItem);
                    Voids.BindData(listBox2, govactina);
                    pacients.Remove((PacientClass)listBox1.SelectedItem);
                    Voids.BindData(listBox1, pacients);
                }
            }
            else
            {
                MessageBox.Show("������ �� �������!", "������ �����");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (((PacientClass)listBox1.SelectedItem).Vacitation == Vacitation.Zero)
                {
                    MessageBox.Show("��������� ������� �� ������ ��������� ����������", "������� ��� ����������");
                }
                else
                {
                    govactina.Add((PacientClass)listBox1.SelectedItem);
                    Voids.BindData(listBox2, govactina);
                    pacients.Remove((PacientClass)listBox1.SelectedItem);
                    Voids.BindData(listBox1, pacients);
                }
            }
            else
            {
                MessageBox.Show("������ �� �������!", "������ �����");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pacients.Count!=0)
            {
                List<PacientClass> addedpacients = new List<PacientClass>();
                foreach (PacientClass pacient in pacients)
                {
                    govactina.Add(pacient);
                    Voids.BindData(listBox2, govactina);
                    addedpacients.Add(pacient);
                }
                foreach (PacientClass pacient1 in addedpacients)
                {
                    pacients.Remove(pacient1);
                    Voids.BindData(listBox1, pacients);
                }
            }
            else 
            {
                MessageBox.Show("�������� �����������!", "�����");
            }
        }
        Random random = new Random();
        Random strah = new Random();
        private void button4_Click(object sender, EventArgs e)
        {
            List<PacientClass> BUFER = new List<PacientClass>(); // ����� ��� �������� ��������� � ��������� ��������� ���������� ���������
            List<PacientClass> GETSERTIFICATE = new List<PacientClass>(); // ����� ��� �������� ��������� ���������� ����������
            List<PacientClass> UBEZHALI = new List<PacientClass>(); // ������ ��������� :)
            bool Ubezhal= false;

            if (govactina.Count!=0)
            {
                int vactina = random.Next(0, 2);
                if (vactina == 1) // ������� ������������
                {
                    foreach (PacientClass pacient in govactina)
                    {
                        int strashilka = strah.Next(0, 2);
                        if (strashilka == 0)
                        {
                            if (pacient.Vacitation == Vacitation.Zero)
                            {
                                pacient.Vacitation = pacient.Vacitation + 1;
                                pacients.Add(pacient);
                                Voids.BindData(listBox1, pacients);
                                BUFER.Add(pacient);
                            }
                            else
                            {
                                pacient.Vacitation = pacient.Vacitation + 1;
                                sertificate.Add(pacient);
                                Voids.BindData(listBox3, sertificate);
                                GETSERTIFICATE.Add(pacient);
                            }
                        }
                        else
                        {
                            Ubezhal = true;
                            pacients.Add(pacient);
                            BUFER.Add(pacient);
                            UBEZHALI.Add(pacient);
                        }
                    }
                    foreach (PacientClass aboba in BUFER) // �������� ��������� � ��������� ��������� ���������� ���������
                    {
                        govactina.Remove(aboba);
                        Voids.BindData(listBox1, pacients);
                    }
                    foreach (PacientClass aboba1 in GETSERTIFICATE) // �������� ��������� ���������� ����������
                    {
                        govactina.Remove(aboba1);
                    }
                    string ubezhavhie = "";
                    foreach (PacientClass aboba2 in UBEZHALI) // ������ ������� ���������� � ������� ��� �������, ����� �������
                    {
                        ubezhavhie += aboba2.FullName + Environment.NewLine;
                    }
                    Voids.BindData(listBox2, govactina);
                    Voids.BindData(listBox1, pacients);


                    if (Ubezhal) // �������� ������ �� ��� ��??
                    {
                        MessageBox.Show("����/��� ��������� ��������� ���������� � ������� � ������!!! \n������ ������:\n" + ubezhavhie + "\n\n� � ����� �� ������� )", "������� ������� ����� �������");
                    }
                    else
                    {
                        MessageBox.Show("���������� ������ �������", "�����");
                    }
                }
                else
                {
                    MessageBox.Show("������ ���, �� ����� ����.");
                    foreach (PacientClass pacient in govactina)
                    {
                        pacients.Add(pacient);
                        Voids.BindData(listBox1, pacients);
                    }
                    govactina.Clear();
                    Voids.BindData(listBox2, govactina);
                }

            }
            else
            {
                MessageBox.Show("������ ��������� �� ���������� ����","�����");
            }
        }
    }
           
}
