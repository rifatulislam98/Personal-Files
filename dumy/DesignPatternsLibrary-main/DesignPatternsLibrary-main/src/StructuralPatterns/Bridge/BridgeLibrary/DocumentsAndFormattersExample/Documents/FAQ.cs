﻿using BridgeLibrary.DocumentsAndFormattersExample.Formatters.Common;
using BridgeLibrary.DocumentsAndFormattersExample.Documents.Common;

namespace BridgeLibrary.DocumentsAndFormattersExample.Documents;

public class FAQ : Document
{
    public FAQ(IFormatter formatter)
        : base(formatter)
    {
        Questions = new Dictionary<string, string>();
    }

    public string Title { get; set; } = string.Empty;
    public Dictionary<string, string> Questions { get; set; }

    public override void Print()
    {
        Console.WriteLine(_formatter.Format("Title", Title));

        foreach (var question in Questions)
        {
            Console.WriteLine(_formatter.Format("   Question", question.Key));
            Console.WriteLine(_formatter.Format("   Answer", question.Value));
        }

        Console.WriteLine();
    }
}
