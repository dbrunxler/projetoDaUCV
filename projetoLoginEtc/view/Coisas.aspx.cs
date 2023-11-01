using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projetoLoginEtc.view
{
    public partial class Coisas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            double m1, m2, m3, m4, div;

            m1 = Convert.ToDouble(txbPMed.Text);
            m2 = Convert.ToDouble(txbSMed.Text);
            m3 = Convert.ToDouble(txbTMed.Text);
            m4 = Convert.ToDouble(txbQMed.Text);

            div = (m1 + m2 + m3 + m4) / 4;

            if (div >= 0 && div < 6)
            {
                lblResultado.Text = $"O resultado deu {Convert.ToString(div)}";
                lstCalcMedias.Items.Add($"REPROVADO com {Convert.ToString(div)}");
            }
            else if (div >= 6 && div < 7)
            {
                lblResultado.Text = $"O resultado deu {Convert.ToString(div)}";
                lstCalcMedias.Items.Add($"Aprovado com {Convert.ToString(div)}");
            }
            else if (div >= 7 && div < 9)
            {
                lblResultado.Text = $"O resultado deu {Convert.ToString(div)}";
                lstCalcMedias.Items.Add($"BEM Aprovado com {Convert.ToString(div)}");
            }
            else if (div >= 9 && div <= 10)
            {
                lblResultado.Text = $"O resultado deu {Convert.ToString(div)}";
                lstCalcMedias.Items.Add($"MUITO Aprovado com {Convert.ToString(div)}");
            }
            else
            {
                lblResultado.Text = "Deu algum problema aí?!";
            }
        }
    }
}