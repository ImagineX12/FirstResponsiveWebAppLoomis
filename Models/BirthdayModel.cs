using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppLoomis.Models
{
    public class BirthdayModel
    {
        [Required(ErrorMessage ="Please enter your name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter the day you were born.")]
        [Range(1, 31, ErrorMessage = "Please enter a vaild date of birth. (1-31)")]
        public int? BirthDay { get; set; }

        [Required(ErrorMessage = "Please enter the month you were born.")]
        [Range(1, 12, ErrorMessage = "Please enter a vaild month of birth. (1-12)")]
        public int? BirthMonth { get; set; }

        [Required(ErrorMessage = "Please enter the year you were born.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a vaild year of birth larger than 0.")]
        public int? BirthYear { get; set; }

        //Converts the 3 birth inputs into 1 DateOnly variable
        //The " ?? 0" converts the nullable inteager to a normal one with a default value of 0 if the value is null
        private DateOnly dateOfBirth => new DateOnly(BirthYear ?? 0, BirthMonth ?? 0, BirthDay ?? 0);

        //Gets todays date
        private readonly DateOnly today = DateOnly.FromDateTime(DateTime.Now);

        //Calculates how old you will be on Dec 31 this year
        private int AgeThisYear()
        {
            DateOnly endOfTheYear = new DateOnly(today.Year,12,31);

            //Gets the ammount of years between the two dates
            int age = endOfTheYear.Year - dateOfBirth.Year;
            //Subtracts one year if the birthday has not happend yet
            if (endOfTheYear.Month < dateOfBirth.Month || (endOfTheYear.Month == dateOfBirth.Month) && endOfTheYear.Day < dateOfBirth.Day)
            { 
                age--;
            }

            return age;
        }

        //Calculates how old you are today
        private int AgeToday()
        {
            //Gets the ammount of years between the two dates
            int age = today.Year - dateOfBirth.Year;
            //Subtracts one year if the birthday has not happend yet
            if (today.Month < dateOfBirth.Month || (today.Month == dateOfBirth.Month) && today.Day < dateOfBirth.Day)
            {
                age--;
            }

            return age;
        }

        //Outputs text telling you how old you are and will be
        public string Output()
        {
            return Name + ", you are currently " + AgeToday() + " years old and will be " + AgeThisYear() + " years old at the end of the year.";
        }
    }
}
