using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabbedPage
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int index = 0;

        private void TVLst(object sender, EventArgs e)
        {
            if (index != 0)
            {
                GrTV.IsVisible = true;
                GrMP.IsVisible = false;
                GrPJ.IsVisible = false;
                GrPL.IsVisible = false;

                bv0.IsVisible = true;
                bv1.IsVisible = false;
                bv2.IsVisible = false;
                bv3.IsVisible = false;

                lbl0.TextColor = Color.Yellow;
                lbl1.TextColor = Color.White;
                lbl2.TextColor = Color.White;
                lbl3.TextColor = Color.White;

                index = 0;

            }
        }

        private void MTLst(object sender, EventArgs e)
        {
            if (index != 1)
            {
                GrTV.IsVisible = false;
                GrMP.IsVisible = true;
                GrPJ.IsVisible = false;
                GrPL.IsVisible = false;

                bv0.IsVisible = false;
                bv1.IsVisible = true;
                bv2.IsVisible = false;
                bv3.IsVisible = false;

                lbl0.TextColor = Color.White;
                lbl1.TextColor = Color.Yellow;
                lbl2.TextColor = Color.White;
                lbl3.TextColor = Color.White;

                index = 1;

            }
        }

        private void PJLst(object sender, EventArgs e)
        {
            if (index != 2)
            {
                GrTV.IsVisible = false;
                GrMP.IsVisible = false;
                GrPJ.IsVisible = true;
                GrPL.IsVisible = false;

                bv0.IsVisible = false;
                bv1.IsVisible = false;
                bv2.IsVisible = true;
                bv3.IsVisible = false;

                lbl0.TextColor = Color.White;
                lbl1.TextColor = Color.White;
                lbl2.TextColor = Color.Yellow;
                lbl3.TextColor = Color.White;

                index = 2;

            }
        }

        private void VPLst(object sender, EventArgs e)
        {
            if (index != 3)
            {
                GrTV.IsVisible = false;
                GrMP.IsVisible = false;
                GrPJ.IsVisible = false;
                GrPL.IsVisible = true;

                bv0.IsVisible = false;
                bv1.IsVisible = false;
                bv2.IsVisible = false;
                bv3.IsVisible = true;

                lbl0.TextColor = Color.White;
                lbl1.TextColor = Color.White;
                lbl2.TextColor = Color.White;
                lbl3.TextColor = Color.Yellow;

                index = 3;

            }
        }
    }
}
