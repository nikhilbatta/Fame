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
    public void QuestionAnsweredYes(int followNumber)
    {
       AddMoney();
       AddFollowers(followNumber);
    }
    public void QuestionAnsweredNo(int followerNumber)
    {
        RemoveFollowers(followerNumber);
        // RemoveMoney(moneyNumber);
    }

    
    private void AddMoney()
    {
        Money = Money + 200;
    }
    private void AddFollowers(int followerNumber)
    {
        Followers += followerNumber;
    }
    private void RemoveFollowers(int followerNumber)
    {
        Followers -= followerNumber;
    }
    public void RemoveMoney(int moneyNumber)
    {
        Money -= moneyNumber;
    }

    }
}