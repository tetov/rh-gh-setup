using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace testproj1
{
    public class testproj1Info : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "testproj1";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("05be0534-c1f2-47d9-95e5-129aefc958cb");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
