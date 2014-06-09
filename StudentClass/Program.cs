using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> list = new List<Student>();
            //11.Count of entries created    
            Student abc = new Student("Umur","Yuksel","yuksel@abc");
            int a = list.Count;
            Console.WriteLine("Items created" + " : " + a);
            list.Add(abc);
            list.Sort();

            

            foreach (var element in list)
            {

                Console.WriteLine(element);
                Console.ReadKey();


            }


        }
    }

    

    class Person
    {

        protected string name, lastName;

        public Person(string name, string lastName)
        {

            this.name = name;
            this.lastName = lastName;

        }

        public virtual string GetInfo()
        {
            return name + ", " + lastName;
        }




    }



    class Student : Person, IComparable
    {

        // 6. Student takes name , lastname , email

        public Student(string name, string lastName, string email)
            : base(name, lastName)
        {
            this.email = email;
        }


        // 7. Student takes name , lastname , location. 
        public Student(string name, string lastName, string location,string email)
            : base(name, lastName)
        {
            this.location = location;
            this.email = email;
        }


        // 1.Automatic property email.
        public string email
        {
            get;
            set;
        }


        //  5. empty destructor
        ~Student() { }


        // 3. Adding property to location .( get-set methods and controls )
        private string location
        {

            get
            {
                return this.location;
            }
            set
            {
                if (location == "SA")
                {
                    this.location = "Sarajevo";

                }

                if (location == "TZ")
                {

                    this.location = "Tuzla";

                }

                if (location == " ")
                {

                    this.location = "NA";

                }


            }
        }


        public bool setName(string input)
        {

            // 2. Checking the string size less than 2 .
            if (input.Length < 2)
            {
                Console.WriteLine("Name must be at least two characters long");

                return false;
            }

            // 2. Checking the string that must include only letters.
            if (input.All(Char.IsLetter) != true)
            {
                Console.WriteLine("Name can only have letters");

                return false;
            }

            // 3. Check first letter starts with uppercase .
            for (int i = 0; i <= input.Length; i++)
            {

                if (char.IsLower(input[0]))
                {
                    Console.WriteLine("Name must start9 with an uppercase letter");
                    return false;

                }

            }

            return true;


        }


        // 9 . Student info including email , location 

        public string getStudentInfo()
        {

            base.GetInfo();
            return this.email + " , " + this.location;

        }

        // 10. Compare to location between Students.

        public int CompareTo(Object obj)
        {
            if (obj is Person)


                return this.location.CompareTo((obj as Student).location);

            return 0;


        }

        // 12. Override tostring method
        public override string ToString()
        {
            return base.ToString();
        }


    }


}
