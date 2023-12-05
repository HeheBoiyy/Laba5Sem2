namespace Laba5Sem2
{
    public partial class Вакцинация : Form
    {
        private List<PacientClass> pacients;
        private List<PacientClass> govactina = new List<PacientClass>();
        private List<PacientClass> sertificate = new List<PacientClass>();
        public Вакцинация()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pacients = new List<PacientClass>
            {
                new PacientClass("Дарбинян Давид Арманович",Vacitation.One),
                new PacientClass("Красноборов Евгений Евгеньевич",Vacitation.Zero),
                new PacientClass("Бельтюков Александр Николаевич",Vacitation.Zero),
                new PacientClass("Рыбин Максим Андреевич",Vacitation.Zero),
                new PacientClass("Савченко Александр Алексеевич",Vacitation.Zero),
                new PacientClass("Павленко Артур",Vacitation.Zero),
                new PacientClass("Сурин Никита Константинович",Vacitation.Zero)
            };
            listBox1.DataSource = pacients;
            listBox1.DisplayMember = "FullNameVacitation";    //
            listBox2.DataSource = govactina;                  // Привязка данных к listbox
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
                    MessageBox.Show("Выбранный пациент уже прошёл первичную вакцинацию", "Пациент с вакцинацией!");
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
                MessageBox.Show("Ничего не выбрано!", "Пустой выбор");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (((PacientClass)listBox1.SelectedItem).Vacitation == Vacitation.Zero)
                {
                    MessageBox.Show("Выбранный пациент не прошёл первичную вакцинацию", "Пациент без вакцинации");
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
                MessageBox.Show("Ничего не выбрано!", "Пустой выбор");
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
                MessageBox.Show("Пациенты отсутствуют!", "Пусто");
            }
        }
        Random random = new Random();
        Random strah = new Random();
        private void button4_Click(object sender, EventArgs e)
        {
            List<PacientClass> BUFER = new List<PacientClass>(); // Нужен для удаления сбежавших и прошедших первичную вакцинацию пациентов
            List<PacientClass> GETSERTIFICATE = new List<PacientClass>(); // Нужен для удаления пациентов получивших сертификат
            List<PacientClass> UBEZHALI = new List<PacientClass>(); // Список убежавших :)
            bool Ubezhal= false;

            if (govactina.Count!=0)
            {
                int vactina = random.Next(0, 2);
                if (vactina == 1) // Вакцина присутствует
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
                    foreach (PacientClass aboba in BUFER) // Удаление сбежавших и прошедших первичную вакцинацию пациентов
                    {
                        govactina.Remove(aboba);
                        Voids.BindData(listBox1, pacients);
                    }
                    foreach (PacientClass aboba1 in GETSERTIFICATE) // Удаление пациентов получивших сертификат
                    {
                        govactina.Remove(aboba1);
                    }
                    string ubezhavhie = "";
                    foreach (PacientClass aboba2 in UBEZHALI) // Данная функция бесполезна и сделана для прикола, можно удалить
                    {
                        ubezhavhie += aboba2.FullName + Environment.NewLine;
                    }
                    Voids.BindData(listBox2, govactina);
                    Voids.BindData(listBox1, pacients);


                    if (Ubezhal) // Проверка убежал ли кто то??
                    {
                        MessageBox.Show("ОДИН/ИЛИ НЕСКОЛЬКО ПАЦИЕНТОВ ИСПУГАЛИСЬ И УБЕЖАЛИ В СТРАХЕ!!! \nСписок трусов:\n" + ubezhavhie + "\n\nА в целом всё успешно )", "СТРАШНО СТРАШНО ОЧЕНЬ СТРАШНО");
                    }
                    else
                    {
                        MessageBox.Show("Вакцинация прошла успешно", "Успех");
                    }
                }
                else
                {
                    MessageBox.Show("Вакцин нет, их украл Шрек.");
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
                MessageBox.Show("Список пациентов на вакцинацию пуст","Пусто");
            }
        }
    }
           
}
