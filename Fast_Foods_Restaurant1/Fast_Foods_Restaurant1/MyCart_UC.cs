using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Foods_Restaurant1
{
    public partial class MyCart_UC : UserControl
    {
        const double Price_Pork_Steak = 99;
        const double Price_Chicken_Steak = 89;
        const double Price_Beef_Steak = 239;
        const double Price_Salmon_Steak = 189;
        const double Price_Caesar_Salad = 139;
        const double Price_Shrimp_Salad = 159;
        const double Price_Gloden_Salad = 99;
        const double Price_Fruit_Salad = 99;
        const double Price_Hawaiian_Pizza = 279;
        const double Price_Super_Deluxe_Pizza = 379;
        const double Price_Meat_Deluxe_Pizza = 319;
        const double Price_Super_Seafood_Pizza = 379;
        const double Price_Chicken_Wing_Appertizer = 129;
        const double Price_Bread_Stick_Appertizer = 129;
        const double Price_Garlic_Bread_Appertizer = 79;
        const double Price_French_Fries_Appertizer = 69;
        const double Price_Carbonara_Pasta = 89;
        const double Price_Bolognese_Pasta = 139;
        const double Price_White_Sauce_Pasta = 99;
        const double Price_Spicy_Seafood_Pasta = 129;
        const double Price_Cake_Desserts = 79;
        const double Price_Ice_cream_Desserts = 69;
        const double Price_Bingsu_Desserts = 119;
        const double Price_Toast_Desserts = 129;
        const double Price_Pudding_Desserts = 99;
        const double Price_Pancake_Desserts = 89;
        const double Price_Pork_Buger = 69;
        const double Price_Chicken_Buger = 69;
        const double Price_Fish_Buger = 79;
        const double Price_Beef_Buger = 89;
        const double Price_Coffee_Drinks = 99;
        const double Price_Pepsi_Drinks = 20;
        const double Price_Juice_Drinks = 89;
        const double Price_Tea_Drinks = 79;
        const double Price_Beer_Drinks = 70;
        const double Price_Water_Drinks = 10;
        const double Tax_Rate = 7.0;

        double iTax, iSubTotal, iTotal;
        public MyCart_UC()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm you want to Exit the System", "Fast Food", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //=====================================RestTextBoxe================================================
        private void RestTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        //====================================EnableTextBoxes==============================================
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        //====================================RestCheckBoxes==============================================
        private void RestCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckBoxes();

        }

        private void MyCart_UC_Load(object sender, EventArgs e)
        {

            cmbPaymentMethod.Items.Add(" ");
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("Master Card");
            cmbPaymentMethod.Items.Add("Visa Card");
            cmbPaymentMethod.Items.Add("Debit Card");


            EnableTextBoxes();
        }
        //====================================Steak==============================================
        private void chkPork_Steak_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPork_Steak.Checked == true)
            {
                txtPork_Steak.Text = "";
                txtPork_Steak.Focus();
                txtPork_Steak.Enabled = true;
                

            }
            else
            {
                txtPork_Steak.Enabled = false;
                txtPork_Steak.Text = "0";

            }
        }

        private void chkChicken_Steak_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChicken_Steak.Checked == true)
            {
                txtChicken_Steak.Text = "";
                txtChicken_Steak.Focus();
                txtChicken_Steak.Enabled = true;
                
            }
            else
            {
                txtChicken_Steak.Enabled = false;
                txtChicken_Steak.Text = "0";
            }
        }

        private void chkBeef_Steak_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBeef_Steak.Checked == true)
            {
                txtBeef_Steak.Text = "";
                txtBeef_Steak.Focus();
                txtBeef_Steak.Enabled = true;
                
            }
            else
            {
                txtBeef_Steak.Enabled = false;
                txtBeef_Steak.Text = "0";
            }
        }

        private void chkSalmon_Steak_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSalmon_Steak.Checked == true)
            {
                txtSalmon_Steak.Text = "";
                txtSalmon_Steak.Focus();
                txtSalmon_Steak.Enabled = true;
                
            }
            else
            {
                txtSalmon_Steak.Enabled = false;
                txtSalmon_Steak.Text = "0";
            }
        }
        //====================================Salad==============================================
        private void chkCaesar_Salad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCaesar_Salad.Checked == true)
            {
                txtCaesar_Salad.Text = "";
                txtCaesar_Salad.Focus();
                txtCaesar_Salad.Enabled = true;
                
            }
            else
            {
                txtCaesar_Salad.Enabled = false;
                txtCaesar_Salad.Text = "0";
            }
        }

        private void chkShrimp_Salad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShrimp_Salad.Checked == true)
            {
                txtShrimp_Salad.Text = "";
                txtShrimp_Salad.Focus();
                txtShrimp_Salad.Enabled = true;
                
            }
            else
            {
                txtShrimp_Salad.Enabled = false;
                txtShrimp_Salad.Text = "0";
            }
        }

        private void chkGloden_Salad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGloden_Salad.Checked == true)
            {
                txtGloden_Salad.Text = "";
                txtGloden_Salad.Focus();
                txtGloden_Salad.Enabled = true;
                
            }
            else
            {
                txtGloden_Salad.Enabled = false;
                txtGloden_Salad.Text = "0";
            }
        }

        private void chkFruit_Salad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFruit_Salad.Checked == true)
            {
                txtFruit_Salad.Text = "";
                txtFruit_Salad.Focus();
                txtFruit_Salad.Enabled = true;
                
            }
            else
            {
                txtFruit_Salad.Enabled = false;
                txtFruit_Salad.Text = "0";
            }
        }
        //====================================Pizza==============================================
        private void chkHawaiian_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHawaiian.Checked == true)
            {
                txtHawaiian.Text = "";
                txtHawaiian.Focus();
                txtHawaiian.Enabled = true;
                
            }
            else
            {
                txtHawaiian.Enabled = false;
                txtHawaiian.Text = "0";
            }
        }

        private void chkSuper_Deluxe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSuper_Deluxe.Checked == true)
            {
                txtSuper_Deluxe.Text = "";
                txtSuper_Deluxe.Focus();
                txtSuper_Deluxe.Enabled = true;
                
            }
            else
            {
                txtSuper_Deluxe.Enabled = false;
                txtSuper_Deluxe.Text = "0";
            }
        }

        private void chkMeat_Deluxe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMeat_Deluxe.Checked == true)
            {
                txtMeat_Deluxe.Text = "";
                txtMeat_Deluxe.Focus();
                txtMeat_Deluxe.Enabled = true;
                
            }
            else
            {
                txtMeat_Deluxe.Enabled = false;
                txtMeat_Deluxe.Text = "0";
            }
        }

        private void chkSuper_Seafood_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSuper_Seafood.Checked == true)
            {
                txtSuper_Seafood.Text = "";
                txtSuper_Seafood.Focus();
                txtSuper_Seafood.Enabled = true;
                
            }
            else
            {
                txtSuper_Seafood.Enabled = false;
                txtSuper_Seafood.Text = "0";
            }
        }
        //====================================Appertizer==============================================
        private void chkChicken_Wing_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChicken_Wing.Checked == true)
            {
                txtChicken_Wing.Text = "";
                txtChicken_Wing.Focus();
                txtChicken_Wing.Enabled = true;
                
            }
            else
            {
                txtChicken_Wing.Enabled = false;
                txtChicken_Wing.Text = "0";
            }
        }

        private void chkBread_Stick_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBread_Stick.Checked == true)
            {
                txtBread_Stick.Text = "";
                txtBread_Stick.Focus();
                txtBread_Stick.Enabled = true;
                
            }
            else
            {
                txtBread_Stick.Enabled = false;
                txtBread_Stick.Text = "0";
            }
        }

        private void chkGarlic_Bread_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGarlic_Bread.Checked == true)
            {
                txtGarlic_Bread.Text = "";
                txtGarlic_Bread.Focus();
                txtGarlic_Bread.Enabled = true;
                
            }
            else
            {
                txtGarlic_Bread.Enabled = false;
                txtGarlic_Bread.Text = "0";
            }
        }

        private void chkFrench_Fries_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFrench_Fries.Checked == true)
            {
                txtFrench_Fries.Text = "";
                txtFrench_Fries.Focus();
                txtFrench_Fries.Enabled = true;
                
            }
            else
            {
                txtFrench_Fries.Enabled = false;
                txtFrench_Fries.Text = "0";
            }
        }
        //====================================Pasta==============================================
        private void chkCarbonara_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCarbonara.Checked == true)
            {
                txtCarbonara.Text = "";
                txtCarbonara.Focus();
                txtCarbonara.Enabled = true;
                
            }
            else
            {
                txtCarbonara.Enabled = false;
                txtCarbonara.Text = "0";
            }
        }

        private void chkBolognese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBolognese.Checked == true)
            {
                txtBolognese.Text = "";
                txtBolognese.Focus();
                txtBolognese.Enabled = true;
                
            }
            else
            {
                txtBolognese.Enabled = false;
                txtBolognese.Text = "0";
            }
        }

        private void chkWhite_Sauce_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWhite_Sauce.Checked == true)
            {
                txtWhiteSauce.Text = "";
                txtWhiteSauce.Focus();
                txtWhiteSauce.Enabled = true;
               
            }
            else
            {
                txtWhiteSauce.Enabled = false;
                txtWhiteSauce.Text = "0";
            }
        }

        private void chkSpicy_Seafood_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpicy_Seafood.Checked == true)
            {
                txtSpicySeafood.Text = "";
                txtSpicySeafood.Focus();
                txtSpicySeafood.Enabled = true;
                
            }
            else
            {
                txtSpicySeafood.Enabled = false;
                txtSpicySeafood.Text = "0";
            }
        }
        //====================================Desserts==============================================
        private void chkCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCake.Checked == true)
            {
                txtCake.Text = "";
                txtCake.Focus();
                txtCake.Enabled = true;
                
            }
            else
            {
                txtCake.Enabled = false;
                txtCake.Text = "0";
            }
        }

        private void chkIce_cream_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIce_cream.Checked == true)
            {
                txtIce_cream.Text = "";
                txtIce_cream.Focus();
                txtIce_cream.Enabled = true;
                
            }
            else
            {
                txtIce_cream.Enabled = false;
                txtIce_cream.Text = "0";
            }
        }

        private void chkBingsu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBingsu.Checked == true)
            {
                txtBingsu.Text = "";
                txtBingsu.Focus();
                txtBingsu.Enabled = true;
                
            }
            else
            {
                txtBingsu.Enabled = false;
                txtBingsu.Text = "0";
            }
        }

        private void chkToast_CheckedChanged(object sender, EventArgs e)
        {
            if (chkToast.Checked == true)
            {
                txtToast.Text = "";
                txtToast.Focus();
                txtToast.Enabled = true;
              
            }
            else
            {
                txtToast.Enabled = false;
                txtToast.Text = "0";
            }
        }

        private void chkPudding_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPudding.Checked == true)
            {
                txtPudding.Text = "";
                txtPudding.Focus();
                txtPudding.Enabled = true;
                
            }
            else
            {
                txtPudding.Enabled = false;
                txtPudding.Text = "0";
            }
        }

        private void chkPancake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPancake.Checked == true)
            {
                txtPancake.Text = "";
                txtPancake.Focus();
                txtPancake.Enabled = true;
                
            }
            else
            {
                txtPancake.Enabled = false;
                txtPancake.Text = "0";
            }
        }
        //====================================Buger==============================================
        private void chkPork_Buger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPork_Buger.Checked == true)
            {
                txtPork_Buger.Text = "";
                txtPork_Buger.Focus();
                txtPork_Buger.Enabled = true;
                
            }
            else
            {
                txtPork_Buger.Enabled = false;
                txtPork_Buger.Text = "0";
            }
        }

        private void chkChicken_Buger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChicken_Buger.Checked == true)
            {
                txtChicken_Buger.Text = "";
                txtChicken_Buger.Focus();
                txtChicken_Buger.Enabled = true;
                
            }
            else
            {
                txtChicken_Buger.Enabled = false;
                txtChicken_Buger.Text = "0";
            }
        }

        private void chkFish_Buger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFish_Buger.Checked == true)
            {
                txtFish_Buger.Text = "";
                txtFish_Buger.Focus();
                txtFish_Buger.Enabled = true;
                
            }
            else
            {
                txtFish_Buger.Enabled = false;
                txtFish_Buger.Text = "0";
            }
        }

        private void chkBeef_buger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBeef_buger.Checked == true)
            {
                txtBeef_Buger.Text = "";
                txtBeef_Buger.Focus();
                txtBeef_Buger.Enabled = true;
                
            }
            else
            {
                txtBeef_Buger.Enabled = false;
                txtBeef_Buger.Text = "0";
            }
        }

        //====================================Drinks==============================================
        private void chkCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoffee.Checked == true)
            {
                txtCoffee.Text = "";
                txtCoffee.Focus();
                txtCoffee.Enabled = true;
                
            }
            else
            {
                txtCoffee.Enabled = false;
                txtCoffee.Text = "0";
            }
        }

        private void chkPepsi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPepsi.Checked == true)
            {
                txtPepsi.Text = "";
                txtPepsi.Focus();
                txtPepsi.Enabled = true;
                
            }
            else
            {
                txtPepsi.Enabled = false;
                txtPepsi.Text = "0";
            }
        }

        private void chkJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJuice.Checked == true)
            {
                txtJuice.Text = "";
                txtJuice.Focus();
                txtJuice.Enabled = true;
            }
            else
            {
                txtJuice.Enabled = false;
                txtJuice.Text = "0";
            }
        }

        private void chkTea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTea.Checked == true)
            {
                txtTea.Text = "";
                txtTea.Focus();
                txtTea.Enabled = true;
            }
            else
            {
                txtTea.Enabled = false;
                txtTea.Text = "0";
            }
        }

        private void chkBeer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBeer.Checked == true)
            {
                txtBeer.Text = "";
                txtBeer.Focus();
                txtBeer.Enabled = true;
            }
            else
            {
                txtBeer.Enabled = false;
                txtBeer.Text = "0";
            }
        }

        private void chkWater_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWater.Checked == true)
            {
                txtWater.Text = "";
                txtWater.Focus();
                txtWater.Enabled = true;
            }
            else
            {
                txtWater.Enabled = false;
                txtWater.Text = "0";
            }
        }

        //==================================Cash===============================
        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbPaymentMethod.Text == "Cash")
            {
                txtPaymentMethod.Enabled = true;
                txtPaymentMethod.Text = "0";
                txtPaymentMethod.Focus();
                

            }
            else
            {
                txtPaymentMethod.Enabled = false;
                txtPaymentMethod.Text = "0";
                
            }

            
           
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double [35];
            itemcost[0] = Convert.ToDouble(txtPork_Steak.Text) * Price_Pork_Steak;
            itemcost[1] = Convert.ToDouble(txtChicken_Steak.Text) * Price_Chicken_Steak;
            itemcost[2] = Convert.ToDouble(txtBeef_Steak.Text) * Price_Beef_Steak;
            itemcost[3] = Convert.ToDouble(txtSalmon_Steak.Text) * Price_Salmon_Steak;
            itemcost[4] = Convert.ToDouble(txtCaesar_Salad.Text) * Price_Caesar_Salad;
            itemcost[5] = Convert.ToDouble(txtShrimp_Salad.Text) * Price_Shrimp_Salad;
            itemcost[6] = Convert.ToDouble(txtGloden_Salad.Text) * Price_Gloden_Salad;
            itemcost[7] = Convert.ToDouble(txtFruit_Salad.Text) * Price_Fruit_Salad;
            itemcost[8] = Convert.ToDouble(txtHawaiian.Text) * Price_Hawaiian_Pizza;
            itemcost[9] = Convert.ToDouble(txtSuper_Deluxe.Text) * Price_Super_Deluxe_Pizza;
            itemcost[10] = Convert.ToDouble(txtMeat_Deluxe.Text) * Price_Meat_Deluxe_Pizza;
            itemcost[11] = Convert.ToDouble(txtSuper_Seafood.Text) * Price_Super_Seafood_Pizza;
            itemcost[12] = Convert.ToDouble(txtBread_Stick.Text) * Price_Bread_Stick_Appertizer;
            itemcost[13] = Convert.ToDouble(txtGarlic_Bread.Text) * Price_Garlic_Bread_Appertizer;
            itemcost[14] = Convert.ToDouble(txtFrench_Fries.Text) * Price_French_Fries_Appertizer;
            itemcost[15] = Convert.ToDouble(txtCarbonara.Text) * Price_Carbonara_Pasta;
            itemcost[16] = Convert.ToDouble(txtBolognese.Text) * Price_Bolognese_Pasta;
            itemcost[17] = Convert.ToDouble(txtWhiteSauce.Text) * Price_White_Sauce_Pasta;
            itemcost[18] = Convert.ToDouble(txtSpicySeafood.Text) * Price_Spicy_Seafood_Pasta;
            itemcost[19] = Convert.ToDouble(txtCake.Text) * Price_Cake_Desserts;
            itemcost[20] = Convert.ToDouble(txtIce_cream.Text) * Price_Ice_cream_Desserts;
            itemcost[21] = Convert.ToDouble(txtBingsu.Text) * Price_Bingsu_Desserts;
            itemcost[22] = Convert.ToDouble(txtToast.Text) * Price_Toast_Desserts;
            itemcost[23] = Convert.ToDouble(txtPudding.Text) * Price_Pudding_Desserts;
            itemcost[24] = Convert.ToDouble(txtPancake.Text) * Price_Pancake_Desserts;
            itemcost[25] = Convert.ToDouble(txtPork_Buger.Text) * Price_Pork_Buger;
            itemcost[26] = Convert.ToDouble(txtChicken_Buger.Text) * Price_Chicken_Buger;
            itemcost[27] = Convert.ToDouble(txtFish_Buger.Text) * Price_Fish_Buger;
            itemcost[28] = Convert.ToDouble(txtBeef_Buger.Text) * Price_Beef_Buger;
            itemcost[29] = Convert.ToDouble(txtCoffee.Text) * Price_Coffee_Drinks;
            itemcost[30] = Convert.ToDouble(txtPepsi.Text) * Price_Pepsi_Drinks;
            itemcost[31] = Convert.ToDouble(txtJuice.Text) * Price_Juice_Drinks;
            itemcost[32] = Convert.ToDouble(txtTea.Text) * Price_Tea_Drinks;
            itemcost[33] = Convert.ToDouble(txtBeer.Text) * Price_Beer_Drinks;
            itemcost[34] = Convert.ToDouble(txtWater.Text) * Price_Water_Drinks;


            double cost, iChange,totSubtot=0;

            if (cmbPaymentMethod.Text == "Cash")
            {
                
                for (int i = 0; i < itemcost.Length; i++)
                    totSubtot = totSubtot + itemcost[i];
                iSubTotal = totSubtot;


                lblSubTotal.Text = String.Format(new System.Globalization.CultureInfo("th-TH"), "{0:C}", iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                lblTax.Text = String.Format(new System.Globalization.CultureInfo("th-TH"), "{0:C}", iTax); 
                iTotal = (iSubTotal + iTax);
                lblTotal.Text = String.Format(new System.Globalization.CultureInfo("th-TH"), "{0:C}", iTotal);

                iChange = Convert.ToDouble(txtPaymentMethod.Text);
                if (iChange < iTotal)
                {
                    MessageBox.Show("ใส่จำนวนเงินไม่ถูกต้อง");
                    return;
                }
                cost = iChange-iTotal;
                lblChange.Text = String.Format(new System.Globalization.CultureInfo("th-TH"), "{0:C}", cost);
            }

            else
            {
                iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] +
                            itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] +
                            itemcost[11] + itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] +
                            itemcost[17] + itemcost[18] + itemcost[19] + itemcost[20] + itemcost[21] + itemcost[22] +
                            itemcost[23] + itemcost[24] + itemcost[25] + itemcost[26] + itemcost[27] + itemcost[28] +
                            itemcost[29] + itemcost[30] + itemcost[31] + itemcost[32] + itemcost[33] + itemcost[34];

                lblSubTotal.Text = String.Format(new System.Globalization.CultureInfo("th-TH"), "{0:C}", iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                lblTax.Text = String.Format(new System.Globalization.CultureInfo("th-TH"), "{0:C}", iTax);
                iTotal = (iSubTotal + iTax);
                lblTotal.Text = String.Format(new System.Globalization.CultureInfo("th-TH"), "{0:C}", iTotal);
            }
        }
    }
}



