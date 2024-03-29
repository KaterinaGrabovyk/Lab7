using Lab7.DB;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {/*Додаток "Каталог Плантатора"
Створіть додаток для любителів садівництва для каталогізації рослин з інформацією про 
        вид, умови зростання, період цвітіння, потреби у воді та добривах.

*/
        PlantDBContext db;
        private BindingList<Plants> _plants;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.GridLines = true;
            listView1.FullRowSelect = true;


            listView1.View = View.Details;
            listView1.Scrollable = true;
            listView1.MultiSelect = false;
            listView1.Columns.Add("Id", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("Вид", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Умови зростання", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("Період цвітіння", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("Потреба у воді", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("Потреба у добриві",200, HorizontalAlignment.Center);

            db = new PlantDBContext();
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            _plants = db.Plant.Local.ToBindingList();
            _plants.RaiseListChangedEvents = true;
            _plants.ListChanged += _plants_ListChanged;
            db.Plant.Load();

        }
        private void _plants_ListChanged(object? sender, ListChangedEventArgs e)
        {
            listView1.Items.Clear();
            foreach (var plant in db.Plant.Local.ToList())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Clear();

                if (plant.Id == 0)
                {
                    item.SubItems[0].Text = "Додано:";
                }
                else
                {
                    item.SubItems[0].Text = "" + plant.Id;
                }
                item.SubItems.Add(plant.PlantKind);
                item.SubItems.Add(plant.UmoviZrost);
                item.SubItems.Add(plant.PeriodCvit);
                item.SubItems.Add(plant.WaterNeeds);
                item.SubItems.Add(plant.DobrivaNeeds);
                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text !="" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                db.Add(new Plants {PlantKind=textBox2.Text,UmoviZrost=textBox3.Text,PeriodCvit=textBox4.Text,WaterNeeds=textBox5.Text,DobrivaNeeds=textBox6.Text});
                db.SaveChanges();
                textBox2.Clear();
                textBox3.Clear(); 
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                MessageBox.Show("Дані додані. Таблиця оновилася");
            }
            else
            {
                MessageBox.Show("Треба вписати всі дані");
                return;
            }
        }
    }
}
