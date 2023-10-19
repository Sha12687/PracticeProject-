using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserExceptionBusinessLogic
{
    public class Movie
    {
        private int movieID;
        public int MovieID
        {
            get { return movieID; }
            set
            {
                if (value == 0)
                {
                    throw new IDException("Id must be greater then zero ... ");
                }
                else
                {
                    movieID = value;
                }
            }
        }

        private string movieName;
        public string MovieName
        {
            get { return movieName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new StringException("Name cannot be null");
                }
                else
                movieName = value;
            }
        }

        private string language;
        public string Language
        {
            get { return language; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new StringException("Name cannot be null");
                }
                else
                    language = value;
            }
        }


        public Movie(int movieID, string movieName, string language)
        {
            MovieID = movieID;
            MovieName = movieName;
            Language = language;
        }
    }
}
