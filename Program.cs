// See https://aka.ms/new-console-template for more information
using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

// Let the moose speak!
MooseSays("H I, I'M  E N T H U S I A S T I C !");
MooseSays("I really am enthusiastic");

// As a question
// using function from ln 73
AskQuestion("Is Canada real?","Really? It seems very unlikely.","I  K N E W  I T !!!");
AskQuestion("Are you enthusiastic?","Yay!","You should try it!");
AskQuestion("Do you love C# yet?","Good job sucking up to your instructor!","You will...oh, yes, you will...");
AskQuestion("Do you want to know a secret?","ME TOO!!!! I love secrets...tell me one!","Oh, no...secrets are the best, I love to share them!");

MagicMooseMain();
}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}
//boolean that prints a string depending on whether the answer given is y or n

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    return answer == "y";
}

//function that takes three parameters: a question, a result if it is true, and a result if it is false

void AskQuestion(string question, string trueResponse, string falseResponse)
{
    bool answer = MooseAsks(question);

    if(answer)
    {
        MooseSays(trueResponse);
    }
    else
    {
        MooseSays(falseResponse);
    }
}

//Questions I refactored into a reuseable function

// void CanadaQuestion()
// {
//     bool isTrue = MooseAsks("Is Canada real?");
//     if (isTrue)
//     {
//         MooseSays("Really? It seems very unlikely.");
//     }
//     else
//     {
//         MooseSays("I  K N E W  I T !!!");
//     }
// }

// void EnthusiasticQuestion()
// {
//     bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
//     if (isEnthusiastic)
//     {
//         MooseSays("Yay!");
//     }
//     else
//     {
//         MooseSays("You should try it!");
//     }
// }

// void LoveCSharpQuestion()
// {
//     bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
//     if (doesLoveCSharp)
//     {
//         MooseSays("Good job sucking up to your instructor!");
//     }
//     else
//     {
//         MooseSays("You will...oh, yes, you will...");
//     }
// }

// void SecretQuestion()
// {
//     bool wantsSecret = MooseAsks("Do you want to know a secret?");
//     if (wantsSecret)
//     {
//         MooseSays("ME TOO!!!! I love secrets...tell me one!");
//     }
//     else
//     {
//         MooseSays("Oh, no...secrets are the best, I love to share them!");
//     }
// }

    static void MagicMooseMain()
    {
        Console.WriteLine("Welcome to the Magic MOOSE!");
        Console.WriteLine("Ask the Magic Moose a Question or Hit ENTER to exit");

        void MooseSays(string message)
        {
            Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
        }


        string question = GetQuestionFromUser();

        while (!string.IsNullOrWhiteSpace(question))
        {
            string response = getRandomResponse();
            MooseSays(response);
            Console.WriteLine();

            question = GetQuestionFromUser();
        }

        Console.WriteLine("Goodbye!");
    }

    static string GetQuestionFromUser()
    {
        Console.Write("Your Question: ");
        return Console.ReadLine();
    }
    static string getRandomResponse()
    {
        string[] responses =
        {
         "As I see it, yes.",
         "Ask again later.",
         "Better not tell you now.",
         "Cannot predict now.",
         "Concentrate and ask again.",
         "Don't count on it.",
         "It is certain.",
         "It is decidedly so.",
         "Most likely.",
         "My reply is no.",
         "My sources say no.",
         "Outlook not so good.",
         "Outlook good.",
         "Reply hazy, try again.",
         "Signs point to yes.",
         "Very doubtful.",
         "Without a doubt.",
         "Yes.",
         "Yes - definitely.",
         "You may rely on it."
         };

        Random random = new Random();
        int index = random.Next(responses.Length);
        return responses[index];

    }

static  void RPSMooseMain()
{

}
