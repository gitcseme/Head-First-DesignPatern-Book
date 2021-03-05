﻿namespace ObserverPattern.Publisher
{
    public class News
    {
        public News(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public string Title { get; set; }
        public string Description { get; set; }
    }
}
