using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMusic.Entidades
{
    public class Topic
    {
        public int idTopic {  get; set; }
        public string title { get; set; }
        public string asunto { get; set; }
        public DateTime Datetopic { get; set; }
        public int idTablon { get; set; }
    }
}
