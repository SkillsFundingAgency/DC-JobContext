using System.Collections.Generic;
using ESFA.DC.JobContext.Interface;

namespace ESFA.DC.JobContext
{
    public sealed class TopicItem : ITopicItem
    {
        public TopicItem()
        {
        }

        public TopicItem(string topicName, IReadOnlyList<ITaskItem> tasks)
        {
            TopicName = topicName;
            Tasks = tasks;
        }

        public string TopicName { get; set; }

        public IReadOnlyList<ITaskItem> Tasks { get; set; }
    }
}
