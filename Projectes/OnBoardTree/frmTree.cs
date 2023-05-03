using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDataAccess;
using MongoDB.Bson;
using MongoDB.Driver;
using StarWarsModels;
using OnBoardTree.DetailForms;
using System.Configuration;

namespace OnBoardTree
{
    public partial class frmTree : Form
    {
        private MongoDbConfig dbConfig;

        public frmTree()
        {
            InitializeComponent();

            string dbUrl = ConfigurationManager.AppSettings["MongoConnectionString"].ToString();
            string dbName = ConfigurationManager.AppSettings["MongoDataBaseName"].ToString();
            dbConfig = new MongoDbConfig(dbUrl, dbName);

            CarregarDropdownCollections();
        }

        private IFormDetall fromDetallActual;

        enum NomsColleccions
        {
            Filiations,
            Planets,
            Regions
        }

        private void CarregarDropdownCollections()
        {
            cmb_Collections.Items.Add("");

            foreach (var item in dbConfig.DataBase.ListCollectionsAsync().Result.ToListAsync().Result)
            {
                cmb_Collections.Items.Add(item["name"].AsString);
            }
        }

        private void CarregarTreeviewLateral(NomsColleccions collName)
        {
            if (collName == NomsColleccions.Filiations)
            {
                MongoAccess<Filiations> filiations = new MongoAccess<Filiations>(dbConfig, NomsColleccions.Filiations.ToString());
                filiations.SelectAll().ForEach(x => tree_Documents.Nodes.Add(x.Id.ToString(), x.description));
            }
            else if (collName == NomsColleccions.Regions)
            {
                MongoAccess<StarWarsModels.Region> regions = new MongoAccess<StarWarsModels.Region>(dbConfig, NomsColleccions.Regions.ToString());
                regions.SelectAll().ForEach(x => tree_Documents.Nodes.Add(x.Id.ToString(), x.nameRegion));
            }
            else if (collName == NomsColleccions.Planets)
            {
                MongoAccess<Planet> planets = new MongoAccess<Planet>(dbConfig, NomsColleccions.Planets.ToString());
                planets.SelectAll().ForEach(x => tree_Documents.Nodes.Add(x.Id.ToString(), x.name));
            }
        }

        private void CarregarFormDetall(NomsColleccions collName)
        {
            Form form;

            pnl_Details.Controls.Clear();

            // TODO: Cambiar esto y poner los formularios pertinentes.
            if (collName == NomsColleccions.Filiations)
            {
                form = new frmPlanetDetails();
            }
            else if (collName == NomsColleccions.Regions)
            {
                form = new frmPlanetDetails();
            }
            else
            {
                form = new frmPlanetDetails();
            }

            form.TopLevel = false;
            pnl_Details.Controls.Add(form);
            form.WindowState = FormWindowState.Maximized;
            form.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            form.Show();

            fromDetallActual = (IFormDetall)form;
        }

        #region Designer Events
        private void cmb_Collections_SelectedIndexChanged(object sender, EventArgs e)
        {
            tree_Documents.Nodes.Clear();
            if (cmb_Collections.SelectedItem.ToString() != string.Empty)
            {
                NomsColleccions selectedCollection = (NomsColleccions)Enum.Parse(typeof(NomsColleccions), cmb_Collections.SelectedItem.ToString());
                CarregarTreeviewLateral(selectedCollection);
                CarregarFormDetall(selectedCollection);
            }
        }

        private void tree_Documents_AfterSelect(object sender, TreeViewEventArgs e)
        {
            fromDetallActual.CarregarDades(tree_Documents.SelectedNode.Name);
        }

        #endregion
    }
}
