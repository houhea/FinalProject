using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final
{
    public partial class Form1 : Form
    {
        //Declarations
        bool takeOut;

        //int pattyNum;
        string orderStep; //keeps track of current pannel

        //string bunType;
        //string cheeseType;
        //string toppingType;
        //string sauceType;
        //string[] toppings = new string[] { };
        //string[] sauce = new string[] { };
        public string[] optionsArray = new string[4];
       
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlStart.Visible = true;


            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlBuild.Visible = false;
            pnlPrevNext.Visible = false;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
            pnlSpecialty.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlNav.Visible = false;
            pnlStack.Visible = false;

            lblStack.Text = "";
            

        }

        //private void lblSauce_Click(object sender, EventArgs e)
        //{

        //}

        private void pnlStart_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlStart.Visible == true)
            {
                orderStep = "start";
            }
            pnlPrevNext.Visible = true;
            pnlNav.Visible = true;                                              //03/03 changed
            pnlStack.Visible = true;


            btnBun.Visible = false;
            btnCheese.Visible = false;                                          //03/03 changed
            btnToppings.Visible = false;
            btnSauce.Visible = false;
            lblOrder.Visible = false;
            //btnStartOver.Visible = false;
           // btnNext.Visible = true;                                         //03/04 changed     
            //btnPrevious.Visible = true;
        }

        private void pnlLocation_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlLocation.Visible == true)
            {
                orderStep = "location";
            }
            btnStartOver.Visible = false;
             //btnNext.Visible = true;                                         //03/04 changed     
            // btnPrevious.Visible = true;
        }

        private void pnlOrderType_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlOrderType.Visible == true)
            {
                orderStep = "orderType";
            }
            btnNext.Visible = true;                                         //03/04 changed     
            btnPrevious.Visible = true;
        }

        private void pnlBuild_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlBuild.Visible == true)
            {
                orderStep = "build";
              //? btnNext.Visible = false;
               //btnNext.Enabled = true;    //added
                
            }
            //btnBun.Visible = false;
            //btnCheese.Visible = false;                                          //03/03 changed
            //btnToppings.Visible = false;
            //btnSauce.Visible = false;
            //lblOrder.Visible = false;
            //lblStack.Visible = false;
        }

        private void pnlBun_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlBun.Visible == true)
            {
                orderStep = "bun";
                btnNext.Enabled = false;
               // btnBun.Enabled = true;                                       ??
            }
            btnBun.Visible = true;
            btnCheese.Visible = true; ;                                                 //changed 03/03
            btnToppings.Visible = true; ;
            btnSauce.Visible = true;
            lblOrder.Visible = true;
            lblStack.Visible = true;
        }
        private void pnlCheese_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlCheese.Visible == true)
            {
                orderStep = "cheese";
                btnNext.Enabled = false;
            }
        }
        private void pnlToppings_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlToppings.Visible == true)
            {
                orderStep = "toppings";
                btnNext.Enabled = false;
            }
        }
        private void pnlSauce_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlSauce.Visible == true)
            {
                orderStep = "sauce";
                btnNext.Enabled = true;
            }
        }
        private void pnlSummary_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlSummary.Visible == true)
            {
                orderStep = "summary";
                btnNext.Enabled = false;
                //for (int i = 0; i < optionsArray.Length; ++i)
                //{
                //    lblSummary3.Text +=
                //    String.Format("{0}", optionsArray[i]);
                //}
                //lblSummary3.Text += lblStack.Text;
            }
        }
        private void pnlSpecialty_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlSpecialty.Visible == true)
            {
                orderStep = "specialty";
                btnNext.Enabled = false;
            }
            
            
        }
        private void pnlComplete_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlComplete.Visible == true)
            {
                orderStep = "complete";
                //btnNext.Enabled = false;
            }
            pnlPrevNext.Visible = true;
            btnNext.Visible = false;                                            
            btnPrevious.Visible = false;
            btnBun.Visible = false;
            btnCheese.Visible = false;                                          //03/03 changed
            btnToppings.Visible = false;
            btnSauce.Visible = false;
            btnStartOver.Visible = false;
            lblOrder.Visible = false;
            lblStack.Visible = false;                                        //03/04 changed
        }




        //Button Click Events

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            pnlLocation.Visible = true;
            pnlPrevNext.Visible = true;
            pnlNav.Visible = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            takeOut = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            //pnlPrevNext.Visible = true;
           //pnlNav.Visible = true;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            takeOut = true;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            //pnlPrevNext.Visible = true;

        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
            pnlBuild.Visible = true;
          
          
        }

        private void btnSpecialty_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
            pnlSpecialty.Visible = true;
            pnlStack.Visible = true;
            pnlPrevNext.Visible = true;
            pnlNav.Visible = true;
            lblOrder.Visible = true;                                    //added 03/04
            lblStack.Visible = true;
            btnPrevious.Visible = false;
            btnNext.Visible = false;
        }
        private void btnBegin_Click(object sender, EventArgs e)
        {
            pnlBuild.Visible = false;
            pnlBun.Visible = true;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
            pnlPrevNext.Visible = true; 
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            switch (orderStep)
            {
                case "location" :
                    pnlStart.Visible = true;
                    pnlLocation.Visible = false;
                    break;
                case "orderType":
                    pnlLocation.Visible = true;
                    pnlOrderType.Visible = false;
                    break;
                case "build":
                    pnlOrderType.Visible = true;
                    pnlBuild.Visible = false;
                    break;
                case "bun":
                    pnlBuild.Visible = true;
                    pnlBun.Visible = false;

                     btnBun.Visible = false;
                     btnCheese.Visible = false;                                          //03/04changed
                     btnToppings.Visible = false;
                     btnSauce.Visible = false;
                     lblOrder.Visible = false;
                     lblStack.Visible = false;
                    break;
                case "cheese":
                    pnlBun.Visible = true;
                    pnlCheese.Visible = false;     
                    break;
                case "toppings" :
                    pnlCheese.Visible = true;
                    pnlToppings.Visible = false;
                    break;
                case "sauce":
                    pnlToppings.Visible = true;
                    pnlSauce.Visible = false;
                    break;
                case "summary" :
                    pnlSauce.Visible = true;
                    pnlSummary.Visible = false;
                    break;
                case "specialty" :
                    pnlSummary.Visible = true;
                    pnlSpecialty.Visible = false;
                    break;

                default:
                    pnlStart.Visible = true;
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            switch (orderStep)
            {
                case "build":
                    pnlBuild.Visible = false;
                    pnlBun.Visible = true;
                    break;
                case "bun":
                    pnlBun.Visible = false;
                    pnlCheese.Visible = true;
                    break;
                case "cheese" :
                    pnlCheese.Visible = false;
                    pnlToppings.Visible = true;
                    break;
                case "toppings" :
                    pnlToppings.Visible = false; 
                    pnlSauce.Visible = true;
                    break;
                case "sauce" :
                    pnlSauce.Visible = false;
                    pnlSummary.Visible = true;
                    btnNo.Visible = true;
                    break;
                case "summary":
                    pnlSummary.Visible = false;
                    pnlSpecialty.Visible = true;
                    //btnNo.Visible = true;
                    break;
                case "specialty":
                    pnlSpecialty.Visible = false;
                    pnlComplete.Visible = true;
                    break;
                case "complete":
                    pnlComplete.Visible = true;

                    break;
                default:
                    pnlStart.Visible = true;
                    break;
            }


        }

        //private void btnBegin_Click(object sender, EventArgs e)
        //{
        //    pnlBuild.Visible = false;
        //    pnlBun.Visible = true;
        //    pnlNav.Visible = true;
        //    pnlStack.Visible = true;
        //}

        private void btnWhite_Click(object sender, EventArgs e)
        {
            //optionsArray[0] = "whiteBun\n";
            //lblStack.Text = optionsArray[0];
            //btnNext.Enabled = true;


            //if (btnWhite.Visible == true)
            //{

            //    remove();
            //}
            
           
            
            string bunType = Bun.createBun("\nwhite bun");
            optionsArray[0] = bunType;
            build();                                                                
            btnNext.Enabled = true;
            
        }

        private void btnWheat_Click(object sender, EventArgs e)
        {
            //optionsArray[0] = "wheatBun\n";
            //lblStack.Text = optionsArray[0];
            //btnNext.Enabled = true;


            //if (btnWheat.Visible == true)
            //{
            //    btnWheat.Enabled = false;
            //    btnWhite.Enabled = true;
            //}


            //if (btnWheat.Visible == true)
            //{
            //    btnWheat.Enabled = false;                                             
            //}

            

            string bunType = Bun.createBun("\nwheat bun");
            optionsArray[0] = bunType;
            build();
           // lblStack.Text = optionsArray[0];                                    
            btnNext.Enabled = true;
        }

        private void btnPotato_Click(object sender, EventArgs e)
        {
            //optionsArray[0] = "potatoBun\n";
            //lblStack.Text = optionsArray[0];
            //btnNext.Enabled = true;

            //if (btnPotato.Visible == true)
            //{
            //    btnPotato.Enabled = false;                                             //created 02/27
            //}


            string bunType = Bun.createBun("\npotato bun");
            optionsArray[0] = bunType;
            build();
           // lblStack.Text = optionsArray[0];                                                 
            btnNext.Enabled = true;
        }

        private void btnAmerican_Click(object sender, EventArgs e)
        {
            //if (btnAmerican.Visible == true)
            //{
            //    btnAmerican.Enabled = false;
            //}
            //optionsArray[1] = "americanCheese\n";
            //lblStack.Text += optionsArray[1];
            //btnNext.Enabled = true;    //added
            string cheeseType = Cheese.createCheese("\namerican cheese");
            optionsArray[1] = cheeseType;
            build();
            //lblStack.Text += optionsArray[1];
            btnNext.Enabled = true;
           
        }

        private void btnCheddar_Click(object sender, EventArgs e)
        {
           //optionsArray[1] = "cheddarCheese\n";
           // if (optionsArray[1] != "")
           // {
                
           //     lblStack.Text += optionsArray[1];     //??????????????
           // }
            //if (btnCheddar.Visible == true)
            //{
            //    btnCheddar.Enabled = false;
            //}

            string cheeseType = Cheese.createCheese("\ncheddar cheese");
            optionsArray[1] = cheeseType;
            build();
           // lblStack.Text += optionsArray[1];                                          
            btnNext.Enabled = true;
           
        }

        private void btnSwiss_Click(object sender, EventArgs e)
        {
            //optionsArray[1] = "swissCheese\n";
            //lblStack.Text += optionsArray[1];
            //btnNext.Enabled = true;


            //if (btnSwiss.Visible == true)
            //{
            //    btnSwiss.Enabled = false;
            //}


            string cheeseType = Cheese.createCheese("\nswiss cheese");
            optionsArray[1] = cheeseType;
            build();
            //lblStack.Text += optionsArray[1];
            btnNext.Enabled = true;
           
        }

        private void btnNoCheese_Click(object sender, EventArgs e)
        {
            //optionsArray[1] = "noCheese\n";
            //lblStack.Text += optionsArray[1];
            //btnNext.Enabled = true;



            //if (btnNoCheese.Visible == true)
            //{
            //    btnNoCheese.Enabled = false;
            //}


            string cheeseType = Cheese.createCheese("\nno cheese");
            optionsArray[1] = cheeseType;
            build();
           // lblStack.Text += optionsArray[1];
            btnNext.Enabled = true;
            
       
        }

        private void btnLettuce_Click(object sender, EventArgs e)
        {
            //optionsArray[2] = "lettuce\n";
            //lblStack.Text += optionsArray[2];
            //btnNext.Enabled = true;



            //if (btnLettuce.Visible == true)
            //{
            //    btnLettuce.Enabled = false;



            //    btnNoToppings.Enabled = false;

            //}


            string toppingType = Toppings.createToppings("\nlettuce");
            optionsArray[2] += toppingType;
            build();
           // lblStack.Text += optionsArray[2];
            btnNext.Enabled = true;
           // btnNoToppings.Enabled = false;

        }

        private void btnTomato_Click(object sender, EventArgs e)
        {
            //optionsArray[2] = "tomato\n";
            //lblStack.Text += optionsArray[2];
            //btnNext.Enabled = true;


            //if (btnTomato.Visible == true)
            //{
            //    btnTomato.Enabled = false;
            //    btnNoToppings.Enabled = false;

            //}


            string  toppingType = Toppings.createToppings("\ntomato");
            optionsArray[2] += toppingType;
            build();
            //lblStack.Text += optionsArray[2];
            btnNext.Enabled = true;
            //btnNoToppings.Enabled = false;
        }

        private void btnOnion_Click(object sender, EventArgs e)
        {
            //optionsArray[2] = "onion\n";
            //lblStack.Text += optionsArray[2];
            //btnNext.Enabled = true;

            //if (btnOnion.Visible == true)
            //{
            //    btnOnion.Enabled = false;
            //    btnNoToppings.Enabled = false;                                                   //No Toppings will show if one topping pushed


            //}



            string toppingType = Toppings.createToppings("\nonions");
            optionsArray[2] += toppingType;
            build();
            //lblStack.Text += optionsArray[2];
            btnNext.Enabled = true;
            //btnNoToppings.Enabled = false;
        }

        private void btnPickles_Click(object sender, EventArgs e)
        {
            //optionsArray[2] = "pickles\n";
            //lblStack.Text += optionsArray[2];
            //btnNext.Enabled = true;



            //if (btnPickles.Visible == true)
            //{
            //    btnPickles.Enabled = false;
            //    btnNoToppings.Enabled = false;

            //}


            string toppingType = Toppings.createToppings("\npickles");
            optionsArray[2] += toppingType;
            build();
           // lblStack.Text += optionsArray[2];
            btnNext.Enabled = true;
            //btnNoToppings.Enabled = false;
        }

        private void btnNoToppings_Click(object sender, EventArgs e)
        {
            //optionsArray[2] = "noToppings\n";
            //lblStack.Text += optionsArray[2];
            //btnNext.Enabled = true;
            string toppingType = Toppings.createToppings("\nno toppings");
            optionsArray[2] += toppingType;
            build();
            //lblStack.Text += optionsArray[2];
            btnNext.Enabled = true;
            //btnLettuce.Enabled = false;
            //btnOnion.Enabled = false;
            //btnTomato.Enabled = false;
            //btnPickles.Enabled = false;
        }

        private void btnKetchup_Click(object sender, EventArgs e)
        {
            //optionsArray[3] = "ketchup\n";
            //lblStack.Text += optionsArray[3];
            //btnNext.Enabled = true;




            //if (btnKetchup.Visible == true)
            //{
            //    btnKetchup.Enabled = false;
            //    btnNoSauce.Enabled = false;

            //}


            string sauceType = Sauce.createSauce("\nketchup");
            optionsArray[3] += sauceType;
            build();
            //lblStack.Text += optionsArray[3];
            btnNext.Enabled = true;
        
        }

        private void btnMayonnaise_Click(object sender, EventArgs e)
        {
            //optionsArray[3] = "mayonnaise\n";
            //lblStack.Text += optionsArray[3];
            //btnNext.Enabled = true;


            //if (btnMayonnaise.Visible == true)
            //{
            //    btnMayonnaise.Enabled = false;
            //    btnNoSauce.Enabled = false;

            //}


            string sauceType = Sauce.createSauce("\nmayonnaise");
            optionsArray[3] += sauceType;
            build();
            //lblStack.Text += optionsArray[3];
            btnNext.Enabled = true;
        }

        private void btnBbqSauce_Click(object sender, EventArgs e)
        {
            //optionsArray[3] = "bbqSauce\n";
            //lblStack.Text += optionsArray[3];
            //btnNext.Enabled = true;
            string sauceType = Sauce.createSauce("\nbbq sauce");
            optionsArray[3] += sauceType;
            build();
            //lblStack.Text += optionsArray[3];
            btnNext.Enabled = true;
        }

        private void btnSpecialSauce_Click(object sender, EventArgs e)
        {
            //optionsArray[3] = "specialSauce\n";
            //lblStack.Text += optionsArray[3];
            //btnNext.Enabled = true;
            string sauceType = Sauce.createSauce("\nmustard");
            optionsArray[3] += sauceType;
            build();
            //lblStack.Text += optionsArray[3];
            btnNext.Enabled = true;
        }

        private void btnNoSauce_Click(object sender, EventArgs e)
        {
            //optionsArray[3] = "noSauce\n";
            //lblStack.Text += optionsArray[3];
            //btnNext.Enabled = true;
            string sauceType = Sauce.createSauce("\nno sauce");
            optionsArray[3] += sauceType;
            build();
            //lblStack.Text += optionsArray[3];
            btnNext.Enabled = true;

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            pnlPrevNext.Visible = false;
            //if (btnYes.Visible == true)         //added if statement (2/27)
           pnlSummary.Visible = false;
           pnlComplete.Visible = true;
               
                   //btnNext.Enabled = true;
               //for (int i = 0; i < optionsArray.Length; i++)
               //{
               //    lblSummary3.Text +=
               //    String.Format("{0}", optionsArray[i]);
               //}
           
            //btnNext.Enabled = true;
            
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;

            pnlStart.Visible = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlBuild.Visible = false;
            pnlBun.Visible = true;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
            pnlSpecialty.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
            pnlPrevNext.Visible = true;
            
        }

        private void btnQuarterPounder_Click(object sender, EventArgs e)
        {
            lblStack.Text = "\nQuarterPounder with Cheese:\n\nwhite bun\namerican cheese\nonion\nketchup\nmustard";
            //specialtyArray[0] = "\nQuarterPounder with Cheese:\nonion\nketchup\nmustard";
            //lblStack.Text = specialtyArray[0];
            //lblSummary3.Text = specialtyArray[0];   
                                 
           // btnNext.Enabled = true;
            pnlPrevNext.Visible = true;

            pnlSpecialty.Visible =false;
            pnlSummary.Visible = true;
            btnNo.Visible = false;

            btnStartOver.Visible = true;
            
            //pnlComplete.Visible = true;
        }

        private void btnBigMac_Click(object sender, EventArgs e)
        {
            lblStack.Text = "\nBig Mac:\n\nwhite bun\namerican cheese\nlettuce\nonions\npickles\nspecial sauce";
            //btnNext.Enabled = true;
            pnlSpecialty.Visible = false;
            pnlSummary.Visible = true;
            btnNo.Visible = false;

            btnStartOver.Visible = true;
        }

        private void btnBun_Click(object sender, EventArgs e)
        {
               
            //for (int i = 1 ; i < optionsArray.Length; i++)
            
            //    lblStack.Text +=
            //    String.Format("{0}", optionsArray[i]);
            //for (int i = 1; i < optionsArray.Length; ++i)
            //{
            //    lblStack.Text=
            //    String.Format("{0}", optionsArray[i]);
            //}

                            
            //if (btnBun.Visible == true)
            //{
            //    btnWhite.Enabled = true;
            //    btnWheat.Enabled = true;
            //    btnPotato.Enabled = true;

            //    //for (int i = 1; i < optionsArray.Length; ++i)
            //    //{
            //    //    lblStack.Text =
            //    //    String.Format("{0}", optionsArray[i]);
            //    //}


                
              
            //                                   //Enabled button if bun button pushed
                
            //}
            //if (btnWhite. == true)
            //{
            //    for (int i = 1; i < optionsArray.Length; ++i)
            //    {
            //        lblStack.Text =
            //        String.Format("{0}", optionsArray[i]);
            //    }
            //}
           
           
            

            pnlStart.Visible = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlBuild.Visible = false;
            pnlBun.Visible = true;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
            pnlSpecialty.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
            pnlPrevNext.Visible = true;
            
        }

        //private void btnWhite_Click()
        //{
        //    throw new NotImplementedException();
        //}

        private void btnCheese_Click(object sender, EventArgs e)
        {
            //if (btnCheese.Visible == true)
            //{
            //    btnAmerican.Enabled = true;
            //    btnCheddar.Enabled = true;
            //    btnSwiss.Enabled = true;                                                          //need to change
            //    btnNoCheese.Enabled = true;
                
            //}
            pnlStart.Visible = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlBuild.Visible = false;
            pnlBun.Visible = false;
            pnlCheese.Visible = true;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
            pnlSpecialty.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
            pnlPrevNext.Visible = true;
            
        }

        private void btnToppings_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlBuild.Visible = false;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = true;
            pnlSauce.Visible = false;
            pnlSpecialty.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
            pnlPrevNext.Visible = true;
           // btnNoToppings.Enabled = true;

        }

        private void btnSauce_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlBuild.Visible = false;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = true;
            pnlSpecialty.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
            pnlPrevNext.Visible = true;
           // btnNoSauce.Enabled = true;

        }
        private void btnStartOver_Click(object sender, EventArgs e)
        {

            pnlStart.Visible = false;
            pnlLocation.Visible = true;
            pnlOrderType.Visible = false;
            pnlBuild.Visible = false;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
            pnlSpecialty.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;


            btnBun.Visible = false;
            btnCheese.Visible = false;                                          //03/03 changed
            btnToppings.Visible = false;
            btnSauce.Visible = false;
            btnPrevious.Visible = false;
            btnNext.Visible = false;
            lblOrder.Visible = false;
            lblStack.Visible = false;
            lblStack.Text = "";
            //pnlNav.Visible = true;
            //pnlStack.Visible = true;
            //pnlPrevNext.Visible = true;
        }

        

        //private void pnlComplete_VisibleChanged(object sender, EventArgs e) //takeout
        //{

        //}

        //private void btnBun_Click(object sender, EventArgs e)   //comment back in line 658 from Form1Designer when you want to use
        //{
           
        //}


        private void build()
        {
            lblStack.Text= optionsArray[0] +
                            optionsArray[1] +
                            optionsArray[2] +
                            optionsArray[3];
                           
            
        }

        

        ////private void remove()
        ////{
        ////   lblStack.Text = optionsArray[0] -
        ////                   optionsArray[1] -;
        ////}

            

    
      
        



    }
}
