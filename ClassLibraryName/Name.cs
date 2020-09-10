using System;

namespace ClassLibraryName
{
    public class Name
    {
        private string _myname;


        /// <summary>
        /// The Name class with one method
        /// </summary>
        /// <param name="name"></param>
        public Name(string name)
        {
            _myname = name;
        }


        /// <summary>
        /// Method that returns your name
        /// </summary>
        /// <returns>"My name is " + _myname</returns>
        public string MyNameIs()
        {
            return "My name is " + _myname;
        }
    }
}
