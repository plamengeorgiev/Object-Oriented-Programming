using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    public class Teacher : Person, ICommentable
    {

        private List<string> comments;
        private List<Discipline> disciplines;

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
            }
        }

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

        public Teacher(string name)
            : base(name)
        {
            this.Disciplines = new List<Discipline>();
            this.Comments = new List<string>();
        }

        public void Comment(string comment)
        {
            Comments.Add(comment);
        }
    }
}
