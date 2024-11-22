using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryFlow
{
    internal class LoginSession
    {
        // 로그인 중인 사용자 정보 저장
        public static string LoggedInMemberName { get; set; }

        // 로그인 중인 사용자 권한 정보
        public static int UserPermission { get; set; } 
    }
}
