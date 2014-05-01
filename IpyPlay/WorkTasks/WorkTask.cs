using System;

namespace WorkTasks
{
    /// <summary>
    /// Models a task done at work.
    /// </summary>
    public class WorkTask
    {
        public DateTimeOffset Start { get; private set; }
        public string Details { get; private set; }
        public TimeSpan Duration { get; set; }

        public WorkTask(DateTimeOffset start,
                        string details)

        {
            Start = start;
            Details = details;
            Duration = TimeSpan.Zero;
        }

        /// <summary>
        /// Do I abut anotherWorkTask?
        /// </summary>
        /// <param name="anotherWorkTask">
        /// The <see cref="WorkTask"/> to test.
        /// </param>
        /// <returns>True if I abut anotherWorkTask; otherwise, false.</returns>
        public bool IsAbutting(WorkTask anotherWorkTask)
        {
            return ((anotherWorkTask.Start + anotherWorkTask.Duration).Equals(Start) ||
                    (Start + Duration).Equals(anotherWorkTask.Start));
        }
    }
}
