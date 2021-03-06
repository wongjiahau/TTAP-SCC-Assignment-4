﻿using System;
using System.Collections.Generic;
using System.Linq;
using Time_Table_Arranging_Program.Class;
using Time_Table_Arranging_Program.Class.StateSummary;
using Time_Table_Arranging_Program.Model;

namespace Time_Table_Arranging_Program.TimetableFinder {
    public interface ITimetableFinder {
        List<List<Slot>> GetPossibleTimetables(List<SubjectModel> subjects, Func<Slot[], List<List<Slot>>> permutator);
    }

    public class TimetableFinder : ITimetableFinder {
        public List<List<Slot>> GetPossibleTimetables(List<SubjectModel> subjects,
                                                      Func<Slot[], List<List<Slot>>> permutator) {
            subjects = SortBySlotCount(subjects);
            var currentSlots = subjects[0].Slots;
            var possibleCombination = permutator.Invoke(currentSlots.ToArray());
            var state = StateTable.GetStateOfDefinitelyOccupied(possibleCombination);
            int last = subjects.Count - 1;
            for (int i = 1; i < subjects.Count; i++) {
                var filtrate = StateTable.Filter(subjects[i].Slots, state);
                currentSlots.AddRange(filtrate);
                possibleCombination = permutator.Invoke(currentSlots.ToArray());
                if (i != last)
                    state = StateTable.GetStateOfDefinitelyOccupied(possibleCombination);
            }
            return possibleCombination;
        }

        public List<SubjectModel> SortBySlotCount(List<SubjectModel> subjects) {
            var input = subjects;
            var result = input.OrderBy(x => x.Slots.Count).ToList();
            return result;
        }
    }
}