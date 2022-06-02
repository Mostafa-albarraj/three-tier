using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class Facade
    {
        private Facade() { }
        public static Facade instance = null;
        public static Facade get_controller()
        {
            if (instance == null)
            {
                instance = new Facade();
            }
            return instance;
        }
        public string get_Data_into_Facade(string name, string age)
        {
            Mylogic m1 = new Mylogic();
            return m1.get_Data_into_Mylogic(name, age);
        }
        public DataSet retrive_pass(int a)
        {
            Mylogic m1 = new Mylogic();
            return m1.retrive_pass Mylogic(a);
    }



}
