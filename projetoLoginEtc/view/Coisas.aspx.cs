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
                lblResultado.Text = $"O resultado deu {Convert.ToString(div)}.";
                lstCalcMedias.Items.Add($"REPROVADO com {Convert.ToString(div)}!");
            }
            else if (div >= 6 && div < 7)
            {
                lblResultado.Text = $"O resultado deu {Convert.ToString(div)}.";
                lstCalcMedias.Items.Add($"Aprovado com {Convert.ToString(div)}!");
            }
            else if (div >= 7 && div < 9)
            {
                lblResultado.Text = $"O resultado deu {Convert.ToString(div)}.";
                lstCalcMedias.Items.Add($"BEM Aprovado com {Convert.ToString(div)}!");
            }
            else if (div >= 9 && div <= 10)
            {
                lblResultado.Text = $"O resultado deu {Convert.ToString(div)}.";
                lstCalcMedias.Items.Add($"MUITO Aprovado com {Convert.ToString(div)}!");
            }
            else
            {
                lblResultado.Text = "Deu algum problema aí?!";
            }
        }

        protected void btnSomar_Click(object sender, EventArgs e)
        {
            double n1, n2, som;

            n1 = Convert.ToInt32(txbPrNum.Text);
            n2 = Convert.ToInt32(txbSeNum.Text);

            som = n1 + n2;

            lblCalculos.Text = $"O resultado da sua soma deu {Convert.ToString(som)}.";
            lstCalculos.Items.Add($"Soma: {Convert.ToString(n1)} + {Convert.ToString(n2)} = {Convert.ToString(som)}");
        }

        protected void btnSubtrair_Click(object sender, EventArgs e)
        {
            double n1, n2, sub;

            n1 = Convert.ToInt32(txbPrNum.Text);
            n2 = Convert.ToInt32(txbSeNum.Text);

            sub = n1 - n2;

            lblCalculos.Text = $"O resultado da sua subtração deu {Convert.ToString(sub)}.";
            lstCalculos.Items.Add($"Subtração: {Convert.ToString(n1)} - {Convert.ToString(n2)} = {Convert.ToString(sub)}");
        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double n1, n2, mult;

            n1 = Convert.ToInt32(txbPrNum.Text);
            n2 = Convert.ToInt32(txbSeNum.Text);

            mult = n1 * n2;

            lblCalculos.Text = $"O resultado da sua multiplicação deu {Convert.ToString(mult)}.";
            lstCalculos.Items.Add($"Multiplicação: {Convert.ToString(n1)} x {Convert.ToString(n2)} = {Convert.ToString(mult)}");
        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {
            double n1, n2, div;

            n1 = Convert.ToInt32(txbPrNum.Text);
            n2 = Convert.ToInt32(txbSeNum.Text);

            div = n1 / n2;

            lblCalculos.Text = $"O resultado da sua divisão deu {Convert.ToString(div)}.";
            lstCalculos.Items.Add($"Soma: {Convert.ToString(n1)} / {Convert.ToString(n2)} = {Convert.ToString(div)}");
        }
    }
}