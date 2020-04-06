using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using Xamarin.Essentials;

namespace SqlEx
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
       private SQLiteConnection conn;
      private int Empid;
        public MainPage()
        {
            InitializeComponent();

            conn = DependencyService.Get<ISqliteConnection>().GetConnection();
            addTable();

            btnAddEmp.Clicked += BtnAddEmp_Clicked;


            bindEmpData();

            //List<string> numbers = new List<string>();
            //numbers.Add("");
            //numbers.Add("");

            //var messsage = new SmsMessage("",numbers);
        }

        private void BtnAddEmp_Clicked(object sender, EventArgs e)
        {
            if(etEmpName.Text!=null && etEmpName.Text.Length>0 && etEmpAddress.Text != null && etEmpAddress.Text.Length > 0)
            {
                Employee objEmployee = new Employee();
                objEmployee.EmpId = 1;
                objEmployee.EmpName = etEmpName.Text;
                objEmployee.EmpAddress = etEmpAddress.Text;

                int i = conn.Insert(objEmployee);
                if (i > 0)
                {
                    DisplayAlert("Add Emp", "Employee Record added successfully", "Ok");
                }
                else
                {
                    DisplayAlert("Add Emp", "Employee Record added failed, Please try again", "Ok");
                }
                bindEmpData();
            }
            else
            {
                DisplayAlert("Add Emp", "Fill all required fields", "Ok");
            }


           
        }

       private void bindEmpData()
        {
            var empData = conn.Table<Employee>().ToList();                                    //??????????????????????????????????///
            lblEmpList.ItemsSource = empData;

            lblEmpList.ItemSelected += LblEmpList_ItemSelected;
        }

        private void LblEmpList_ItemSelected(object sender, SelectedItemChangedEventArgs e)                  //???????????????????????///
        {
            var empItem = e.SelectedItem as Employee;
            Empid = empItem.EmpId;

        }

        private void addTable()
        {
            conn.CreateTable<Employee>();
        }
    }
}
