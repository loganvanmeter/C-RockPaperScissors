using System.Diagnostics.Contracts;
int PlayerScore = 0;
int ComputerScore = 0;
Main();
void Main(){
      
while (PlayerScore < 3 && ComputerScore < 3) {
PlayRound();
}

if ( PlayerScore == 3) {
    Console.WriteLine("You Won The Game!");
} else if (ComputerScore == 3){
    Console.WriteLine("You Lost The Game.");
}

}

static int RandomNumber() {
    Random r = new Random();
    int genRand= r.Next(1,3);
   return genRand;
}

void PlayRound() {  
    Console.WriteLine($@"
-------------------------------
| Player: {PlayerScore} | Computer: {ComputerScore} |
-------------------------------
1) Rock
2) Paper
3) Scissors
");  
string PlayerChoice = Console.ReadLine();
int Rock = 1;
int Paper = 2;
int Scissors = 3;
int ComputerChoice = RandomNumber();
    if (int.TryParse(PlayerChoice, out int num))
{
    if (num >=1 && num <=3){
        Console.WriteLine("You:");
        ChoiceGraphic(num);
        Console.WriteLine("VS");
        Console.WriteLine("The Computer:");
        ChoiceGraphic(ComputerChoice);


    if((num == Rock && ComputerChoice == Scissors) || (num == Paper && ComputerChoice == Rock) || (num == Scissors && ComputerChoice == Paper)) {
        PlayerScore++;
        Console.WriteLine("You Win The Round!");
    } else if (num == ComputerChoice) {
        Console.WriteLine("Draw");
    } else {
        ComputerScore++;
        Console.WriteLine("You Lose The Round!");
    }
    }
    else {
        Console.WriteLine("Not an option.");
        PlayRound();
    }
} else {
    Console.WriteLine("Not an number.");
    PlayRound();
}
}


static void ChoiceGraphic(int num) {
    switch(num) {
        case 1:
        Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)");
break;
case 2:
Console.WriteLine(@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)");
break;
case 3:
Console.WriteLine(@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)");
break;
    }
}