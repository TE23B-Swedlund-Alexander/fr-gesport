int score = 0;
Console.WriteLine("question one.  what is 1+1");
Console.WriteLine("A. 15   B. 3   C. nither");
string awnserone = Console.ReadLine();
if (awnserone.ToLower() == "c")
{
    score = score + 1;
    Console.WriteLine("correct!!");
}

if (awnserone.ToLower() == "a" || awnserone.ToLower() == "b")
{
    Console.WriteLine("incorrect idiot");
}
Console.WriteLine("question 2.  what color is grass usually?");
Console.WriteLine("A. purple  B. green  C. blue");
string awnserztwo = Console.ReadLine();

if (awnserztwo.ToLower() == "b")
{
    score = score + 1;
    if (score == 2)
    {
    Console.WriteLine("correct again!!");
    }
     if (score == 1)
    {
    Console.WriteLine("thats more like it!!");
    }
    
  
}

if (awnserone.ToLower() == "a" || awnserone.ToLower() == "c")
{
       if (score == 1)
    {
    Console.WriteLine("i expected more from you");
    }
     if (score == 0)
    {
    Console.WriteLine("you are really bad at this...");
    }
    
}
Console.WriteLine("what is the meaning of life?");
Console.WriteLine("A. 42  B. green  C. what?");
string awnserzthreee = Console.ReadLine();
if (awnserzthreee.ToLower() == "a")
{
    score = score + 1;
      if (score == 3)
    {
    Console.WriteLine("you got them all!!");
    }
    if (score == 2)
    {
    Console.WriteLine("2 out of 3 is not too bad i guess..");
    }
     if (score == 1)
    {
    Console.WriteLine("lucky guess >:(");
    }
    
  
}

if (awnserone.ToLower() == "a" || awnserone.ToLower() == "c")
{
        if (score == 2)
    {
    Console.WriteLine("you were so close:(");
    }
       if (score == 1)
    {
    Console.WriteLine("womp womp only one right");
    }
     if (score == 0)
    {
    Console.WriteLine("your shit at this");
    }
    
}
Console.ReadLine();