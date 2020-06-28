using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlsv.Models;

namespace qlsv.Controllers
{
    public class TeacherController
    {
        public static bool AddTeacher(QLGV teacher)
        {
            try
            {
                {
                    using (var _context = new DBDOANWINEntities3())
                    {
                        _context.QLGVs.Add(teacher);
                        _context.SaveChanges();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        public static QLGV getTeacher(string MaGV)
        {
            using (var _context = new DBDOANWINEntities3())
            {
                var maGV = (from u in _context.QLGVs
                              where u.Ma_GV == MaGV
                              select u).ToList();
                if (maGV.Count == 1)
                {
                    return maGV[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static bool UpdateTeacher(QLGV teacher)
        {
            try
            {
                using (var _context = new DBDOANWINEntities3())

                {
                    _context.QLGVs.AddOrUpdate(teacher) ;
                    _context.SaveChanges();
                    return true;
                }
            }
            catch { return false; }

        }
        public static bool DeleteTeacher(string MaGV)
        {
            using (var _context = new DBDOANWINEntities3())
            {
                try
                {
                    var k = _context.QLGVs.Find(MaGV);
                    _context.QLGVs.Remove(k);
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

