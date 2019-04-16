using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

using Com.ProjetCodevi.Controleur;
namespace ProjetFenetreCodevi
{
   public static class Program
    {
       public static TcpChannel t;
         static void Main()
        {

            t = new TcpChannel(6060);

            ChannelServices.RegisterChannel(t);
         

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(UtilisateurControleur), "objetutilisateur", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ClientControleur), "objetclient", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(CompteControleur), "objetcompte", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(PretControleur), "objetpret", WellKnownObjectMode.Singleton);
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Lancement());
            
           
        }
    }
    }

