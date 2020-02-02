// Source: https://docs.microsoft.com/en-us/dotnet/api/system.environment.getenvironmentvariables?view=netframework-4.8
// Added sorting to match the output of the native Windows "set"

// C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:exe /out:env.exe env.cs

using System;
using System.Collections;
using System.Collections.Generic;

class Env {
    public static void Main() {
        SortedDictionary<string, string> envVars = new SortedDictionary<string, string>();
        
        foreach (DictionaryEntry de in Environment.GetEnvironmentVariables()) {
            envVars.Add((string)de.Key, (string)de.Value);
        }
        
        foreach( KeyValuePair<string, string> kvp in envVars ) {
            Console.WriteLine("{0}={1}", kvp.Key, kvp.Value);
        }
        
        Console.WriteLine("\nDONE");
    }
}