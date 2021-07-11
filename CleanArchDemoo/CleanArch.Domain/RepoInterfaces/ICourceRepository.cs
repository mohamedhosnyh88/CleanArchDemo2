using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.RepoInterfaces
{
  public  interface ICourceRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
