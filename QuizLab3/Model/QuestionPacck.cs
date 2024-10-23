﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLab3.Model
{
    enum Difficulty { Easy, Medium, Hard }

    internal class QuestionPack
    {
        public QuestionPack(string name, Difficulty difficulty = Difficulty.Medium, int timeLimitInSeconds = 30) //lägger till default värden
        {
            Name = name;
            Difficulty = difficulty;
            TimeLimitInSeconds = timeLimitInSeconds;
            Questions = new List<Question>() ;
        }

        public string Name { get; set; }
        public Difficulty Difficulty { get; set; }
        public int TimeLimitInSeconds { get; set; }
        public List<Question> Questions { get; set; }

    }
}