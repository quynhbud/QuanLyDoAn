using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlsv.Models;

namespace qlsv.Controllers
{
    public class ProjectController
    {
        public static bool AddProject(QLDA project)
        {
            
            try
            {
                {
                    using (var _context = new DBDOANWINEntities3())
                    {
                        _context.QLDAs.Add(project);
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
        public static QLDA getProject(string MaDoAn)
        {
            using (var _context = new DBDOANWINEntities3())
            {
                var madoAn = (from u in _context.QLDAs
                            where u.Ma_ĐA == MaDoAn
                            select u).ToList();
                if (madoAn.Count == 1)
                {
                    return madoAn[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static bool UpdateProject(QLDA project)
        {
            try
            { 
                using (var _context = new DBDOANWINEntities3())

                {                 
                    _context.QLDAs.AddOrUpdate(project);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch { return false; }
        
        }
        public static bool DeleteProject(string MaDoAn)
        {
            using (var _context = new DBDOANWINEntities3())
            try
            {
                var k = _context.QLDAs.Find(MaDoAn);
                _context.QLDAs.Remove(k);
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
