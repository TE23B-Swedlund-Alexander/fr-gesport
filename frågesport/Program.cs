using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

bool score1 = false;
bool score2 = false;
bool score3 = false;
bool score4 = false;
int correct = 0;

static void fel(){
Console.WriteLine ("""
 ___       __   ________  ________  ________   ________                ________  _________  ___  ___  ________  ___  ________     
|\  \     |\  \|\   __  \|\   __  \|\   ___  \|\   ____\              |\   ____\|\___   ___\\  \|\  \|\   __  \|\  \|\   ___ \    
\ \  \    \ \  \ \  \|\  \ \  \|\  \ \  \\ \  \ \  \___|              \ \  \___|\|___ \  \_\ \  \\\  \ \  \|\  \ \  \ \  \_|\ \   
 \ \  \  __\ \  \ \   _  _\ \  \\\  \ \  \\ \  \ \  \  ___  ___        \ \_____  \   \ \  \ \ \  \\\  \ \   ____\ \  \ \  \ \\ \  
  \ \  \|\__\_\  \ \  \\  \\ \  \\\  \ \  \\ \  \ \  \|\  \|\  \        \|____|\  \   \ \  \ \ \  \\\  \ \  \___|\ \  \ \  \_\\ \ 
   \ \____________\ \__\\ _\\ \_______\ \__\\ \__\ \_______\ \  \         ____\_\  \   \ \__\ \ \_______\ \__\    \ \__\ \_______\
    \|____________|\|__|\|__|\|_______|\|__| \|__|\|_______|\/  /|       |\_________\   \|__|  \|_______|\|__|     \|__|\|_______|
                                                          |\___/ /       \|_________|                                             
                                                          \|___|/                                                                 
                                                                                                                                  
""");
}
static void bra(){
Console.WriteLine ("""
 ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄ 
▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌
▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀  ▀▀▀▀█░█▀▀▀▀ 
▐░▌          ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░▌          ▐░▌               ▐░▌     
▐░▌          ▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░▌               ▐░▌     
▐░▌          ▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌               ▐░▌     
▐░▌          ▐░▌       ▐░▌▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌               ▐░▌     
▐░▌          ▐░▌       ▐░▌▐░▌     ▐░▌  ▐░▌     ▐░▌  ▐░▌          ▐░▌               ▐░▌     
▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄█░▌▐░▌      ▐░▌ ▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄      ▐░▌     
▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌     ▐░▌     
 ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀  ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀       ▀      
""");
}

