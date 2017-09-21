using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Painted_Trailer_Tool
{
    public partial class frmMain : Form
    {

        public string localpath = AppDomain.CurrentDomain.BaseDirectory;
        public float colorR = 0;
        public float colorG = 0;
        public float colorB = 0;
        public string blankSii = Properties.Resources.emptytrailer;
        public string doubleSii = Properties.Resources.emptytrailer_double;
        public string newSii;
        public int currentIndex = 0;
        public string baseCompany = "company_permanent: company.permanent.<intname>\n{\n\tname: \"<intname>\"\n\tsort_name: \"<intname>\"\n\ttrailer_look: default\n}";
        public string[] companies = { "agronord.dlc_north", "aria_fd_albg.dlc_north", "aria_fd_esbj.dlc_north", "aria_fd_jnpg.dlc_north", "aria_fd_trbg.dlc_north", "batisse_hs", "bcp", "bhv.dlc_north", "bhv", "bjork.dlc_north", "cont_port.dlc_north", "drekkar.dlc_north", "euroacres", "eurogoodies", "fcp", "fle", "gnt.dlc_north", "ika_bohag.dlc_north", "ika_bohag", "itcc", "kaarfor", "konstnr.dlc_north", "konstnr_br.dlc_north", "konstnr_hs.dlc_north", "konstnr_wind.dlc_north", "lisette_log", "lkwlog", "marina.dlc_north", "ms_stein.dlc_north", "nbfc", "nord_crown.dlc_north", "nord_sten.dlc_north", "norrsken.dlc_north", "norr_food.dlc_north", "ns_chem.dlc_north", "ns_oil.dlc_north", "polarislines.dlc_north", "polar_fish.dlc_north", "posped", "quarry", "renar.dlc_north", "sag_tre.dlc_north", "sanbuilders", "scania_dlr", "scania_fac.dlc_north", "sellplan", "skoda", "stokes", "tradeaux", "trameri", "transinet", "tree_et", "vitas_pwr.dlc_north", "voitureux", "volvo_dlr", "volvo_fac.dlc_north", "vpc.dlc_north", "wgcc" };
        public string[] trailerNames = { "fridge", "krone_coolliner", "krone_profiliner", "schmitz_universal", "willig_fuel_cistern" };
        public string[] trailers = { "cement", "chemical_cistern", "food_cistern", "fuel_cistern", "livestock" };
        public string[] oldTrailers = { "reefer/chassis", "reefer/chassis_a", "container/chassis", "container/chassis" };
        public string[] newTrailers = { "krone/fridge", "krone/coolliner", "krone/profiliner", "schmitz/universal", "willig/fuel_cistern" };
        public string[] schwTrailers = { "schw_cistern_food", "schw_curtain", "schw_reefer" };

        public frmMain()
        {
            InitializeComponent();

            string[] trailersStr = Properties.Resources.defChassis.Split('\n');

            foreach (String current in trailersStr)
            {
                trailer toAdd = new trailer();
                toAdd.filePath = (current.Split(','))[0];
                toAdd.displayName = (current.Split(','))[1];
                toAdd.displayName = toAdd.displayName.Remove(toAdd.displayName.Length - 1);
                cmbOverrideTrailer.Items.Add(toAdd);
            }

        }

        private void btnBuildMod_Click(object sender, EventArgs e)
        {
            clrPaintColor.ShowDialog();
            colorR = float.Parse(clrPaintColor.Color.R.ToString());
            colorG = float.Parse(clrPaintColor.Color.G.ToString());
            colorB = float.Parse(clrPaintColor.Color.B.ToString());

            colorR = (colorR * colorR) / 65025;
            colorG = (colorG * colorG) / 65025;
            colorB = (colorB * colorB) / 65025;

            if (ckbOverrideTrailer.Checked == false)
            {
                makeModNormal();
            }
            else
            {
                makeModOverride();
            }

        }

        public void makeModNormal ()
        {
            Directory.CreateDirectory(localpath + txtModName.Text + "/def/vehicle/trailer");
            Directory.CreateDirectory(localpath + txtModName.Text + "/def/company");
            foreach (string currentTrailer in trailers)
            {
                newSii = blankSii;
                newSii = newSii.Replace("<trailer>", currentTrailer + "/chassis");
                if (currentTrailer == "chemical_cistern")
                {
                    newSii = newSii.Replace("<intname>", "chcistern");
                }
                else
                {
                    newSii = newSii.Replace("<intname>", currentTrailer);
                }
                newSii = newSii.Replace("<r>", colorR.ToString().Replace(",", "."));
                newSii = newSii.Replace("<g>", colorG.ToString().Replace(",", "."));
                newSii = newSii.Replace("<b>", colorB.ToString().Replace(",", "."));
                using (StreamWriter siiout = new StreamWriter(localpath + txtModName.Text + "/def/vehicle/trailer/" + currentTrailer + ".sii"))
                {
                    siiout.Write(newSii);
                }
            }
            if (ckbSchwTrailers.Checked == true)
            {
                foreach (string currentTrailer in schwTrailers)
                {
                    newSii = blankSii;
                    if (currentTrailer == "schw_cistern_food")
                    {
                        newSii = newSii.Replace("<intname>", "schw_food");
                    }
                    else
                    {
                        newSii = newSii.Replace("<intname>", currentTrailer);
                    }
                    newSii = newSii.Replace("<trailer>", currentTrailer + "/chassis.dlc_schwarzmuller");
                    newSii = newSii.Replace("<r>", colorR.ToString().Replace(",", "."));
                    newSii = newSii.Replace("<g>", colorG.ToString().Replace(",", "."));
                    newSii = newSii.Replace("<b>", colorB.ToString().Replace(",", "."));
                    using (StreamWriter siiout = new StreamWriter(localpath + txtModName.Text + "/def/vehicle/trailer/" + currentTrailer + ".dlc_schwarzmuller.sii"))
                    {
                        siiout.Write(newSii);
                    }
                    currentIndex = currentIndex + 1;
                }
                currentIndex = 0;
            }
            if (ckbETS1Trailers.Checked == true)
            {
                foreach (string currentTrailer in oldTrailers)
                {
                    newSii = blankSii;
                    newSii = newSii.Replace("<trailer>", currentTrailer);
                    newSii = newSii.Replace("<intname>", trailerNames[currentIndex].Replace("_", "."));
                    newSii = newSii.Replace("<r>", colorR.ToString().Replace(",", "."));
                    newSii = newSii.Replace("<g>", colorG.ToString().Replace(",", "."));
                    newSii = newSii.Replace("<b>", colorB.ToString().Replace(",", "."));
                    using (StreamWriter siiout = new StreamWriter(localpath + txtModName.Text + "/def/vehicle/trailer/" + trailerNames[currentIndex] + ".sii"))
                    {
                        siiout.Write(newSii);
                    }
                    currentIndex = currentIndex + 1;
                }
            }
            else
            {
                currentIndex = 0;
                foreach (string currentTrailer in newTrailers)
                {
                    newSii = blankSii;
                    newSii = newSii.Replace("<trailer>", currentTrailer + "/chassis");
                    newSii = newSii.Replace("<intname>", trailerNames[currentIndex].Replace("_", "."));
                    newSii = newSii.Replace("<r>", colorR.ToString().Replace(",", "."));
                    newSii = newSii.Replace("<g>", colorG.ToString().Replace(",", "."));
                    newSii = newSii.Replace("<b>", colorB.ToString().Replace(",", "."));
                    using (StreamWriter siiout = new StreamWriter(localpath + txtModName.Text + "/def/vehicle/trailer/" + trailerNames[currentIndex] + ".sii"))
                    {
                        siiout.Write(newSii);
                    }
                    currentIndex = currentIndex + 1;
                }
            }
            //Double Trailer
            newSii = doubleSii;
            newSii = newSii.Replace("<r>", colorR.ToString().Replace(",", "."));
            newSii = newSii.Replace("<g>", colorG.ToString().Replace(",", "."));
            newSii = newSii.Replace("<b>", colorB.ToString().Replace(",", "."));
            using (StreamWriter siiout = new StreamWriter(localpath + txtModName.Text + "/def/vehicle/trailer/krone_profiliner_double.sii"))
            {
                siiout.Write(newSii);
            }

            foreach (string currentCompany in companies)
            {
                using (StreamWriter siiout = new StreamWriter(localpath + txtModName.Text + "/def/company/" + currentCompany + ".sii"))
                {
                    siiout.Write(baseCompany.Replace("<intname>", currentCompany.Replace(".dlc_north", "")));
                }
            }

            MessageBox.Show("Painted trailers successfully created.");
        }

        public void makeModOverride ()
        {
            trailer tempTrailer = cmbOverrideTrailer.SelectedItem as trailer;

            string trailerDataPath = tempTrailer.filePath;

            foreach (string currentTrailer in trailers)
            {
                newSii = blankSii;
                newSii = newSii.Replace("<trailer>", trailerDataPath);
                if (currentTrailer == "chemical_cistern")
                {
                    newSii = newSii.Replace("<intname>", "chcistern");
                }
                else
                {
                    newSii = newSii.Replace("<intname>", currentTrailer);
                }
                newSii = newSii.Replace("<r>", colorR.ToString().Replace(",", "."));
                newSii = newSii.Replace("<g>", colorG.ToString().Replace(",", "."));
                newSii = newSii.Replace("<b>", colorB.ToString().Replace(",", "."));
                using (StreamWriter siiout = new StreamWriter(localpath + txtModName.Text + "/def/vehicle/trailer/" + currentTrailer + ".sii"))
                {
                    siiout.Write(newSii);
                }
                Console.Write(currentTrailer + " has been written\n");
            }
            foreach (string currentTrailer in newTrailers)
            {
                newSii = blankSii;
                newSii = newSii.Replace("<trailer>", trailerDataPath);
                newSii = newSii.Replace("<intname>", trailerNames[currentIndex].Replace("_", "."));
                newSii = newSii.Replace("<r>", colorR.ToString().Replace(",", "."));
                newSii = newSii.Replace("<g>", colorG.ToString().Replace(",", "."));
                newSii = newSii.Replace("<b>", colorB.ToString().Replace(",", "."));
                using (StreamWriter siiout = new StreamWriter(localpath + txtModName.Text + "/def/vehicle/trailer/" + trailerNames[currentIndex] + ".sii"))
                {
                    siiout.Write(newSii);
                }
                Console.Write(currentTrailer + " has been written as: " + trailerNames[currentIndex] + "\n");
                currentIndex = currentIndex + 1;
            }

            MessageBox.Show("Painted trailers successfully created.");
        }
    }
}
