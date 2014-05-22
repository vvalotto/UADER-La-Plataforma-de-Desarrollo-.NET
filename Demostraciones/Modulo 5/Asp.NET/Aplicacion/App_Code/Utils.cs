using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Utils
/// </summary>
public class Utils
{
    public string DirectorioActual()
    {
        return Environment.CurrentDirectory;
    }

    public string NombreMaquina()
    {
        return Environment.MachineName;
    }

    public string VersionWindows()
    {
        return Environment.OSVersion.ToString();
    }
}