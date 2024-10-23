﻿using QuizLab3.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuizLab3.ViewModel
{
    class QuestionPackViewModel: ViewModelBase
        //Model är helt fristående, modelview ska vara en mellanhand och kunna hämta logik från Model
    {
        private readonly QuestionPack model; //Den kommer bara gå att läsa

        public QuestionPackViewModel(QuestionPack model)
        {
            this.model = model;
            this.Questions = new ObservableCollection<Question>(model.Questions);
        }
        public string Name //Det blir bara som en översättning egentligen
        {
            get => model.Name;
            set 
            {  
                model.Name = value;
                RaisePropertyChanged();
            }
        }
        public Difficulty Difficulty
        {
            get => model.Difficulty;
            set
            {
                model.Difficulty = value;
                RaisePropertyChanged();
            }
        }
        public int TimeLimitInSeconds
        { 
            get => model.TimeLimitInSeconds;
            set 
            {  
                model.TimeLimitInSeconds = value;
                RaisePropertyChanged();
            }
        }   
        public ObservableCollection<Question> Questions { get; }

    }

}
