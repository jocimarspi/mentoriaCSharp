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
                || _context.ClassRooms.Any()
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

            ClassRoom c1 = new ClassRoom() { Id = 1, Name = "4º Ano A", SchoolYear = 2019, Instituition = i1 };
            ClassRoom c2 = new ClassRoom() { Id = 2, Name = "4º Ano B", SchoolYear = 2019, Instituition = i1 };
            ClassRoom c3 = new ClassRoom() { Id = 3, Name = "5º Ano A", SchoolYear = 2019, Instituition = i1 };
            ClassRoom c4 = new ClassRoom() { Id = 4, Name = "5º Ano B", SchoolYear = 2019, Instituition = i1 };
            ClassRoom c5 = new ClassRoom() { Id = 5, Name = "4º Ano A", SchoolYear = 2019, Instituition = i2 };
            ClassRoom c6 = new ClassRoom() { Id = 6, Name = "5º Ano A", SchoolYear = 2019, Instituition = i2 };
            ClassRoom c7 = new ClassRoom() { Id = 7, Name = "4º Ano A", SchoolYear = 2019, Instituition = i3 };
            ClassRoom c8 = new ClassRoom() { Id = 8, Name = "4º Ano B", SchoolYear = 2019, Instituition = i3 };
            ClassRoom c9 = new ClassRoom() { Id = 9, Name = "5º Ano A", SchoolYear = 2019, Instituition = i3 };
            ClassRoom c10 = new ClassRoom() { Id = 10, Name = "5º Ano B", SchoolYear = 2019, Instituition = i3 };

            Student s1  = new Student() { Id = 1 , Name = "Abigail Farias", ClassRoom = c1 };
            Student s2  = new Student() { Id = 2 , Name = "Abraão Mafra", ClassRoom = c1 };
            Student s3  = new Student() { Id = 3 , Name = "Bernardo Sardina", ClassRoom = c1 };
            Student s4  = new Student() { Id = 4 , Name = "Calisto Anlicoara", ClassRoom = c1 };
            Student s5  = new Student() { Id = 5 , Name = "Camila Prada", ClassRoom = c1 };
            Student s6  = new Student() { Id = 6 , Name = "Capitolino Valadares", ClassRoom = c2 };
            Student s7  = new Student() { Id = 7 , Name = "Carla Temes", ClassRoom = c2 };
            Student s8  = new Student() { Id = 8 , Name = "Carlota Villaverde", ClassRoom = c2 };
            Student s9  = new Student() { Id = 9 , Name = "Catarina Isla", ClassRoom = c2 };
            Student s10 = new Student() { Id = 10, Name = "Celestino Mascarenhas", ClassRoom = c2 };
            Student s11 = new Student() { Id = 11, Name = "Cláudio Robalinho", ClassRoom = c3 };
            Student s12 = new Student() { Id = 12, Name = "Cássia Bernardes", ClassRoom = c3 };
            Student s13 = new Student() { Id = 13, Name = "Adolfo Mendonça", ClassRoom = c3 };
            Student s14 = new Student() { Id = 14, Name = "Elia Cairu", ClassRoom = c3 };
            Student s15 = new Student() { Id = 15, Name = "Emiliana Gameiro", ClassRoom = c3 };
            Student s16 = new Student() { Id = 16, Name = "Esmeralda Lobo", ClassRoom = c4 };
            Student s17 = new Student() { Id = 17, Name = "Esperança Salgueiro", ClassRoom = c4 };
            Student s18 = new Student() { Id = 18, Name = "Eusébio Bulhão", ClassRoom = c4 };
            Student s19 = new Student() { Id = 19, Name = "Girão Mendoça", ClassRoom = c4 };
            Student s20 = new Student() { Id = 20, Name = "Gustavo Pasos", ClassRoom = c4 };
            Student s21 = new Student() { Id = 21, Name = "Gustavo Rosmaninho", ClassRoom = c5 };
            Student s22 = new Student() { Id = 22, Name = "Ilma Montenegro", ClassRoom = c5 };
            Student s23 = new Student() { Id = 23, Name = "Joana Ramírez", ClassRoom = c5 };
            Student s24 = new Student() { Id = 24, Name = "Adélio Vila-Chã", ClassRoom = c5 };
            Student s25 = new Student() { Id = 25, Name = "Joel Leite", ClassRoom = c5 };
            Student s26 = new Student() { Id = 26, Name = "Jordana Mendonça", ClassRoom = c6 };
            Student s27 = new Student() { Id = 27, Name = "Lucília Peña", ClassRoom = c6 };
            Student s28 = new Student() { Id = 28, Name = "Lília Bicudo", ClassRoom = c6 };
            Student s29 = new Student() { Id = 29, Name = "Mafalda León", ClassRoom = c6 };
            Student s30 = new Student() { Id = 30, Name = "Magda Cisneros", ClassRoom = c6 };
            Student s31 = new Student() { Id = 31, Name = "Marcos Bensaúde", ClassRoom = c7 };
            Student s32 = new Student() { Id = 32, Name = "Mercedes Grilo", ClassRoom = c7 };
            Student s33 = new Student() { Id = 33, Name = "Neuza Baía", ClassRoom = c7 };
            Student s34 = new Student() { Id = 34, Name = "Ofélia Soto", ClassRoom = c7 };
            Student s35 = new Student() { Id = 35, Name = "Aida Bezerra", ClassRoom = c7 };
            Student s36 = new Student() { Id = 36, Name = "Olavo Madeira", ClassRoom = c8 };
            Student s37 = new Student() { Id = 37, Name = "Raul Sá", ClassRoom = c8 };
            Student s38 = new Student() { Id = 38, Name = "Reginaldo Passos", ClassRoom = c8 };
            Student s39 = new Student() { Id = 39, Name = "Rosaura Angelim", ClassRoom = c8 };
            Student s40 = new Student() { Id = 40, Name = "Sabrina Tabares", ClassRoom = c8 };
            Student s41 = new Student() { Id = 41, Name = "Teodoro Marinho", ClassRoom = c9 };
            Student s42 = new Student() { Id = 42, Name = "Teresa Coitinho", ClassRoom = c9 };
            Student s43 = new Student() { Id = 43, Name = "Vitória Piragibe", ClassRoom = c9 };
            Student s44 = new Student() { Id = 44, Name = "Zubaida Portella", ClassRoom = c9 };
            Student s45 = new Student() { Id = 45, Name = "Élvio Torrado", ClassRoom = c9 };
            Student s46 = new Student() { Id = 46, Name = "Alípio Betancour", ClassRoom = c10};
            Student s47 = new Student() { Id = 47, Name = "Anita Herrera", ClassRoom = c10};
            Student s48 = new Student() { Id = 48, Name = "Antero Moreira", ClassRoom = c10};
            Student s49 = new Student() { Id = 49, Name = "Antônia Santana", ClassRoom = c10};
            Student s50 = new Student() { Id = 50, Name = "Antônio Guerrero", ClassRoom = c10};           
           
            _context.Instituitions.AddRange(i1, i2, i3);

            _context.ClassRooms.AddRange(c1, c2, c3, c4, c5, c6, c7, c8, c9, c10);

            _context.Students.AddRange(s1,s2,s3,s4,s5,s6,s7,s8,s9,s10,s11,s12,s13,s14,s15,s16,
                                        s17,s18,s19,s20,s21,s22,s23,s24,s25,s26,s27,s28,s29,s30,s31,s32,
                                        s33,s34,s35,s36,s37,s38,s39,s40,s41,s42,s43,s44,s45,s46,s47,s48,
                                        s49,s50);

            _context.SaveChanges();
        }
    }
}