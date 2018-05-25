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
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
        }

        public void MakeTagCloud()
        {

        }

        private void FormStatistic_Load(object sender, EventArgs e)
        {
            List<string> XValues = new List<string>();
            List<int> YValues = new List<int>();

            List<TAG> tagList = new List<TAG>();
            tagList.AddRange(Manager.TagList);
            tagList.RemoveAt(0);
            tagList = tagList.OrderByDescending(o => o.ID.Count).ThenBy(o => o.TagName).ToList();

            for (int i = 0; i < 5 && i < tagList.Count; i++)
            {
                XValues.Add(tagList[i].TagName);
                YValues.Add(tagList[i].ID.Count);
            }
            int otherTags = 0;
            for(int i = 5; i < tagList.Count; i++)
            {
                otherTags += tagList[i].ID.Count;
            }
            if (otherTags > 0)
            {
                XValues.Add("Others..");
                YValues.Add(otherTags);
            }
            chartTag.Series["Tag"].XValueMember = "Tag";
            chartTag.Series["Tag"].YValueMembers = "Number of corresponding notes";
            chartTag.Series["Tag"].Points.DataBindXY(XValues, YValues);
        }
    }
}
