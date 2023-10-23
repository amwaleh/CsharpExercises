
/* 

You've consumed X amount of Mbps on Wikipedia and Y amount of Mbps on memes. The cost of visiting Wikipedia is 0,10$ per Mb and the cost for watching memes is 0,05$ per Mb. If total consumption is more than 100$ print "Too much consumption". If watching meme consumption is greater than reading wikipedia consumption print "WOW MANY MEMES", "SUCH LOL"(in new line).
Create a program that:
Reads X(wikipedia Mb consupmtion) and Y(watching meme Mb consumption)
Calculates the total consumption
If total consumption greater than 100$ print proper message
If watching meme consumption is greater than reading wikipedia articles print proper messages
Warning! For the greater meme consumption you will use one print statement and the output must be in seperate lines

*/


using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    var s = new NetworkSpend (1000.00, 1000.00);
    s.CheckConsumption();
  }
}

class NetworkSpend {

  public double WikiCost = 0.10;
  public double MemeSpend = 0.05;
  public double wikiMbs = 0; 
  public double memeMbs = 0;
  
 public NetworkSpend(double wikiMbs, double memeMbs){
   this.wikiMbs = wikiMbs;
   this.memeMbs = memeMbs;
 }

public double WikiConsumedMbs => this.wikiMbs * this.WikiCost;
public double GetmemeConsumedMbs => this.memeMbs * this.MemeSpend;
public double GetTotalConsumptionMbs => this.WikiConsumedMbs + this.GetmemeConsumedMbs;
  
public void CheckConsumption () {
    if (this.GetTotalConsumptionMbs > 100){
      Console.WriteLine("Too much consumption");
    }
    if (this.WikiConsumedMbs <  this.GetmemeConsumedMbs) {
      Console.WriteLine("WOW MANY MEMES,\n SUCH LOL");
    }
  }
  
}