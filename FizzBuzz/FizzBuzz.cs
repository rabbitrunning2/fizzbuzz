using System;

namespace FizzBuzzConsole
{
	public class FizzBuzz
	{

		public int Limit { get; set; }
		public String FirstOutput { get; set; }
		public String SecondOutput { get; set; }
		public int FirstNumber { get; set; }
		public int SecondNumber { get; set; }

		public FizzBuzz(string opone, string optwo, int numone, int numtwo, int lim){

			FirstOutput = opone;
			SecondOutput = optwo;
			FirstNumber = numone;
			SecondNumber = numtwo;
			Limit = lim;	

		}

		public static bool FactorDecider(int number, int factor)
		{
			return factor%number == 0;
		}

		public string OuputDecider()
		{
			var output = "";
			var space = " ";

			for (var i = 1; i < this.Limit; i++)
			{
				if (FactorDecider(this.FirstNumber, i))
				{
					output += this.FirstOutput;
				}
				if (FactorDecider(this.SecondNumber, i))
				{
					output += this.SecondOutput;
				}
				if(!FactorDecider(this.FirstNumber, i) && !FactorDecider(this.SecondNumber, i) )
				{
					output += i.ToString();
				}
				output += space;

			}
			return output;
		}
	}
}




