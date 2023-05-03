using MongoDataAccess;
using StarWarsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
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
        private readonly string rutaDirImatges = Directory.GetCurrentDirectory() + "\\..\\..\\..\\..\\Imatges\\";

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
            lbl_ErrorImatge.Visible = false;
            // Carregar les dades a partir del id.
            Region region = bbdd.SelectById(id);

            lbl_Name.Text = region.nameRegion;
            lbl_Description.Text = region.descriptionRegion;

            try
            {
                // D'aquesta manera ens asegurem de que encara que la extensió sigui diferent, mentre
                // el nom de la imatge sigui el mateix, aquesta es mostrará.
                string nomImatge = SepararExtensio(region.mapRegion);
                nomImatge = File.Exists($"{rutaDirImatges}{nomImatge}.jpg") ?
                            $"{rutaDirImatges}{nomImatge}.jpg" :
                            $"{rutaDirImatges}{nomImatge}.png";

                pic_Map.Image = Image.FromFile(nomImatge);
            }
            catch (Exception)
            {
                lbl_ErrorImatge.Visible = true;
            }

        }

        private string SepararExtensio(string cadenaOriginal)
        {
            string[] arrayCadena = cadenaOriginal.Split('.');
            StringBuilder cadenaFinal = new StringBuilder();

            for (int i = 0; i < arrayCadena.Length - 1; i++)
            {
                cadenaFinal.Append(arrayCadena[i]);
            }

            return cadenaFinal.ToString();
        }
    }
}
