using System;

namespace mentoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var context = new MentoriaContext())
            {
               var instituition = new Instituition()
                {
                    Name = "Escola Professor Jocimar Teixeira"
                };

                context.Add(instituition);


                context.Add(new Student{
                    Name = "Silvana Huss",
                    Instituition = instituition
                });

                context.SaveChanges();
            }
        }
    }
}
