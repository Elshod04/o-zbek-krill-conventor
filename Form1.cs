using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;


namespace UzbRusEngTextTransformer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<char, char> uz_ru = new Dictionary<char, char>
        {
            {'a', 'а'}, {'A', 'А'}, {'b', 'б'}, {'B', 'Б'}, {'d', 'д'}, {'D', 'Д'},
            {'e', 'е'}, {'E', 'Е'}, {'f', 'ф'}, {'F', 'Ф'}, {'g', 'г'}, {'G', 'Г'}, {'h', 'ҳ'}, {'H', 'Ҳ'},
            {'i', 'и'}, {'I', 'И'}, {'j', 'ж'}, {'J', 'Ж'}, {'k', 'к'}, {'K', 'К'}, {'l', 'л'}, {'L', 'Л'},
            {'m', 'м'}, {'M', 'М'}, {'n', 'н'}, {'N', 'Н'}, {'o', 'о'}, {'O', 'О'}, {'p', 'п'}, {'P', 'П'},
            {'q', 'қ'}, {'Q', 'Қ'}, {'r', 'р'}, {'R', 'Р'}, {'s', 'с'}, {'S', 'С'}, {'t', 'т'}, {'T', 'Т'},
            {'u', 'у'}, {'U', 'У'}, {'v', 'в'}, {'V', 'В'}, {'x', 'х'}, {'X', 'Х'},
            {'y', 'й'}, {'Y', 'Й'}, {'z', 'з'}, {'Z', 'З'}, {'\'', 'ъ'}, {'‘', 'ъ'}, {'`', 'ъ'}
        };

        private void button_uzb_krill_Click(object sender, EventArgs e)
        {
            string text = input_text.Text;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Matnni kiriting!!!", "Xatolik!", MessageBoxButtons.OK);
                return;
            }

            text = text.Replace("sh", "ш");
            text = text.Replace("Sh", "Ш");
            text = text.Replace("SH", "Ш");

            text = text.Replace("ch", "ч");
            text = text.Replace("Ch", "Ч");
            text = text.Replace("CH", "Ч");

            text = text.Replace("o'", "ў");
            text = text.Replace("O'", "Ў");
            text = text.Replace("o‘", "ў");
            text = text.Replace("O‘", "Ў");
            text = text.Replace("O", "Ў");
            text = text.Replace("o", "ў");

            text = text.Replace("g'", "ғ");
            text = text.Replace("G'", "Ғ");
            text = text.Replace("G‘", "Ғ");
            text = text.Replace("g‘", "ғ");
            text = text.Replace("g", "ғ");
            text = text.Replace("G", "Ғ");

            text = text.Replace("Ya", "Я");
            text = text.Replace("YA", "Я");
            text = text.Replace("ya", "я");


            text = text.Replace("yu", "ю");
            text = text.Replace("Yu", "Ю");
            text = text.Replace("YU", "Ю");


            string res = "";

            foreach (char c in text)
            {
                if (uz_ru.ContainsKey(c))
                {
                    res += uz_ru[c];
                }
                else res += c;
            }

            natija_text.Text = res;
        }

        private void input_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button_uzb_krill_Click(sender, e);
            }
        }



        Dictionary<char, char> ru_uz = new Dictionary<char, char>
        {
           {'а', 'a'}, {'А', 'A'}, {'б', 'b'}, {'Б', 'B'}, {'д', 'd'}, {'Д', 'D'},
           {'е', 'e'}, {'Е', 'E'}, {'ф', 'f'}, {'Ф', 'F'}, {'г', 'g'}, {'Г', 'G'}, {'ҳ', 'h'}, {'Ҳ', 'H'},
           {'и', 'i'}, {'И', 'I'}, {'ж', 'j'}, {'Ж', 'J'}, {'к', 'k'}, {'К', 'K'}, {'л', 'l'}, {'Л', 'L'},
           {'м', 'm'}, {'М', 'M'}, {'н', 'n'}, {'Н', 'N'}, {'о', 'o'}, {'О', 'O'}, {'п', 'p'}, {'П', 'P'},
           {'қ', 'q'}, {'Қ', 'Q'}, {'р', 'r'}, {'Р', 'R'}, {'с', 's'}, {'С', 'S'}, {'т', 't'}, {'Т', 'T'},
           {'у', 'u'}, {'У', 'U'}, {'в', 'v'}, {'В', 'V'}, {'х', 'x'}, {'Х', 'X'},
           {'й', 'y'}, {'Й', 'Y'}, {'з', 'z'}, {'З', 'Z'}
        };




        private void button_krill_uzb_Click(object sender, EventArgs e)
        {
            string text = input_text.Text;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Matnni kiriting!!!", "Xatolik!", MessageBoxButtons.OK);
                return;
            }

            text = text.Replace("ш", "sh").Replace("Ш", "Sh");
            text = text.Replace("ч", "ch").Replace("Ч", "Ch");
            text = text.Replace("ў", "o'").Replace("Ў", "O'");
            text = text.Replace("ғ", "g'").Replace("Ғ", "G'");
            text = text.Replace("Я", "Ya").Replace("я", "ya");
            text = text.Replace("Ю", "Yu").Replace("ю", "yu");
            text = text.Replace("ъ", "").Replace("Ъ", "");
            text = text.Replace("ы", "i").Replace("Ы", "I");


            string res = "";
            foreach (char c in text)
            {
                res += ru_uz.ContainsKey(c) ? ru_uz[c] : c;
            }

            natija_text.Text = res;
        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(natija_text.Text))
            {
                Clipboard.SetText(natija_text.Text);
                MessageBox.Show("Matn nusxalandi!", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nusxalash uchun matn yo'q!", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            input_text.Clear();
            natija_text.Clear();
        }

        private void input_text_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(input_text.Text))
            {
                natija_text.Clear();
                return;
            }


            if (!check(input_text.Text)) button_uzb_krill_Click(sender, e);
            else button_krill_uzb_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int w = (int)this.Width / 2;
            input_text.Width = w;
            natija_text.Left = w + 1;

        }
        private bool check(string s)
        {
            foreach (char c in s)
            {
                if (c >= 65 && c < 91 || c >= 97 && c <= 122)
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfile = new OpenFileDialog())
            {
                openfile.Filter = "Text files (*.txt)|*.txt|Word Document (*.docx)|*.docx|All files (*.*)|*.*";

                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    string extension = Path.GetExtension(openfile.FileName);

                    if (extension.Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        input_text.Text = File.ReadAllText(openfile.FileName);
                    }
                    else if (extension.Equals(".docx", StringComparison.OrdinalIgnoreCase))
                    {
                        using (var doc = DocX.Load(openfile.FileName))
                        {
                            input_text.Text = doc.Text;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tanlangan fayl formati qo‘llab-quvvatlanmaydi.", "Xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(natija_text.Text))
            {
                MessageBox.Show("Saqlash uchun malumot kiriting!", "Xatolik");
                return;
            }
            using (SaveFileDialog savefile = new SaveFileDialog())
            {
                //savefile.ShowDialog();
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(savefile.FileName, natija_text.Text);
                    MessageBox.Show("Saqlandi", "Malumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else return;

            }
        }
    }
}