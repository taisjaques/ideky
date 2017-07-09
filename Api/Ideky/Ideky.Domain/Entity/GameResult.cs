using System;
using System.Collections.Generic;

namespace Ideky.Domain.Entity
{
    public class GameResult : IBasicEntity
    {
        public int Id { get; private set; }
        public User User { get; private set; }
        public DateTime GameDate { get; private set; }
        public int Score { get; private set; }
        public bool Active { get; private set; }

        public List<string> Messages { get; private set; }

        protected GameResult() { Messages = new List<string>();  }

        public GameResult(User user, int score)
        {
            Id = 0;
            User = user;
            GameDate = DateTime.Now;
            Score = score;
            Active = true;
            Messages = new List<string>();
        }

        public GameResult(int id, bool active)
        {
            Id = id;
            Ativo = active;

        }

        public bool Validate()
        {
            if(User == null)
            {
                Messages.Add("Usuário inválido");
            }
            return Messages.Count == 0;
        }
    }
}
