using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExample.ProtoType
{
    public class Report : ICloneAble<Report>
    {
        private Guid _id;
        private string _header;
        private string _footer;
        private IList<string> _content;
        private Report() { }
        public Report(string header, string footer, IList<string> content)
        {
            _id = Guid.NewGuid();
            _header = header;
            _footer = footer;
            _content = content;
        }

        public void SetHeader(string header)
        {
            _header = header;
        }

        public void SetFooter(string footer)
        {
            _footer = footer;
        }

        public void AddContent(string content)
        {
            _content.Add(content);
        }

        public void RemoveContent(string content)
        {
            _content.Remove(content);
        }
        public Guid Id => _id;
        public string Header => _header;
        public string Footer => _footer;
        public IList<string> Content => _content.ToList();

        public Report Clone()
        {
            return new Report(_header, _footer, _content.ToList());
        }
    }
}
