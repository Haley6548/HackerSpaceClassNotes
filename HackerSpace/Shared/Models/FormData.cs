using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerSpace.Shared.Models
{
    public class FormData
    {
        public string Text { get; set; }
        public bool IsSet { get; set; }

        private string radioGroupSelection;
        public string RadioGroupSelection { get; set; }
        public string TextArea { get; set; }
        public string DropDownSelection { get; set; }
        public DateTime DateTimeSelected { get; set; }
    }
}
