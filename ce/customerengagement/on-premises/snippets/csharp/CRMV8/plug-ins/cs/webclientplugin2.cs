// <snippetwebclientplugin2>


 // Download the target URI using a Web client. Any .NET class that uses the
 // HTTP or HTTPS protocols and a DNS lookup should work.
 using (WebClient client = new WebClient())
 {
     byte[] responseBytes = client.DownloadData(webAddress);
     string response = Encoding.UTF8.GetString(responseBytes);

// </snippetwebclientplugin2>