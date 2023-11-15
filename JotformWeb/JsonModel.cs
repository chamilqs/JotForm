using System;
using System.Collections.Generic;

public class Answer
{
    public string Name { get; set; }
    public string Order { get; set; }
    public string Text { get; set; }
    public string Type { get; set; }
    public string AnswerValue { get; set; }
    public string Sublabels { get; set; }
    public string TimeFormat { get; set; }
    public AnswerData AnswerData { get; set; }
    public string PrettyFormat { get; set; }
}

public class AnswerData
{
    public string Month { get; set; }
    public string Day { get; set; }
    public string Year { get; set; }
    public string Datetime { get; set; }
    public string TimeInput { get; set; }
    public string Hour { get; set; }
    public string Min { get; set; }
    public string Ampm { get; set; }
    public string First { get; set; }
    public string Last { get; set; }
}

public class ResultSet
{
    public int Offset { get; set; }
    public int Limit { get; set; }
    public int Count { get; set; }
}

public class Submission
{
    public string Id { get; set; }
    public string FormId { get; set; }
    public string Ip { get; set; }
    public string CreatedAt { get; set; }
    public string Status { get; set; }
    public string New { get; set; }
    public string Flag { get; set; }
    public string Notes { get; set; }
    public string UpdatedAt { get; set; }
    public Dictionary<string, Answer> Answers { get; set; }
}

public class ApiResponse
{
    public string Duration { get; set; }
    public ResultSet ResultSet { get; set; }
    public int LimitLeft { get; set; }
    public List<Submission> Content { get; set; }
}

public class Root
{
    public string Id { get; set; }
    public string FormId { get; set; }
    public string Ip { get; set; }
    public string CreatedAt { get; set; }
    public string Status { get; set; }
    public string New { get; set; }
    public string Flag { get; set; }
    public string Notes { get; set; }
    public string UpdatedAt { get; set; }
    public Dictionary<string, Answer> Answers { get; set; }
    public string Duration { get; set; }
    public ResultSet ResultSet { get; set; }
    public int LimitLeft { get; set; }
}

public class AnswerContainer
{
    public Answer Answer { get; set; }
}
