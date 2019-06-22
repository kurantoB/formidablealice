using System;

[Serializable]
public class PrologueContainer
{
    public string[] lines;
    public int i;
}

[Serializable]
public class TopicContainer
{
    public Topic[] topics;
}

[Serializable]
public class Topic
{
    public string topic;
    public string[] leadIns;
    public RealTalk realTalk;
    public CasualTalk casualTalk;
}

[Serializable]
public class RealTalk
{
    public string alicesOpening;
    public Line[] lines;
    public int pointMade;
}

[Serializable]
public class CasualTalk
{
    public string alicesOpening;
    public Line[] lines;
    public int pointMade;
}

[Serializable]
public class Line
{
    public string line;
    public string mugshot;
}