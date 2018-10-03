using System;
using System.Collections.Generic;

namespace askRichard
{
    public class Person
    {
        public string Name;
        public int Happiness;
        public int Sadness;
        public int Annoyed;
        public List<string> Questions = new List<string>() 
        {
            // 1-10 Questions that entertain Richard
            "What's your favorite color?",
            "Can you see me?",
            "How did you solve the problem?",
            "Why are you so fat?",
            "Where to invade next?",
            "Where am I?",
            "Which Harry Potter character are you?",
            "Which Pokemon are you?",
            "Which Disney princess are you?",
            "What is your favorite number?",
            // 11-20 Questions that upset Richard
            "Are you sure your algorithm works?",
            "What do you mean?",
            "How many friends do you have?",
            "Why do you look tired today?",
            "What's your name again?",
            "Are you okay?",
            "Why are you so quiet today?",
            "Why is traffic so bad?",
            "Where's your car?",
            "Where's the bug?",
            // 21-30 Questions that annoy Richard
            "I have a question",
            "How old are you?",
            "Why did you fail the first black belt in Mean?",
            "What time is it?",
            "What are your greatest strengths and weaknesses?",
            "No, where are you really from?",
            "Why do your shirts look the same?",
            "Who are you voting for?",
            "Why aren't you on Facebook?",
            "What's on your mind?"
        };
        public List<string> Answers = new List<string>()
        {
            // 1-10 
            "Cardinal",
            "Oh yeah",
            "It's easy",
            "Why am I so fat???", 
            "Brunei", 
            "I don't know",
            "Voldemort *Richard chuckled*", 
            "I don't play Pokemon", 
            "I don't know. Why are you asking that?",
            "Pi! *Richard answered then started typing abstract numbers on the screen...*",
            // 11-20
            "Why not? Run it",
            "What do you mean what I mean?",
            "Four.", 
            "Give me a chance to get my coffee! *Walks to the kitchen", 
            "Richard", 
            "Yup. Why would you ask?",
            "...",
            "Lots of people live here. Too many cars. Do you imagine driving on the free way... *keeps ranting", 
            "What do you mean!",
            "What kind of bug?",
            // 21-30
            "*Richard stared at you*",
            "Why do you ask? Be more creative!",
            "I hated the test",
            "Check your clock",
            "My answer for your question is... Wait, will you pay me if i answer?", 
            "...", 
            "I don't have any weaknesses... I don't have any strengths either", 
            "What? Why does it have to be political? I don't vote", 
            "Which one does it look the same to you? *Richard checked his shirt*", 
            "Because I only have 4 friends", 
            "Neurons" 
        };
        public Person(string name)
        {

        }
    }
}