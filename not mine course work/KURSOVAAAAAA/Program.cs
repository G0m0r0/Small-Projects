using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ConsoleApp7
{
    class Student
    {
        public string Name;
        public int FacultyNumber;
        public int GradeCount;
        public string GradesInput;
        public List<int> GradesList;// List<int> GradesList
        public double AvgGrade;
    }
    class Menu
    {
        public string Option()
        {
            Console.Clear();
            Console.Write("Choose an option from the menu below: \n\n" +
                          "1) Add a new student\n" +
                          "2) Add grades to an existing student\n" +
                          "3) Print students by: Name/Fac.num. and avg.Grade)\n" +
                          "4) Save students to a file \n" +
                          "5) Load students from a file\n" +
                          "6) Sort students by Fac. Num(selection.sort)\n" +
                          "7) Sort students by Avg. Grade(insertion.sort)\n" +
                          "8) Print dossier of students\n" +
                          "0) Quit\n\n" +
                          "Select option: ");

            string option = Console.ReadLine();
            if (option.Length > 1) Option();
            
            return option;
        }
    }
    class Program
    {
        static string CheckingName(string checkingname)
        {
            Console.Write("\nName: ");
            bool allLetters = false;
            while (!allLetters)
            {
                checkingname = Console.ReadLine();
                 allLetters = checkingname.All(c => Char.IsLetter(c));
                if (allLetters) break;
                Console.Write("\nPlease enter a valid name: ");
            }
            return checkingname;
        }
        static int CheckingGradeCount(int checkinggradecount)
        {
            var validgradecount = false;
            Console.Write("\nEnter the student's grade count: ");
            while (!validgradecount)
            {
                validgradecount = int.TryParse(Console.ReadLine(), out checkinggradecount)
                    && checkinggradecount > 0 && checkinggradecount < 40;
                if (validgradecount) break;
                Console.Write("\nEnter a valid grade count: ");
            }
            return checkinggradecount;
        }
        static int CheckingFacultyNumber(int checkingfacnum)
        {
            Console.Write("\nEnter the student's faculty number: ");
            var validfacnum = false;
            while (!validfacnum)
            {
                validfacnum = int.TryParse(Console.ReadLine(), out checkingfacnum)//need to fix duplicates
                    && checkingfacnum > 99999999 && checkingfacnum < 1000000000;
                if (validfacnum) break;
                Console.Write("\nEnter a valid faculty number: ");
            }
            return checkingfacnum;
        }
        static void Main(string[] args)
        {
            var menu = new Menu();
            var dictionaryStudents = new Dictionary<int, Student>(); //creating a dict.
            bool quit = false;

            do
            {
                switch (menu.Option())
                {
                    case "1":
                        {
                            try{
                                var student = new Student();
                                bool checkGrade = false;
                                student.Name = CheckingName(student.Name); //Enterng NAME and checking it

                                student.FacultyNumber = CheckingFacultyNumber(student.FacultyNumber); //entering and checking faculty number
                                if (dictionaryStudents.ContainsKey(student.FacultyNumber)) { Console.WriteLine("\n You cannot overwrite an existing student! Press any key to continue..."); Console.ReadLine(); break; }
                                student.GradeCount = CheckingGradeCount(student.GradeCount); //entering and checking gradecount

                                //entering grades in a string then converting it to a list
                                Console.Write("Enter grades on one line line with commas in between: ");// need to fix entering empty space error

                                student.GradesInput = Console.ReadLine();                                // and length of enter grades limit
                                string[] stringGrades = student.GradesInput.Split(',');
                                int[] arrGrades = Array.ConvertAll(stringGrades, int.Parse);
                                student.GradesList = arrGrades.ToList();
                                foreach (int grade in arrGrades) if (grade < 2 || grade > 6) checkGrade = true;
                                if (checkGrade) break;
                                if (stringGrades.Length > student.GradeCount) { Console.WriteLine("\nGrades more than grade count"); Console.ReadLine(); break; } //checking if grades are more than grade count
                                                                                                                                                                  

                                foreach (var grade in student.GradesList) { student.AvgGrade += grade; } //calculating avg grade of a student
                                student.AvgGrade = student.AvgGrade / stringGrades.Length;

                                dictionaryStudents.Add(student.FacultyNumber, student);
                            }
                            catch (System.FormatException)
                            {
                                Console.WriteLine("Error In grades input!...");Console.ReadLine();
                                break;

                            }
                            break;
                        }

                    case "2":
                        {
                            try
                            { 
                            var student = new Student();
                            //add grades to an exsisting student
                            bool checkGrade = false;
                            student.FacultyNumber = CheckingFacultyNumber(student.FacultyNumber); //entering and checking faculty number

                            if (dictionaryStudents.ContainsKey(student.FacultyNumber))
                            {
                                Console.Write("Enter grades on one line line with commas in between: ");// need to fix entering empty space error
                                string AddedGradesInput = Console.ReadLine();                                // and length of enter grades limit
                                string[] stringGrades = AddedGradesInput.Split(',');
                                int[] arrGrades = Array.ConvertAll(stringGrades, int.Parse);
                                List<int> ListAddedGrades = arrGrades.ToList();
                                //if (student.GradesList.Count + stringGrades.Length > 40) { Console.WriteLine("\n You have entered too much grades! (grades <=40)"); break; }
                                foreach (int grade in arrGrades) if (grade < 2 || grade > 6) checkGrade = true;
                                if (checkGrade) break;

                                if (dictionaryStudents.TryGetValue(student.FacultyNumber, out Student value))
                                {
                                    value.GradesList.AddRange(ListAddedGrades);
                                }
                                value.AvgGrade = 0;
                                foreach (var grade in value.GradesList) { value.AvgGrade += grade; } //calculating avg grade of a student
                                value.AvgGrade = value.AvgGrade / value.GradesList.Count;

                                value.GradesInput = value.GradesInput + "," + AddedGradesInput;
                            }

                            if (!dictionaryStudents.ContainsKey(student.FacultyNumber)) Console.WriteLine("\n Faculty Number not found. Press any key to continue...");
                            Console.ReadLine(); }
                            catch (System.FormatException)
                            {
                                Console.WriteLine("Error In grades input!..."); Console.ReadLine();
                                break;

                            }

                            break;
                        }
                    case "3":
                        {
                            foreach (var item in dictionaryStudents)  //Print the library with id/name/ avg grade
                            {
                                    Console.Write($"\nName: {item.Value.Name}  Faculty Number: {item.Key}  Average Grade: {item.Value.AvgGrade}");
                                    Console.Write("\n----------------------------------------------------------------------");
                            }
                            Console.ReadLine();
                            break;
                        }
                    case "4":
                        {
                            //save to a file
                            File.WriteAllLines(@"C:\Users\USER\Desktop\StudentsList.txt", 
                                dictionaryStudents.Select(item => String.Join(" / ","Faculty number: "+ item.Key,"Name: " + item.Value.Name , "Average Grade: " + item.Value.AvgGrade)));
                            Console.WriteLine("\nStudents list saved");
                            Console.ReadLine();
                            break;
                        }
                    case "5":
                        {
                            // read a file
                            if (!File.Exists(@"C:\Users\USER\Desktop\StudentsList.txt")) { Console.Write("\n File not found."); Console.ReadLine(); break; }
                            if (new FileInfo(@"C:\Users\USER\Desktop\StudentsList.txt").Length == 0) { Console.Write("\n File empty."); Console.ReadLine(); break; }
                           
                            string storage = File.ReadAllText(@"C:\Users\USER\Desktop\StudentsList.txt");
                            Console.WriteLine(storage);

                            Console.ReadLine();
                            break;
                        }
                    case "6":
                        {
                            var dictionaryKeyArray = dictionaryStudents.Keys.ToArray();   //need to implement selection sort
                            
                            int pos_min, temp;

                            for (int i = 0; i < dictionaryKeyArray.Length - 1; i++)
                            {
                                pos_min = i;//set pos_min to the current index of array

                                for (int j = i + 1; j < dictionaryKeyArray.Length; j++)
                                {
                                    if (dictionaryKeyArray[j] < dictionaryKeyArray[pos_min])
                                    {
                                        
                                        pos_min = j; //keep track of the index that min index
                                    }
                                }

                                if (pos_min != i) 
                                {
                                    temp = dictionaryKeyArray[i];
                                    dictionaryKeyArray[i] = dictionaryKeyArray[pos_min];
                                    dictionaryKeyArray[pos_min] = temp;
                                }
                            }
                            // Loop through keys.
                            for (int i = 0; i < dictionaryKeyArray.Length; i++)
                            {
                                if (dictionaryStudents.ContainsKey(dictionaryKeyArray[i]))
                                {
                                    if (dictionaryStudents.TryGetValue(dictionaryKeyArray[i], out Student value))
                                    {
                                        Console.Write($"\nName: {value.Name} Faculty Number: {dictionaryKeyArray[i]} Average Grade: {value.AvgGrade}");
                                        Console.Write("\n----------------------------------------------------------------------");
                                    }
                                }
                            }
                            Console.ReadLine();
                            break;
                        }
                    case "7":
                        {
                            List<double> dictionaryAvgList = new List<double>();
                            
                            foreach (var item in dictionaryStudents)
                            {
                                 dictionaryAvgList.Add(item.Value.AvgGrade); 
                            }
                            double[] dictionaryAvgArray = dictionaryAvgList.ToArray();
                            
                            for (int i = 1; i < dictionaryAvgArray.Length; i++)
                            {
                                double value = dictionaryAvgArray[i];
                                int j = i - 1;
                                while ((j >= 0) && (dictionaryAvgArray[j].CompareTo(value) < 0))
                                {
                                    dictionaryAvgArray[j + 1] = dictionaryAvgArray[j];
                                    j--;
                                }
                                dictionaryAvgArray[j + 1] = value;
                            }

                            int s = 0;
                            foreach (var item in dictionaryStudents)
                            {
                                
                                    Console.Write($"\nName: {item.Value.Name} Faculty Number: {item.Key} Average Grade: {dictionaryAvgArray[s]}");
                                    Console.Write("\n----------------------------------------------------------------------");
                                if (s == dictionaryAvgArray.Length) break;
                                s++;

                            }
                                Console.ReadLine();
                            break;
                        }
                    case "8":
                        {
                            var student = new Student();
                            int checkingFacultyNumber = CheckingFacultyNumber(student.FacultyNumber); //entering and checking faculty number

                            if (dictionaryStudents.ContainsKey(checkingFacultyNumber))
                                 if (dictionaryStudents.TryGetValue(checkingFacultyNumber, out Student value))
                                {
                                    Console.Write($"Name: {value.Name}  Faculty Number: {checkingFacultyNumber} Average Grade: {value.AvgGrade}  List of grades: {value.GradesInput}");
                                }
                            if (!dictionaryStudents.ContainsKey(checkingFacultyNumber)) Console.WriteLine("\n Faculty Number not found. Press any key to continue...");
                            Console.ReadLine();
                            break;
                        }
                    case "0":
                        {
                            Console.WriteLine("\nAre you sure you want to exit. Press any key to continue...\nIf you want to cancel press 'n' ");
                            string quitCheck = Console.ReadLine();
                            if ( quitCheck!="n") quit = true; break;
                        }
                }
            }
            while (!quit);

        }
    }
}
