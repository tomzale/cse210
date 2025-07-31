using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1 - BYU Computing Channel
        Video video1 = new Video("What Is CPM?", "BYU Computing, Math & Science", 480);
        video1.AddComment(new Comment("Thomas Etiuzale", "This explanation is clearer than what we got in class!"));
        video1.AddComment(new Comment("Adebayo Okafor", "Omo! This guy sabi network matters"));
        video1.AddComment(new Comment("Chioma Nwachukwu", "Please make more videos on networking"));
        video1.AddComment(new Comment("Emeka Okonkwo", "Wetin be the textbook for this course?"));
        videos.Add(video1);

        // Video 2 - freeCodeCamp
        Video video2 = new Video("Learn Python - Full Course for Beginners", "freeCodeCamp", 14400);
        video2.AddComment(new Comment("Funke Adeleke", "4 hours no be beans o! But I go try am"));
        video2.AddComment(new Comment("Ibrahim Musa", "Alhamdulillah for free education"));
        video2.AddComment(new Comment("Thomas Etiuzale", "I've watched this 3 times - golden content"));
        video2.AddComment(new Comment("Amina Mohammed", "Where can I get the practice files?"));
        videos.Add(video2);

        // Video 3 - SimpliLearn
        Video video3 = new Video("Data Science in 10 Minutes", "SimpliLearn", 600);
        video3.AddComment(new Comment("Oluwaseun Adebayo", "Short and sweet like puff-puff"));
        video3.AddComment(new Comment("Thomas Etiuzale", "This got me interested in data science"));
        video3.AddComment(new Comment("Ngozi Eze", "Which school fit teach this for Nigeria?"));
        video3.AddComment(new Comment("Yusuf Bello", "Abeg make una do one for AI"));
        videos.Add(video3);

        // Video 4 - BYU Computing Bonus Video
        Video video4 = new Video("Object-Oriented Programming Principles", "BYU Computing, Math & Science", 720);
        video4.AddComment(new Comment("Thomas Etiuzale", "Finally understand polymorphism!"));
        video4.AddComment(new Comment("Chinedu Iwu", "OOP don wound my brain before"));
        video4.AddComment(new Comment("Blessing Okon", "This go help for my JAMB prep"));
        videos.Add(video4);

        // Display all videos
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}