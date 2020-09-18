using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0918
{

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string fName, string lName)
        {
            this.FirstName = fName;
             this.LastName = lName;
        }

        public override string ToString()
        {
            string str = $@" 성 : {this.FirstName}  이름 : {this.LastName}"; 
                

            return str;
        }

        public void PrintIngo()
        {
            Console.WriteLine();
        }

        public override bool Equals(object obj)
        {
            //if (obj is Person)
            //{
            //    Person temp = (Person)obj;
            //    if (this.FirstName == temp.FirstName && this.LastName == temp.LastName) { return true; }
            //    else { return false; }
            //}
            //else
            //    return false;

           return obj is Person temp && FirstName == temp.FirstName && LastName == temp.LastName;
        }

        public override int GetHashCode()
        {
            int result = EqualityComparer<string>.Default.GetHashCode(FirstName);
            result += EqualityComparer<string>.Default.GetHashCode(LastName);


            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Person per =  new Person("류","현진");
           
            Console.WriteLine(per.ToString());      //타입에 대한 풀이름이 값으로 나타나는 것


            Person per2 = new Person("류", "현진");
            if(per.Equals(per2))
                Console.WriteLine("동일한 이름입니다");
            else
                Console.WriteLine("다른 이름입니다.");
            //Type t1 = per.GetType();
            //Type t2 = typeof(Person);


            string str = "류현진";
            string str2 = "류현진";

            
            if (str.Equals(str2))
                Console.WriteLine("동일한 이름입니다");
            else
                Console.WriteLine("다른 이름입니다.");

            Console.WriteLine(per.GetHashCode());
            Console.WriteLine(per2.GetHashCode());
        }
    }
}
