using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace DP_Ex02
{
    public class WordUsageStatistics
    {
        public static List<KeyValuePair<string, WordUsageData>> GetWordUsageStatisticsOfPosts(User i_User, DateTime i_StartDate, DateTime i_EndDate)
        {
            Dictionary<string, WordUsageData> wordsUsageData = new Dictionary<string, WordUsageData>();
            string[] postWords;
            WordUsageData wordUsageData;

            Dictionary<string, bool> postInserted;
            bool postHasBeenInserted;

            foreach(Post post in i_User.Posts)
            {
                if(post.CreatedTime < i_StartDate || post.CreatedTime > i_EndDate)
                {
                    continue;
                }

                postInserted = new Dictionary<string, bool>();
                postWords = post.Message.Split(' ');
                foreach (string word in postWords)
                {
                    if (wordsUsageData.TryGetValue(word, out wordUsageData))
                    {
                        wordUsageData.OccurrencesCount++;
                        if (!(postInserted.TryGetValue(word, out postHasBeenInserted) || postHasBeenInserted))
                        {
                            wordUsageData.Posts.Add(post.Message);
                            postInserted[word] = true;
                        }

                        wordsUsageData[word] = wordUsageData;
                    }
                    else
                    {
                        wordUsageData = new WordUsageData();
                        wordUsageData.OccurrencesCount = 1;
                        wordUsageData.Posts = new List<string> { post.Message };
                        postInserted[word] = true;

                        wordsUsageData.Add(word, wordUsageData);
                    }
                }
            }

            List<KeyValuePair<string, WordUsageData>> sortedWordUsageDate = wordsUsageData.ToList();
            sortedWordUsageDate.Sort(test);

            return sortedWordUsageDate;
        }

        private static int test(KeyValuePair<string, WordUsageData> pair1, KeyValuePair<string, WordUsageData> pair2)
        {
            return pair2.Value.OccurrencesCount.CompareTo(pair1.Value.OccurrencesCount);
        }

        public struct WordUsageData
        {
            public int OccurrencesCount;
            public List<string> Posts;
        }
    }
}
