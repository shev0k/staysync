﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace housing.Classes
{
    public class Agenda
    {
        public int ID { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Description { get; set; }
        public string DescriptionList { get; set; }

        // Constructor for creating the Agenda
        public Agenda(int id, int day, int month, int year, string start, string end, string title, string desc)
        {
            this.ID = id;
            this.Day = day;
            this.Month = month;
            this.Year = year;
            this.Start = start;
            this.End = end;
            this.Title = title;
            this.Desc = desc;
            this.DescriptionList = $"{title}: {desc} \nDate: {day}-{month}-{year} \nStart: {start} | End: {end}";
            this.Description = $"{title}: {desc} | Date: {day}-{month}-{year} | Start: {start} | End: {end}";
        }

        // Default Constructor
        public Agenda() { }

        // Method for displaying info
        public string GetAgendaInfo()
        {
            return $"{ID} - {Description}";
        }

        // Method for getting just the message
        public string GetAgendaMessage()
        {
            if (this.Description.Contains(":"))
            {
                return this.Description.Split(':')[1].Trim();
            }
            else
            {
                return this.Description;
            }
        }
    }
}