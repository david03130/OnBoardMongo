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

namespace OnBoardTree
{
    public partial class frmTree : Form
    {
        public frmTree()
        {
            InitializeComponent();

            dbConfig = new MongoDbConfig(dbUrl, dbName);

            LoadCollectionsDropdown();
        }

        enum CollectionName
        {
            Filiations,
            HyperspaceRoutes,
            Planets,
            Regions
        }

        private const string dbUrl = "mongodb://localhost:27017";
        private const string dbName = "StarWars";
        private MongoDbConfig dbConfig;

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
                filiations.SelectAll().ForEach(x => tree_Documents.Nodes.Add(x.description));
            }
            else if (collName == CollectionName.HyperspaceRoutes)
            {
                MongoAccess<HyperspaceRoutes> hyperspaceRoutes = new MongoAccess<HyperspaceRoutes>(dbConfig, CollectionName.HyperspaceRoutes.ToString());
                hyperspaceRoutes.SelectAll().ForEach(x => tree_Documents.Nodes.Add(x.nameRoute));
            }
            else if (collName == CollectionName.Regions)
            {
                MongoAccess<StarWarsModels.Region> regions = new MongoAccess<StarWarsModels.Region>(dbConfig, CollectionName.Regions.ToString());
                regions.SelectAll().ForEach(x => tree_Documents.Nodes.Add(x.nameRegion));
            }
            else if (collName == CollectionName.Planets)
            {
                MongoAccess<Planet> planets = new MongoAccess<Planet>(dbConfig, CollectionName.Planets.ToString());
                planets.SelectAll().ForEach(x => tree_Documents.Nodes.Add(x.name));
            }
        }


        private void cmb_Collections_SelectedIndexChanged(object sender, EventArgs e)
        {
            tree_Documents.Nodes.Clear();
            if (cmb_Collections.SelectedItem.ToString() != string.Empty)
            {
                LoadLateralTreeView((CollectionName)Enum.Parse(typeof(CollectionName), cmb_Collections.SelectedItem.ToString()));
            }
        }
    }
}
