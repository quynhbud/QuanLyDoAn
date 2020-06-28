using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlsv.Models;

namespace qlsv.Controllers
{
    
    public class StudentController
    {
        public static bool AddStudent(QLSV student)
        {

            try
            {
                {
                    using (var _context = new DBDOANWINEntities3())
                    {
                        _context.QLSVs.Add(student);
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
        public static QLSV getStudent(string maSV)
        {
            using (var _context = new DBDOANWINEntities3())
            {
                var MaSV = (from u in _context.QLSVs
                              where u.Ma_SV == maSV
                              select u).ToList();
                if (MaSV.Count == 1)
                {
                    return MaSV[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static bool UpdateStudent(QLSV student)
        {
            try
            {
                using (var _context = new DBDOANWINEntities3())

                {
                    _context.QLSVs.AddOrUpdate(student);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch { return false; }

        }
        public static bool DeleteStudent(string maSV)
        {
            using (var _context = new DBDOANWINEntities3())
            {
                try
                {
                    var k = _context.QLSVs.Find(maSV);
                    _context.QLSVs.Remove(k);
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
