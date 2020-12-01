using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Globalization;
using System.IO;

namespace Pinhouse
{
    public partial class Form1 : Form
    {
        EmployeeContext eContext = new EmployeeContext();
        CultureInfo provider = CultureInfo.InvariantCulture;
        CustomerContext cContext = new CustomerContext();
        StreamReader fileToPrint;
        Font printFont;
        bool isNew = true;  
        const string customerReport = "customers.txt";
        const string employeeSchedule = "employee_schedule.txt";
        public Form1()
        {
            InitializeComponent();
            eContext.Database.Migrate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillEmployeeListBox();
            FillCustomerListBox();
        }

        private void FillEmployeeListBox()
        {
            employeeList.Items.Clear();
            scheduledEmployeeList.Items.Clear();
            foreach (var employee in GetEmployee())
            {
                employeeList.Items.Add(employee.FullName());
                scheduledEmployeeList.Items.Add(employee.FullName());
            }
        }


        private void NewEmployeeItem()
        {
            int newEmployeeIndex = 0;
            employeeList.Items.Add("New Employee");
            int count = employeeList.Items.Count;
            newEmployeeIndex = count - 1;
            employeeList.SelectedIndex = newEmployeeIndex;
        }

        private void NewCustomerItem()
        {
            int newCustomerIndex = 0;
            customerList.Items.Add("New Customer");
            int count = customerList.Items.Count;
            newCustomerIndex = count - 1;
            customerList.SelectedIndex = newCustomerIndex;
        }

        public Employee GetEmployeeWhereName(string employeeFirstName, string employeeLastName)
        {
            Employee employee = eContext.Employee.Where(Employee => Employee.FirstName == employeeFirstName & Employee.LastName == employeeLastName).FirstOrDefault();
            return employee;
        }

        public IEnumerable<Employee> GetEmployee()
        {
            return from employee 
                   in eContext.Employee
                   orderby employee.FirstName
                   select employee;
        }
        public IEnumerable<Customer> GetCustomer()
        {
            return from customer
                   in cContext.Customer
                   orderby customer.FirstName
                   select customer;
        }

        public IEnumerable<Customer> GetCustomerByTime()
        {
            return from customer
                   in cContext.Customer
                   orderby customer.Time
                   select customer;
        }
        private void eUpdateInfoWhereName(string firstName, string lastName)
        {
            Employee employee = GetEmployeeWhereName(firstName, lastName);
            employee.FirstName = eFirstNameBox.Text;
            employee.LastName = eLastNameBox.Text;
            employee.Dob = eDobMasked.Text;
            employee.Phone = ePhoneMasked.Text;
            employee.Street = eStreetBox.Text;
            employee.City = eCityBox.Text;
            employee.State = eStateCombo.Text;
            employee.ZipCode = eZipCodeMasked.Text;
            eContext.SaveChanges();
            FillEmployeeListBox();
        }
        private void eUpdateScheduleWhereName(string firstName, string lastName)
        {
            Employee employee = GetEmployeeWhereName(firstName, lastName);
            employee.Monday = $"{startMondayTime.Text}|{startMondayKind.Text}|{stopMondayTime.Text}|{stopMondayKind.Text}";
            employee.Tuesday = $"{startTuesdayTime.Text}|{startTuesdayKind.Text}|{stopTuesdayTime.Text}|{stopTuesdayKind.Text}";
            employee.Wednesday = $"{startWednesdayTime.Text}|{startWednesdayKind.Text}|{stopWednesdayTime.Text}|{stopWednesdayKind.Text}";
            employee.Thursday = $"{startThursdayTime.Text}|{startThursdayKind.Text}|{stopThursdayTime.Text}|{stopThursdayKind.Text}";
            employee.Friday = $"{startFridayTime.Text}|{startFridayKind.Text}|{stopFridayTime.Text}|{stopFridayKind.Text}";
            employee.Saturday = $"{startSaturdayTime.Text}|{startSaturdayKind.Text}|{stopSaturdayTime.Text}|{stopSaturdayKind.Text}";
            employee.Sunday = $"{startSundayTime.Text}|{startSundayKind.Text}|{stopSundayTime.Text}|{stopSundayKind.Text}";
            eContext.SaveChanges();
            FillEmployeeListBox();
        }

        private void InsertEmployee(Employee employee)
        {
            eContext.Employee.Add(employee);
            eContext.SaveChanges();
            FillEmployeeListBox();
        }



        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            if (employeeList.SelectedItem != null)
            {
                eContext.Employee.Remove(GetEmployeeWhereName(employeeList.SelectedItem.ToString().Split(' ')[0], employeeList.SelectedItem.ToString().Split(' ')[1]));
                eContext.SaveChanges();
                eClearBoxes();
                FillEmployeeListBox();
                isNew = true;
            }
            else
            {
                eContext.Employee.Remove(GetEmployeeWhereName(eFirstNameBox.Text, eLastNameBox.Text));
                eContext.SaveChanges();
                eClearBoxes();
                FillEmployeeListBox();
                isNew = true;
            }
        }

