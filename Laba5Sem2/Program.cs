using System.Windows.Forms;

namespace Laba5Sem2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Вакцинация());
        }
    }
    public class Voids
    {
        public static void BindData(ListBox list,List<PacientClass> pacient)
        {
            list.DataSource = null;
            list.DataSource = pacient;
            list.DisplayMember = "FullNameVacitation";
        }
    }
}