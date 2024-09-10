using System.Linq.Expressions;

bool score1 = false;
bool score2 = false;
bool score3 = false;
int correct = 0;
Console.WriteLine("question one.  you have a fox a chicken and a small bag of grain you have to bring them over a river and can only bring one at a time having to leave the other two behind, if the fox is left with the chicken it will eat it and if the chicken is left with the grain it will eat it how do you get all three accross the river. to be helpfull im giving you three alternatives");
Console.WriteLine("A. fox over, back, chicken over, fox back, grain over, back chicken over    B. chicken over, back, fox over, back, grain over  C. chicken over, back, fox over, chicken back, grain over, back chicken over");
string awnserone = Console.ReadLine();
if (awnserone.ToLower() == "a" || awnserone.ToLower() == "b" ||awnserone.ToLower() == "c") {
if (awnserone.ToLower() == "c")
{
    score1 = true;
    correct = correct + 1;
    Console.WriteLine("correct!!");
}

if (awnserone.ToLower() == "a" || awnserone.ToLower() == "b")
{
    Console.WriteLine("incorrect, do better");
}
} else {
    Console.WriteLine("that counts as a wrong awnser, should have awnserd with one of the alternatives");
}
Console.WriteLine("question 2.  what color is best?");
Console.WriteLine("A. red  B. blue  C. green");
string awnserztwo = Console.ReadLine();
if (awnserztwo.ToLower() == "a" || awnserztwo.ToLower() == "b" ||awnserztwo.ToLower() == "c"){
if (awnserztwo.ToLower() == "b")
{
    score2 = true;
    correct = correct + 1;
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
}else {
    Console.WriteLine("that counts as a wrong awnser, should have awnserd with one of the alternatives");
}
Console.WriteLine("what is the meaning of life?");
Console.WriteLine("A. 42  B. green  C. what?");
string awnserzthreee = Console.ReadLine();
if (awnserzthreee.ToLower() == "a" || awnserzthreee.ToLower() == "b" ||awnserzthreee.ToLower() == "c"){
if (awnserzthreee.ToLower() == "a")
{
    score3 = true;
    correct = correct + 1;
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
                Console.WriteLine("good save");
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
    if (score3 == false)
    {
        if (score2 == true)
        {
            if (score1 == true)
            {
                Console.WriteLine("ah sooooo close :(");
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
                Console.WriteLine("peaked on the first question");
            }
            if (score1 == false)
            {
                Console.WriteLine("how are you so bad at this");
            }
        }
    }

}
}else {
    Console.WriteLine("that counts as a wrong awnser, should have awnserd with one of the alternatives");
}
Console.WriteLine($"you got {correct} correct");
Console.ReadLine();
