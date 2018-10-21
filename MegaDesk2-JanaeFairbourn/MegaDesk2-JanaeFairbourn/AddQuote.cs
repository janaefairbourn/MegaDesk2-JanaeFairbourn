using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk2_JanaeFairbourn
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();

            var materials = new List<Desk.SurfaceMaterial>();

            materials = Enum.GetValues(typeof(Desk.SurfaceMaterial))
                .Cast<Desk.SurfaceMaterial>()
                .ToList();

            surfaceInput.DataSource = materials;

            surfaceInput.SelectedIndex = -1;

            var shipping = new List<DeskQuote.Delivery>();

            shipping = Enum.GetValues(typeof(DeskQuote.Delivery))
                .Cast<DeskQuote.Delivery>()
                .ToList();

            timeInput.DataSource = shipping;

            timeInput.SelectedIndex = -1;

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void b1_cancelAddQuote_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void b1_getQuote_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameInput.Text == "" || surfaceInput.SelectedItem == null || timeInput.SelectedItem == null)
                {
                    throw new ArgumentNullException();
                }
            }
            catch (ArgumentNullException f)
            {
                MessageBox.Show("Fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            widthInput.ReadOnly = true;
            depthInput.ReadOnly = true;
            drawersInput.ReadOnly = true;
            surfaceInput.Enabled = false;
            timeInput.Enabled = false;
            nameInput.ReadOnly = true;

            decimal width = widthInput.Value;
            decimal depth = depthInput.Value;
            int drawers = (int)drawersInput.Value;
            Desk.SurfaceMaterial deskMaterial = (Desk.SurfaceMaterial)surfaceInput.SelectedItem;
            DeskQuote.Delivery shipping = (DeskQuote.Delivery)timeInput.SelectedItem;
            string name = nameInput.Text;
            DateTime date = new DateTime();

            Desk desk = new Desk(width, depth, drawers, deskMaterial);
            DeskQuote quote = new DeskQuote(desk, shipping, name, date);

            priceOutput.Text = quote.Price.ToString();
            priceOutput.Visible = true;
            priceLabel.Visible = true;


            string filepath = "quotes.json";
            if (File.Exists(filepath))
            {
                string text = File.ReadAllText(filepath);
                var list = JsonConvert.DeserializeObject<List<DeskQuote>>(text);
                list.Add(quote);
                var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
                File.WriteAllText(filepath, convertedJson);
            }
            else
            {
                List<DeskQuote> list = new List<DeskQuote>();
                list.Add(quote);
                var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
                File.WriteAllText(filepath, convertedJson);
            }


        }
    }
}
