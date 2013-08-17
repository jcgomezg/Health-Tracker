using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorksOrdersViewer
{
    class User
    {

        private String name;
        private String lastName;
        private int userId;

        public  User()
        {
            //TODO
        }

        public  User(String n , String ln , int id)
        {
            this.name = n;
            this.lastName = ln;
            this.userId = id;
        }






        public String userName
        {
            get { return this.name; }
            set { this.name = value; }
        }


        public String userLastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int userUserId
        {
            get { return this.userId; }
            set { this.userId = value; }

        }






    }
}
