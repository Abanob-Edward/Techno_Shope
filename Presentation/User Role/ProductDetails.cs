using Appliaction.Services;
using Autofac;
using Context;
using Infrastructure.Contract;
using Infrastructure.Repositores;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation.User_Role
{
    public partial class ProductDetails : Form
    {
        // ICartService CartService;
        IUserService UserService;
        IProductService ProductService;
        ICartService cartService;
        int currentUserId;
        string ProductImageSelction = "";
        string newImageName = "";
        string Idlabel;
        public ProductDetails(int? proID, int _currentUserId)
        {
            InitializeComponent();

            Idlabel = proID.ToString();

            var inject = AutoFact.Inject();
            ProductService = inject.Resolve<IProductService>();
            cartService = inject.Resolve<ICartService>();
            UserService = inject.Resolve<IUserService>();
            ///new
            

            currentUserId = _currentUserId;

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(Idlabel, out int productID))
            {

                int cartID = cartService.GetCartByUserID(currentUserId).Id;
                // int cartID = cartID1.Id;

                ProductCartItem addedProduct = cartService.addproductToCart(productID, cartID);

                if (addedProduct != null)
                {
                    MessageBox.Show("Product added to cart successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add product to cart.");
                }
            }
            else
            {
                MessageBox.Show("Invalid product ID.");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void ProductDetails_Load_1(object sender, EventArgs e)
        {


            // // string imagePath = @"C:\Users\ALAWAEL\OneDrive\Desktop\Asmaa\new\Techno_Shope\Presentation\images\images.jPEG";
            //string imagePath = @"C:\Users\ALAWAEL\OneDrive\Desktop\Asmaa\new\Techno_Shope\Presentation\images";


            //if (!string.IsNullOrEmpty(imagePath))
            //{
            //    try
            //    {
            //        pictureBox1.Image = Image.FromFile(imagePath);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error loading image: {ex.Message}");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No image found for this product.");
            //}



            int proID;


            if (int.TryParse(Idlabel, out proID))
            {
                Product product = ProductService.GettechById(proID);

                if (product != null)
                {
                    label7.Text = product.Name;
                    label8.Text = product.Description;
                    label9.Text = product.Price.ToString();

                    // string pic = product.Image;

                    //static image
                  //  string imagePath = @"C:\Users\ALAWAEL\OneDrive\Desktop\Asmaa\new\Techno_Shope\Presentation\images\download.jPG";
                    string imagePath = @"D:\Project\Techno_Shope\Presentation\images\download.jPG";

                    //daynamic image
                    // string imagePath = Path.Combine(@"C:\Users\ALAWAEL\OneDrive\Desktop\Asmaa\new5\Techno_Shope\Presentation\images", product.Image);


                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        try
                        {
                            pictureBox1.Image = Image.FromFile(imagePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading image: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No image found for this product.");
                    }



                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid product ID.");
            }



        }

        
    }
}

