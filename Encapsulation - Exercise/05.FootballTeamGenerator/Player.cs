using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private const int minAllowedValue = 0;
        private const int maxAllowedValue = 100;
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }
        public string Name  
        { 
            get 
            {
                return this.name;
            } 
            private set
            {
                Validator.ThrowInvalidNameException(value, "A name should not be empty.");
                this.name = value;
            } 
        }
        public int Endurance 
        { 
            get 
            {
                return this.endurance;
            }
            private set 
            {
                Validator.ThrowInvalidStatsException(value, minAllowedValue, maxAllowedValue,
                    $"{nameof(Endurance)} should be between 0 and 100.");
                this.endurance = value;
            }
        }
        public int Sprint 
        { 
            get 
            {
                return this.sprint;
            } 
            private set 
            {
                Validator.ThrowInvalidStatsException(value, minAllowedValue, maxAllowedValue,
                    $"{nameof(Sprint)} should be between 0 and 100.");
                this.sprint = value;
            }
        }
        public int Dribble 
        { 
            get 
            {
                return this.dribble;
            }
            private set
            {
                Validator.ThrowInvalidStatsException(value, minAllowedValue, maxAllowedValue,
                    $"{nameof(Dribble)} should be between 0 and 100.");
                this.dribble = value;
            }
        }
        public int Passing 
        {
            get 
            {
                return this.passing;
            }
            private set 
            {
                Validator.ThrowInvalidStatsException(value, minAllowedValue, maxAllowedValue,
                    $"{nameof(Passing)} should be between 0 and 100.");
                this.passing = value;
            }
        }
        public int Shooting 
        { 
            get 
            {
                return this.shooting;
            }
            private set
            {
                Validator.ThrowInvalidStatsException(value, minAllowedValue, maxAllowedValue, 
                    $"{nameof(Shooting)} should be between 0 and 100.");
                this.shooting = value;
            } 
        }
        public double AverageSkill 
        { 
            get 
            {
                return Math.Round((this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0);
            } 
        }
    }
}
