using System.Collections.Generic;

namespace ESFA.DC.JobContext.Interface
{
    public interface ITopicItem
    {
        string TopicName { get; }

        IReadOnlyList<ITaskItem> Tasks { get; }
    }
}
