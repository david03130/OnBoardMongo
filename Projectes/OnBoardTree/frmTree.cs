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

            LoadDropdown();
            LoadTreeView();
        }

        private const string dbUrl = "mongodb://localhost:27017";
        private const string dbName = "StarWars";
        private MongoDbConfig dbConfig;

        private void LoadDropdown()
        {
            cmb_Collections.Items.Add("");

            foreach (var item in dbConfig.DataBase.ListCollectionsAsync().Result.ToListAsync().Result)
            {
                cmb_Collections.Items.Add(item["name"].AsString);
            }
        }

        private void LoadTreeView()
        {
            MongoAccess<Planet> planets = new MongoAccess<Planet>(dbConfig, "Planets");
            planets.SelectAll().ForEach(x => tree_Documents.Nodes.Add(x.name));
        }
    }
}
