namespace day21_task1.Models
{
    public class Calculator
    {
        public int Id { get; set; }
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public int Add(int Num1, int Num2) {  return Num1 + Num2; }
        public int Sub(int Num1, int Num2) { return Num1 - Num2; }
        public int Mul(int Num1, int Num2) { return Num1 * Num2; }
        public int Div(int Num1, int Num2) { return Num1 / Num2; }


    }
}
