using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    public class Discipline : ICommentable
    {
        private List<string> comments;
        private string name;
        private int numberOfLectures;
        private int numberOfExercices;

        public List<string> Comments
        {
            get
            {
                return this.comments;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.comments = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercices;
            }
            set
            {
                this.numberOfExercices = value;
            }
        }

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfExercises = numberOfExercises;
            this.NumberOfLectures = numberOfLectures;
            this.Comments = new List<string>();
        }

        public void Comment(string comment)
        {
            Comments.Add(comment);
        }
    }
}
