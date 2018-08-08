using System;

namespace Project_Daisy.Model
{
    public class ShowcasedItem
    {
        public string Artist { get; set; }
        public int MediaType { get; set; }
        public string Style { get; set; }
        public int Speed { get; set; }
        public int Size { get; set; }
        public string RecordLabel { get; set; }
        public int DiscogsID { get; set; }
        public int ID { get; set; }
        public string UserID { get; set; }
        public string Title { get; set; }
        public int UserNum { get; set; }
        public string Genre { get; set; }
        public object Language { get; set; }
        public string Notes { get; set; }
        public string ImageUrl { get; set; }
        public int YearReleased { get; set; }
        public bool IsPhysical { get; set; }
        public bool IsNew { get; set; }
        public string LocationPurchased { get; set; }
        public DateTime DatePurchased { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime LastCompleted { get; set; }
        public int CompletionStatus { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateCompleted { get; set; }
        public bool CheckedOut { get; set; }
        public int TimesCompleted { get; set; }
        public object Category { get; set; }
        public string CountryOfOrigin { get; set; }
        public string CountryPurchased { get; set; }
        public bool IsShowcased { get; set; }
        public bool IsQueued { get; set; }
        public int QueueRank { get; set; }
    }
}