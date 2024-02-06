using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class OtpViewModel
    {
        public OtpViewModel()
        {
            Success = true;
        }
        public bool Success { get; set; }
        public DateTime? Expire { get; set; }
        public string Message { get; set; }
        public string UserName { get; set; }
        public int Id { get; set; }
    }
}
