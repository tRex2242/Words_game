using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class game : Form
    {
        static string[] words;
        static string current_word;
        static string show_text;
        static int lives;
        static PictureBox[] lives_image;
        public game()
        {
            InitializeComponent();
            words = new string[] { "карнавал", "подарки", "костюм", 
                "ковогодний носок", "имбирный домик"};
            lives_image = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3,
                pictureBox, pictureBox5, pictureBox6 };
            current_word = " ";
            show_text = " ";
            lives = lives_image.Length;
        }

        void start_game(TextBox wordArea)
        {
            Random random = new Random();
            int index = random.Next(0, words.Length);
            current_word = words[index];
            show_text = get_show_text(current_word);
            wordArea.Text = show_text;
            lives = lives_image.Length;
        }

        void start_game(TextBox wordArea, PictureBox[] lives_image) 
        {
            start_game(wordArea);
            Image image = Properties.Resources._7;
            for(int i = 0; i < lives_image.Length; i++)
            {
                lives_image[i].Image = image;
            }
        }

        string get_show_text(string word)
        {
            return "";
        }

        bool is_contain(string word, char symbol)
        {

        }

        string get_new_show_text(string word, char symbol, string old_show_text)
        {
            return "";
        }

        void button_symbol_click(char symbol, TextBox wordArea, 
            Button cur_button, Button start_button)
        {

        }

    }
}
