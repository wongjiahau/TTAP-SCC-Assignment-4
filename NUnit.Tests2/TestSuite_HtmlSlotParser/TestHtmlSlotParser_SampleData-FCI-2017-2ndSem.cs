using System.Collections.Generic;
using Time_Table_Arranging_Program;
using Time_Table_Arranging_Program.Class;
using Time_Table_Arranging_Program.Class.Converter;

namespace NUnit.Tests2.TestSuite_HtmlSlotParser {
    public class TestHtmlSlotParser_SampleData_FCI_2017_2ndSem : Test_HtmlSlotParserBase{
        public TestHtmlSlotParser_SampleData_FCI_2017_2ndSem() : base( "SampleData-FCI-2017-2ndSem.html") { }
        protected override List<Slot> GenerateExpectedSlots() {
            return new List<Slot>()
            {
				new Slot(1, "MPU3113", "HUBUNGAN ETNIK (FOR LOCAL STUDENTS)".Beautify(), "1", "L", Day.Monday, "KB521",new TimePeriod(Time.CreateTime_24HourFormat(9, 00), Time.CreateTime_24HourFormat(12, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
            			new Slot(1, "MPU3113", "HUBUNGAN ETNIK (FOR LOCAL STUDENTS)".Beautify(), "1", "L", Day.Thursday, "KB304",new TimePeriod(Time.CreateTime_24HourFormat(8, 00), Time.CreateTime_24HourFormat(11, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		    		new Slot(2, "MPU3123", "TAMADUN ISLAM DAN TAMADUN ASIA (TITAS)".Beautify(), "2", "L", Day.Tuesday, "KB110",new TimePeriod(Time.CreateTime_24HourFormat(12, 00), Time.CreateTime_24HourFormat(15, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	    			new Slot(2, "MPU3123", "TAMADUN ISLAM DAN TAMADUN ASIA (TITAS)".Beautify(), "2", "L", Day.Friday, "KB110",new TimePeriod(Time.CreateTime_24HourFormat(9, 30), Time.CreateTime_24HourFormat(12, 30)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	    			new Slot(3, "MPU3143", "BAHASA MELAYU KOMUNIKASI 2".Beautify(), "1", "L", Day.Tuesday, "KB312",new TimePeriod(Time.CreateTime_24HourFormat(8, 00), Time.CreateTime_24HourFormat(11, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	    			new Slot(3, "MPU3143", "BAHASA MELAYU KOMUNIKASI 2".Beautify(), "1", "L", Day.Thursday, "KB311",new TimePeriod(Time.CreateTime_24HourFormat(14, 30), Time.CreateTime_24HourFormat(17, 30)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	    			new Slot(4, "MPU3173", "MALAYSIAN STUDIES 3 (FOR INTERNATIONAL STUDENTS)".Beautify(), "1", "L", Day.Tuesday, "KB201",new TimePeriod(Time.CreateTime_24HourFormat(15, 00), Time.CreateTime_24HourFormat(18, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	    			new Slot(4, "MPU3173", "MALAYSIAN STUDIES 3 (FOR INTERNATIONAL STUDENTS)".Beautify(), "1", "L", Day.Friday, "KB201",new TimePeriod(Time.CreateTime_24HourFormat(14, 30), Time.CreateTime_24HourFormat(17, 30)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	    			new Slot(5, "MPU32013", "BAHASA KEBANGSAAN A".Beautify(), "1", "L", Day.Tuesday, "KB204",new TimePeriod(Time.CreateTime_24HourFormat(8, 00), Time.CreateTime_24HourFormat(11, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	  			new Slot(5, "MPU32013", "BAHASA KEBANGSAAN A".Beautify(), "1", "L", Day.Wednesday, "KB201",new TimePeriod(Time.CreateTime_24HourFormat(8, 00), Time.CreateTime_24HourFormat(11, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),  
	    			new Slot(6, "MPU34022", "ARTS AND CULTURAL PERFORMANCE".Beautify(), "1", "L", Day.Monday, "KB107",new TimePeriod(Time.CreateTime_24HourFormat(8, 00), Time.CreateTime_24HourFormat(10, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	    			new Slot(6, "MPU34022", "ARTS AND CULTURAL PERFORMANCE".Beautify(), "1", "L", Day.Wednesday, "KB107",new TimePeriod(Time.CreateTime_24HourFormat(8, 00), Time.CreateTime_24HourFormat(10, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	    			new Slot(7, "MPU34032", "COMMUNITY PROJECT".Beautify(), "1", "L", Day.Monday, "KB200",new TimePeriod(Time.CreateTime_24HourFormat(10, 30), Time.CreateTime_24HourFormat(12, 30)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	    			new Slot(7, "MPU34032", "COMMUNITY PROJECT".Beautify(), "1", "L", Day.Wednesday, "KB204",new TimePeriod(Time.CreateTime_24HourFormat(10, 30), Time.CreateTime_24HourFormat(12, 30)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	    			new Slot(8, "MPU34072", "ART, CRAFT, AND DESIGN".Beautify(), "1", "L", Day.Monday, "KB200",new TimePeriod(Time.CreateTime_24HourFormat(14, 00), Time.CreateTime_24HourFormat(16, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	    			new Slot(8, "MPU34072", "ART, CRAFT, AND DESIGN".Beautify(), "1", "L", Day.Wednesday, "KB201",new TimePeriod(Time.CreateTime_24HourFormat(14, 00), Time.CreateTime_24HourFormat(16, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	    			new Slot(9, "MPU34072", "ART, CRAFT, AND DESIGN".Beautify(), "2", "L", Day.Tuesday, "KB200",new TimePeriod(Time.CreateTime_24HourFormat(14, 00), Time.CreateTime_24HourFormat(16, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	    			new Slot(9, "MPU34072", "ART, CRAFT, AND DESIGN".Beautify(), "2", "L", Day.Thursday, "KB200",new TimePeriod(Time.CreateTime_24HourFormat(14, 00), Time.CreateTime_24HourFormat(16, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		    		new Slot(10, "UALF1003", "INTRODUCTION TO FRENCH".Beautify(), "3", "L", Day.Tuesday, "KB308",new TimePeriod(Time.CreateTime_24HourFormat(08, 00), Time.CreateTime_24HourFormat(10, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		      		new Slot(10, "UALF1003", "INTRODUCTION TO FRENCH".Beautify(), "3", "L", Day.Wednesday, "KB313",new TimePeriod(Time.CreateTime_24HourFormat(14, 00), Time.CreateTime_24HourFormat(16, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		    		new Slot(11, "UALF1003", "INTRODUCTION TO FRENCH".Beautify(), "5", "T", Day.Tuesday, "KB308",new TimePeriod(Time.CreateTime_24HourFormat(10, 00), Time.CreateTime_24HourFormat(11, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	    			new Slot(11, "UALF1003", "INTRODUCTION TO FRENCH".Beautify(), "5", "T", Day.Wednesday, "KB313",new TimePeriod(Time.CreateTime_24HourFormat(16, 00), Time.CreateTime_24HourFormat(17, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	    			new Slot(12, "UALF1003", "INTRODUCTION TO FRENCH".Beautify(), "6", "T", Day.Tuesday, "KB308",new TimePeriod(Time.CreateTime_24HourFormat(11, 00), Time.CreateTime_24HourFormat(12, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	    			new Slot(12, "UALF1003", "INTRODUCTION TO FRENCH".Beautify(), "6", "T", Day.Wednesday, "KB313",new TimePeriod(Time.CreateTime_24HourFormat(17, 00), Time.CreateTime_24HourFormat(18, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	   			new Slot(13, "UALJ2013", "INTRODUCTION TO JAPANESE".Beautify(), "1", "L", Day.Tuesday, "KB107",new TimePeriod(Time.CreateTime_24HourFormat(08, 00), Time.CreateTime_24HourFormat(10, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		  		new Slot(13, "UALJ2013", "INTRODUCTION TO JAPANESE".Beautify(), "1", "L", Day.Wednesday, "KB107",new TimePeriod(Time.CreateTime_24HourFormat(14, 00), Time.CreateTime_24HourFormat(16, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		    		new Slot(14, "UALJ2013", "INTRODUCTION TO JAPANESE".Beautify(), "2", "L", Day.Wednesday, "KB200",new TimePeriod(Time.CreateTime_24HourFormat(08, 00), Time.CreateTime_24HourFormat(10, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	   			new Slot(14, "UALJ2013", "INTRODUCTION TO JAPANESE".Beautify(), "2", "L", Day.Thursday, "KB107",new TimePeriod(Time.CreateTime_24HourFormat(14, 00), Time.CreateTime_24HourFormat(16, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		    		new Slot(15, "UALJ2013", "INTRODUCTION TO JAPANESE".Beautify(), "1", "T", Day.Tuesday, "KB107",new TimePeriod(Time.CreateTime_24HourFormat(10, 00), Time.CreateTime_24HourFormat(11, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		    		new Slot(15, "UALJ2013", "INTRODUCTION TO JAPANESE".Beautify(), "1", "T", Day.Wednesday, "KB107",new TimePeriod(Time.CreateTime_24HourFormat(16, 00), Time.CreateTime_24HourFormat(17, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		    		new Slot(16, "UALJ2013", "INTRODUCTION TO JAPANESE".Beautify(), "2", "T", Day.Tuesday, "KB107",new TimePeriod(Time.CreateTime_24HourFormat(11, 00), Time.CreateTime_24HourFormat(12, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		    		new Slot(16, "UALJ2013", "INTRODUCTION TO JAPANESE".Beautify(), "2", "T", Day.Wednesday, "KB107",new TimePeriod(Time.CreateTime_24HourFormat(17, 00), Time.CreateTime_24HourFormat(18, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		    		new Slot(17, "UALJ2013", "INTRODUCTION TO JAPANESE".Beautify(), "3", "T", Day.Wednesday, "KB200",new TimePeriod(Time.CreateTime_24HourFormat(10, 00), Time.CreateTime_24HourFormat(11, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		    		new Slot(17, "UALJ2013", "INTRODUCTION TO JAPANESE".Beautify(), "3", "T", Day.Thursday, "KB107",new TimePeriod(Time.CreateTime_24HourFormat1(16, 00), Time.CreateTime_24HourFormat(17, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		    		new Slot(18, "UALJ2013", "INTRODUCTION TO JAPANESE".Beautify(), "4", "T", Day.Wednesday, "KB200",new TimePeriod(Time.CreateTime_24HourFormat(11, 00), Time.CreateTime_24HourFormat(12, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		    		new Slot(18, "UALJ2013", "INTRODUCTION TO JAPANESE".Beautify(), "4", "T", Day.Thursday, "KB107",new TimePeriod(Time.CreateTime_24HourFormat(17, 00), Time.CreateTime_24HourFormat(18, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		    		new Slot(19, "UAPS2003", "INTRODUCTION TO SOCIOLOGY".Beautify(), "1", "L", Day.Tuesday, "KB204",new TimePeriod(Time.CreateTime_24HourFormat(15, 00), Time.CreateTime_24HourFormat(17, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		  		new Slot(19, "UAPS2003", "INTRODUCTION TO SOCIOLOGY".Beautify(), "1", "L", Day.Wednesday, "KB313",new TimePeriod(Time.CreateTime_24HourFormat(08, 00), Time.CreateTime_24HourFormat(10, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		    		new Slot(20, "UAPS2003", "INTRODUCTION TO SOCIOLOGY".Beautify(), "1", "T", Day.Tuesday, "KB204",new TimePeriod(Time.CreateTime_24HourFormat(17, 00), Time.CreateTime_24HourFormat(18, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		    		new Slot(20, "UAPS2003", "INTRODUCTION TO SOCIOLOGY".Beautify(), "1", "T", Day.Wednesday, "KB313",new TimePeriod(Time.CreateTime_24HourFormat(10, 00), Time.CreateTime_24HourFormat(11, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		    		new Slot(21, "UAPS2003", "INTRODUCTION TO SOCIOLOGY".Beautify(), "2", "T", Day.Thursday, "KB308",new TimePeriod(Time.CreateTime_24HourFormat(16, 00), Time.CreateTime_24HourFormat(17, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
		    		new Slot(21, "UAPS2003", "INTRODUCTION TO SOCIOLOGY".Beautify(), "2", "T", Day.Thursday, "KB308",new TimePeriod(Time.CreateTime_24HourFormat(17, 00), Time.CreateTime_24HourFormat(18, 00)),new WeekNumber(new List<int>() {1, 2, 3, 4, 5, 6, 7})),
	    };
        }
    }
}
