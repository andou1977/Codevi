﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetFenetreCodevi
{
    public partial class Fenlistertracabilite : Form
    {
        public Fenlistertracabilite()
        {
            InitializeComponent();
        }

        private void btnlister_Click(object sender, EventArgs e)
        {
            //string requet = "select * from tracabilite";

            //string chaine = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            //MySqlCommand cmd = null; ;
            //MySqlConnection con = null;
            ////MySqlDataReader rs = null;


            //try
            //{
            //    dgvliste.ClearSelection();
            //    dgvliste.Refresh();

            //    con = new MySqlConnection(chaine);
            //    con.Open();
            //    cmd = new MySqlCommand(requet, con);
            //    MySqlDataAdapter ad = null;
            //    ad = new MySqlDataAdapter(cmd);
            //    MySqlCommandBuilder buil = null;
            //    buil = new MySqlCommandBuilder(ad);
            //    DataSet ds = null;
            //    ds = new DataSet();
            //    //if (ad == null)
            //    //{
            //    //    MessageBox.Show("Aucune tracabilite n'est enregistrée!");
            //    //}
            //    //else
            //    //{
            //        ad.Fill(ds, "tracabilite");
            //        con.Close();
            //        dgvliste.DataSource = ds.Tables["tracabilite"];
            //        dgvliste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //        dgvliste.AutoGenerateColumns = true;

            //    }
            ////}

            //catch (MySqlException sq)
            //{
            //    MessageBox.Show(sq.Message);

            //}
            //finally
            //{
            //    if (con != null)
            //    {
            //        con.Close();
            //    }
            //}
        
         
        }

        private void btannuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fenlistertracabilite_Load(object sender, EventArgs e)
        {
            
            string requet = "select * from tracabilite";

            string chaine = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            MySqlCommand cmd = null; ;
            MySqlConnection con = null;
            //MySqlDataReader rs = null;


            try
            {
                dgvliste.ClearSelection();
                dgvliste.Refresh();

                con = new MySqlConnection(chaine);
                con.Open();
                cmd = new MySqlCommand(requet, con);
                MySqlDataAdapter ad = null;
                ad = new MySqlDataAdapter(cmd);
                MySqlCommandBuilder buil = null;
                buil = new MySqlCommandBuilder(ad);
                DataSet ds = null;
                ds = new DataSet();
                //if (ad == null)
                //{
                //    MessageBox.Show("Aucune tracabilite n'est enregistrée!");
                //}
                //else
                //{
                ad.Fill(ds, "tracabilite");
                con.Close();
                dgvliste.DataSource = ds.Tables["tracabilite"];
                dgvliste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvliste.AutoGenerateColumns = true;

            }
            //}

            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message);

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
    }
}