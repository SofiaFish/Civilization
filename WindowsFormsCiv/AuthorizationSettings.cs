using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCiv
{
    class AuthorizationSettings
    {
        Authorization authorization = new Authorization();

        public string NickName { get; set; }
        public string Civilization { get; set; }

        public AuthorizationSettings()
        {
            NickName = authorization.tbNickname.Text;
            Civilization = authorization.tbCivilzation.Text;

        }
}
}
