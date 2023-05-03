using MongoDataAccess;
using StarWarsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Region = StarWarsModels.Region;

namespace OnBoardTree.DetailForms
{
    public partial class frmRegionsDetails : Form, IFormDetall
    {
        private readonly MongoDbConfig dbConfig;
        private readonly MongoAccess<Region> bbdd;

        public frmRegionsDetails()
        {
            InitializeComponent();

            string dbUrl = ConfigurationManager.AppSettings["MongoConnectionString"].ToString();
            string dbName = ConfigurationManager.AppSettings["MongoDataBaseName"].ToString();
            dbConfig = new MongoDbConfig(dbUrl, dbName);
            bbdd = new MongoAccess<Region>(dbConfig, "Regions");
        }

        public void CarregarDades(string id)
        {
            // Carregar les dades a partir del id.
            Region region = bbdd.SelectById(id);

            lbl_Name.Text = region.nameRegion;
            lbl_Description.Text = region.descriptionRegion;
        }
    }
}
