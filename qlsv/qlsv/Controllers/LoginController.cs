using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlsv.Models;
using qlsv.views;

namespace qlsv.Controllers
{
    public class LoginController
    {
        static DBDOANWINEntities3 getuser = new DBDOANWINEntities3();
        public static bool Login(string Ten, string MK, string quyen)
        {
            var user = (from a in getuser.QLUsers
                        where a.Ten_dang_nhap == Ten.Trim() && a.Mat_khau == MK.Trim() && a.Quyen_han == quyen.Trim()
                        select a).ToList();
            if (user.Count == 1)
                return true;
            else
                return
                    false;
        }

        //public static bool Quyenhan(string quyen)
        //{

        //    var user = (from a in getuser.QLUsers
        //                where a.Quyen_han == quyen.Trim()
        //                select a).ToList();
        //    if (user.SingleOrDefault().Quyen_han == "Admin")
        //        return true;
        //    else 
        //        return false;
        //}
        public static QLUser Getaccount(string username)
        {
            using (var _context = new DBDOANWINEntities3())
            {
                var acc = (from u in _context.QLUsers
                            where u.Ten_dang_nhap == username
                            select u).ToList();
                if (acc.Count == 1)
                {
                    return acc[0];
                }
                else
                {
                    return null;
                }
            }
        }

        public static bool AddAccount (QLUser acc )
        { 
            try
            {
                using (var _context = new DBDOANWINEntities3())
                {
                    _context.QLUsers.Add(acc);
                    _context.SaveChanges();
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }
        public static bool UpdateAccout(QLUser acc)
        {
            try
            {
                using (var _context = new DBDOANWINEntities3())
                {
                    _context.QLUsers.AddOrUpdate(acc);
                    _context.SaveChanges();
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }
        public static bool DeleteAccount(string account)
        {
            using (var _context = new DBDOANWINEntities3())
            {
                try
                {
                    var k = _context.QLUsers.Find(account);
                    _context.QLUsers.Remove(k);
                    _context.SaveChanges();
                    return true;

                }
                catch
                {
                    return false;
                }
            }
        }

    }
}
