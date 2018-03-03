using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // fiest term
            ElawadyDataStructureTest.Subject x1_1 = new ElawadyDataStructureTest.Subject("math1",111);
            ElawadyDataStructureTest.Subject x1_2 = new ElawadyDataStructureTest.Subject("physic1", 112);
            ElawadyDataStructureTest.Subject x1_3 = new ElawadyDataStructureTest.Subject("michanic1", 113);
            ElawadyDataStructureTest.Subject x1_4 = new ElawadyDataStructureTest.Subject("chimstry", 114);
            ElawadyDataStructureTest.Subject x1_5 = new ElawadyDataStructureTest.Subject("computer", 115);
            ElawadyDataStructureTest.Subject x1_6 = new ElawadyDataStructureTest.Subject("english1", 116);
            // second term
            ElawadyDataStructureTest.Subject x2_1 = new ElawadyDataStructureTest.Subject("math2", 121);
            ElawadyDataStructureTest.Subject x2_2 = new ElawadyDataStructureTest.Subject("physic2", 122);
            ElawadyDataStructureTest.Subject x2_3 = new ElawadyDataStructureTest.Subject("michanic2", 123);
            ElawadyDataStructureTest.Subject x2_4 = new ElawadyDataStructureTest.Subject("production", 124);
            ElawadyDataStructureTest.Subject x2_5 = new ElawadyDataStructureTest.Subject("drowing", 125);
            ElawadyDataStructureTest.Subject x2_6 = new ElawadyDataStructureTest.Subject("english2", 126);

            // third term
            ElawadyDataStructureTest.Subject x3_1 = new ElawadyDataStructureTest.Subject("math3", 211);
            ElawadyDataStructureTest.Subject x3_2 = new ElawadyDataStructureTest.Subject("structured programming", 212);
            ElawadyDataStructureTest.Subject x3_3 = new ElawadyDataStructureTest.Subject("logic design", 213);
            ElawadyDataStructureTest.Subject x3_4 = new ElawadyDataStructureTest.Subject("elctrical circuit 1", 214);
            ElawadyDataStructureTest.Subject x3_5 = new ElawadyDataStructureTest.Subject("elctrinics 1", 215);
            ElawadyDataStructureTest.Subject x3_6 = new ElawadyDataStructureTest.Subject("word processing", 216);

            // 4th term
            ElawadyDataStructureTest.Subject x4_1 = new ElawadyDataStructureTest.Subject("math4", 221);
            ElawadyDataStructureTest.Subject x4_2 = new ElawadyDataStructureTest.Subject("programming application", 222);
            ElawadyDataStructureTest.Subject x4_3 = new ElawadyDataStructureTest.Subject("measurment", 223);
            ElawadyDataStructureTest.Subject x4_4 = new ElawadyDataStructureTest.Subject("elctrical circuit 2", 224);
            ElawadyDataStructureTest.Subject x4_5 = new ElawadyDataStructureTest.Subject("elctrinics 2", 225);
            ElawadyDataStructureTest.Subject x4_6 = new ElawadyDataStructureTest.Subject("technical report", 226);


            // 5th term

            ElawadyDataStructureTest.Subject x5_1 = new ElawadyDataStructureTest.Subject("digital design", 311);
            ElawadyDataStructureTest.Subject x5_2 = new ElawadyDataStructureTest.Subject("data structure", 312);
            ElawadyDataStructureTest.Subject x5_3 = new ElawadyDataStructureTest.Subject("numiriacal", 313);
            ElawadyDataStructureTest.Subject x5_4 = new ElawadyDataStructureTest.Subject("communiaction theory", 314);
            ElawadyDataStructureTest.Subject x5_5 = new ElawadyDataStructureTest.Subject("energy systems", 315);
            ElawadyDataStructureTest.Subject x5_6 = new ElawadyDataStructureTest.Subject("technology", 316);

            //  6th term

            ElawadyDataStructureTest.Subject x6_1 = new ElawadyDataStructureTest.Subject("discrete math", 321);
            ElawadyDataStructureTest.Subject x6_2 = new ElawadyDataStructureTest.Subject("oop", 322);
            ElawadyDataStructureTest.Subject x6_3 = new ElawadyDataStructureTest.Subject("computer architecture", 323);
            ElawadyDataStructureTest.Subject x6_4 = new ElawadyDataStructureTest.Subject("electric machines", 324);
            ElawadyDataStructureTest.Subject x6_5 = new ElawadyDataStructureTest.Subject("communication system", 325);

            //  7th term 

            ElawadyDataStructureTest.Subject x7_1 = new ElawadyDataStructureTest.Subject("systems programming", 411);
            ElawadyDataStructureTest.Subject x7_2 = new ElawadyDataStructureTest.Subject("database systems", 412);
            ElawadyDataStructureTest.Subject x7_3 = new ElawadyDataStructureTest.Subject("microprocessors", 413);
            ElawadyDataStructureTest.Subject x7_4 = new ElawadyDataStructureTest.Subject("control systems", 414);
            ElawadyDataStructureTest.Subject x7_5 = new ElawadyDataStructureTest.Subject("algorithm", 4151);
            ElawadyDataStructureTest.Subject x7_6 = new ElawadyDataStructureTest.Subject("assembly", 4152);


            //  8th term

            ElawadyDataStructureTest.Subject x8_1 = new ElawadyDataStructureTest.Subject("data systems", 421);
            ElawadyDataStructureTest.Subject x8_2 = new ElawadyDataStructureTest.Subject("computer grapgics", 422);
            ElawadyDataStructureTest.Subject x8_3 = new ElawadyDataStructureTest.Subject("operating systems", 423);
            ElawadyDataStructureTest.Subject x8_4 = new ElawadyDataStructureTest.Subject("modern control", 424);
            ElawadyDataStructureTest.Subject x8_5 = new ElawadyDataStructureTest.Subject("modeling", 4251);
            ElawadyDataStructureTest.Subject x8_6 = new ElawadyDataStructureTest.Subject("microcomputer", 4252);


            //  9th term

            ElawadyDataStructureTest.Subject x9_1 = new ElawadyDataStructureTest.Subject("artifical intelligence", 511);
            ElawadyDataStructureTest.Subject x9_2 = new ElawadyDataStructureTest.Subject("computer network 1", 512);
            ElawadyDataStructureTest.Subject x9_3 = new ElawadyDataStructureTest.Subject("software engineering", 513);
            ElawadyDataStructureTest.Subject x9_4 = new ElawadyDataStructureTest.Subject("computer perfomance", 5141);
            ElawadyDataStructureTest.Subject x9_5 = new ElawadyDataStructureTest.Subject("project", 525);


            //  10th term

            ElawadyDataStructureTest.Subject x10_1 = new ElawadyDataStructureTest.Subject("computer syyems", 521);
            ElawadyDataStructureTest.Subject x10_2 = new ElawadyDataStructureTest.Subject("data security", 522);
            ElawadyDataStructureTest.Subject x10_3 = new ElawadyDataStructureTest.Subject("computer network 2", 523);
            ElawadyDataStructureTest.Subject x10_4 = new ElawadyDataStructureTest.Subject("neural network", 5241);
            ElawadyDataStructureTest.Subject x10_5 = new ElawadyDataStructureTest.Subject("project", 525);


            
            ElawadyDataStructureTest.Test.GetGrade();
            Console.In.Read();

        }
    }
}
