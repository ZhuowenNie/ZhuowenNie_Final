using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineTicket
{
    class TypeInfo
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String content;

        public String Content
        {
            get { return content; }
            set { content = value; }
        }

        public TypeInfo(String content,int id)
        {
            this.id = id;
            this.content = content;
        }
    }
}
