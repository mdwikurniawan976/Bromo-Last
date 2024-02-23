using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo.Masters
{
    public partial class tes : Form
    {
        BromoAirlinesEntities1 db = new BromoAirlinesEntities1();

        public tes()
        {
            InitializeComponent();
        }

        private void tes_Load(object sender, EventArgs e)
        {
            //int currentid = (bindingSource1.Current as KodePromo)?.ID ?? 0;
            AutoCompleteStringCollection c = new AutoCompleteStringCollection();
            List<Bandara> b = db.Bandara.ToList();
            foreach (var item in b)
            {
                c.Add(item.Nama);
            }
            textBox1.AutoCompleteCustomSource = c;
        }
        bool unik(string nama,int id)
        {
            if(id == 0)
            {
                return !db.KodePromo.Any(f => f.Kode == nama);
            }
            else
            {
                return !db.KodePromo.Any(f => f.Kode == nama && f.ID == id);
            }
        }
    }
}
