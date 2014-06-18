using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    public class Class : ICommentable
    {

        private List<string> comments;
        private List<Student> students;
        private List<Teacher> teachers;
        private string identifier;


        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
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

        public Class()
        {
            this.Teachers = new List<Teacher>();
            this.Students = new List<Student>();
            this.Comments = new List<string>();
        }

        public void Comment(string comment)
        {
            Comments.Add(comment);
        }
    }
}
