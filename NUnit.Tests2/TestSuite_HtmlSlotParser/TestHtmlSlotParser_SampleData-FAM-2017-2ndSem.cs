using System.Collections.Generic;
using Time_Table_Arranging_Program;
using Time_Table_Arranging_Program.Class;
using Time_Table_Arranging_Program.Class.Converter;

namespace NUnit.Tests2.TestSuite_HtmlSlotParser {
    public class TestHtmlSlotParser_SampleData_FAM_2017_2ndSem : Test_HtmlSlotParserBase {
        public TestHtmlSlotParser_SampleData_FAM_2017_2ndSem() : base("SampleData-FAM-2017-2ndSem.html") { }
        protected override List<Slot> GenerateExpectedSlots() {
            return new List<Slot>()
            {
		new Slot(1, "MPU3123", "TAMADUN ISLAM DAN TAMADUN ASIA (TITAS)".Beautify(), "2", "L", Day.Tuesday, "KB214",new TimePeriod(Time.CreateTime_24HourFormat(16, 00), Time.CreateTime_24HourFormat(19, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(1, "MPU3123", "TAMADUN ISLAM DAN TAMADUN ASIA (TITAS)".Beautify(), "2", "L", Day.Friday, "KB214",new TimePeriod(Time.CreateTime_24HourFormat(8, 00), Time.CreateTime_24HourFormat(11, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(2, "MPU3123", "TAMADUN ISLAM DAN TAMADUN ASIA (TITAS)".Beautify(), "3", "L", Day.Tuesday, "KAG03",new TimePeriod(Time.CreateTime_24HourFormat(16, 00), Time.CreateTime_24HourFormat(19, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(2, "MPU3123", "TAMADUN ISLAM DAN TAMADUN ASIA (TITAS)".Beautify(), "3", "L", Day.Friday, "KAG03",new TimePeriod(Time.CreateTime_24HourFormat(8, 00), Time.CreateTime_24HourFormat(11, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(3, "MPU3123", "TAMADUN ISLAM DAN TAMADUN ASIA (TITAS)".Beautify(), "6", "L", Day.Monday, "KAG01",new TimePeriod(Time.CreateTime_24HourFormat(15, 30), Time.CreateTime_24HourFormat(18, 30)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(3, "MPU3123", "TAMADUN ISLAM DAN TAMADUN ASIA (TITAS)".Beautify(), "6", "L", Day.Thursday, "KA805",new TimePeriod(Time.CreateTime_24HourFormat(15, 00), Time.CreateTime_24HourFormat(18, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(4, "MPU3143", "BAHASA MELAYU KOMUNIKASI 2".Beautify(), "1", "L", Day.Tuesday, "KB312",new TimePeriod(Time.CreateTime_24HourFormat(8, 00), Time.CreateTime_24HourFormat(11, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})), 
		new Slot(4, "MPU3143", "BAHASA MELAYU KOMUNIKASI 2".Beautify(), "1", "L", Day.Thursday, "KB311",new TimePeriod(Time.CreateTime_24HourFormat(14, 30), Time.CreateTime_24HourFormat(17, 30)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(5, "MPU3173", "MALAYSIAN STUDIES 3".Beautify(), "1", "L", Day.Tuesday, "KB201",new TimePeriod(Time.CreateTime_24HourFormat(15, 00), Time.CreateTime_24HourFormat(18, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(5, "MPU3173", "MALAYSIAN STUDIES 3".Beautify(), "1", "L", Day.Friday, "KB201",new TimePeriod(Time.CreateTime_24HourFormat(14, 30), Time.CreateTime_24HourFormat(17, 30)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})), 
		new Slot(6, "MPU32013", "BAHASA KEBANGSAAN A".Beautify(), "1", "L", Day.Tuesday, "KB204",new TimePeriod(Time.CreateTime_24HourFormat(8, 00), Time.CreateTime_24HourFormat(11, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(6, "MPU32013", "BAHASA KEBANGSAAN A".Beautify(), "1", "L", Day.Wednesday, "KB201",new TimePeriod(Time.CreateTime_24HourFormat(8, 00), Time.CreateTime_24HourFormat(11, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(7, "MPU34022", "ARTS AND CULTURAL PERFORMANCE".Beautify(), "1", "L", Day.Tuesday, "KAG03",new TimePeriod(Time.CreateTime_24HourFormat(8, 00), Time.CreateTime_24HourFormat(10, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(7, "MPU34022", "ARTS AND CULTURAL PERFORMANCE".Beautify(), "1", "L", Day.Thursday, "KAG03",new TimePeriod(Time.CreateTime_24HourFormat(8, 00), Time.CreateTime_24HourFormat(10, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(8, "MPU34022", "ARTS AND CULTURAL PERFORMANCE".Beautify(), "2", "L", Day.Tuesday, "KA745",new TimePeriod(Time.CreateTime_24HourFormat(10, 00), Time.CreateTime_24HourFormat(12, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(8, "MPU34022", "ARTS AND CULTURAL PERFORMANCE".Beautify(), "2", "L", Day.Thursday, "KAG03",new TimePeriod(Time.CreateTime_24HourFormat(10, 00), Time.CreateTime_24HourFormat(12, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(9, "MPU34032", "COMMUNITY PROJECT".Beautify(), "1", "L", Day.Monday, "KA745",new TimePeriod(Time.CreateTime_24HourFormat(10, 30), Time.CreateTime_24HourFormat(12, 30)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(9, "MPU34032", "COMMUNITY PROJECT".Beautify(), "1", "L", Day.Wednesday, "KAG03",new TimePeriod(Time.CreateTime_24HourFormat(10, 30), Time.CreateTime_24HourFormat(12, 30)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(10, "MPU34032", "COMMUNITY PROJECT".Beautify(), "2", "L", Day.Tuesday, "KA804",new TimePeriod(Time.CreateTime_24HourFormat(10, 30), Time.CreateTime_24HourFormat(12, 30)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(10, "MPU34032", "COMMUNITY PROJECT".Beautify(), "2", "L", Day.Thursday, "KA745",new TimePeriod(Time.CreateTime_24HourFormat(10, 30), Time.CreateTime_24HourFormat(12, 30)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(11, "MPU34032", "COMMUNITY PROJECT".Beautify(), "3", "L", Day.Tuesday, "KAG02",new TimePeriod(Time.CreateTime_24HourFormat(14, 00), Time.CreateTime_24HourFormat(16, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(11, "MPU34032", "COMMUNITY PROJECT".Beautify(), "3", "L", Day.Thursday, "KAG02",new TimePeriod(Time.CreateTime_24HourFormat(14, 00), Time.CreateTime_24HourFormat(16, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(12, "MPU34082", "ORAL COMMUNICATION".Beautify(), "1", "L", Day.Monday, "KA804",new TimePeriod(Time.CreateTime_24HourFormat(10, 30), Time.CreateTime_24HourFormat(12, 30)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(12, "MPU34082", "ORAL COMMUNICATION".Beautify(), "1", "L", Day.Wednesday, "KA804",new TimePeriod(Time.CreateTime_24HourFormat(10, 30), Time.CreateTime_24HourFormat(12, 30)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})), 
		new Slot(13, "MPU34112", "WORK ETHICS AND EQ".Beautify(), "1", "L", Day.Monday, "KA745",new TimePeriod(Time.CreateTime_24HourFormat(8, 00), Time.CreateTime_24HourFormat(10, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(13, "MPU34112", "WORK ETHICS AND EQ".Beautify(), "1", "L", Day.Wednesday, "KA745",new TimePeriod(Time.CreateTime_24HourFormat(8, 00), Time.CreateTime_24HourFormat(10, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(14, "MPU34152", "LEADERSHIP AND TEAMBUILDING".Beautify(), "1", "L", Day.Monday, "KA745",new TimePeriod(Time.CreateTime_24HourFormat(14, 00), Time.CreateTime_24HourFormat(16, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(14, "MPU34152", "LEADERSHIP AND TEAMBUILDING".Beautify(), "1", "L", Day.Wednesday, "KA745",new TimePeriod(Time.CreateTime_24HourFormat(14, 00), Time.CreateTime_24HourFormat(16, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(15, "UKAF4023", "ACCOUNTING THEORY AND PRACTICE".Beautify(), "1", "L", Day.Monday, "KA512",new TimePeriod(Time.CreateTime_24HourFormat(8, 00), Time.CreateTime_24HourFormat(10, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		new Slot(15, "UKAF4023", "ACCOUNTING THEORY AND PRACTICE".Beautify(), "1", "L", Day.Wednesday, "KA506",new TimePeriod(Time.CreateTime_24HourFormat(12, 00), Time.CreateTime_24HourFormat(14, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		    
		        
            };
        }
    }
}
