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
                "дед мороз"};
            lives_image = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3,
                pictureBox, pictureBox5, pictureBox6 };
            current_word = " ";
            show_text = " ";
            lives = lives_image.Length;

            start_game(textBox1, lives_image);
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
            string result = "";
            for (int i = 0; i < word.Length; i++)
            {
                if(word[i] != ' ')
                {
                    result += "*";
                }
                else
                {
                    result += ' ';
                }
            }
            return result;
        }

        bool is_contain(string word, char symbol)
        {
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol)
                {
                    return true;
                }
            }
            return false;
        }

        string get_new_show_text(string word, char symbol, string old_show_text)
        {
            string new_show_text = "";
            for (int i = 0; i < word.Length; i++)
            {
                if(word[i] == symbol)
                {
                    new_show_text += symbol;
                }
                else
                {
                    new_show_text += old_show_text[i];
                }
            }
            return new_show_text;
        }

        void button_symbol_click(TextBox wordArea, char symbol,
            Button cur_button, Button start_button)
        {
            bool is_contains = is_contain(current_word, symbol);
            if (is_contains)
            {
                show_text = get_new_show_text(current_word, symbol, show_text);
                wordArea.Text = show_text;
            }
            else
            {
                lives--;
                lives_image[lives].Image = null;
            }
            if(lives == 0)
            {
                using (loser loser = new loser())
                {
                    loser.ShowDialog();
                }
                start_button.PerformClick();
            }
            else if(!is_contain(show_text, '*'))
            {
                using(win win = new win())
                {
                    win.ShowDialog();
                }
            }
            cur_button.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1,'а', button1, start228);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'б', button2, start228);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'в', button3, start228);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'г', button4, start228);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'д', button5, start228);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'е', button6, start228);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ж', button7, start228);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'з', button8, start228);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'и', button9, start228);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'к', button10, start228);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'л', button11, start228);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'м', button12, start228);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'н', button13, start228);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'о', button14, start228);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'п', button15, start228);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'р', button16, start228);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'с', button17, start228);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'т', button18, start228);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'у', button19, start228);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ф', button20, start228);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'х', button21, start228);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ц', button22, start228);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ч', button23, start228);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ш', button24, start228);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'щ', button25, start228);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ъ', button26, start228);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ы', button27, start228);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ь', button28, start228);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'э', button29, start228);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ю', button30, start228);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'я', button31, start228);
        }

    }
}
