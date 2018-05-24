using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Clases
{
    public class Usuario
    {
        private int _id;
        private string _UserName;
        private int _PerfilId;
        private string _password;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        public int PerfilId
        {
            get { return _PerfilId; }
            set { _PerfilId = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

 

        public Usuario()
        {
        }

        public Usuario(int id,string UserName, int PerfilId, string password)
        {
            _id = id;
            _UserName = UserName;
            _PerfilId = PerfilId;
            _password = password;
        }
    }
}