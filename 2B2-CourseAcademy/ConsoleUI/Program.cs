using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
internal class Program
{
    private static void Main(string[] args)
    {
        //CategoryTest();
        //CourseTest();
        //InstrucorTest();
        //TastyTest();
        //Test();
        CourseManager courseManager = new CourseManager(new EfCourseDal());
        var result = courseManager.GetAll();

        if (result.IsSuccess)
        {
            foreach (var course in result.Data)
            {
                Console.WriteLine(course.CourseName);
            }
            Console.WriteLine(result.Message);
        }
        else
        {
            Console.WriteLine(result.Message);
        }

    }

    // private static void Test()
    // {
    //     CourseManager courseManager = new CourseManager(new EfCourseDal());
    //     var result = courseManager.GetByCourseDetails();
    //     if (result.IsSuccess)
    //     {
    //         foreach (var course in courseManager.GetByCourseDetails().Data)
    //         {
    //	Console.WriteLine("CourseId: " + course.Id + " | CourseName: " + course.CourseName
    //                 +" | CategoryName: "+ course.CategoryName);
    //}
    //         Console.WriteLine(result.Message);
    //     }
    //     else
    //     {
    //         Console.WriteLine(result.Message);
    //     }
    // }
    // private static void TastyTest()
    // {
    //     CourseManager courseManager = new CourseManager(new EfCourseDal());
    //     var result = courseManager.GetAll();
    //     if (result.IsSuccess)
    //     {
    //         foreach (var course in courseManager.GetAll().Data)
    //         {
    //             Console.WriteLine("CourseId: "+course.CourseId+" CourseName: "+course.CourseName);
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine(result.Message);
    //     }
    // }

    // private static void CourseTest()
    // {
    //     CourseManager courseManager = new CourseManager(new EfCourseDal());

    //     foreach (var course in courseManager.GetByCourseDetails().Data)
    //     {
    //         Console.WriteLine(course.CourseName + " " + course.CategoryName);

    //     }
    // }

    //    private static void CategoryTest()
    //    {
    //        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

    //        foreach (var category in categoryManager.GetAll())
    //        {
    //            Console.WriteLine(category.CategoryName);
    //        }
    //    }

    //    private static void InstructorTest()
    //    {
    //        InstructorManager instructorManager = new InstructorManager(new EfInstructorDal());

    //        var result = instructorManager.GetAll();

    //        if (result.IsSuccess)
    //        {
    //            foreach (var instructor in result.Message)
    //            {
    //                Console.WriteLine(instructor.InstructorName + " " + instructor.InstructorSurname);
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine(result.Message);
    //        }
    //    }
}