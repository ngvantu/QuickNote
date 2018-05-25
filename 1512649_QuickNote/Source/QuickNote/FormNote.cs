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
    public partial class FormNote : Form
    {

        public FormNote()
        {
            InitializeComponent();
            LoadDataToCollection();
        }

        public void LoadDataToCollection()
        {
            AutoCompleteStringCollection list = new AutoCompleteStringCollection();
            List<TAG> tagList = new List<TAG>();
            tagList.AddRange(Manager.TagList);
            tagList.RemoveAt(0);
            tagList = tagList.OrderByDescending(o => o.ID.Count).ThenBy(o => o.TagName).ToList();
            foreach (var tag in tagList)
            {
                list.Add(tag.TagName);
            }
            textBox_Tags.AutoCompleteCustomSource = list;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string tags = textBox_Tags.Text;
            string content = textBox_Note.Text;
            if (tags == "" || content == "")
            {
                MessageBox.Show("Tags and Note field cannot be blank!", "Message", MessageBoxButtons.OK);
                return;
            }
            Manager.SaveNewNote(tags, content);
            
            this.Close();
        }

        private void FormNote_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.Hide();
        }
    }
}
