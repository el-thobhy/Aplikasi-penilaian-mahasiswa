using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ResponseResult
    {
        public ResponseResult()
        {
            Success = true;
        }
        public bool Success { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }
        public int Pages { get; set; }
    }
}
