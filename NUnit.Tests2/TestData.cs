﻿using System.Collections.Generic;
using Time_Table_Arranging_Program;
using Time_Table_Arranging_Program.Class;
using Time_Table_Arranging_Program.Class.Converter;
using Time_Table_Arranging_Program.Interfaces;
using Time_Table_Arranging_Program.Model;
using Time_Table_Arranging_Program.User_Control.SubjectListFolder;
using static NUnit.Tests2.TestData.Subjects;

namespace NUnit.Tests2 {
    public static class TestData {
        public static readonly List<Slot> TestSlots = new List<Slot>
        {
         new Slot(3,"MPU3113", " Hubungan Etnik (for Local Students)", "1", "L", Day.Parse("Mon"), "KB521", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("1-14")),
new Slot(5,"MPU3113", " Hubungan Etnik (for Local Students)", "2", "L", Day.Parse("Mon"), "KB521", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("1-14")),
new Slot(7,"MPU3113", " Hubungan Etnik (for Local Students)", "3", "L", Day.Parse("Tue"), "KB520", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("1-14")),
new Slot(9,"MPU3113", " Hubungan Etnik (for Local Students)", "4", "L", Day.Parse("Thu"), "KB316", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("1-14")),
new Slot(11,"MPU3123", " Tamadun Islam Dan Tamadun Asia (titas)", "1", "L", Day.Parse("Mon"), "KB520", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("1-14")),
new Slot(13,"MPU3123", " Tamadun Islam Dan Tamadun Asia (titas)", "2", "L", Day.Parse("Tue"), "KB520", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("1-14")),
new Slot(15,"MPU3123", " Tamadun Islam Dan Tamadun Asia (titas)", "3", "L", Day.Parse("Tue"), "KB521", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("1-14")),
new Slot(17,"MPU3123", " Tamadun Islam Dan Tamadun Asia (titas)", "4", "L", Day.Parse("Thu"), "KB316", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("1-14")),
new Slot(19,"MPU3143", " Bahasa Melayu Komunikasi 2", "1", "L", Day.Parse("Thu"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("1-14")),
new Slot(21,"MPU3173", " Malaysian Studies 3 (for International Students)", "1", "L", Day.Parse("Thu"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("1-14")),
new Slot(23,"MPU32013", " Bahasa Kebangsaan A", "1", "L", Day.Parse("Tue"), "KB314", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("1-14")),
new Slot(25,"MPU32043", " English For Engineering", "1", "L", Day.Parse("Mon"), "KB324", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("1-14")),
new Slot(27,"MPU32043", " English For Engineering", "2", "L", Day.Parse("Wed"), "KB323", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(16,0)), WeekNumber.Parse("1-14")),
new Slot(29,"MPU32043", " English For Engineering", "5", "L", Day.Parse("Thu"), "KB300", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(19,0)), WeekNumber.Parse("1-14")),
new Slot(31,"MPU32043", " English For Engineering", "1", "T", Day.Parse("Mon"), "KB324", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("1-14")),
new Slot(33,"MPU32043", " English For Engineering", "7", "T", Day.Parse("Thu"), "KB322", new TimePeriod(Time.CreateTime_24HourFormat(13,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("1-14")),
new Slot(35,"MPU33183", " Engineer In Society", "1", "L", Day.Parse("Tue"), "KB209", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("1-14")),
new Slot(37,"MPU33183", " Engineer In Society", "2", "L", Day.Parse("Thu"), "KB208", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(15,0)), WeekNumber.Parse("1-14")),
new Slot(39,"MPU34012", " Social Entrepreneurship Project", "1", "L", Day.Parse("Mon"), "KB322", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("1-14")),
new Slot(41,"MPU34022", " Arts And Cultural Performance", "1", "L", Day.Parse("Mon"), "KB314", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("1-14")),
new Slot(43,"MPU34072", " Art, Craft, And Design", "1", "L", Day.Parse("Mon"), "KB322", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(16,0)), WeekNumber.Parse("1-14")),
new Slot(45,"UALB1003", " Introduction To German Language", "1", "L", Day.Parse("Mon"), "KB322", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(19,0)), WeekNumber.Parse("1-14")),
new Slot(47,"UALB1003", " Introduction To German Language", "2", "L", Day.Parse("Wed"), "KB323", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(19,0)), WeekNumber.Parse("1-14")),
new Slot(49,"UALB1003", " Introduction To German Language", "1", "T", Day.Parse("Tue"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("1-14")),
new Slot(51,"UALB1003", " Introduction To German Language", "2", "T", Day.Parse("Tue"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(18,0),Time.CreateTime_24HourFormat(19,0)), WeekNumber.Parse("1-14")),
new Slot(53,"UALB1003", " Introduction To German Language", "3", "T", Day.Parse("Thu"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("1-14")),
new Slot(55,"UALB1003", " Introduction To German Language", "4", "T", Day.Parse("Thu"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(18,0),Time.CreateTime_24HourFormat(19,0)), WeekNumber.Parse("1-14")),
new Slot(57,"UALF1003", " Introduction To French", "1", "L", Day.Parse("Mon"), "KB324", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("1-14")),
new Slot(59,"UALF1003", " Introduction To French", "2", "L", Day.Parse("Tue"), "KB323", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("1-14")),
new Slot(61,"UALF1003", " Introduction To French", "1", "T", Day.Parse("Mon"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("1-14")),
new Slot(63,"UALF1003", " Introduction To French", "2", "T", Day.Parse("Mon"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("1-14")),
new Slot(65,"UALF1003", " Introduction To French", "3", "T", Day.Parse("Tue"), "KB319", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("1-14")),
new Slot(67,"UALF1003", " Introduction To French", "4", "T", Day.Parse("Tue"), "KB319", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("1-14")),
new Slot(69,"UALJ2013", " Introduction To Japanese", "1", "L", Day.Parse("Wed"), "KB324", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("1-14")),
new Slot(71,"UALJ2013", " Introduction To Japanese", "1", "T", Day.Parse("Wed"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("1-14")),
new Slot(73,"UALJ2013", " Introduction To Japanese", "2", "T", Day.Parse("Wed"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("1-14")),
new Slot(75,"UECM1653", " Mathematics For Engineering I", "4", "L", Day.Parse("Mon"), "KB520", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(16,0)), WeekNumber.Parse("1-14")),
new Slot(77,"UECM1653", " Mathematics For Engineering I", "4", "L", Day.Parse("Tue"), "KB520", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(9,0)), WeekNumber.Parse("1-14")),
new Slot(79,"UECM1653", " Mathematics For Engineering I", "8", "T", Day.Parse("Tue"), "KB519", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("1-14")),
new Slot(81,"UECM1653", " Mathematics For Engineering I", "11", "T", Day.Parse("Mon"), "KB519", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("1-14")),
new Slot(83,"UECM1713", " Mathematics For Engineering II", "1", "L", Day.Parse("Mon"), "KB213", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("1-14")),
new Slot(85,"UECM1713", " Mathematics For Engineering II", "1", "L", Day.Parse("Wed"), "KB214", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("1-14")),
new Slot(87,"UECM1713", " Mathematics For Engineering II", "2", "L", Day.Parse("Mon"), "KB214", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("1-14")),
new Slot(89,"UECM1713", " Mathematics For Engineering II", "2", "L", Day.Parse("Wed"), "KB209", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(9,0)), WeekNumber.Parse("1-14")),
new Slot(91,"UECM1713", " Mathematics For Engineering II", "1", "T", Day.Parse("Mon"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(9,0)), WeekNumber.Parse("1-14")),
new Slot(93,"UECM1713", " Mathematics For Engineering II", "2", "T", Day.Parse("Mon"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("1-14")),
new Slot(95,"UECM1713", " Mathematics For Engineering II", "3", "T", Day.Parse("Wed"), "KB314", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("1-14")),
new Slot(97,"UECM1713", " Mathematics For Engineering II", "4", "T", Day.Parse("Wed"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(15,0)), WeekNumber.Parse("1-14")),
new Slot(99,"UECM1713", " Mathematics For Engineering II", "5", "T", Day.Parse("Mon"), "KB523", new TimePeriod(Time.CreateTime_24HourFormat(15,0),Time.CreateTime_24HourFormat(16,0)), WeekNumber.Parse("1-14")),
new Slot(101,"UECM1713", " Mathematics For Engineering II", "6", "T", Day.Parse("Wed"), "KB314", new TimePeriod(Time.CreateTime_24HourFormat(16,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("1-14")),
new Slot(103,"UECM1713", " Mathematics For Engineering II", "7", "T", Day.Parse("Thu"), "KB519", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("1-14")),
new Slot(105,"UECM1713", " Mathematics For Engineering II", "8", "T", Day.Parse("Thu"), "KB523", new TimePeriod(Time.CreateTime_24HourFormat(13,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("1-14")),
new Slot(107,"UECM1713", " Mathematics For Engineering II", "9", "T", Day.Parse("Thu"), "KB320", new TimePeriod(Time.CreateTime_24HourFormat(15,0),Time.CreateTime_24HourFormat(16,0)), WeekNumber.Parse("1-14")),
new Slot(109,"UECM1713", " Mathematics For Engineering II", "10", "T", Day.Parse("Thu"), "KB320", new TimePeriod(Time.CreateTime_24HourFormat(16,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("1-14")),
new Slot(111,"UECM1713", " Mathematics For Engineering II", "11", "T", Day.Parse("Thu"), "KB319", new TimePeriod(Time.CreateTime_24HourFormat(18,0),Time.CreateTime_24HourFormat(19,0)), WeekNumber.Parse("1-14")),
new Slot(113,"UECM1713", " Mathematics For Engineering II", "12", "T", Day.Parse("Tue"), "KB519", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(9,0)), WeekNumber.Parse("1-14")),
new Slot(115,"UECM1713", " Mathematics For Engineering II", "13", "T", Day.Parse("Fri"), "KB524", new TimePeriod(Time.CreateTime_24HourFormat(14,30),Time.CreateTime_24HourFormat(15,30)), WeekNumber.Parse("1-14")),
new Slot(117,"UECM1713", " Mathematics For Engineering II", "14", "T", Day.Parse("Fri"), "KB524", new TimePeriod(Time.CreateTime_24HourFormat(15,30),Time.CreateTime_24HourFormat(16,30)), WeekNumber.Parse("1-14")),
new Slot(119,"UECM2623", " Numerical Methods And Statistics", "1", "L", Day.Parse("Tue"), "KB213", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("1-14")),
new Slot(121,"UECM2623", " Numerical Methods And Statistics", "1", "L", Day.Parse("Thu"), "KB209", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(9,0)), WeekNumber.Parse("1-14")),
new Slot(123,"UECM2623", " Numerical Methods And Statistics", "2", "L", Day.Parse("Tue"), "KB213", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(16,0)), WeekNumber.Parse("1-14")),
new Slot(125,"UECM2623", " Numerical Methods And Statistics", "2", "L", Day.Parse("Thu"), "KB214", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("1-14")),
new Slot(127,"UECM2623", " Numerical Methods And Statistics", "1", "T", Day.Parse("Mon"), "KB516", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("1-14")),
new Slot(129,"UECM2623", " Numerical Methods And Statistics", "2", "T", Day.Parse("Tue"), "KB323", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("1-14")),
new Slot(131,"UECM2623", " Numerical Methods And Statistics", "3", "T", Day.Parse("Tue"), "KB314", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("1-14")),
new Slot(133,"UECM2623", " Numerical Methods And Statistics", "4", "T", Day.Parse("Tue"), "KB523", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("1-14")),
new Slot(135,"UECM2623", " Numerical Methods And Statistics", "5", "T", Day.Parse("Thu"), "KB519", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("1-14")),
new Slot(137,"UECM2623", " Numerical Methods And Statistics", "6", "T", Day.Parse("Thu"), "KB324", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("1-14")),
new Slot(139,"UECM2623", " Numerical Methods And Statistics", "7", "T", Day.Parse("Thu"), "KB321", new TimePeriod(Time.CreateTime_24HourFormat(16,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("1-14")),
new Slot(141,"UECM2623", " Numerical Methods And Statistics", "8", "T", Day.Parse("Tue"), "KB520", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("1-14")),
new Slot(143,"UECM2623", " Numerical Methods And Statistics", "9", "T", Day.Parse("Thu"), "KB518", new TimePeriod(Time.CreateTime_24HourFormat(15,0),Time.CreateTime_24HourFormat(16,0)), WeekNumber.Parse("1-14")),
new Slot(145,"UECM2623", " Numerical Methods And Statistics", "10", "T", Day.Parse("Thu"), "KB320", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("1-14")),
new Slot(147,"UECM2623", " Numerical Methods And Statistics", "11", "T", Day.Parse("Mon"), "KB314", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("1-14")),
new Slot(149,"UECM2623", " Numerical Methods And Statistics", "12", "T", Day.Parse("Mon"), "KB516", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("1-14")),
new Slot(151,"UECM2623", " Numerical Methods And Statistics", "13", "T", Day.Parse("Wed"), "KB519", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("1-14")),
new Slot(153,"UECM2623", " Numerical Methods And Statistics", "14", "T", Day.Parse("Wed"), "KB524", new TimePeriod(Time.CreateTime_24HourFormat(13,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("1-14")),
new Slot(155,"UECS1643", " Fundamentals Of Programming", "2", "L", Day.Parse("Tue"), "KB213", new TimePeriod(Time.CreateTime_24HourFormat(16,0),Time.CreateTime_24HourFormat(18,30)), WeekNumber.Parse("1-14")),
new Slot(157,"UECS1643", " Fundamentals Of Programming", "6", "P", Day.Parse("Mon"), "KB605", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("1-2,4,6-14")),
new Slot(159,"UECS1643", " Fundamentals Of Programming", "10", "P", Day.Parse("Thu"), "KB605", new TimePeriod(Time.CreateTime_24HourFormat(15,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("1-4,6-14")),
new Slot(161,"UECS1643", " Fundamentals Of Programming", "13", "P", Day.Parse("Wed"), "KB606", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("1-4,6-14")),
new Slot(163,"UECS1643", " Fundamentals Of Programming", "14", "P", Day.Parse("Thu"), "KB608", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("1-4,6-14")),
new Slot(165,"UECS1643", " Fundamentals Of Programming", "15", "P", Day.Parse("Thu"), "KB606", new TimePeriod(Time.CreateTime_24HourFormat(15,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("1-4,6-14")),
new Slot(167,"UEME1112", " Engineering Thermodynamics I", "1", "L", Day.Parse("Mon"), "KB209", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("1-14")),
new Slot(169,"UEME1112", " Engineering Thermodynamics I", "3", "L", Day.Parse("Fri"), "KB208", new TimePeriod(Time.CreateTime_24HourFormat(10,30),Time.CreateTime_24HourFormat(12,30)), WeekNumber.Parse("1-14")),
new Slot(171,"UEME1112", " Engineering Thermodynamics I", "5", "P", Day.Parse("Mon"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("2,8")),
new Slot(173,"UEME1112", " Engineering Thermodynamics I", "6", "P", Day.Parse("Mon"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("4,10")),
new Slot(175,"UEME1112", " Engineering Thermodynamics I", "7", "P", Day.Parse("Mon"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("6,12")),
new Slot(177,"UEME1112", " Engineering Thermodynamics I", "8", "P", Day.Parse("Mon"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("7,11")),
new Slot(179,"UEME1112", " Engineering Thermodynamics I", "14", "P", Day.Parse("Tue"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("2,8")),
new Slot(181,"UEME1112", " Engineering Thermodynamics I", "15", "P", Day.Parse("Tue"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("3,9")),
new Slot(183,"UEME1112", " Engineering Thermodynamics I", "16", "P", Day.Parse("Tue"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("4,10")),
new Slot(185,"UEME1112", " Engineering Thermodynamics I", "17", "P", Day.Parse("Tue"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("6,12")),
new Slot(187,"UEME1112", " Engineering Thermodynamics I", "18", "P", Day.Parse("Tue"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("7,11")),
new Slot(189,"UEME1112", " Engineering Thermodynamics I", "19", "P", Day.Parse("Wed"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("2,8")),
new Slot(191,"UEME1112", " Engineering Thermodynamics I", "20", "P", Day.Parse("Wed"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("3,9")),
new Slot(193,"UEME1112", " Engineering Thermodynamics I", "21", "P", Day.Parse("Wed"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("4,10")),
new Slot(195,"UEME1112", " Engineering Thermodynamics I", "22", "P", Day.Parse("Wed"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("6,12")),
new Slot(197,"UEME1112", " Engineering Thermodynamics I", "24", "P", Day.Parse("Wed"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("2,8")),
new Slot(199,"UEME1112", " Engineering Thermodynamics I", "25", "P", Day.Parse("Wed"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("3,9")),
new Slot(201,"UEME1112", " Engineering Thermodynamics I", "26", "P", Day.Parse("Wed"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("4,10")),
new Slot(203,"UEME1112", " Engineering Thermodynamics I", "31", "P", Day.Parse("Thu"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("4,10")),
new Slot(205,"UEME1112", " Engineering Thermodynamics I", "32", "P", Day.Parse("Thu"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("6,12")),
new Slot(207,"UEME1112", " Engineering Thermodynamics I", "2", "T", Day.Parse("Mon"), "KB521", new TimePeriod(Time.CreateTime_24HourFormat(13,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(209,"UEME1112", " Engineering Thermodynamics I", "5", "T", Day.Parse("Wed"), "KB521", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(211,"UEME1112", " Engineering Thermodynamics I", "6", "T", Day.Parse("Wed"), "KB521", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(213,"UEME1112", " Engineering Thermodynamics I", "7", "T", Day.Parse("Wed"), "KB524", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(15,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(215,"UEME1112", " Engineering Thermodynamics I", "9", "T", Day.Parse("Wed"), "KB322", new TimePeriod(Time.CreateTime_24HourFormat(16,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(217,"UEME1112", " Engineering Thermodynamics I", "10", "T", Day.Parse("Wed"), "KB322", new TimePeriod(Time.CreateTime_24HourFormat(16,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(219,"UEME1112", " Engineering Thermodynamics I", "11", "T", Day.Parse("Wed"), "KB322", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(221,"UEME1112", " Engineering Thermodynamics I", "12", "T", Day.Parse("Wed"), "KB322", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(223,"UEME1112", " Engineering Thermodynamics I", "15", "T", Day.Parse("Thu"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(225,"UEME1112", " Engineering Thermodynamics I", "16", "T", Day.Parse("Thu"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(227,"UEME1112", " Engineering Thermodynamics I", "21", "T", Day.Parse("Fri"), "KB324", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(229,"UEME1112", " Engineering Thermodynamics I", "22", "T", Day.Parse("Fri"), "KB324", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(231,"UEME1132", " Statics", "1", "L", Day.Parse("Mon"), "KB209", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("1-14")),
new Slot(233,"UEME1132", " Statics", "3", "L", Day.Parse("Wed"), "KB208", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("1-14")),
new Slot(235,"UEME1132", " Statics", "4", "L", Day.Parse("Fri"), "KB520", new TimePeriod(Time.CreateTime_24HourFormat(16,30),Time.CreateTime_24HourFormat(18,30)), WeekNumber.Parse("1-14")),
new Slot(237,"UEME1132", " Statics", "6", "P", Day.Parse("Tue"), "KB730", new TimePeriod(Time.CreateTime_24HourFormat(11,30),Time.CreateTime_24HourFormat(14,30)), WeekNumber.Parse("2,8")),
new Slot(239,"UEME1132", " Statics", "7", "P", Day.Parse("Tue"), "KB730", new TimePeriod(Time.CreateTime_24HourFormat(11,30),Time.CreateTime_24HourFormat(14,30)), WeekNumber.Parse("3,9")),
new Slot(241,"UEME1132", " Statics", "8", "P", Day.Parse("Tue"), "KB730", new TimePeriod(Time.CreateTime_24HourFormat(11,30),Time.CreateTime_24HourFormat(14,30)), WeekNumber.Parse("4,10")),
new Slot(243,"UEME1132", " Statics", "10", "P", Day.Parse("Tue"), "KB730", new TimePeriod(Time.CreateTime_24HourFormat(11,30),Time.CreateTime_24HourFormat(14,30)), WeekNumber.Parse("7,11")),
new Slot(245,"UEME1132", " Statics", "15", "P", Day.Parse("Tue"), "KB730", new TimePeriod(Time.CreateTime_24HourFormat(14,30),Time.CreateTime_24HourFormat(17,30)), WeekNumber.Parse("7,11")),
new Slot(247,"UEME1132", " Statics", "16", "P", Day.Parse("Wed"), "KB730", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(11,30)), WeekNumber.Parse("2,8")),
new Slot(249,"UEME1132", " Statics", "17", "P", Day.Parse("Wed"), "KB730", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(11,30)), WeekNumber.Parse("3,9")),
new Slot(251,"UEME1132", " Statics", "18", "P", Day.Parse("Wed"), "KB730", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(11,30)), WeekNumber.Parse("4,10")),
new Slot(253,"UEME1132", " Statics", "21", "P", Day.Parse("Wed"), "KB730", new TimePeriod(Time.CreateTime_24HourFormat(11,30),Time.CreateTime_24HourFormat(14,30)), WeekNumber.Parse("2,8")),
new Slot(255,"UEME1132", " Statics", "22", "P", Day.Parse("Wed"), "KB730", new TimePeriod(Time.CreateTime_24HourFormat(11,30),Time.CreateTime_24HourFormat(14,30)), WeekNumber.Parse("3,9")),
new Slot(257,"UEME1132", " Statics", "23", "P", Day.Parse("Wed"), "KB730", new TimePeriod(Time.CreateTime_24HourFormat(11,30),Time.CreateTime_24HourFormat(14,30)), WeekNumber.Parse("4,10")),
new Slot(259,"UEME1132", " Statics", "25", "P", Day.Parse("Wed"), "KB730", new TimePeriod(Time.CreateTime_24HourFormat(11,30),Time.CreateTime_24HourFormat(14,30)), WeekNumber.Parse("7,11")),
new Slot(261,"UEME1132", " Statics", "31", "P", Day.Parse("Thu"), "KB730", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(11,30)), WeekNumber.Parse("2,8")),
new Slot(263,"UEME1132", " Statics", "5", "T", Day.Parse("Mon"), "KB320", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(265,"UEME1132", " Statics", "6", "T", Day.Parse("Mon"), "KB320", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(267,"UEME1132", " Statics", "15", "T", Day.Parse("Wed"), "KB516", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(15,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(269,"UEME1132", " Statics", "16", "T", Day.Parse("Wed"), "KB516", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(15,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(271,"UEME1132", " Statics", "17", "T", Day.Parse("Thu"), "KB326", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(15,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(273,"UEME1132", " Statics", "18", "T", Day.Parse("Thu"), "KB326", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(15,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(275,"UEME1132", " Statics", "22", "T", Day.Parse("Fri"), "KB320", new TimePeriod(Time.CreateTime_24HourFormat(15,30),Time.CreateTime_24HourFormat(16,30)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(277,"UEME1132", " Statics", "23", "T", Day.Parse("Fri"), "KB320", new TimePeriod(Time.CreateTime_24HourFormat(16,30),Time.CreateTime_24HourFormat(17,30)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(279,"UEME1132", " Statics", "24", "T", Day.Parse("Fri"), "KB320", new TimePeriod(Time.CreateTime_24HourFormat(16,30),Time.CreateTime_24HourFormat(17,30)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(281,"UEME1252", " Engineering Drawing And Cad", "1", "L", Day.Parse("Mon"), "KB208", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,30)), WeekNumber.Parse("1-14")),
new Slot(283,"UEME1252", " Engineering Drawing And Cad", "2", "L", Day.Parse("Tue"), "KB207", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,30)), WeekNumber.Parse("1-14")),
new Slot(285,"UEME1252", " Engineering Drawing And Cad", "3", "L", Day.Parse("Wed"), "KB213", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,30)), WeekNumber.Parse("1-14")),
new Slot(287,"UEME1252", " Engineering Drawing And Cad", "3", "P", Day.Parse("Mon"), "KB609", new TimePeriod(Time.CreateTime_24HourFormat(13,0),Time.CreateTime_24HourFormat(15,0)), WeekNumber.Parse("1-2,4,6-14")),
new Slot(289,"UEME1252", " Engineering Drawing And Cad", "4", "P", Day.Parse("Mon"), "KB609", new TimePeriod(Time.CreateTime_24HourFormat(15,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("1-2,4,6-14")),
new Slot(291,"UEME1252", " Engineering Drawing And Cad", "5", "P", Day.Parse("Tue"), "KB609", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("1-4,6-14")),
new Slot(293,"UEME1252", " Engineering Drawing And Cad", "6", "P", Day.Parse("Tue"), "KB609", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("1-4,6-14")),
new Slot(295,"UEME1252", " Engineering Drawing And Cad", "7", "P", Day.Parse("Tue"), "KB609", new TimePeriod(Time.CreateTime_24HourFormat(13,0),Time.CreateTime_24HourFormat(15,0)), WeekNumber.Parse("1-4,6-14")),
new Slot(297,"UEME1252", " Engineering Drawing And Cad", "8", "P", Day.Parse("Tue"), "KB609", new TimePeriod(Time.CreateTime_24HourFormat(15,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("1-4,6-14")),
new Slot(299,"UEME1252", " Engineering Drawing And Cad", "10", "P", Day.Parse("Wed"), "KB606", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("1-4,6-14")),
new Slot(301,"UEME1252", " Engineering Drawing And Cad", "17", "P", Day.Parse("Fri"), "KB609", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(10,30)), WeekNumber.Parse("1-4,6-14")),
new Slot(303,"UEME1252", " Engineering Drawing And Cad", "18", "P", Day.Parse("Fri"), "KB609", new TimePeriod(Time.CreateTime_24HourFormat(10,30),Time.CreateTime_24HourFormat(12,30)), WeekNumber.Parse("1-4,6-14")),
new Slot(305,"UEME1252", " Engineering Drawing And Cad", "20", "P", Day.Parse("Fri"), "KB606", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(10,30)), WeekNumber.Parse("1-4,6-14")),
new Slot(307,"UEME1252", " Engineering Drawing And Cad", "21", "P", Day.Parse("Fri"), "KB606", new TimePeriod(Time.CreateTime_24HourFormat(10,30),Time.CreateTime_24HourFormat(12,30)), WeekNumber.Parse("1-4,6-14")),
new Slot(309,"UEME2123", " Fluid Mechanics I", "1", "L", Day.Parse("Mon"), "KB209", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("1-14")),
new Slot(311,"UEME2123", " Fluid Mechanics I", "1", "L", Day.Parse("Thu"), "KB207", new TimePeriod(Time.CreateTime_24HourFormat(13,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("1-14")),
new Slot(313,"UEME2123", " Fluid Mechanics I", "2", "L", Day.Parse("Mon"), "KB207", new TimePeriod(Time.CreateTime_24HourFormat(13,0),Time.CreateTime_24HourFormat(15,0)), WeekNumber.Parse("1-14")),
new Slot(315,"UEME2123", " Fluid Mechanics I", "2", "L", Day.Parse("Fri"), "KB209", new TimePeriod(Time.CreateTime_24HourFormat(17,30),Time.CreateTime_24HourFormat(18,30)), WeekNumber.Parse("1-14")),
new Slot(317,"UEME2123", " Fluid Mechanics I", "3", "L", Day.Parse("Tue"), "KB208", new TimePeriod(Time.CreateTime_24HourFormat(16,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("1-14")),
new Slot(319,"UEME2123", " Fluid Mechanics I", "3", "L", Day.Parse("Thu"), "KB209", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(19,0)), WeekNumber.Parse("1-14")),
new Slot(321,"UEME2123", " Fluid Mechanics I", "1", "P", Day.Parse("Tue"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("2,8")),
new Slot(323,"UEME2123", " Fluid Mechanics I", "2", "P", Day.Parse("Tue"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("3,9")),
new Slot(325,"UEME2123", " Fluid Mechanics I", "3", "P", Day.Parse("Tue"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("4,10")),
new Slot(327,"UEME2123", " Fluid Mechanics I", "4", "P", Day.Parse("Tue"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("6,12")),
new Slot(329,"UEME2123", " Fluid Mechanics I", "5", "P", Day.Parse("Tue"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("7,11")),
new Slot(331,"UEME2123", " Fluid Mechanics I", "6", "P", Day.Parse("Tue"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("2,8")),
new Slot(333,"UEME2123", " Fluid Mechanics I", "7", "P", Day.Parse("Tue"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("3,9")),
new Slot(335,"UEME2123", " Fluid Mechanics I", "8", "P", Day.Parse("Tue"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("4,10")),
new Slot(337,"UEME2123", " Fluid Mechanics I", "10", "P", Day.Parse("Tue"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("7,11")),
new Slot(339,"UEME2123", " Fluid Mechanics I", "16", "P", Day.Parse("Wed"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("2,8")),
new Slot(341,"UEME2123", " Fluid Mechanics I", "17", "P", Day.Parse("Wed"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("3,9")),
new Slot(343,"UEME2123", " Fluid Mechanics I", "18", "P", Day.Parse("Wed"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("4,10")),
new Slot(345,"UEME2123", " Fluid Mechanics I", "19", "P", Day.Parse("Wed"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("6,12")),
new Slot(347,"UEME2123", " Fluid Mechanics I", "20", "P", Day.Parse("Wed"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("7,11")),
new Slot(349,"UEME2123", " Fluid Mechanics I", "21", "P", Day.Parse("Thu"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("2,8")),
new Slot(351,"UEME2123", " Fluid Mechanics I", "22", "P", Day.Parse("Thu"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("3,9")),
new Slot(353,"UEME2123", " Fluid Mechanics I", "23", "P", Day.Parse("Thu"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("4,10")),
new Slot(355,"UEME2123", " Fluid Mechanics I", "24", "P", Day.Parse("Thu"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("6,12")),
new Slot(357,"UEME2123", " Fluid Mechanics I", "25", "P", Day.Parse("Thu"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("7,11")),
new Slot(359,"UEME2123", " Fluid Mechanics I", "26", "P", Day.Parse("Fri"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(11,30)), WeekNumber.Parse("2,8")),
new Slot(361,"UEME2123", " Fluid Mechanics I", "27", "P", Day.Parse("Fri"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(11,30)), WeekNumber.Parse("3,9")),
new Slot(363,"UEME2123", " Fluid Mechanics I", "28", "P", Day.Parse("Fri"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(11,30)), WeekNumber.Parse("4,10")),
new Slot(365,"UEME2123", " Fluid Mechanics I", "29", "P", Day.Parse("Fri"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(11,30)), WeekNumber.Parse("6,12")),
new Slot(367,"UEME2123", " Fluid Mechanics I", "30", "P", Day.Parse("Fri"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(11,30)), WeekNumber.Parse("7,11")),
new Slot(369,"UEME2123", " Fluid Mechanics I", "3", "T", Day.Parse("Wed"), "KB316", new TimePeriod(Time.CreateTime_24HourFormat(13,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(371,"UEME2123", " Fluid Mechanics I", "4", "T", Day.Parse("Wed"), "KB316", new TimePeriod(Time.CreateTime_24HourFormat(13,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(373,"UEME2123", " Fluid Mechanics I", "5", "T", Day.Parse("Wed"), "KB301", new TimePeriod(Time.CreateTime_24HourFormat(15,0),Time.CreateTime_24HourFormat(16,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(375,"UEME2123", " Fluid Mechanics I", "6", "T", Day.Parse("Wed"), "KB301", new TimePeriod(Time.CreateTime_24HourFormat(15,0),Time.CreateTime_24HourFormat(16,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(377,"UEME2123", " Fluid Mechanics I", "9", "T", Day.Parse("Wed"), "KB301", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(379,"UEME2123", " Fluid Mechanics I", "10", "T", Day.Parse("Wed"), "KB301", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(381,"UEME2123", " Fluid Mechanics I", "11", "T", Day.Parse("Thu"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(383,"UEME2123", " Fluid Mechanics I", "12", "T", Day.Parse("Thu"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(385,"UEME2123", " Fluid Mechanics I", "13", "T", Day.Parse("Fri"), "KB314", new TimePeriod(Time.CreateTime_24HourFormat(10,30),Time.CreateTime_24HourFormat(11,30)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(387,"UEME2123", " Fluid Mechanics I", "14", "T", Day.Parse("Fri"), "KB314", new TimePeriod(Time.CreateTime_24HourFormat(10,30),Time.CreateTime_24HourFormat(11,30)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(389,"UEME2123", " Fluid Mechanics I", "15", "T", Day.Parse("Fri"), "KB314", new TimePeriod(Time.CreateTime_24HourFormat(11,30),Time.CreateTime_24HourFormat(12,30)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(391,"UEME2123", " Fluid Mechanics I", "16", "T", Day.Parse("Fri"), "KB314", new TimePeriod(Time.CreateTime_24HourFormat(11,30),Time.CreateTime_24HourFormat(12,30)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(393,"UEME2123", " Fluid Mechanics I", "17", "T", Day.Parse("Fri"), "KB326", new TimePeriod(Time.CreateTime_24HourFormat(14,30),Time.CreateTime_24HourFormat(15,30)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(395,"UEME2123", " Fluid Mechanics I", "18", "T", Day.Parse("Fri"), "KB326", new TimePeriod(Time.CreateTime_24HourFormat(14,30),Time.CreateTime_24HourFormat(15,30)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(397,"UEME2123", " Fluid Mechanics I", "19", "T", Day.Parse("Fri"), "KB518", new TimePeriod(Time.CreateTime_24HourFormat(16,30),Time.CreateTime_24HourFormat(17,30)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(399,"UEME2123", " Fluid Mechanics I", "20", "T", Day.Parse("Fri"), "KB518", new TimePeriod(Time.CreateTime_24HourFormat(16,30),Time.CreateTime_24HourFormat(17,30)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(401,"UEME3112", " Fluid Mechanics II", "1", "L", Day.Parse("Wed"), "KB209", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(16,0)), WeekNumber.Parse("1-14")),
new Slot(403,"UEME3112", " Fluid Mechanics II", "2", "L", Day.Parse("Thu"), "KB207", new TimePeriod(Time.CreateTime_24HourFormat(15,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("1-14")),
new Slot(405,"UEME3112", " Fluid Mechanics II", "1", "P", Day.Parse("Mon"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("2,8")),
new Slot(407,"UEME3112", " Fluid Mechanics II", "2", "P", Day.Parse("Mon"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("4,10")),
new Slot(409,"UEME3112", " Fluid Mechanics II", "3", "P", Day.Parse("Mon"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("6,12")),
new Slot(411,"UEME3112", " Fluid Mechanics II", "4", "P", Day.Parse("Mon"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("7,11")),
new Slot(413,"UEME3112", " Fluid Mechanics II", "5", "P", Day.Parse("Mon"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("2,8")),
new Slot(415,"UEME3112", " Fluid Mechanics II", "6", "P", Day.Parse("Mon"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("4,10")),
new Slot(417,"UEME3112", " Fluid Mechanics II", "7", "P", Day.Parse("Mon"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("7,11")),
new Slot(419,"UEME3112", " Fluid Mechanics II", "8", "P", Day.Parse("Thu"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("2,8")),
new Slot(421,"UEME3112", " Fluid Mechanics II", "9", "P", Day.Parse("Thu"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("4,10")),
new Slot(423,"UEME3112", " Fluid Mechanics II", "10", "P", Day.Parse("Fri"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(11,30)), WeekNumber.Parse("2,8")),
new Slot(425,"UEME3112", " Fluid Mechanics II", "11", "P", Day.Parse("Fri"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(11,30)), WeekNumber.Parse("3,9")),
new Slot(427,"UEME3112", " Fluid Mechanics II", "12", "P", Day.Parse("Fri"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(11,30)), WeekNumber.Parse("4,10")),
new Slot(429,"UEME3112", " Fluid Mechanics II", "13", "P", Day.Parse("Fri"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(11,30)), WeekNumber.Parse("6,12")),
new Slot(431,"UEME3112", " Fluid Mechanics II", "14", "P", Day.Parse("Fri"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,30),Time.CreateTime_24HourFormat(17,30)), WeekNumber.Parse("2,8")),
new Slot(433,"UEME3112", " Fluid Mechanics II", "16", "P", Day.Parse("Fri"), "KB731", new TimePeriod(Time.CreateTime_24HourFormat(14,30),Time.CreateTime_24HourFormat(17,30)), WeekNumber.Parse("4,10")),
new Slot(435,"UEME3112", " Fluid Mechanics II", "1", "T", Day.Parse("Mon"), "KB320", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(9,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(437,"UEME3112", " Fluid Mechanics II", "2", "T", Day.Parse("Mon"), "KB320", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(9,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(439,"UEME3112", " Fluid Mechanics II", "3", "T", Day.Parse("Mon"), "KB320", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(441,"UEME3112", " Fluid Mechanics II", "4", "T", Day.Parse("Mon"), "KB320", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(443,"UEME3112", " Fluid Mechanics II", "5", "T", Day.Parse("Mon"), "KB517", new TimePeriod(Time.CreateTime_24HourFormat(13,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(445,"UEME3112", " Fluid Mechanics II", "6", "T", Day.Parse("Mon"), "KB517", new TimePeriod(Time.CreateTime_24HourFormat(13,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(447,"UEME3112", " Fluid Mechanics II", "7", "T", Day.Parse("Wed"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(449,"UEME3112", " Fluid Mechanics II", "8", "T", Day.Parse("Wed"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(451,"UEME3112", " Fluid Mechanics II", "9", "T", Day.Parse("Wed"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(453,"UEME3112", " Fluid Mechanics II", "10", "T", Day.Parse("Wed"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(455,"UEME3112", " Fluid Mechanics II", "11", "T", Day.Parse("Fri"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(9,30)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(457,"UEME3112", " Fluid Mechanics II", "12", "T", Day.Parse("Fri"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(9,30)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(459,"UEME3112", " Fluid Mechanics II", "13", "T", Day.Parse("Fri"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(9,30),Time.CreateTime_24HourFormat(10,30)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(461,"UEME3112", " Fluid Mechanics II", "14", "T", Day.Parse("Fri"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(9,30),Time.CreateTime_24HourFormat(10,30)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(463,"UEME3112", " Fluid Mechanics II", "15", "T", Day.Parse("Fri"), "KB211", new TimePeriod(Time.CreateTime_24HourFormat(15,30),Time.CreateTime_24HourFormat(16,30)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(465,"UEME3112", " Fluid Mechanics II", "16", "T", Day.Parse("Fri"), "KB211", new TimePeriod(Time.CreateTime_24HourFormat(15,30),Time.CreateTime_24HourFormat(16,30)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(467,"UEMX1133", " Introduction To Building Services", "1", "L", Day.Parse("Tue"), "KB207", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("1-14")),
new Slot(469,"UEMX1133", " Introduction To Building Services", "1", "L", Day.Parse("Thu"), "KB209", new TimePeriod(Time.CreateTime_24HourFormat(13,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("1-14")),
new Slot(471,"UEMX1133", " Introduction To Building Services", "1", "T", Day.Parse("Fri"), "KB517", new TimePeriod(Time.CreateTime_24HourFormat(9,30),Time.CreateTime_24HourFormat(10,30)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(473,"UEMX1133", " Introduction To Building Services", "2", "T", Day.Parse("Fri"), "KB517", new TimePeriod(Time.CreateTime_24HourFormat(9,30),Time.CreateTime_24HourFormat(10,30)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(475,"UEMX1133", " Introduction To Building Services", "3", "T", Day.Parse("Fri"), "KB517", new TimePeriod(Time.CreateTime_24HourFormat(10,30),Time.CreateTime_24HourFormat(11,30)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(477,"UEMX1133", " Introduction To Building Services", "4", "T", Day.Parse("Fri"), "KB517", new TimePeriod(Time.CreateTime_24HourFormat(10,30),Time.CreateTime_24HourFormat(11,30)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(479,"UEMX1133", " Introduction To Building Services", "5", "T", Day.Parse("Fri"), "KB211", new TimePeriod(Time.CreateTime_24HourFormat(14,30),Time.CreateTime_24HourFormat(15,30)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(481,"UEMX1133", " Introduction To Building Services", "6", "T", Day.Parse("Fri"), "KB211", new TimePeriod(Time.CreateTime_24HourFormat(14,30),Time.CreateTime_24HourFormat(15,30)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(483,"UEMX1843", " Survey I", "1", "L", Day.Parse("Tue"), "KB209", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("1-14")),
new Slot(485,"UEMX1843", " Survey I", "1", "L", Day.Parse("Thu"), "KB209", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("1-14")),
new Slot(487,"UEMX1843", " Survey I", "4", "P", Day.Parse("Fri"), "KBS01", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(12,30)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(489,"UEMX1843", " Survey I", "5", "P", Day.Parse("Fri"), "KBS01", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(12,30)), WeekNumber.Parse("1,3,7,9,11,13")),
new Slot(491,"UEMX1843", " Survey I", "1", "T", Day.Parse("Thu"), "KB516", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(493,"UEMX1843", " Survey I", "2", "T", Day.Parse("Thu"), "KB516", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(495,"UEMX2323", " Structural Analysis II", "1", "L", Day.Parse("Tue"), "KB209", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("1-14")),
new Slot(497,"UEMX2323", " Structural Analysis II", "1", "L", Day.Parse("Wed"), "KB208", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(16,0)), WeekNumber.Parse("1-14")),
new Slot(499,"UEMX2323", " Structural Analysis II", "1", "T", Day.Parse("Tue"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(9,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(501,"UEMX2323", " Structural Analysis II", "2", "T", Day.Parse("Tue"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(9,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(503,"UEMX2323", " Structural Analysis II", "3", "T", Day.Parse("Tue"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(505,"UEMX2323", " Structural Analysis II", "4", "T", Day.Parse("Tue"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(507,"UEMX2323", " Structural Analysis II", "5", "T", Day.Parse("Fri"), "KB324", new TimePeriod(Time.CreateTime_24HourFormat(14,30),Time.CreateTime_24HourFormat(15,30)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(509,"UEMX2323", " Structural Analysis II", "6", "T", Day.Parse("Fri"), "KB324", new TimePeriod(Time.CreateTime_24HourFormat(14,30),Time.CreateTime_24HourFormat(15,30)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(511,"UEMX2363", " Concrete Structures Design II", "1", "L", Day.Parse("Tue"), "KB209", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("2-14")),
new Slot(513,"UEMX2363", " Concrete Structures Design II", "1", "L", Day.Parse("Wed"), "KB207", new TimePeriod(Time.CreateTime_24HourFormat(13,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("2-14")),
new Slot(515,"UEMX2363", " Concrete Structures Design II", "1", "T", Day.Parse("Tue"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(517,"UEMX2363", " Concrete Structures Design II", "2", "T", Day.Parse("Tue"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(519,"UEMX2363", " Concrete Structures Design II", "3", "T", Day.Parse("Thu"), "KB326", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(521,"UEMX2363", " Concrete Structures Design II", "4", "T", Day.Parse("Thu"), "KB326", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(523,"UEMX2363", " Concrete Structures Design II", "5", "T", Day.Parse("Thu"), "KB326", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(525,"UEMX2363", " Concrete Structures Design II", "6", "T", Day.Parse("Thu"), "KB326", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(527,"UEMX2423", " Geotechnical Engineering", "1", "L", Day.Parse("Mon"), "KB207", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("1-14")),
new Slot(529,"UEMX2423", " Geotechnical Engineering", "1", "L", Day.Parse("Thu"), "KB208", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(9,0)), WeekNumber.Parse("1-14")),
new Slot(531,"UEMX2423", " Geotechnical Engineering", "1", "P", Day.Parse("Tue"), "KBS01", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("4,6,8,10")),
new Slot(533,"UEMX2423", " Geotechnical Engineering", "2", "P", Day.Parse("Tue"), "KBS01", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("3,7,9,11")),
new Slot(535,"UEMX2423", " Geotechnical Engineering", "3", "P", Day.Parse("Wed"), "KBS01", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("4,6,8,10")),
new Slot(537,"UEMX2423", " Geotechnical Engineering", "4", "P", Day.Parse("Wed"), "KBS01", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("3,7,9,11")),
new Slot(539,"UEMX2423", " Geotechnical Engineering", "5", "P", Day.Parse("Thu"), "KBS01", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("4,6,8,10")),
new Slot(541,"UEMX2423", " Geotechnical Engineering", "6", "P", Day.Parse("Thu"), "KBS01", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("3,7,9,11")),
new Slot(543,"UEMX2423", " Geotechnical Engineering", "7", "P", Day.Parse("Fri"), "KBS01", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(11,30)), WeekNumber.Parse("4,6,8,10")),
new Slot(545,"UEMX2423", " Geotechnical Engineering", "8", "P", Day.Parse("Fri"), "KBS01", new TimePeriod(Time.CreateTime_24HourFormat(8,30),Time.CreateTime_24HourFormat(11,30)), WeekNumber.Parse("3,7,9,11")),
new Slot(547,"UEMX2423", " Geotechnical Engineering", "1", "T", Day.Parse("Mon"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(549,"UEMX2423", " Geotechnical Engineering", "2", "T", Day.Parse("Mon"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(551,"UEMX2423", " Geotechnical Engineering", "3", "T", Day.Parse("Mon"), "KB516", new TimePeriod(Time.CreateTime_24HourFormat(16,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(553,"UEMX2423", " Geotechnical Engineering", "4", "T", Day.Parse("Mon"), "KB516", new TimePeriod(Time.CreateTime_24HourFormat(16,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(555,"UEMX2423", " Geotechnical Engineering", "5", "T", Day.Parse("Thu"), "KB314", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(557,"UEMX2423", " Geotechnical Engineering", "6", "T", Day.Parse("Thu"), "KB314", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(559,"UEMX2513", " Hydrology", "1", "L", Day.Parse("Tue"), "KB209", new TimePeriod(Time.CreateTime_24HourFormat(15,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("1-14")),
new Slot(561,"UEMX2513", " Hydrology", "1", "L", Day.Parse("Wed"), "KB208", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(9,0)), WeekNumber.Parse("1-14")),
new Slot(563,"UEMX2513", " Hydrology", "1", "T", Day.Parse("Mon"), "KB516", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(565,"UEMX2513", " Hydrology", "2", "T", Day.Parse("Mon"), "KB516", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(567,"UEMX2513", " Hydrology", "3", "T", Day.Parse("Mon"), "KB516", new TimePeriod(Time.CreateTime_24HourFormat(13,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(569,"UEMX2513", " Hydrology", "4", "T", Day.Parse("Mon"), "KB516", new TimePeriod(Time.CreateTime_24HourFormat(13,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(571,"UEMX2513", " Hydrology", "5", "T", Day.Parse("Tue"), "KB516", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(573,"UEMX2513", " Hydrology", "6", "T", Day.Parse("Tue"), "KB516", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(575,"UEMX3333", " Structural Steel Design", "1", "L", Day.Parse("Tue"), "KB208", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(19,0)), WeekNumber.Parse("1-14")),
new Slot(577,"UEMX3333", " Structural Steel Design", "1", "L", Day.Parse("Wed"), "KB208", new TimePeriod(Time.CreateTime_24HourFormat(16,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("1-14")),
new Slot(579,"UEMX3333", " Structural Steel Design", "1", "T", Day.Parse("Mon"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(15,0),Time.CreateTime_24HourFormat(16,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(581,"UEMX3333", " Structural Steel Design", "2", "T", Day.Parse("Mon"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(15,0),Time.CreateTime_24HourFormat(16,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(583,"UEMX3333", " Structural Steel Design", "3", "T", Day.Parse("Fri"), "KB320", new TimePeriod(Time.CreateTime_24HourFormat(14,30),Time.CreateTime_24HourFormat(15,30)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(585,"UEMX3333", " Structural Steel Design", "4", "T", Day.Parse("Fri"), "KB320", new TimePeriod(Time.CreateTime_24HourFormat(14,30),Time.CreateTime_24HourFormat(15,30)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(587,"UEMX3333", " Structural Steel Design", "5", "T", Day.Parse("Wed"), "KB518", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(589,"UEMX3333", " Structural Steel Design", "6", "T", Day.Parse("Wed"), "KB518", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(591,"UEMX3813", " Highway And Transportation", "1", "L", Day.Parse("Mon"), "KB207", new TimePeriod(Time.CreateTime_24HourFormat(18,0),Time.CreateTime_24HourFormat(19,0)), WeekNumber.Parse("1-14")),
new Slot(593,"UEMX3813", " Highway And Transportation", "1", "L", Day.Parse("Wed"), "KB214", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("1-14")),
new Slot(595,"UEMX3813", " Highway And Transportation", "1", "P", Day.Parse("Mon"), "KBS01", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("8")),
new Slot(597,"UEMX3813", " Highway And Transportation", "2", "P", Day.Parse("Mon"), "KBS01", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("10")),
new Slot(599,"UEMX3813", " Highway And Transportation", "3", "P", Day.Parse("Mon"), "KB607", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("6")),
new Slot(601,"UEMX3813", " Highway And Transportation", "4", "P", Day.Parse("Mon"), "KB607", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("7")),
new Slot(603,"UEMX3813", " Highway And Transportation", "5", "P", Day.Parse("Thu"), "KB607", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("2")),
new Slot(605,"UEMX3813", " Highway And Transportation", "6", "P", Day.Parse("Thu"), "KBS01", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("9")),
new Slot(607,"UEMX3813", " Highway And Transportation", "7", "P", Day.Parse("Thu"), "KB607", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("4")),
new Slot(609,"UEMX3813", " Highway And Transportation", "8", "P", Day.Parse("Thu"), "KBS01", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("12")),
new Slot(611,"UEMX3813", " Highway And Transportation", "9", "P", Day.Parse("Thu"), "KB607", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("7")),
new Slot(613,"UEMX3813", " Highway And Transportation", "1", "T", Day.Parse("Tue"), "KB326", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(15,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(615,"UEMX3813", " Highway And Transportation", "2", "T", Day.Parse("Tue"), "KB326", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(15,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(617,"UEMX3813", " Highway And Transportation", "3", "T", Day.Parse("Thu"), "KB314", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(619,"UEMX3813", " Highway And Transportation", "4", "T", Day.Parse("Thu"), "KB314", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(621,"UEMX3813", " Highway And Transportation", "5", "T", Day.Parse("Thu"), "KB314", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(623,"UEMX3813", " Highway And Transportation", "6", "T", Day.Parse("Thu"), "KB314", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(625,"UEMX4293", " Finite Element Method In Structural Engineering", "1", "L", Day.Parse("Thu"), "KB322", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(9,0)), WeekNumber.Parse("1-14")),
new Slot(627,"UEMX4293", " Finite Element Method In Structural Engineering", "1", "L", Day.Parse("Fri"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(10,30),Time.CreateTime_24HourFormat(12,30)), WeekNumber.Parse("1-14")),
new Slot(629,"UEMX4293", " Finite Element Method In Structural Engineering", "1", "T", Day.Parse("Thu"), "KB322", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(631,"UEMX4293", " Finite Element Method In Structural Engineering", "2", "T", Day.Parse("Thu"), "KB322", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(633,"UEMX4293", " Finite Element Method In Structural Engineering", "3", "T", Day.Parse("Fri"), "KB324", new TimePeriod(Time.CreateTime_24HourFormat(15,30),Time.CreateTime_24HourFormat(16,30)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(635,"UEMX4293", " Finite Element Method In Structural Engineering", "4", "T", Day.Parse("Fri"), "KB324", new TimePeriod(Time.CreateTime_24HourFormat(15,30),Time.CreateTime_24HourFormat(16,30)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(637,"UEMX4313", " Advanced Structural Steel Design", "1", "L", Day.Parse("Mon"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(16,0)), WeekNumber.Parse("1-14")),
new Slot(639,"UEMX4313", " Advanced Structural Steel Design", "1", "L", Day.Parse("Tue"), "KB324", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(9,0)), WeekNumber.Parse("1-14")),
new Slot(641,"UEMX4313", " Advanced Structural Steel Design", "1", "T", Day.Parse("Mon"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(16,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(643,"UEMX4313", " Advanced Structural Steel Design", "2", "T", Day.Parse("Mon"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(16,0),Time.CreateTime_24HourFormat(17,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(645,"UEMX4313", " Advanced Structural Steel Design", "3", "T", Day.Parse("Tue"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(647,"UEMX4313", " Advanced Structural Steel Design", "4", "T", Day.Parse("Tue"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(649,"UEMX4393", " Concrete Technology", "1", "L", Day.Parse("Thu"), "KB300", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("1-14")),
new Slot(651,"UEMX4393", " Concrete Technology", "1", "L", Day.Parse("Fri"), "KB322", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(9,0)), WeekNumber.Parse("1-14")),
new Slot(653,"UEMX4393", " Concrete Technology", "1", "P", Day.Parse("Tue"), "KBS01", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(16,0)), WeekNumber.Parse("1,3,7,9,11,13")),
new Slot(655,"UEMX4393", " Concrete Technology", "2", "P", Day.Parse("Tue"), "KBS01", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(16,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(657,"UEMX4393", " Concrete Technology", "3", "P", Day.Parse("Wed"), "KBS01", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(16,0)), WeekNumber.Parse("1,3,7,9,11,13")),
new Slot(659,"UEMX4393", " Concrete Technology", "1", "T", Day.Parse("Fri"), "KB322", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(661,"UEMX4393", " Concrete Technology", "2", "T", Day.Parse("Fri"), "KB322", new TimePeriod(Time.CreateTime_24HourFormat(9,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(663,"UEMX4913", " Integrated Design Project", "1", "L", Day.Parse("Wed"), "KB209", new TimePeriod(Time.CreateTime_24HourFormat(12,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("1")),
new Slot(665,"UEMX4913", " Integrated Design Project", "1", "L", Day.Parse("Thu"), "KB208", new TimePeriod(Time.CreateTime_24HourFormat(15,0),Time.CreateTime_24HourFormat(18,0)), WeekNumber.Parse("1")),
new Slot(667,"UEMX4963", " Engineering Application In Environment", "1", "L", Day.Parse("Mon"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(13,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("1-14")),
new Slot(669,"UEMX4963", " Engineering Application In Environment", "1", "L", Day.Parse("Wed"), "KB301", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("1-14")),
new Slot(671,"UEMX4963", " Engineering Application In Environment", "1", "T", Day.Parse("Mon"), "KB517", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(673,"UEMX4963", " Engineering Application In Environment", "2", "T", Day.Parse("Mon"), "KB517", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(675,"UEMX4963", " Engineering Application In Environment", "3", "T", Day.Parse("Mon"), "KB517", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("3,5,7,9,11,13")),
new Slot(677,"UEMX4963", " Engineering Application In Environment", "4", "T", Day.Parse("Mon"), "KB517", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("2,4,6,8,10,12")),
new Slot(679,"UJLL1093", " Introduction To Korean", "1", "L", Day.Parse("Wed"), "KB211", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(10,0)), WeekNumber.Parse("1-14")),
new Slot(681,"UJLL1093", " Introduction To Korean", "1", "T", Day.Parse("Wed"), "KB319", new TimePeriod(Time.CreateTime_24HourFormat(10,0),Time.CreateTime_24HourFormat(11,0)), WeekNumber.Parse("1-14")),
new Slot(683,"UJLL1093", " Introduction To Korean", "2", "T", Day.Parse("Wed"), "KB319", new TimePeriod(Time.CreateTime_24HourFormat(11,0),Time.CreateTime_24HourFormat(12,0)), WeekNumber.Parse("1-14")),
new Slot(685,"UKMM1011", " Sun Zi's Art Of War And Business Strategies", "1", "L", Day.Parse("Tue"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(8,0),Time.CreateTime_24HourFormat(9,0)), WeekNumber.Parse("1-14")),
new Slot(687,"UKMM1011", " Sun Zi's Art Of War And Business Strategies", "2", "L", Day.Parse("Tue"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(13,0),Time.CreateTime_24HourFormat(14,0)), WeekNumber.Parse("1-14")),
new Slot(689,"UKMM1011", " Sun Zi's Art Of War And Business Strategies", "3", "L", Day.Parse("Tue"), "KB210", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(15,0)), WeekNumber.Parse("1-14")),
new Slot(691,"UKMM1043", " Basic Economics, Accounting And Management", "1", "L", Day.Parse("Mon"), "KB324", new TimePeriod(Time.CreateTime_24HourFormat(14,0),Time.CreateTime_24HourFormat(16,0)), WeekNumber.Parse("1-14")),
new Slot(693,"UKMM1043", " Basic Economics, Accounting And Management", "2", "L", Day.Parse("Thu"), "KB316", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(19,0)), WeekNumber.Parse("1-14")),
new Slot(695,"UKMM1043", " Basic Economics, Accounting And Management", "1", "T", Day.Parse("Mon"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,30)), WeekNumber.Parse("1-14")),
new Slot(697,"UKMM1043", " Basic Economics, Accounting And Management", "3", "T", Day.Parse("Tue"), "KB320", new TimePeriod(Time.CreateTime_24HourFormat(17,0),Time.CreateTime_24HourFormat(18,30)), WeekNumber.Parse("1-14")),
new Slot(699,"UKMM1043", " Basic Economics, Accounting And Management", "5", "T", Day.Parse("Thu"), "KB516", new TimePeriod(Time.CreateTime_24HourFormat(11,30),Time.CreateTime_24HourFormat(13,0)), WeekNumber.Parse("1-14")),
new Slot(701,"UKMM1043", " Basic Economics, Accounting And Management", "6", "T", Day.Parse("Fri"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(14,30),Time.CreateTime_24HourFormat(16,0)), WeekNumber.Parse("1-14")),
new Slot(703,"UKMM1043", " Basic Economics, Accounting And Management", "7", "T", Day.Parse("Fri"), "KB318", new TimePeriod(Time.CreateTime_24HourFormat(16,0),Time.CreateTime_24HourFormat(17,30)), WeekNumber.Parse("1-14"))

       };


        public static Slot GetSlot(int uid) {
            return TestSlots.Find(x => x.UID == uid);
        }
        
        public static List<Slot> GetSlotRange(int fromUid , int toUid) {
            return TestSlots.FindAll(x => x.UID >= fromUid && x.UID <= toUid);
        }

        public static List<Slot> GetSlotsByName(Subjects name) {
            switch (name) {
                case HubunganEtnik:
                    return GetSlotRange(3 , 9);
                case TamadunIslamDanTamadunAsia:
                    return GetSlotRange(11 , 17);
                case BahasaMelayuKomunikasi2:
                    return GetSlotRange(19 , 19);
                case MalaysianStudies3:
                    return GetSlotRange(21 , 21);
                case BahasaKebangsaanA:
                    return GetSlotRange(23 , 23);
                case EnglishForEngineering:
                    return GetSlotRange(25 , 33);
                case EngineerInSociety:
                    return GetSlotRange(35 , 37);
                case SocialEntrepreneurshipProject:
                    return GetSlotRange(39 , 39);
                case ArtsAndCulturalPerformance:
                    return GetSlotRange(41 , 41);
                case ArtCraftAndDesign:
                    return GetSlotRange(43 , 43);
                case IntroductionToGermanLanguage:
                    return GetSlotRange(45 , 55);
                case IntroductionToFrench:
                    return GetSlotRange(57 , 67);
                case IntroductionToJapanese:
                    return GetSlotRange(69 , 73);
                case MathematicsForEngineeringI:
                    return GetSlotRange(75 , 81);
                case MathematicsForEngineeringII:
                    return GetSlotRange(83 , 117);
                case NumericalMethodsAndStatistics:
                    return GetSlotRange(119 , 153);
                case FundamentalsOfProgramming:
                    return GetSlotRange(155 , 165);
                case EngineeringThermodynamicsI:
                    return GetSlotRange(167 , 229);
                case Statics:
                    return GetSlotRange(231 , 279);
                case EngineeringDrawingAndCad:
                    return GetSlotRange(281 , 307);
                case FluidMechanicsI:
                    return GetSlotRange(309 , 399);
                case FluidMechanicsII:
                    return GetSlotRange(401 , 465);
                case IntroductionToBuildingServices:
                    return GetSlotRange(467 , 481);
                case SurveyI:
                    return GetSlotRange(483 , 493);
                case StructuralAnalysisII:
                    return GetSlotRange(495 , 509);
                case ConcreteStructuresDesignII:
                    return GetSlotRange(511 , 525);
                case GeotechnicalEngineering:
                    return GetSlotRange(527 , 557);
                case Hydrology:
                    return GetSlotRange(559 , 573);
                case StructuralSteelDesign:
                    return GetSlotRange(575 , 589);
                case HighwayAndTransportation:
                    return GetSlotRange(591 , 623);
                case FiniteElementMethodInStructuralEngineering:
                    return GetSlotRange(625 , 635);
                case AdvancedStructuralSteelDesign:
                    return GetSlotRange(637 , 647);
                case ConcreteTechnology:
                    return GetSlotRange(649 , 661);
                case IntegratedDesignProject:
                    return GetSlotRange(663 , 665);
                case EngineeringApplicationInEnvironment:
                    return GetSlotRange(667 , 677);
                case IntroductionToKorean:
                    return GetSlotRange(679 , 683);
                case SunZisArtOfWarAndBusinessStrategies:
                    return GetSlotRange(685 , 689);
                case BasicEconomicsAccountingAndManagement:
                    return GetSlotRange(691 , 703);

                default:
                    return null;
            }
        }

        public static SubjectListModel GetSubjectListModel() {
            return new SubjectListModel(SubjectModel.Parse(TestSlots), Permutator.Run_v2_withoutConsideringWeekNumber, new TaskRunnerForUnitTesting());
            
        }
        public enum Subjects {

            HubunganEtnik,
            TamadunIslamDanTamadunAsia,
            BahasaMelayuKomunikasi2,
            MalaysianStudies3,
            BahasaKebangsaanA,
            EnglishForEngineering,
            EngineerInSociety,
            SocialEntrepreneurshipProject,
            ArtsAndCulturalPerformance,
            ArtCraftAndDesign,
            IntroductionToGermanLanguage,
            IntroductionToFrench,
            IntroductionToJapanese,
            MathematicsForEngineeringI,
            MathematicsForEngineeringII,
            NumericalMethodsAndStatistics,
            FundamentalsOfProgramming,
            EngineeringThermodynamicsI,
            Statics,
            EngineeringDrawingAndCad,
            FluidMechanicsI,
            FluidMechanicsII,
            IntroductionToBuildingServices,
            SurveyI,
            StructuralAnalysisII,
            ConcreteStructuresDesignII,
            GeotechnicalEngineering,
            Hydrology,
            StructuralSteelDesign,
            HighwayAndTransportation,
            FiniteElementMethodInStructuralEngineering,
            AdvancedStructuralSteelDesign,
            ConcreteTechnology,
            IntegratedDesignProject,
            EngineeringApplicationInEnvironment,
            IntroductionToKorean,
            SunZisArtOfWarAndBusinessStrategies,
            BasicEconomicsAccountingAndManagement
        }

    }

}
