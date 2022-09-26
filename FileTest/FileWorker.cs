using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTest
{
    public class FileWorker
    {
        public ObservableCollection<User> FileWork()
        {
          var userList= new ObservableCollection<User>();
            using (StreamReader reader= new StreamReader("C:\\Users\\пк\\source\\repos\\FileTest\\FileTest\\Files\\users1_1.txt") )
            {
                foreach (var item in reader.ReadToEnd().Split('\n'))
                {
                    var arrayString = item.Split(';') ;
                    if (arrayString[0]!="FirstName")
                    {
                        var user = new User()
                        {
                            FirstName = arrayString[0],
                            MiddleName = arrayString[1],
                            LastName = arrayString[2],
                            Age = int.Parse(arrayString[3]),
                            Salary = int.Parse(arrayString[4])
                        };
                        userList.Add(user);
                    }
                }
                return userList;
            }
        }
    }
}
