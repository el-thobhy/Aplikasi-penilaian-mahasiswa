using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ViewModel
{
    public class AnnouncementViewModel
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string? Title { get; set; }
        public string? Content { get; set; }
    }
    public class GetAnnouncementViewModel : AnnouncementViewModel
    {
        public string? Created_by { get; set; }
        public DateTime? Created_on { get; set; }
    }
}