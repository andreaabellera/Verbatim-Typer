using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Verbatim_Typer
{
    public partial class Form1 : Form
    {
        private List<String> defHead = new List<String>();
        private List<String> defContent = new List<String>();
        private List<String> wordList = new List<String>();
        private List<String> masterList = new List<String>();
        private String currFileName = "data.txt";
        private int totalWords = 0;
        private int totalPress = 0;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
            processDefinitionData(currFileName);
            updateDefinitionData();
        }

        private void processDefinitionData(String filename) 
        {
            try
            {
                StreamReader sr = new StreamReader(filename);
                src_tbx.Text = filename;
                String line = sr.ReadLine().Trim();
                while (line != null)
                {
                    parseLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e) { Console.WriteLine("Error: " + e.Message); }
        }

        private void parseLine(String line) 
        {
            if(line != "") 
            {
                line = line.Trim();
                if(line[0] == '@') { defHead.Add(line.Substring(1)); }
                else if(line[0] == '#') { defContent.Add(line.Substring(1)); }
            }
        }

        private void updateDefinitionData() 
        {
            defSelector_cmbx.Items.Clear();
            foreach(String def in defHead) { defSelector_cmbx.Items.Add(def); }
        }

        private void updateScore() 
        {
            score++;
            score_lbl.Text = "Score: " + score + "/" + totalWords;
        }

        private void setWordList(String content) 
        {
            String[] contents = content.Split();
            wordList.AddRange(contents);
        }

        private void assessScore() 
        {
            float scr = (float)score / (float)totalWords;
            if (scr >= 0.9)
            {
                int index = defSelector_cmbx.SelectedIndex;
                String newMastered = head_lbl.Text;
                if (!masterList.Contains(newMastered)) { updateMasterList(newMastered); }
            }
        }

        private void updateMasterList(String def) 
        {
            masterList.Add(def);
            masterlist_lbl.Text += "\n" + def;
        }

        private void resetTyper() 
        {
            totalPress = 0;
            score = 0;
            score_lbl.Text = "Score: 0/" + totalWords;
            input_tbx.Clear();
            output_tbx.Clear();
            input_tbx.Enabled = true;
        }

        private void setNewDefinition(int index) 
        {
            wordList.Clear();
            setWordList(defContent.ElementAt(index));
            head_lbl.Text = defHead.ElementAt(index);
            totalWords = wordList.Count();
            score_lbl.Text = "Score: " + score + "/" + totalWords;
            input_tbx.Enabled = true;
        }


        /**************************************
         * EVENT HANDLERS
         * ***********************************/
        private void reset_btn_Click(object sender, EventArgs e)
        {
            resetTyper();
            masterList.Clear();
            masterlist_lbl.Text = "Masterlist:\n";
        }

        private void defSelector_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetTyper();
            int index = defSelector_cmbx.SelectedIndex;
            setNewDefinition(index);
        }


        private void random_btn_Click(object sender, EventArgs e)
        {
            resetTyper();
            Random r = new Random();
            int index = r.Next(0, defHead.Count);
            setNewDefinition(index);
        }

        private void repeat_btn_Click(object sender, EventArgs e)
        {
            resetTyper();
        }

        private void newDef_btn_Click(object sender, EventArgs e)
        {
            Form2 defGetter= new Form2();
            defGetter.ShowDialog();

            String newDefHead = defGetter.defHead;
            String newDefContent = defGetter.defContent;
            if (newDefHead != "" && newDefContent != "") 
            {
                defHead.Add(newDefHead);
                defContent.Add(newDefContent);
                updateDefinitionData();

                using (StreamWriter sw = File.AppendText(currFileName))
                {
                    sw.WriteLine("\n@" + newDefHead);
                    sw.WriteLine("#" + newDefContent);
                    sw.Close();
                }
            }
        }

        private void input_tbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            totalPress++;
            char letter = e.KeyChar;
            char target = wordList.ElementAt(totalPress - 1)[0];
            if (Char.ToUpper(letter) == Char.ToUpper(target)) { updateScore(); }
            if (totalPress == totalWords)
            {
                assessScore();
                input_tbx.Enabled = false;
            }
            output_tbx.Text += wordList.ElementAt(totalPress - 1) + " ";
        }

        private void switch_btn_Click(object sender, EventArgs e)
        {
            if (File.Exists(src_tbx.Text)) 
            {
                resetTyper();
                defHead.Clear();
                defContent.Clear();
                currFileName = src_tbx.Text;
                src_lbl.Text = "Current Source: " + currFileName;
                processDefinitionData(currFileName);
                updateDefinitionData();
            }
            else { src_tbx.Text = "File not found"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
