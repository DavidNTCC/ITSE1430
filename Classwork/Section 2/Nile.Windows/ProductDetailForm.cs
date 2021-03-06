﻿using System;
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
    public partial class ProductDetailForm : Form
    {
        public ProductDetailForm()
        {
            InitializeComponent();
        }

        private void ProductDetailForm_Load( object sender, EventArgs e )
        {

        }

        public Product Product { get; set; }
        private void OnSave( object sender, EventArgs e )
        {

            //Create product
            var product = new Product();
            product.Name = _labelName.Text;
            product.Description = _labelDescription.Text;
            product.Price = ConvertToPrice(_textPrice);
            product.IsDiscontinued = _checkIsDiscontinued.Checked;

            //Return from form
            Product = product;
            DialogResult = DialogResult.OK;
            //DialogResult = DialogResult.None;
            Close();
        }

        private decimal ConvertToPrice( TextBox control )
        {
            if (Decimal.TryParse(control.Text, out var price))
                return price;

            return -1;
        }
        private void OnCancel( object sender, EventArgs e )
        {
            //DialogResult = DialogResult.Cancel;
           //Close();
        }
    }
}
