﻿using MongoDataAccess;
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

namespace OnBoardTree.DetailForms
{
    public partial class frmPlanetDetails : Form, IFormDetall
    {
        private readonly MongoDbConfig dbConfig;
        private readonly MongoAccess<Planet> bbdd;
        // La ruta de la
        private readonly string rutaDirImatges = Directory.GetCurrentDirectory() + "\\..\\..\\..\\..\\Imatges\\";

        public frmPlanetDetails()
        {
            InitializeComponent();

            string dbUrl = ConfigurationManager.AppSettings["MongoConnectionString"].ToString();
            string dbName = ConfigurationManager.AppSettings["MongoDataBaseName"].ToString();
            dbConfig = new MongoDbConfig(dbUrl, dbName);
            bbdd = new MongoAccess<Planet>(dbConfig, "Planets");
        }

        public void CarregarDades(string id)
        {
            lbl_ErrorImatge.Visible = false;
            // Carregar les dades a partir del id.
            Planet planet = bbdd.SelectById(id);

            lbl_Name.Text = planet.name;
            lbl_Natives.Text = planet.natives;
            lbl_Filiation.Text = planet.filiation;
            lbl_Longitude.Text = planet.situation.Long;
            lbl_Latitude.Text = planet.situation.lat;
            lbl_Persecs.Text = planet.situation.parsecs;
            lbl_Sector.Text = planet.sector;

            list_HyperspaceRoutes.Items.Clear();
            foreach (var item in planet.hyperspaceRoute.route)
            {
                list_HyperspaceRoutes.Items.Add(item);
            }

            try
            {
                string nomImatge = File.Exists($"{rutaDirImatges}{planet.name}.jpg") ?
                                   $"{rutaDirImatges}{planet.name}.jpg" :
                                   $"{rutaDirImatges}{planet.name}.png";

                pic_PlanetImage.Image = Image.FromFile(nomImatge);
            }
            catch (Exception)
            {
                lbl_ErrorImatge.Visible = true;
            }
        }
    }
}
