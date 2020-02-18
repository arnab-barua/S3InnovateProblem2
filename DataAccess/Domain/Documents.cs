using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Domain
{
    public class Documents
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string MimeType { get; set; }
        public byte[] FileContent { get; set; }
    }
}
