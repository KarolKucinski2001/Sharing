using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sharing.Models
{
    public class FeedbackModel
    {
        [PrimaryKey, AutoIncrement]
        public int FeedbackID { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        // Inne właściwości opinii

        // Metody opinii (np. Dodawanie, Edycja, Usuwanie)

    }
}
