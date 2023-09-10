using System.Globalization;
using System;


namespace DefiningClasses{
    public class DateModifier{


        public int difference(string first_date, string second_date){
            List<int> date1 = first_date.Split(' ').Select(int.Parse).ToList();
            List<int> date2 = second_date.Split(' ').Select(int.Parse).ToList();
            var first_date1 = new DateTime(date1[0], date1[1], date1[2]);
            var second_date1 = new DateTime(date2[0], date2[1], date2[2]);

            var difference = second_date1 - first_date1;

            return Math.Abs(difference.Days);
        } 


    }
}