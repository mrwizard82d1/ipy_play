import clr
from System import DateTime, DateTimeOffset, TimeSpan
clr.AddReference("WorkTasks")
from WorkTasks import WorkTask

cut_start = DateTimeOffset(1997, 3, 3, 15, 31, 34, 361, TimeSpan.FromMinutes(500))
cut_details = "artio"
account = WorkTask(cut_start, cut_details)

cut_duration = TimeSpan.FromSeconds(25570)
account.Duration = cut_duration

abutting_task = WorkTask(cut_start + cut_duration, "corollarii")
not_abutting_task = WorkTask (cut_start + cut_duration + TimeSpan.FromTicks(1), "poenae")

def test_abutting():
    "Do two WorkTasks abut?"
    return account.IsAbutting(abutting_task)

def test_not_abutting():
    "Do two WorkTasks NOT abut?"
    return account.IsAbutting(not_abutting_task)
