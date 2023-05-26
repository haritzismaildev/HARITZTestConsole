using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HARITZTestConsole
{
    class Program
    {
        // define the public class variable
        struct employee
        {
            public string[] EmpID;
            public string[] FullName;
            public DateTime[] BirthDate;
        }

        static void Main(string[] args)
        {
            // inherits public variable class above
            employee empi = new employee();

            // assign variable as the return value parameter trigger
            x:

            // show the information to user related to any requirement need to filled
            Console.WriteLine("Simple CRUD App with Structure !");
            Console.WriteLine("Press 1 to add value");
            Console.WriteLine("Press 2 to update value");
            Console.WriteLine("Press 3 to read value");
            Console.WriteLine("Press 4 to remove value");

            // asign class parameter as trigger start proccessing
            int proccess = Convert.ToInt32(Console.ReadLine());

            // error handling exception
            try
            {
                // start the proccess
                switch (proccess)
                {
                    case 1:
                        // assign variable as the value grab from user input
                        String[] employeeID = new String[5];
                        String[] fullName = new String[5];
                        DateTime[] birthDate = new DateTime[5];

                        // as the condition will input arrays by 5, so using the looping condition as get users multi insert also
                        for(int x = 0; x < 5; x++)
                        {
                            Console.WriteLine("Please Enter Employee ID :");
                            employeeID[x] = Console.ReadLine();

                            Console.WriteLine("Please Enter Employee FullName :");
                            fullName[x] = Console.ReadLine();

                            Console.WriteLine("Please Enter Employee BirthDate :");
                            birthDate[x] = Convert.ToDateTime(Console.ReadLine());

                            // here we make condition as validation for user input null
                            if(employeeID[x] == null)
                            {
                                Console.WriteLine("you has not insert any Employee ID, please insert first :");
                                employeeID[x] = Console.ReadLine();
                            } else if(fullName[x] == null)
                            {
                                Console.WriteLine("you has not insert any Full Name, please insert first :");
                                fullName[x] = Console.ReadLine();
                            }else if(birthDate[x] == null)
                            {
                                Console.WriteLine("you has not insert any birth date, please insert first :");
                                birthDate[x] = Convert.ToDateTime(Console.ReadLine());
                            }
                            else
                            {
                                // insert data into public memory class
                                empi.EmpID = employeeID;
                                empi.FullName = fullName;
                                empi.BirthDate = birthDate;
                                Console.WriteLine("Proccess Done, Data Inserted Successfully!!");
                            }

                            // continue to show the result that has inserted before
                            for(int y = 0; y < 5; y++)
                            {
                                Console.WriteLine("Data Employee ID = {1}", y, employeeID[y]);
                                Console.WriteLine("Data FullName = {2}", y, fullName[y]);
                                Console.WriteLine("Data Birth Date = {3}", y, birthDate[y]);
                            }
                        }

                        goto x;
                    case 2:
                        // first assign variable as the parameter trigger
                        String[] employeeID_2 = new String[5];
                        String[] fullName_2 = new String[5];
                        DateTime[] birthDate_2 = new DateTime[5];

                        // next is going into condition to proccess update as is an array data
                        for(int i = 0; i < 5; i++)
                        {
                            // show the data as changing needs
                            // first proccess employeeid
                            Console.WriteLine("Employee ID : " + empi.EmpID);
                            Console.WriteLine("please insert your employee ID wanna change : ");
                            employeeID_2[i] = Console.ReadLine();

                            // then proccess fullname
                            Console.WriteLine("Full Name : " + empi.FullName);
                            Console.WriteLine("please insert your Full Name wanna change : ");
                            fullName_2[i] = Console.ReadLine();

                            // last is for birth date
                            Console.WriteLine("Birth Date : " + empi.BirthDate);
                            Console.WriteLine("please insert your Birthdate wanna change : ");
                            birthDate_2[i] = Convert.ToDateTime(Console.ReadLine());

                            // after user triggered for next action
                            // create validation for null input
                            if(employeeID_2[i] == null)
                            {
                                Console.WriteLine("you has not insert any Employee ID, please insert first :");
                                employeeID_2[i] = Console.ReadLine();
                            }else if(fullName_2[i] == null)
                            {
                                Console.WriteLine("you has not insert any Full Name, please insert first :");
                                fullName_2[i] = Console.ReadLine();
                            }else if(birthDate_2[i] == null)
                            {
                                Console.WriteLine("you has not insert any birth date, please insert first :");
                                birthDate_2[i] = Convert.ToDateTime(Console.ReadLine());
                            }
                            else
                            {
                                // update data into public memory class
                                empi.EmpID = employeeID_2;
                                empi.FullName = fullName_2;
                                empi.BirthDate = birthDate_2;
                                Console.WriteLine("Proccess Done, Data Updated Successfully!!");
                            }
                        }

                        // continue to show the result that has inserted before
                        for(int j = 0; j < 5; j++)
                        {
                            Console.WriteLine("Data Employee ID = {1}", j, employeeID_2[j]);
                            Console.WriteLine("Data FullName = {2}", j, fullName_2[j]);
                            Console.WriteLine("Data Birth Date = {3}", j, birthDate_2[j]);
                        }
                        goto x;
                    case 3:
                        // show the current data systems got's
                        Console.WriteLine("your Employee ID Data : " + empi.EmpID);
                        Console.WriteLine("your Full Name Data : " + empi.FullName);
                        Console.WriteLine("your Birthdate Data : " + empi.BirthDate);
                        goto x;
                    case 4:
                        // first assign variable as the parameter trigger
                        String[] employeeID_3 = new String[5];
                        String[] fullName_3 = new String[5];
                        DateTime[] birthDate_3 = new DateTime[5];

                        // next going to condition into proccessing the deleted
                        for(int a = 0; a < 5; a++)
                        {
                            #region for employee id
                            Console.WriteLine("Employee ID : " + empi.EmpID);
                            Console.WriteLine("please insert your employee ID wanna deleted : ");
                            employeeID_3[a] = Console.ReadLine();

                            // proccessing the deleted after sync the data inputs by user by its own by memories
                            for (int a1 = 0; a1 < empi.EmpID.Length; a1++)
                            {
                                // making validation if user not input the value need for deleted
                                if (employeeID_3[a] == null)
                                {
                                    Console.WriteLine("you has not input any value, please input first !!");
                                    employeeID_3[a] = Console.ReadLine();
                                }
                                else
                                {
                                    if (employeeID_3[a] == Convert.ToString(empi.EmpID))
                                    {
                                        empi.EmpID = null;
                                    }
                                }
                            }
                            #endregion

                            #region fullname
                            Console.WriteLine("Full Name : " + empi.FullName);
                            Console.WriteLine("please insert your Full Name wanna deleted : ");
                            fullName_3[a] = Console.ReadLine();

                            // proccessing the deleted after sync the data inputs by user by its own by memories
                            for(int a2 = 0; a2 < empi.FullName.Length; a2++)
                            {
                                // making validation if user not input the value need for deleted
                                if(fullName_3[a] == null)
                                {
                                    Console.WriteLine("you has not input any value, please input first !!");
                                    fullName_3[a] = Console.ReadLine();
                                }
                                else
                                {
                                    if (fullName_3[a] == Convert.ToString(empi.FullName))
                                    {
                                        empi.FullName = null;
                                    }
                                }
                            }
                            #endregion
                        }
                        goto x;
                }
                Console.ReadKey();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
