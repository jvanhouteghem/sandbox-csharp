﻿using sandbox_csharp_step3.classes;
using sandbox_csharp_step3.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sandbox_csharp_step3 {
    static class Program {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new acceuilForm());
            //Application.Run(new questionnaireForm());

            /*TestPersonnalite t = new TestPersonnalite();

            Question q = t.questionSuivante();

            q.reponse = true;
            t.ajouterReponse(q);
            q = t.questionSuivante();

            q.reponse = false;
            t.ajouterReponse(q);
            q = t.questionSuivante();

            q.reponse = true;
            t.ajouterReponse(q);
            q = t.questionSuivante();

            q.reponse = true;
            t.ajouterReponse(q);

            t.enregistrerResultat();*/

        }
    }
}
