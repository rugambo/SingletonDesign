using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//This class is designed to show how a singleton class works and only one instance of it can exist
namespace SingletonDesign
{
    internal class Person
    {
        static Person instance;
        public static Person Instance {
            get
            {
                if (instance != null)
                {
                    return instance;
                }else{
                    instance = new Person();
                    return instance;
                }

            }
            
        }

    }
}
