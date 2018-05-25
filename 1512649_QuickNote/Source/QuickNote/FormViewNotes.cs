using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickNote
{
    public partial class FormViewNotes : Form
    {
        KeyboardHook _keyboardHook; 
        public FormViewNotes()
        {
            InitializeComponent();
            _keyboardHook = new KeyboardHook();
            _keyboardHook.Install();
            _keyboardHook.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.LWin)
                {
                    _keyboardHook.keyLWin = true; ;
                }                
            };
            _keyboardHook.KeyUp += (sender, e) =>
            {
                if (e.KeyCode == Keys.LWin)
                {
                    _keyboardHook.keyLWin = false;                    
                }
                else if (e.KeyCode == Keys.N && _keyboardHook.keyLWin)
                {
                    FormNote formNote = new FormNote();
                    formNote.ShowDialog();

                    Manager.UpdateAllData();
                    LoadDataToListBox();
                    LoadDataToCollection();
                }
            };

            Manager.LoadDataFromFile();
            Manager.UpdateAllData();
            LoadDataToListBox();
            LoadDataToCollection();
        }

        public void LoadDataToListBox()
        {                   
            if (Manager.TagList.Count == 0)
            {
                TAG allNotes = new TAG();
                allNotes.TagName = "All Notes";
                Manager.TagList.Add(allNotes);
            }
            listBox_Tags.Items.Clear();   
            foreach(var tag in Manager.TagList)
            {
                listBox_Tags.Items.Add(tag.TagName + "   (" + tag.ID.Count.ToString() + ")");
            }
            listBox_Tags.SelectedIndex = 0;

            listBox_Notes.Items.Clear();
            foreach(var note in Manager.NoteList)
            {
                listBox_Notes.Items.Add(note.Content);
            }

            button_edit.Enabled = false;
            txtBox_Tags.Enabled = false;
            txtBox_Content.Enabled = false;
        } 

        public void LoadDataToCollection()
        {
            AutoCompleteStringCollection list = new AutoCompleteStringCollection();
            List<TAG> tagList = new List<TAG>();
            tagList.AddRange(Manager.TagList);
            tagList.RemoveAt(0);
            tagList = tagList.OrderByDescending(o => o.ID.Count).ThenBy(o => o.TagName).ToList();
            foreach(var tag in tagList)
            {
                list.Add(tag.TagName);
            }
            txtBox_Tags.AutoCompleteCustomSource = list;
        }

        private void noteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNote fNote = new FormNote();
            fNote.ShowDialog();

            Manager.UpdateAllData();
            LoadDataToListBox();
            LoadDataToCollection();
        }

        private void viewNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void viewStatitisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatistic fStatistic = new FormStatistic();
            fStatistic.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager.SaveDataToFile();
            Application.Exit();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void button_NewNote_Click(object sender, EventArgs e)
        {
            FormNote fNote = new FormNote();
            fNote.ShowDialog();

            Manager.UpdateAllData();
            LoadDataToListBox();
            LoadDataToCollection();
        }

        private void button_Statistics_Click(object sender, EventArgs e)
        {
            FormStatistic fStatistic = new FormStatistic();
            fStatistic.ShowDialog();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            string tags = txtBox_Tags.Text;
            string content = txtBox_Content.Text;
            if (tags == "" || content == "")
            {
                MessageBox.Show("Tags and Note field cannot be blank!", "Message", MessageBoxButtons.OK);
                return;
            }
            txtBox_Tags.Text = string.Empty;
            txtBox_Content.Text = string.Empty;

            string selectedNote = listBox_Notes.SelectedItem.ToString();
            int selectedNote_ID = -1;
            foreach (var note in Manager.NoteList)
            {
                if (selectedNote == note.Content)
                {
                    selectedNote_ID = note.ID;
                    break;
                }
            }
            int selectedTag = listBox_Tags.SelectedIndex;
            string selectedTag_Name = Manager.TagList[selectedTag].TagName;
            Manager.UpdateNote(selectedNote_ID, tags, content);

            Manager.UpdateAllData();
            LoadDataToListBox();           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox_Tags.SelectedIndex;
            if (selectedIndex != -1 && selectedIndex < Manager.TagList.Count)
            {
                listBox_Notes.Items.Clear();
                foreach (var id in Manager.TagList[selectedIndex].ID)
                {
                    listBox_Notes.Items.Add(Manager.NoteList[id].Content);
                }
            }
            txtBox_Tags.Text = string.Empty;
            txtBox_Content.Text = string.Empty;
            button_edit.Enabled = false;
            txtBox_Tags.Enabled = false;
            txtBox_Content.Enabled = false;
        }

        private void listBox_Notes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex_Tag = listBox_Tags.SelectedIndex;
            int selectedIndex_Note = listBox_Notes.SelectedIndex;
            if (selectedIndex_Note != -1 && selectedIndex_Note < Manager.TagList[selectedIndex_Tag].ID.Count)
            {
                string content = listBox_Notes.SelectedItem.ToString();              
                int selectedNote_ID = -1;
                foreach(var note in Manager.NoteList)
                {
                    if (content == note.Content)
                    {
                        selectedNote_ID = note.ID;
                        break;
                    }
                }
                string tagsString = "";
                for (int i = 1; i < Manager.TagList.Count; i++) 
                {
                    if (Manager.TagList[i].ID.Contains(selectedNote_ID))
                    {
                        tagsString += ", " + Manager.TagList[i].TagName;
                    }
                }
                tagsString = tagsString.Remove(0, 2);

                txtBox_Tags.Text = tagsString;
                txtBox_Content.Text = content;

                button_edit.Enabled = true;
                txtBox_Tags.Enabled = true;
                txtBox_Content.Enabled = true;
            }
        }

        private void FormViewNotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Manager.SaveDataToFile();
        }
    }
}
