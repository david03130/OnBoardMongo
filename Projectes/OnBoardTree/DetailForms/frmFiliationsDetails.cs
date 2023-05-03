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
    public partial class frmFiliationsDetails : Form, IFormDetall
    {
        private readonly MongoDbConfig dbConfig;
        private readonly MongoAccess<Filiation> bbdd;

        public frmFiliationsDetails()
        {
            InitializeComponent();

            string dbUrl = ConfigurationManager.AppSettings["MongoConnectionString"].ToString();
            string dbName = ConfigurationManager.AppSettings["MongoDataBaseName"].ToString();
            dbConfig = new MongoDbConfig(dbUrl, dbName);
            bbdd = new MongoAccess<Filiation>(dbConfig, "Filiations");
        }

        public void CarregarDades(string id)
        {
            // Carregar les dades a partir del id.
            Filiation filiation = bbdd.SelectById(id);

            lbl_Description.Text = filiation.description;
        }
    }
}
