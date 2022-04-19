using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in types)
            {
                if (!type.GetCustomAttributes().Any(s=>s.GetType()==typeof(AuthorAttribute)))
                {
                    continue;
                }
                var attributes = type.GetCustomAttributes().Where(s => s.GetType() == typeof(AuthorAttribute)).Select(s=>(AuthorAttribute)s)
                    .ToArray();
                foreach (var att in attributes)
                {
                    Console.WriteLine(att.Name);
                }
            }
        }
    }
}
