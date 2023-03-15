
using SMS.Data.Entities;
	
namespace SMS.Data.Services;

// This interface describes the operations that a StudentService class should implement
public interface IStudentService
{
    // Initialise the repository (database)  
    void Initialise();
    
    // ---------------- Student Management --------------
    // Read 
    List<Student> GetStudents();
    Student GetStudent(int id);    
    Student GetStudentByEmail(string email);

    // Create/Update/Delete
    Student AddStudent(Student s);
    Student UpdateStudent(Student updated);  
    bool    DeleteStudent(int id);

}
    
