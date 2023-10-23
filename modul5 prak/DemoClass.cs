using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_prak
{
    public class DemoClass
    {
        public void CallerMethod()
        {
            try
            {
                CalledMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение перехвачено в CallerMethod: {ex.Message}");
            }
        }
        public void CalledMethod()
        {
            throw new InvalidOperationException("Ошибка в CalledMethod");
        }
    }

}
