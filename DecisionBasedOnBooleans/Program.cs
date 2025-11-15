Console.WriteLine("Is the lecture topic interesting? (y/n)");
bool isLectureInteresting = Console.ReadLine() == "y";

Console.WriteLine("Does one of your friends join? (y/n)");
bool isFriendJoining = Console.ReadLine() == "y";

Console.WriteLine("Do you have problems with the assignment? (y/n)");
bool hasProblemsWithAssignment = Console.ReadLine() == "y";

if (isLectureInteresting && (isFriendJoining || hasProblemsWithAssignment))
    Console.WriteLine("Go.");
else
    Console.WriteLine("Stay.");
