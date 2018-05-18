using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsProjectCollection
    {
        public int Count
        {
            get
            {
                return mListNames.Count;
            }
            set
            {

            }

        }
        private List<clsProject> mListNames = new List<clsProject>();
   

        public List<clsProject> ListNames
        {
            get
            {
                return mListNames;
            }
            set
            {
                mListNames = value;
            }
        }

        public clsProject ThisProject { get; set; }
    }
    }
