using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSender.Models
{
    public class MassTransitMessageModel
    {
        public string UrnProperty { get; set; }
        public List<MassTransitErrorModel>? ErrorModel { get; set; }

        public object MessageBody { get; set; }
    }
}
