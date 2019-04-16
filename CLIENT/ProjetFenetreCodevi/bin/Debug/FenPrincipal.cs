using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFenetreCodevi
{
    public partial class FenPrincipal : Form
    {
        public FenPrincipal()
        {
            InitializeComponent();
        }

        private void mauthentification_Click(object sender, EventArgs e)
        {
            lblacceuil.ResetText();
        }

        private void tousToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FenListercompte fltco = new FenListercompte();
            fltco.Show();
        }

        private void smnEnrClient_Click(object sender, EventArgs e)
        {
            //smnEnrClient.Enabled = false;
            
            FenEnregistrerClient fc = new FenEnregistrerClient();
            fc.Show();
        }

        private void smnModClient_Click(object sender, EventArgs e)
        {
            FenModifierClient fm = new FenModifierClient();
            fm.Show();
        }

        private void smnRechClient_Click(object sender, EventArgs e)
        {
            FenRechercherClient fr = new FenRechercherClient();
            fr.Show();
        }

        private void smnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void smnTousClient_Click(object sender, EventArgs e)
        {
            FenListerClient fl=new FenListerClient();
            fl.Show();
        }

        private void smnCritereClient_Click(object sender, EventArgs e)
        {
            FenlisterClientCritere flc = new FenlisterClientCritere();
            flc.Show();
        }

        private void rembourserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FenRemboursement fremb = new FenRemboursement();
            fremb.Show();
        }

     

        private void FenPrincipal_Load(object sender, EventArgs e)
        {
            ///*///////////*/  
            mclient.Enabled = false;
            smnEnrClient.Enabled = false;
            smnRechClient.Enabled = false;
            smnModClient.Enabled = false;
            smnLisClient.Enabled = false;
            /////*/////////////////////////////*/
            mCompte.Enabled = false;
            smnEnrCompte.Enabled = false;
            smnRechCompte.Enabled = false;
            smnLisCompte.Enabled = false;
            //*///////////////////////*/
            mpret.Enabled = false;
            //smnenrpret.Enabled = false;
            //smnrecherchpret.Enabled = false;
            //smnmodifierpret.Enabled = false;
            //smnlisterpret.Enabled = false;

            //// /*//////////////////////////*/
            mnutilisateur.Enabled = false;
            smnajouterutilisateur.Enabled = false;
            smnrecherchuser.Enabled = false;
            smnmodifieruser.Enabled = false;
            smnlisterutilisateur.Enabled = false;
            smnlistinactifuser.Enabled = false;
            smnlistinactifuser.Enabled = false;
            smnbloquerutilisateur.Enabled = false;
            smndebolqueruser.Enabled = false;
            mtracabilite.Enabled = false;
            mtransaction.Enabled = false;
            smnlistertransaction.Enabled = false;
            mrembourser.Enabled = false;
        }

        private void tousToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FenListerpret fltp = new FenListerpret();
            fltp.Show();
        }

        private void parCritereToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Fenlisterpretcritere flt = new Fenlisterpretcritere();
            flt.Show();
        }

        private void smnlisteractifuser_Click(object sender, EventArgs e)
        {
            FenListerUtilisteuractif fac = new FenListerUtilisteuractif();
            fac.Show();
        }

        private void smnlistinactifuser_Click(object sender, EventArgs e)
        {
            FenListerUtilisateurInactif fiac = new FenListerUtilisateurInactif();
            fiac.Show();
        }

        private void tousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FenListerTransaction fltr = new FenListerTransaction();
            fltr.Show();
        }

        private void parCritereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fenlistertransactioncritere fltc = new Fenlistertransactioncritere();
            fltc.Show();
        }

        private void tousToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Fenlistertracabilite fltb = new Fenlistertracabilite();
            fltb.Show();
        }

        private void parCritereToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fenlistertracabilitecritere ftrb = new fenlistertracabilitecritere();
            ftrb.Show();
        }

        private void FenPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void smndeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void smnajouterutilisateur_Click(object sender, EventArgs e)
        {
            FenEnregistrerUtilisateur feu = new FenEnregistrerUtilisateur();
            feu.Show();
        }

        private void smnCritereCompte_Click(object sender, EventArgs e)
        {
            FenListercomptecritere fltccr = new FenListercomptecritere();
            fltccr.Show();
        }

        private void smnEnrCompte_Click(object sender, EventArgs e)
        {
            enregistrercompte rec = new enregistrercompte();
            rec.Show();
        }

        private void smnRechCompte_Click(object sender, EventArgs e)
        {
            Fenrechercher fer = new Fenrechercher();
            fer.Show();
        }

        private void bloquerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fenblocquer fbl = new Fenblocquer();
            fbl.Show();
        }

        private void debloquerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fenactiver fact = new Fenactiver();
            fact.Show();
        }

        private void smndepot_Click(object sender, EventArgs e)
        {
            Fendepot fd = new Fendepot();
            fd.Show();
        }

        private void smnretrait_Click(object sender, EventArgs e)
        {
            Fenretrait fr = new Fenretrait();
            fr.Show();
        }

        private void smnenrpret_Click(object sender, EventArgs e)
        {
            Fenpret fpr = new Fenpret();
            fpr.Show();
        }

        private void smnrecherchpret_Click(object sender, EventArgs e)
        {
            fenrechercherpret fnr = new fenrechercherpret();
            fnr.Show();
        }

        private void smnvirement_Click(object sender, EventArgs e)
        {
            Fenvirement fv = new Fenvirement();
            fv.Show();
        }

        private void smndebolqueruser_Click(object sender, EventArgs e)
        {
            Fenactiverutilisateur fau = new Fenactiverutilisateur();
            fau.Show();
        }

        private void smnbloquerutilisateur_Click(object sender, EventArgs e)
        {
            FenBloquerUtilisateur fbu = new FenBloquerUtilisateur();
            fbu.Show();
        }

        private void smnrecherchuser_Click(object sender, EventArgs e)
        {
            rechercherutilisateur ru = new rechercherutilisateur();
            ru.Show();

        }

        private void smnmodifieruser_Click(object sender, EventArgs e)
        {
            FenModifierUtilisateur fmu = new FenModifierUtilisateur();
            fmu.Show();
        }

        private void smnrembourser_Click(object sender, EventArgs e)
        {
            FenRemboursement fenre = new FenRemboursement();
            fenre.Show();
        }

        private void smntousremboursement_Click(object sender, EventArgs e)
        {
            FenListerRemboursement flrb = new FenListerRemboursement();
            flrb.Show();
        }

        private void smncritereremboursement_Click(object sender, EventArgs e)
        {
            Fenlisterrembcritere flcr = new Fenlisterrembcritere();
            flcr.Show();
        }

        private void mclient_Click(object sender, EventArgs e)
        {
            lblacceuil.ResetText();

        }

        private void mCompte_Click(object sender, EventArgs e)
        {
            lblacceuil.ResetText();

        }

        private void mtransaction_Click(object sender, EventArgs e)
        {
            lblacceuil.ResetText();

        }

        private void mpret_Click(object sender, EventArgs e)
        {
            lblacceuil.ResetText();

        }

        private void mrembourser_Click(object sender, EventArgs e)
        {
            lblacceuil.ResetText();

        }

        private void mtracabilite_Click(object sender, EventArgs e)
        {
            lblacceuil.ResetText();

        }

        private void mnutilisateur_Click(object sender, EventArgs e)
        {
            lblacceuil.ResetText();

        }

        private void listerToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FenChanger ch = new FenChanger();
            ch.Show();
        }
    }
}
