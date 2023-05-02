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

            LoadCollectionsDropdown();
        }

        private IDetailForm currentDetailForm;

        enum CollectionName
        {
            Filiations,
            Planets,
            Regions
        }

        private void LoadCollectionsDropdown()
        {
            cmb_Collections.Items.Add("");

            foreach (var item in dbConfig.DataBase.ListCollectionsAsync().Result.ToListAsync().Result)
            {
                cmb_Collections.Items.Add(item["name"].AsString);
            }
        }

        private void LoadLateralTreeView(CollectionName collName)
        {
            if (collName == CollectionName.Filiations)
            {
                MongoAccess<Filiations> filiations = new MongoAccess<Filiations>(dbConfig, CollectionName.Filiations.ToString());
                filiations.SelectAll().ForEach(x => tree_Documents.Nodes.Add(x.Id.ToString(), x.description));
            }
            else if (collName == CollectionName.Regions)
            {
                MongoAccess<StarWarsModels.Region> regions = new MongoAccess<StarWarsModels.Region>(dbConfig, CollectionName.Regions.ToString());
                regions.SelectAll().ForEach(x => tree_Documents.Nodes.Add(x.Id.ToString(), x.nameRegion));
            }
            else if (collName == CollectionName.Planets)
            {
                MongoAccess<Planet> planets = new MongoAccess<Planet>(dbConfig, CollectionName.Planets.ToString());
                planets.SelectAll().ForEach(x => tree_Documents.Nodes.Add(x.Id.ToString(), x.name));
            }
        }

        private void LoadDetailForm(CollectionName collName)
        {
            Form form;

            pnl_Details.Controls.Clear();

            if (collName == CollectionName.Filiations)
            {
                form = new frmPlanetDetails();
            }
            else if (collName == CollectionName.Regions)
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

            currentDetailForm = (IDetailForm)form;
        }

        #region Designer Events
        private void cmb_Collections_SelectedIndexChanged(object sender, EventArgs e)
        {
            tree_Documents.Nodes.Clear();
            if (cmb_Collections.SelectedItem.ToString() != string.Empty)
            {
                CollectionName selectedCollection = (CollectionName)Enum.Parse(typeof(CollectionName), cmb_Collections.SelectedItem.ToString());
                LoadLateralTreeView(selectedCollection);
                LoadDetailForm(selectedCollection);
            }
        }

        private void tree_Documents_AfterSelect(object sender, TreeViewEventArgs e)
        {
            currentDetailForm.LoadData(tree_Documents.SelectedNode.Name);
        }

        #endregion
    }
}
