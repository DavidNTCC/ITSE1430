using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nile.Windows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PlayingWithProductMembers( EventArgs e )
        {
            //this is a comment
            //base.OnLoad(e);
            
            var product = new Product();

            Decimal.TryParse("123", out decimal price);

            var name = product.Name;
            //var name = product.GetName();
            product.Name = "Product A";
            product.Price = 50;
            product.IsDiscontinued = true;

            var price2 = product.ActualPrice;
            //product.SetName("Product A");
            //product.Description = "None";
            var error = product.Validate();

            var str = product.ToString();

            var productB = new Product();
            productB.Name = "Product B";
            //productB.SetName("Product B");
            //productB.Description = product.Description;
            error = productB.Validate();
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);
            //PlayingWithProductMembers(e);
        }

        private void MainForm_Load( object sender, EventArgs e )
        {

        }
    }
}
