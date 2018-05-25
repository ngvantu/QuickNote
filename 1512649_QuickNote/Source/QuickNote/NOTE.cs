	using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuickNote
{
    class NOTE
    {
        public int ID { get; set; }
        public string Content { get; set; }
     //   public List<string> Tags = new List<string>();
       
    }

    class TAG
    {
        public string TagName { get; set; }
        public List<int> ID = new List<int>() { };
    }

    class Manager
    {
        public static List<TAG> TagList;
        public static List<NOTE> NoteList;
        static Manager() {
            TagList = new List<TAG>();
            NoteList = new List<NOTE>();
        }

        public static void LoadDataFromFile()
        {
            // Load TagList
            StreamReader srTagList;
            try
            {
                using (srTagList = new StreamReader("../../tagslist.txt")) { }
            } 
            catch(Exception e)
            {
                return;
            }
            srTagList = new StreamReader("../../tagslist.txt");
            string data = srTagList.ReadLine();
            while (data != null)
            {
                TAG newTag = new TAG();
                newTag.TagName = data;
                data = srTagList.ReadLine();
                string[] values = data.Split(',');

                foreach (var id in values) 
                {
                    newTag.ID.Add(Int32.Parse(id)); 
                }
                TagList.Add(newTag);
                data = srTagList.ReadLine();
            }
            srTagList.Close();

            // Load NoteList content
            int countNote = TagList[0].ID.Max<int>() + 1;
            for (int i = 0; i < countNote; i++)
            {
                StreamReader srNoteList = new StreamReader("../../" + i.ToString() + ".txt");
                NOTE note = new NOTE();
                note.ID = i;
                note.Content = srNoteList.ReadToEnd();
                note.Content = note.Content.Remove(note.Content.Length - 2);
                NoteList.Add(note);
                srNoteList.Close();
            }          
        }

        public static void SaveDataToFile()
        {
            StreamWriter swTagList = new StreamWriter("../../tagslist.txt");
            foreach(var tag in TagList)
            {
                swTagList.WriteLine(tag.TagName);
                string tagID = string.Empty;
                foreach(var id in tag.ID)
                {
                    tagID += "," + id.ToString();
                }
                tagID = tagID.Remove(0, 1);
                swTagList.WriteLine(tagID);
            }
            swTagList.Close();

            int countNote = TagList[0].ID.Max<int>() + 1;
            for (int i = 0; i < countNote; i++)
            {
                StreamWriter swNote = new StreamWriter("../../" + i.ToString() + ".txt");
                swNote.WriteLine(NoteList[i].Content);
                swNote.Close();
            }
        }

        public static void SaveNewNote(string tags, string content)
        {
            // All Notes
            TagList[0].ID.Add(NoteList.Count);

            // Other tags
            List<string> singleTag = tags.Split(',').ToList<string>();
            for (int i = 0; i < singleTag.Count; i++)
            {
                singleTag[i] = singleTag[i].Trim();
            }
            singleTag.Distinct();

            foreach (var tagName in singleTag)
            {
                if (tagName == "") continue;
                bool isExist = false;
                for (int i = 1; i < TagList.Count; i++) 
                {
                    if (tagName == TagList[i].TagName)
                    {
                        TagList[i].ID.Add(NoteList.Count);
                        isExist = true;
                        break;
                    }
                }
                if (!isExist)
                {
                    TAG newTag = new TAG();
                    newTag.TagName = tagName;
                    newTag.ID.Add(NoteList.Count);
                    TagList.Add(newTag);
                }
            }

            NOTE note = new NOTE();
            note.ID = NoteList.Count;
            note.Content = content;
            NoteList.Add(note);
        }

        public static void UpdateNote(int id, string newTags, string newContent)
        {
            // Except All Notes
            for (int i = 1; i < TagList.Count; i++)
            {
                if (TagList[i].ID.Contains(id))
                    TagList[i].ID.Remove(id);
            }

            List<string> singleTag = newTags.Split(',').ToList<string>();
            for (int i = 0; i < singleTag.Count; i++)
            {
                singleTag[i] = singleTag[i].Trim();             
            }
            singleTag.Distinct();

            foreach (var tagName in singleTag)
            {
                if (tagName == "") continue;
                bool isExist = false;
                for (int i = 1; i < TagList.Count; i++)
                {
                    if (tagName == TagList[i].TagName)
                    {
                        TagList[i].ID.Add(id);
                        isExist = true;
                        break;
                    }
                }
                if (!isExist)
                {
                    TAG newTag = new TAG();
                    newTag.TagName = tagName;
                    newTag.ID.Add(id);
                    TagList.Add(newTag);
                }
            }

            NoteList[id].Content = newContent;
            for(int i = 0; i < TagList.Count; i++)
            {
                if (TagList[i].ID.Count == 0)
                {
                    TagList.RemoveAt(i);
                    i--;
                }
            }

        }

        public static void UpdateAllData()
        {
            if (TagList.Count == 0)
            {
                return;
            }
            foreach(var tag in TagList)
            {
                tag.ID.Sort();
            }           
            TAG temp = TagList[0];
            TagList.RemoveAt(0);

            List<TAG> tempList = TagList;
            tempList = tempList.OrderBy(o => o.TagName).ToList();

            TagList.Clear();
            TagList.Add(temp);
            TagList.AddRange(tempList);
        }
    }
}
