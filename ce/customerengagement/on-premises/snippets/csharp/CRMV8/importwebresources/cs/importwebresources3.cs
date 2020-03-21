// <snippetimportwebresources3>


 //Encodes the Web Resource File
 static public string getEncodedFileContents(String pathToFile)
 {
     FileStream fs = new FileStream(pathToFile, FileMode.Open, FileAccess.Read);
     byte[] binaryData = new byte[fs.Length];
     long bytesRead = fs.Read(binaryData, 0, (int)fs.Length);
     fs.Close();
     return System.Convert.ToBase64String(binaryData, 0, binaryData.Length);
 }

// </snippetimportwebresources3>