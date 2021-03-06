﻿using System;

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
    public string leadInRealTalk;
}

[Serializable]
public class RealTalk
{
    public Line alicesOpening;
    public Line[] lines;
    public int pointMade;
}

[Serializable]
public class CasualTalk
{
    public Line alicesOpening;
    public Line[] lines;
    public int pointMade;
}

[Serializable]
public class Line
{
    public string line;
    public string mugshot;
}