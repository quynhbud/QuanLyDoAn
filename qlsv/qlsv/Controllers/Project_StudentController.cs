using qlsv.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlsv.Controllers
{
    public class Project_StudentController
    {
        public static bool AddProject_Student(QLDASV doAnSV)
        {
            try
            {
                {
                    using (var _context = new DBDOANWINEntities3())
                    {
                        _context.QLDASVs.Add(doAnSV);
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
        public static QLDASV getProject_Student(string madoansv,string maSV, string maGV, string maDA)
        {
            using (var _context = new DBDOANWINEntities3())
            {
                var madasv = (from a in _context.QLDASVs where a.Ma_DASV == madoansv select a).ToList();
                if (madasv.Count == 1)
                    return madasv[0];
                else
                {
                    var maDASV = (from u in _context.QLDASVs
                                  where u.Ma_GV == maGV && u.Ma_SV == maSV && u.Ma_DA == maDA
                                  select u).ToList();
                    if (maDASV.Count == 1)
                    {
                        return maDASV[0];
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        public static bool  getProject (string db)
        {
            using (var _context = new DBDOANWINEntities3())
            {
                var maDA = (from a in _context.QLDAs where a.Ma_ĐA == db select a).ToList();
                if (maDA.Count == 1)
                    return true;
                else
                {
                    return false;
                }
            }
        }
        public static bool UpdateProject_Student(QLDASV DASV)
        {
            try
            {
                using (var _context = new DBDOANWINEntities3())

                {
                    _context.QLDASVs.AddOrUpdate(DASV);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch { return false; }

        }
        public static bool DeleteProject_Student(string madasv)
        {
            using (var _context = new DBDOANWINEntities3())
            {
                try
                {
                    var k = _context.QLDASVs.Find(madasv);
                    _context.QLDASVs.Remove(k);
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
