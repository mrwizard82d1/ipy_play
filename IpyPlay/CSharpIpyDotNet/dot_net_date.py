import clr
clr.AddReference('System')
from System import DateTime, DateTimeOffset, TimeZoneInfo


def today():
    "Returns today as a .NET type (including offset)."
    local_time = DateTime.Now
    return local_time, DateTimeOffset(local_time,
                                      TimeZoneInfo.Local.GetUtcOffset(local_time))