        private Employee NewEmployee()
        {
            Employee employee = new Employee();
            employee.FirstName = eFirstNameBox.Text;
            employee.LastName = eLastNameBox.Text;
            employee.Dob = eDobMasked.Text;
            employee.Phone = ePhoneMasked.Text;
            employee.Street = eStreetBox.Text;
            employee.City = eCityBox.Text;
            employee.State = eStateCombo.Text;
            employee.ZipCode = eZipCodeMasked.Text;
            eContext.SaveChanges();
            return employee;
        }

        private void eSaveEmployee_Click(object sender, EventArgs e)
        {
            if (isNew == true)
            {
                InsertEmployee(NewEmployee());
                isNew = false;
            }
            else
            {
                if (employeeList.SelectedItem == null)
                    eUpdateInfoWhereName(eFirstNameBox.Text,eLastNameBox.Text);
                else
                    eUpdateInfoWhereName(employeeList.SelectedItem.ToString().Split(' ')[0], employeeList.SelectedItem.ToString().Split(' ')[1]);
            }
        }

        private void employeeSelected(object sender, EventArgs e)
        {
            FillEmployeeBoxes();
            isNew = false;
        }

        private void FillEmployeeBoxes()
        {
            if (employeeList.SelectedItem == null)
            {
                //MessageBox.Show("An unexpected error has occured. Please make sure you selected an employee.");
                //When a user trys to select nothing it throws an erorr
                //Throw a quite error so the user can proceed without being bothered
            }
            else
            {
                if (employeeList.SelectedItem.ToString() != "New Employee")
                {
                    Employee employee = GetEmployeeWhereName(employeeList.SelectedItem.ToString().Split(' ')[0], employeeList.SelectedItem.ToString().Split(' ')[1]);
                    #region populating boxes
                    eFirstNameBox.Text = employee.FirstName;
                    eLastNameBox.Text = employee.LastName;
                    eDobMasked.Text = employee.Dob;
                    ePhoneMasked.Text = employee.Phone.ToString();
                    eStreetBox.Text = employee.Street;
                    eCityBox.Text = employee.City;
                    eStateCombo.Text = employee.State;
                    eZipCodeMasked.Text = employee.ZipCode.ToString();
                    #endregion
                }
            }
        }

