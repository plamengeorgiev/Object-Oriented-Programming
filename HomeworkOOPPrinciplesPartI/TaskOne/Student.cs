using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    public class Student : Person, ICommentable
    {
        private int classNumber;
        private List<string> comments;

        public List<string> Comments
        {
            get
            {
                return this.comments;
            }
            set
            {
                this.comments = value;
            }
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                this.classNumber = value;
            }
        }

        public Student(string name, int classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
            this.Comments = new List<string>();
        }

        public void Comment(string comment)
        {
            Comments.Add(comment);
        }
    }
}
