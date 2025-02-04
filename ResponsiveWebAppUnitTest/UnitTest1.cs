using FirstResponsiveWebAppLoomis.Models;

namespace ResponsiveWebAppUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void AgeBirthdayPassed()
        {
            //Arange
            BirthdayModel model = new BirthdayModel();
            model.Name = "Test";
            model.BirthDay = 1;
            model.BirthMonth = 1;
            model.BirthYear = 2000;

            int expected = 25;
            int actual;
            //Act

            actual = model.AgeToday();
            //Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AgeBirthdayNotPassed()
        {
            //Arange
            BirthdayModel model = new BirthdayModel();
            model.Name = "Test";
            model.BirthDay = 1;
            model.BirthMonth = 12;
            model.BirthYear = 2000;

            int expected = 24;
            int actual;
            //Act

            actual = model.AgeToday();
            //Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AgeThisYearBirthdayPassed()
        {
            //Arange
            BirthdayModel model = new BirthdayModel();
            model.Name = "Test";
            model.BirthDay = 1;
            model.BirthMonth = 1;
            model.BirthYear = 2000;

            int expected = 25;
            int actual;
            //Act

            actual = model.AgeThisYear();
            //Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AgeThisYearBirthdayNotPassed()
        {
            //Arange
            BirthdayModel model = new BirthdayModel();
            model.Name = "Test";
            model.BirthDay = 1;
            model.BirthMonth = 12;
            model.BirthYear = 2000;

            int expected = 25;
            int actual;
            //Act

            actual = model.AgeThisYear();
            //Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OutputBirthdayPassed()
        {
            //Arange
            BirthdayModel model = new BirthdayModel();
            model.Name = "Test";
            model.BirthDay = 1;
            model.BirthMonth = 1;
            model.BirthYear = 2000;

            string expected = "Test, you are currently 25 years old and will be 25 years old at the end of the year.";
            string actual;
            //Act

            actual = model.Output();
            //Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OutputBirthdayNotPassed()
        {
            //Arange
            BirthdayModel model = new BirthdayModel();
            model.Name = "Test";
            model.BirthDay = 1;
            model.BirthMonth = 12;
            model.BirthYear = 2000;

            string expected = "Test, you are currently 24 years old and will be 25 years old at the end of the year.";
            string actual;
            //Act

            actual = model.Output();
            //Assert

            Assert.Equal(expected, actual);
        }
    }
}