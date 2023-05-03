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

namespace OnBoardTree.DetailForms
{
    public partial class frmPlanetDetails : Form, IDetailForm
    {
        private readonly MongoDbConfig dbConfig;
        private readonly MongoAccess<Planet> bbdd;

        public frmPlanetDetails()
        {
            InitializeComponent();

            string dbUrl = ConfigurationManager.AppSettings["MongoConnectionString"].ToString();
            string dbName = ConfigurationManager.AppSettings["MongoDataBaseName"].ToString();
            dbConfig = new MongoDbConfig(dbUrl, dbName);
            bbdd = new MongoAccess<Planet>(dbConfig, "Planets");
        }

        public void LoadData(string id)
        {
            // Carregar les dades a partir del id.
            Planet planet = bbdd.SelectById(id);

            lbl_Name.Text = planet.name;
            lbl_Natives.Text = planet.natives;
        }
    }
}
