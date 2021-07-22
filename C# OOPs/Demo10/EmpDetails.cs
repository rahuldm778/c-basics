using System;

namespace Demo10
{
    public class EmpDetails
    {
        int cnt =0;
        public int ID {
            get{
                return cnt++;
            } private set{

            }
        }
        private string name;
        public string Name{
            get{
                return name;
            }
            set{
                name=Name;
            }
        }

        public string addres {get;  set;}
        public int PIN {get;set;}

        public long phone {get;set;}

        public int GrossSalary {get;set;}
        public int PF {get;set;}

        public int NetSalary {
            get{
                return GrossSalary - PF;
            }
        }

        public string grade{
            get{
                if(NetSalary > 10000){
                    return "A";
                }else if(NetSalary >= 5000){
                    return "B";
                }else{
                    return "c";
                }
            }
        }
    }
}