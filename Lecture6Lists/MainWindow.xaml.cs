using System.Net.Security;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Collections.Generic;

namespace Lecture6Lists
{
    /// Joshua Saetern
    /// 04.30.2024
    /// Lecture 6 Lists
    /// Computer Programming II
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Initialize 5 Rectangle objects 
            Rectangle rectangle1 = new Rectangle("Rectangle1");
            Rectangle rectangle2 = new Rectangle("Rectangle2");
            Rectangle rectangle3 = new Rectangle("Rectangle3");
            Rectangle rectangle4 = new Rectangle("Rectangle4");
            Rectangle rectangle5 = new Rectangle("Rectangle5");

            //Create a list and store 5 Rectangles
            List<Rectangle> rectangles = new List<Rectangle> {rectangle1 ,rectangle2 ,rectangle3 ,rectangle4 , rectangle5 };

            //Using InsertAt method
            Rectangle rectangle6 = new Rectangle("Rectangle6");
            Rectangle rectangle7 = new Rectangle("Rectangle7");

            //Im not sure how to use InsertAt method
            //rectangles.InsertAt(3, rectangle6);
            rectangles.Insert(3, rectangle6);
            rectangles.Insert(3, rectangle7);

            //Removing from List<T>
            
            //Using reference
            rectangles.Remove(rectangle1);
            rectangles.Remove(rectangle5);

            //Using specific index
            rectangles.RemoveAt(1);

            //Call display method
            DisplayRectanglesInRichTextBox(rectangles);
        }
        
        //Creating a Method
        public void DisplayRectanglesInRichTextBox(List<Rectangle> rectangles)
        {
            //Loop through list and display elements
            foreach (Rectangle rectangle in rectangles)
            {
                //Displays each element in rectangles
                richTextBoxDisplay.AppendText(rectangle.ToString() + "\n"); 
            }
        }

        private void richTextBoxDisplay_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}