// See https://aka.ms/new-console-template for more information
class program
{
    public class Loan
    {
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Interest calculated");
        }
    }

    class PersonalLoan : Loan
    {
        public override void CalculateInterest()
        {
                Console.WriteLine("Personal loan interest calculated");
            }
        }

    class EducationLoan : Loan
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("Education loan interest calculated");
        }
    }

    public static void Main()
    {
        Loan Dishari = new PersonalLoan();
        Dishari.CalculateInterest();

        Loan Manish = new EducationLoan();
        Manish.CalculateInterest();
    }
}


    