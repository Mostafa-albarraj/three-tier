using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_layer;

namespace Business_layer
{
    class Mylogic
    {
        public string get_Data_into_Mylogic(string name, string age)
        {
            Database sd = new Database();
            return sd.store Data(name, age);
        }
        public DataSet retrive_pass_Mylogic(int a)
        {
            Database ds = new Database();
            return ds.retrive_My_Data(a);
    }


}
