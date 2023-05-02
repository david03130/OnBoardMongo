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
using StarWarsModels;

namespace OnBoardTree
{
    public partial class frmTree : Form
    {
        public frmTree()
        {
            InitializeComponent();
            Test();
        }

        public void Test()
        {
            MongoAccess<Planet> access = new MongoAccess<Planet>("mongodb://localhost:27017", "StarWars", "Planets");
            //List<Planet> test = access.SelectAll();
            Planet planet = access.SelectById("62583c245c116fed874696f5");
        }
    }
}
