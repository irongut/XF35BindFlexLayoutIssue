using System;
using System.Collections.Generic;

namespace XF35BindFlexLayoutIssue
{
    public class ListItem
    {
        public string Title { get; }
        public string MainText { get; }
        public List<string> Tags { get; }

        public ListItem(string title, string text)
        {
            Title = title;
            MainText = text;
            Tags = new List<string>();
            BuildTags();
        }

        private void BuildTags()
        {
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(1, 6); i++)
            {
                Tags.Add(String.Format("Tag #{0}", i));
            }
        }
    }
}