Console.WriteLine("question one.  you have a fox a chicken and a small bag of grain you have to bring them over a river and can only bring one at a time having to leave the other two behind, if the fox is left with the chicken it will eat it and if the chicken is left with the grain it will eat it how do you get all three accross the river. to be helpfull im giving you three alternatives");
Console.WriteLine("A. fox over, back, chicken over, fox back, grain over, back chicken over    B. chicken over, back, fox over, back, grain over  C. chicken over, back, fox over, chicken back, grain over, back chicken over");
string awnserone = Console.ReadLine();
if (awnserone.ToLower() == "a" || awnserone.ToLower() == "b" || awnserone.ToLower() == "c")
{
    if (awnserone.ToLower() == "c")
    {
        bra();
        
        score1 = true;
        correct++;
        Console.WriteLine("great start");
    }

    if (awnserone.ToLower() == "a" || awnserone.ToLower() == "b")
    {
        fel();
    
        Console.WriteLine("do better");
    }
}
else
{
    Console.WriteLine("that counts as a wrong awnser, should have awnserd with one of the alternatives");
}
Console.WriteLine("question 2.  what color is best?");
Console.WriteLine("A. red  B. blue  C. green");
string awnserztwo = Console.ReadLine();
if (awnserztwo.ToLower() == "a" || awnserztwo.ToLower() == "b" || awnserztwo.ToLower() == "c")
{
    if (awnserztwo.ToLower() == "b")
    {
         bra();
        
        score2 = true;
        correct++;
        if (score2 == true)
        {
            if (score1 == true)
            {
                Console.WriteLine("correct again!!");
            }
            if (score1 == false)
            {
                Console.WriteLine("thats more like it!!");
            }
        }

    }

    if (awnserztwo.ToLower() == "a" || awnserztwo.ToLower() == "c")
    {
        fel();
        if (score2 == false)
        {
            if (score1 == true)
            {
                Console.WriteLine("i expected more from you");
            }
            if (score1 == false)
            {
                Console.WriteLine("you are really bad at this...");
            }
        }

    }
}
else
{
    Console.WriteLine("that counts as a wrong awnser, should have awnserd with one of the alternatives");
}
Console.WriteLine("what is the meaning of life?");
Console.WriteLine("A. 42  B. green  C. nothing");
string awnserzthreee = Console.ReadLine();
if (awnserzthreee.ToLower() == "a" || awnserzthreee.ToLower() == "b" || awnserzthreee.ToLower() == "c")
{
    if (awnserzthreee.ToLower() == "a")
    {
         bra();
       
        score3 = true;
        correct++;
        if (score3 == true)
        {
            if (score2 == true)
            {
                if (score1 == true)
                {
                    Console.WriteLine("almost there!!");
                }
                if (score1 == false)
                {
                    Console.WriteLine("first one was to tricky for you");
                }
            }
            if (score2 == false)
            {
                if (score1 == true)
                {
                    Console.WriteLine("must have missclicked on question 2 ;)");
                }
                if (score1 == false)
                {
                    Console.WriteLine("lucky guess >:(");
                }
            }
        }


    }

    if (awnserzthreee.ToLower() == "b" || awnserzthreee.ToLower() == "c")
    {
        fel();
        if (score3 == false)
        {
            if (score2 == true)
            {
                if (score1 == true)
                {
                    Console.WriteLine("you were doing so good");
                }
                if (score1 == false)
                {
                    Console.WriteLine("must have been lucky on question 2");
                }
            }
            if (score2 == false)
            {
                if (score1 == true)
                {
                    Console.WriteLine("strong start i guess...");
                }
                if (score1 == false)
                {
                    Console.WriteLine("how are you so bad at this");
                }
            }
        }

    }
}
else
{
    Console.WriteLine("that counts as a wrong awnser, should have awnserd with one of the alternatives");
}
Console.WriteLine("the awnser to this question is incorrect");
Console.WriteLine("A. true  B. incorrect  C. what?");
string awns4 = Console.ReadLine();
if (awns4.ToLower() == "a" || awns4.ToLower() == "b" || awns4.ToLower() == "c")
{
    if (awns4.ToLower() == "b")
    {
         bra();
        
        score4 = true;
        correct++;
        if (score4 == true)
        {
            if (score3 == true)
            {
                if (score2 == true)
                {
                    if (score1 == true)
                    {
                        Console.WriteLine("you got them all!!");
                    }
                    if (score1 == false)
                    {
                        Console.WriteLine("you did well after the first block of text flew over your head");
                    }
                }
                if (score2 == false)
                {
                    if (score1 == true)
                    {
                        Console.WriteLine("you did pretty good only failed one");
                    }
                    if (score1 == false)
                    {
                        Console.WriteLine("just gets more difficult");
                    }
                }
            }
            if (score3 == false)
            {
                if (score2 == true)
                {
                    if (score1 == true)
                    {
                        Console.WriteLine("if only you didnt fail question 3");
                    }
                    if (score1 == false)
                    {
                        Console.WriteLine("its hard to come up with these texts");
                    }
                }
                if (score2 == false)
                {
                    if (score1 == true)
                    {
                        Console.WriteLine("good, bad, bad, good");
                    }
                    if (score1 == false)
                    {
                        Console.WriteLine("at least you didnt fail this one");
                    }
                }
            }
        }


    }

    if (awns4.ToLower() == "a" || awns4.ToLower() == "c")
    {
        fel();
        if (score4 == false)
        {
            if (score3 == true)
            {
                if (score2 == true)
                {
                    if (score1 == true)
                    {
                        Console.WriteLine("almost got tem all, smh");
                    }
                    if (score1 == false)
                    {
                        Console.WriteLine("bad, good, good, bad");
                    }
                }
                if (score2 == false)
                {
                    if (score1 == true)
                    {
                        Console.WriteLine("blue is the best color and the awnser was litteraly incorrect");
                    }
                    if (score1 == false)
                    {
                        Console.WriteLine("how did you even get this text");
                    }
                }
            }
            if (score3 == false)
            {
                if (score2 == true)
                {
                    if (score1 == true)
                    {
                        Console.WriteLine("only made it half way");
                    }
                    if (score1 == false)
                    {
                        Console.WriteLine("at least you know what the best color is");
                    }
                }
                if (score2 == false)
                {
                    if (score1 == true)
                    {
                        Console.WriteLine("peaked on the first question");
                    }
                    if (score1 == false)
                    {
                        Console.WriteLine("really how stupid do you have to be to get every question wrong");
                    }
                }
            }
        }
    }
}
else
{
    Console.WriteLine("that counts as a wrong awnser, should have awnserd with one of the alternatives");
}
Console.WriteLine($"you got {correct} correct");
Console.ReadLine();

// SUger donke ballz ;) "hugo"