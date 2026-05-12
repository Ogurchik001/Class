using Lukianov_Class.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lukianov_Class.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для JournalPage.xaml
    /// </summary>
    public partial class JournalPage : Page
    {
        public JournalPage()
        {
            InitializeComponent();
            JournalLV.ItemsSource = App.context.Journal.ToList();

            ClassCmb.SelectedValuePath = "ClassID";
            ClassCmb.DisplayMemberPath = "Name";
            ClassCmb.ItemsSource = App.context.Class.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ClassTb.Text)|| string.IsNullOrEmpty(KgTb.Text)|| string.IsNullOrEmpty(ClassCmb.Text)|| string.IsNullOrEmpty(DateDp.Text))
            {
                MessageBox.Show("Заполните все поля!", "Внимание" );
            }
            else
            {
                Journal newJournal = new Journal()
                {
                    DateEvent = (DateTime)DateDp.SelectedDate,
                    Class = ClassCmb.SelectedItem as Class,
                    KiloFlourPaper = KgTb.Text

                };
                App.context.Journal.Add(newJournal);
                App.context.SaveChanges();
                MessageBox.Show("Запись добавлена");
            }
        }
    }
}
