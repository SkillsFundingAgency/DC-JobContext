using System.Collections.Generic;

namespace ESFA.DC.JobContext
{
    public sealed class TopicItemDto
    {
        public string TopicName { get; set; }

        public List<TaskItemDto> Tasks { get; set; }
    }
}
