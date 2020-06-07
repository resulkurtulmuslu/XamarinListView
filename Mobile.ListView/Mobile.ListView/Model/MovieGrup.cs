using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.ListView.Model
{
    public class MovieGrup : List<Movie>
    {

        public string Title { get; set; }
        public string ShortName { get; set; }

        public MovieGrup(string title,string shortName)
        {
            Title = title;
            ShortName = shortName;
        }
    }
}
