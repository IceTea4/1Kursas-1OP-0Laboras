using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace ValidWeb
{
    public partial class Forma1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillAge();
            FillTableHeader();

            List<Dalyvis> dalyviai = GetRegistrations();
            FillRegistrationsTable(dalyviai);
        }

        private void FillAge()
        {
            if (DropDownList1.Items.Count == 0)
            {
                ListItem none = new ListItem("-");
                none.Value = "0";
                DropDownList1.Items.Add(none);
                for (int i = 14; i <= 25; i++)
                {
                    DropDownList1.Items.Add(i.ToString());
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Dalyvis> dalyviai = GetRegistrations();
            
            Dalyvis dalyvis = CreateNewRegistrationRecord();
            if (dalyvis == null)
            {
                return;
            }
            dalyviai.Add(dalyvis);

            TableRow row = CreateRegistrationRow(dalyviai.Count, dalyvis);
            Table1.Rows.Add(row);
        }

        private List<Dalyvis> GetRegistrations()
        {
            List<Dalyvis> dalyviai = (List<Dalyvis>)Session["dalyviai"];

            if (dalyviai == null)
            {
                dalyviai = new List<Dalyvis>();
                Session["dalyviai"] = dalyviai;
            }

            return dalyviai;
        }

        private Dalyvis CreateNewRegistrationRecord()
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                return null;
            }

            if (!IsTextBox3Valid())
            {
                return null;
            }

            return new Dalyvis(
                TextBox1.Text, 
                TextBox2.Text, 
                TextBox3.Text, 
                int.Parse(DropDownList1.SelectedItem.Value), 
                CollectSelectedLanguages());
        }

        private List<String> CollectSelectedLanguages()
        {
            List<String> languages = new List<String>();

            foreach (ListItem language in CheckBoxList1.Items)
            {
                if (language.Selected)
                {
                    languages.Add(language.Text);
                }
            }

            return languages;
        }

        private void FillTableHeader()
        {
            TableCell cell = new TableCell();
            cell.Text = "Nr.";
            TableCell cellname = new TableCell();
            cellname.Text = "Vardas";
            TableCell cellsurname = new TableCell();
            cellsurname.Text = "Pavardė";
            TableCell cellschool = new TableCell();
            cellschool.Text = "Mokykla";
            TableCell cellage = new TableCell();
            cellage.Text = "Amžius";
            TableCell celllanguages = new TableCell();
            celllanguages.Text = "Programavimo kalbos";

            TableRow row = new TableRow();
            row.Cells.Add(cell);
            row.Cells.Add(cellname);
            row.Cells.Add(cellsurname);
            row.Cells.Add(cellschool);
            row.Cells.Add(cellage);
            row.Cells.Add(celllanguages);

            Table1.Rows.Add(row);
        }

        private void FillRegistrationsTable(List<Dalyvis> dalyviai)
        {
            int number = 0;

            foreach(Dalyvis dalyvis in dalyviai)
            {
                number++;

                TableRow row = CreateRegistrationRow(number, dalyvis);
                Table1.Rows.Add(row);
            }
        }

        private TableRow CreateRegistrationRow(int number, Dalyvis dalyvis)
        {
            TableCell cell = new TableCell();
            cell.Text = number.ToString();
            TableCell cellname = new TableCell();
            cellname.Text = dalyvis.Name;
            TableCell cellsurname = new TableCell();
            cellsurname.Text = dalyvis.Surname;
            TableCell cellschool = new TableCell();
            cellschool.Text = dalyvis.School;
            TableCell cellage = new TableCell();
            cellage.Text = dalyvis.Age.ToString();
            TableCell celllanguage = new TableCell();
            celllanguage.Text = dalyvis.JoinLanguages();

            TableRow row = new TableRow();
            row.Cells.Add(cell);
            row.Cells.Add(cellname);
            row.Cells.Add(cellsurname);
            row.Cells.Add(cellschool);
            row.Cells.Add(cellage);
            row.Cells.Add(celllanguage);

            return row;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["dalyviai"] = new List<Dalyvis>();
            Table1.Rows.Clear();
            FillTableHeader();
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = IsTextBox3Valid();
        }
        private bool IsTextBox3Valid()
        {
            string pattern = "\\w";
            return Regex.Matches(TextBox3.Text, pattern).Count > 0;
        }
    }

    public class Dalyvis
    {
        public string Name { get; }
        public string Surname { get; }
        public string School { get; }
        public int Age { get; }
        public List<String> Languages { get; }

        public Dalyvis(string name, string surname, string school, int age, List<String> languages)
        {
            this.Name = name;
            this.Surname = surname;
            this.School = school;
            this.Age = age;
            this.Languages = languages;
        }

        public String JoinLanguages()
        {
            string joined = "";
            int x = 0;

            foreach (String language in Languages)
            {
                x++;

                if (Languages.Count > x)
                {
                    joined += language.ToString() + "; ";
                }
                else
                {
                    joined += language.ToString();
                }
            }

            return joined;
        }
    }
}