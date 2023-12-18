using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns_in_C_.Singleton.Theoretical_example
{
    public class MySingleton
    {
        private static MySingleton _instance;

        private MySingleton()
        {
        }

        public static MySingleton GetInstance()
        {
            if( _instance == null ){
                _instance = new MySingleton();
            }
            return _instance;
        }
    }
}