        private void eClearBoxes()
        {
            TextBox[] textBoxes = { eFirstNameBox, eLastNameBox ,eStreetBox, eCityBox};
            MaskedTextBox[] maskedBoxes = { eDobMasked,ePhoneMasked,eZipCodeMasked };
            ComboBox[] comboBoxes = { eStateCombo };

            foreach (TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }

            foreach (MaskedTextBox maskedTextBox in maskedBoxes)
            {
                maskedTextBox.Clear();
            }

            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.SelectedItem = null;
            }

        }

        private void newEmployee_Click(object sender, EventArgs e)
        {
            eClearBoxes();
            NewEmployeeItem();
            isNew = true;
        }

        private void cSaveCustomer_Click(object sender, EventArgs e)
        {
            if (isNew == true)
            {
                InsertCustomer(NewCustomer());
                isNew = false;
            }
            else
            {
                if (customerList.SelectedItem == null)
                    cUpdateWhereName(cFirstNameBox.Text, cLastNameBox.Text);
                else
                    cUpdateWhereName(customerList.SelectedItem.ToString().Split(' ')[0], customerList.SelectedItem.ToString().Split(' ')[1]);
            }
        }

        private Customer NewCustomer()
        {
            Customer customer = new Customer(); 
            customer.FirstName = cFirstNameBox.Text;
            customer.LastName = cLastNameBox.Text;
            customer.Date = cDateMasked.Text;
            customer.Time = DateTime.ParseExact(cTimeMasked.Text + " " + cTimeCombo.Text, "hh:mm tt", provider);
            cContext.SaveChanges();
            return customer;
        }

        private void InsertCustomer(Customer customer)
        {
            cContext.Customer.Add(customer);
            cContext.SaveChanges();
            FillCustomerListBox();
        }

        private void FillCustomerBoxes()
        {
            if (customerList.SelectedItem == null)
            {
                //MessageBox.Show("An unexpected error has occured. Please make sure you selected an employee.");
                //When a user trys to select nothing it throws an erorr
                //Throw a quite error so the user can proceed without being bothered
            }
            else
            {
                if (customerList.SelectedItem.ToString() != "New Customer")
                {
                    Customer customer = GetCustomerWhereName(customerList.SelectedItem.ToString().Split(' ')[0], customerList.SelectedItem.ToString().Split(' ')[1]);
                    #region populating boxes
                    cFirstNameBox.Text = customer.FirstName;
                    cLastNameBox.Text = customer.LastName;
                    cDateMasked.Text = customer.Date;
                    cTimeMasked.Text = customer.Time.ToString("hh:mm");
                    cTimeCombo.Text = customer.Time.ToString("tt");
                    #endregion
                }
            }
        }

        private Customer GetCustomerWhereName(string customerFirstName, string customerLastName)
        {
            Customer customer = cContext.Customer.Where(Customer => Customer.FirstName == customerFirstName & Customer.LastName == customerLastName).FirstOrDefault();
            return customer;
        }

        private void cUpdateWhereName(string firstName, string lastName)
        {
            Customer customer = GetCustomerWhereName(firstName, lastName);
            customer.FirstName = cFirstNameBox.Text;
            customer.LastName = cLastNameBox.Text;
            customer.Date = cDateMasked.Text;
            customer.Time = DateTime.ParseExact(cTimeMasked.Text + " " + cTimeCombo.Text, "hh:mm tt", provider);
            cContext.SaveChanges();
            FillCustomerListBox();
        }

        private void FillCustomerListBox()
        {
            customerList.Items.Clear();
            foreach (var customer in GetCustomer())
            {
                customerList.Items.Add(customer.FullName());
            }
        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            if (customerList.SelectedItem != null)
            {
                cContext.Customer.Remove(GetCustomerWhereName(customerList.SelectedItem.ToString().Split(' ')[0], customerList.SelectedItem.ToString().Split(' ')[1]));
                cContext.SaveChanges();
                cClearBoxes();
                FillCustomerListBox();
                isNew = true;
            }
            else
            {
                cContext.Customer.Remove(GetCustomerWhereName(cFirstNameBox.Text, cLastNameBox.Text));
                cContext.SaveChanges();
                cClearBoxes();
                FillCustomerListBox();
                isNew = true;
            }
        }

        private void newCustomer_Click(object sender, EventArgs e)
        {
            cClearBoxes();
            NewCustomerItem();
            isNew = true;
        }

        private void cClearBoxes()
        {
            TextBox[] textBoxes = { cFirstNameBox, cLastNameBox };
            ComboBox[] comboBoxes = { cTimeCombo };
            MaskedTextBox[] maskedBoxes = { cDateMasked, cTimeMasked };
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }
            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.SelectedItem = null;
            }
            foreach (MaskedTextBox maskedBox in maskedBoxes)
            {
                maskedBox.Clear();
            }
        }
        private void customerSelected(object sender, EventArgs e)
        {
            FillCustomerBoxes();
            isNew = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete(customerReport);
            foreach (Customer item in GetCustomerByTime())
            {
                using (StreamWriter s = File.AppendText(customerReport))
                {
                    s.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t{Application.CompanyName}\n\n\n");
                    s.WriteLine($"{item.FirstName} {item.LastName} {item.Date} {item.Time.ToString("hh:mm tt")}\n");
                }
            }
            string printPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fileToPrint = new StreamReader(customerReport);
            printFont = new Font("Arial", 12);
            printDocument1.PrintPage += printDocument1_PrintPage;
            printDocument1.Print();
            fileToPrint.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float yPos = 0f;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
            while (count < linesPerPage)
            {
                line = fileToPrint.ReadLine();
                if (line == null)
                {
                    break;
                }
                yPos = topMargin + count * printFont.GetHeight(e.Graphics);
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }
            if (line != null)
            {
                e.HasMorePages = true;
            }
        }

        private void saveScheduleButton_Click(object sender, EventArgs e)
        {
            eUpdateScheduleWhereName(scheduledEmployeeList.SelectedItem.ToString().Split(' ')[0], scheduledEmployeeList.SelectedItem.ToString().Split(' ')[1]);
            FillEmployeeListBox();
        }

        private void scheduledEmployeeList_SelectedValueChanged(object sender, EventArgs e)
        {
            FillScheduleBoxes();
        }

        private void FillScheduleBoxes()
        {
            if (scheduledEmployeeList.SelectedItem == null)
            {
                //nothing is selected but it throws an error, so just ignore.
            }
            else
            {
                Employee employee = GetEmployeeWhereName(scheduledEmployeeList.SelectedItem.ToString().Split(' ')[0], scheduledEmployeeList.SelectedItem.ToString().Split(' ')[1]);
                if (employee.Monday == null)
                {
                    //user is requesting to add a schedule to the employee so nothing will happen.
                }
                else
                {
                    #region FillStartTime
                    startMondayTime.Text = employee.Monday.Split('|')[0];
                    startTuesdayTime.Text = employee.Tuesday.Split('|')[0];
                    startWednesdayTime.Text = employee.Wednesday.Split('|')[0];
                    startThursdayTime.Text = employee.Thursday.Split('|')[0];
                    startFridayTime.Text = employee.Friday.Split('|')[0];
                    startSaturdayTime.Text = employee.Saturday.Split('|')[0];
                    startSundayTime.Text = employee.Sunday.Split('|')[0];
                    #endregion
                    #region FillStartKind
                    startMondayKind.Text = employee.Monday.Split('|')[1];
                    startTuesdayKind.Text = employee.Tuesday.Split('|')[1];
                    startWednesdayKind.Text = employee.Wednesday.Split('|')[1];
                    startThursdayKind.Text = employee.Thursday.Split('|')[1];
                    startFridayKind.Text = employee.Friday.Split('|')[1];
                    startSaturdayKind.Text = employee.Saturday.Split('|')[1];
                    startSundayKind.Text = employee.Sunday.Split('|')[1];
                    #endregion
                    #region FillStopTime
                    stopMondayTime.Text = employee.Monday.Split('|')[2];
                    stopTuesdayTime.Text = employee.Tuesday.Split('|')[2];
                    stopWednesdayTime.Text = employee.Wednesday.Split('|')[2];
                    stopThursdayTime.Text = employee.Thursday.Split('|')[2];
                    stopFridayTime.Text = employee.Friday.Split('|')[2];
                    stopSaturdayTime.Text = employee.Saturday.Split('|')[2];
                    stopSundayTime.Text = employee.Sunday.Split('|')[2];
                    #endregion
                    #region FillStopKind
                    stopMondayKind.Text = employee.Monday.Split('|')[3];
                    stopTuesdayKind.Text = employee.Tuesday.Split('|')[3];
                    stopWednesdayKind.Text = employee.Wednesday.Split('|')[3];
                    stopThursdayKind.Text = employee.Thursday.Split('|')[3];
                    stopFridayKind.Text = employee.Friday.Split('|')[3];
                    stopSaturdayKind.Text = employee.Saturday.Split('|')[3];
                    stopSundayKind.Text = employee.Sunday.Split('|')[3];
                    #endregion
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            File.Delete(employeeSchedule);
            foreach (Employee item in GetEmployee())
            {
                using (StreamWriter s = File.AppendText(employeeSchedule))
                {
                    s.WriteLine($"\n\t\t\t\t\t\t{Application.CompanyName}\n\n\n");
                    s.WriteLine($"{item.FirstName} {item.LastName}\n"
                        + $"\t\t\t\t Monday: {item.Monday.Split('|')[0] + " " + item.Monday.Split('|')[1]} - {item.Monday.Split('|')[2] + item.Monday.Split('|')[3]}\n"
                        + $"\t\t\t\t Tuesday: {item.Tuesday.Split('|')[0] + " " + item.Tuesday.Split('|')[1]} - {item.Tuesday.Split('|')[2] + item.Tuesday.Split('|')[3]}\n"
                        + $"\t\t\t\t Wednesday: {item.Wednesday.Split('|')[0] + " " + item.Wednesday.Split('|')[1]} - {item.Wednesday.Split('|')[2] + item.Wednesday.Split('|')[3]}\n"
                        + $"\t\t\t\t Thursday: {item.Thursday.Split('|')[0] + " " + item.Thursday.Split('|')[1]} - {item.Thursday.Split('|')[2] + item.Thursday.Split('|')[3]}\n"
                        + $"\t\t\t\t Friday: {item.Friday.Split('|')[0] + " " + item.Friday.Split('|')[1]} - {item.Friday.Split('|')[2] + item.Friday.Split('|')[3]}\n"
                        + $"\t\t\t\t Saturday: {item.Saturday.Split('|')[0] + " " + item.Saturday.Split('|')[1]} - {item.Saturday.Split('|')[2] + item.Saturday.Split('|')[3]}\n"
                        + $"\t\t\t\t Sunday: {item.Sunday.Split('|')[0] + " " + item.Sunday.Split('|')[1]} - {item.Sunday.Split('|')[2] + item.Sunday.Split('|')[3]}\n");
                }
            }
            string printPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fileToPrint = new StreamReader(employeeSchedule);
            printFont = new Font("Arial", 12);
            printDocument1.PrintPage += printDocument1_PrintPage;
            printDocument1.Print();
            fileToPrint.Close();
        }
    }
}
