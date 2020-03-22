using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw3.DAL{
    public class MockDbService : IDbService{
        private static IEnumerable<Student> studentsList;

        static MockDbService(){
            studentsList = new List<Student>()
            {
                new Student{ idNumber = 1, firstName = "Michal",lastName = "Bursztynowski", indexNumber = "s1"},
                new Student{ idNumber = 2, firstName = "Michal2",lastName = "Bursztynowski2", indexNumber = "s2"},
                new Student{ idNumber = 3, firstName = "Michal3",lastName = "Bursztynowski3", indexNumber = "s3"}
            };

        }
        public IEnumerable<Student> GetStudents(){
            return studentsList;
            throw new NotImplementedException();
        }
    }
}
