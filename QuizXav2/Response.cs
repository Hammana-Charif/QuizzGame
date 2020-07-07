using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace Quiz
{
    public class Response
    {
        public string Label { get; set; }

        public Response()
        {

        }

        public override string ToString() => Label;
    }
}
