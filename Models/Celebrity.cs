using System;
using System.Collections.Generic;

namespace Fame
{
    public class Celebrity
    {
        public string Name{get; set;}
        public int Followers{get;set;}
        public int Money{get;set;}
    
    public Celebrity (string aName)
    {
        Name = aName;
        Followers = 0;
        Money = 0;
    }  
    public void QuestionAnsweredYes()
    {
       AddMoney();
       AddFollowers();
    }
    public void QuestionAnsweredNo()
    {
        RemoveFollowers();
        RemoveMoney();
    }
    private void AddMoney()
    {
        Money = Money + 200;
    }
    private void AddFollowers()
    {
        Followers = Followers + 200;
    }
    private void RemoveFollowers()
    {
        Followers = Followers - 125;
    }
    private void RemoveMoney()
    {
        Money = Money - 125;
    }

    }
}