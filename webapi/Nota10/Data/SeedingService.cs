using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nota10.Models;

namespace Nota10.Data
{
    public class SeedingService
    {
        private Nota10Context _context;

        private bool DataBaseSeeded()
        {
            return _context.Instituitions.Any()
                || _context.Classrooms.Any()
                || _context.Students.Any();
        }


        public SeedingService(Nota10Context context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (DataBaseSeeded())
                return;

            Instituition i1 = new Instituition() { Id = 1, Name = "Escola Municipal Prof.º Jocimar Huss" };
            Instituition i2 = new Instituition() { Id = 2, Name = "Escola Municipal Profª. Silvana Rodrigues " };
            Instituition i3 = new Instituition() { Id = 3, Name = "Escola Municipal Profº. Robson Abrantes " };

            Classroom c1 = new Classroom() { Id = 1, Name = "4º Ano A", SchoolYear = 2019, Instituition = i1 };
            Classroom c2 = new Classroom() { Id = 2, Name = "4º Ano B", SchoolYear = 2019, Instituition = i1 };
            Classroom c3 = new Classroom() { Id = 3, Name = "5º Ano A", SchoolYear = 2019, Instituition = i1 };
            Classroom c4 = new Classroom() { Id = 4, Name = "5º Ano B", SchoolYear = 2019, Instituition = i1 };
            Classroom c5 = new Classroom() { Id = 5, Name = "4º Ano A", SchoolYear = 2019, Instituition = i2 };
            Classroom c6 = new Classroom() { Id = 6, Name = "5º Ano A", SchoolYear = 2019, Instituition = i2 };
            Classroom c7 = new Classroom() { Id = 7, Name = "4º Ano A", SchoolYear = 2019, Instituition = i3 };
            Classroom c8 = new Classroom() { Id = 8, Name = "4º Ano B", SchoolYear = 2019, Instituition = i3 };
            Classroom c9 = new Classroom() { Id = 9, Name = "5º Ano A", SchoolYear = 2019, Instituition = i3 };
            Classroom c10 = new Classroom() { Id = 10, Name = "5º Ano B", SchoolYear = 2019, Instituition = i3 };

            Student s1  = new Student() { Id = 1 , Name = "Abigail Farias", Classroom = c1 };
            Student s2  = new Student() { Id = 2 , Name = "Abraão Mafra", Classroom = c1 };
            Student s3  = new Student() { Id = 3 , Name = "Bernardo Sardina", Classroom = c1 };
            Student s4  = new Student() { Id = 4 , Name = "Calisto Anlicoara", Classroom = c1 };
            Student s5  = new Student() { Id = 5 , Name = "Camila Prada", Classroom = c1 };
            Student s6  = new Student() { Id = 6 , Name = "Capitolino Valadares", Classroom = c2 };
            Student s7  = new Student() { Id = 7 , Name = "Carla Temes", Classroom = c2 };
            Student s8  = new Student() { Id = 8 , Name = "Carlota Villaverde", Classroom = c2 };
            Student s9  = new Student() { Id = 9 , Name = "Catarina Isla", Classroom = c2 };
            Student s10 = new Student() { Id = 10, Name = "Celestino Mascarenhas", Classroom = c2 };
            Student s11 = new Student() { Id = 11, Name = "Cláudio Robalinho", Classroom = c3 };
            Student s12 = new Student() { Id = 12, Name = "Cássia Bernardes", Classroom = c3 };
            Student s13 = new Student() { Id = 13, Name = "Adolfo Mendonça", Classroom = c3 };
            Student s14 = new Student() { Id = 14, Name = "Elia Cairu", Classroom = c3 };
            Student s15 = new Student() { Id = 15, Name = "Emiliana Gameiro", Classroom = c3 };
            Student s16 = new Student() { Id = 16, Name = "Esmeralda Lobo", Classroom = c4 };
            Student s17 = new Student() { Id = 17, Name = "Esperança Salgueiro", Classroom = c4 };
            Student s18 = new Student() { Id = 18, Name = "Eusébio Bulhão", Classroom = c4 };
            Student s19 = new Student() { Id = 19, Name = "Girão Mendoça", Classroom = c4 };
            Student s20 = new Student() { Id = 20, Name = "Gustavo Pasos", Classroom = c4 };
            Student s21 = new Student() { Id = 21, Name = "Gustavo Rosmaninho", Classroom = c5 };
            Student s22 = new Student() { Id = 22, Name = "Ilma Montenegro", Classroom = c5 };
            Student s23 = new Student() { Id = 23, Name = "Joana Ramírez", Classroom = c5 };
            Student s24 = new Student() { Id = 24, Name = "Adélio Vila-Chã", Classroom = c5 };
            Student s25 = new Student() { Id = 25, Name = "Joel Leite", Classroom = c5 };
            Student s26 = new Student() { Id = 26, Name = "Jordana Mendonça", Classroom = c6 };
            Student s27 = new Student() { Id = 27, Name = "Lucília Peña", Classroom = c6 };
            Student s28 = new Student() { Id = 28, Name = "Lília Bicudo", Classroom = c6 };
            Student s29 = new Student() { Id = 29, Name = "Mafalda León", Classroom = c6 };
            Student s30 = new Student() { Id = 30, Name = "Magda Cisneros", Classroom = c6 };
            Student s31 = new Student() { Id = 31, Name = "Marcos Bensaúde", Classroom = c7 };
            Student s32 = new Student() { Id = 32, Name = "Mercedes Grilo", Classroom = c7 };
            Student s33 = new Student() { Id = 33, Name = "Neuza Baía", Classroom = c7 };
            Student s34 = new Student() { Id = 34, Name = "Ofélia Soto", Classroom = c7 };
            Student s35 = new Student() { Id = 35, Name = "Aida Bezerra", Classroom = c7 };
            Student s36 = new Student() { Id = 36, Name = "Olavo Madeira", Classroom = c8 };
            Student s37 = new Student() { Id = 37, Name = "Raul Sá", Classroom = c8 };
            Student s38 = new Student() { Id = 38, Name = "Reginaldo Passos", Classroom = c8 };
            Student s39 = new Student() { Id = 39, Name = "Rosaura Angelim", Classroom = c8 };
            Student s40 = new Student() { Id = 40, Name = "Sabrina Tabares", Classroom = c8 };
            Student s41 = new Student() { Id = 41, Name = "Teodoro Marinho", Classroom = c9 };
            Student s42 = new Student() { Id = 42, Name = "Teresa Coitinho", Classroom = c9 };
            Student s43 = new Student() { Id = 43, Name = "Vitória Piragibe", Classroom = c9 };
            Student s44 = new Student() { Id = 44, Name = "Zubaida Portella", Classroom = c9 };
            Student s45 = new Student() { Id = 45, Name = "Élvio Torrado", Classroom = c9 };
            Student s46 = new Student() { Id = 46, Name = "Alípio Betancour", Classroom = c10};
            Student s47 = new Student() { Id = 47, Name = "Anita Herrera", Classroom = c10};
            Student s48 = new Student() { Id = 48, Name = "Antero Moreira", Classroom = c10};
            Student s49 = new Student() { Id = 49, Name = "Antônia Santana", Classroom = c10};
            Student s50 = new Student() { Id = 50, Name = "Antônio Guerrero", Classroom = c10};           
           
            _context.Instituitions.AddRange(i1, i2, i3);

            _context.Classrooms.AddRange(c1, c2, c3, c4, c5, c6, c7, c8, c9, c10);

            _context.Students.AddRange(s1,s2,s3,s4,s5,s6,s7,s8,s9,s10,s11,s12,s13,s14,s15,s16,
                                        s17,s18,s19,s20,s21,s22,s23,s24,s25,s26,s27,s28,s29,s30,s31,s32,
                                        s33,s34,s35,s36,s37,s38,s39,s40,s41,s42,s43,s44,s45,s46,s47,s48,
                                        s49,s50);

            _context.SaveChanges();
        }
    }
}