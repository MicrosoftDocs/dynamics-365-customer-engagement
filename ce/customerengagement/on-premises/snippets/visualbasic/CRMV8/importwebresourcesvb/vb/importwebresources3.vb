' <snippetimportwebresources3>


	'Encodes the Web Resource File
	Public Shared Function getEncodedFileContents(ByVal pathToFile As String) As String
		Dim fs As New FileStream(pathToFile, FileMode.Open, FileAccess.Read)
           Dim binaryData(CType(fs.Length, Integer) - 1) As Byte
		Dim bytesRead As Long = fs.Read(binaryData, 0, CInt(fs.Length))
		fs.Close()
		Return Convert.ToBase64String(binaryData, 0, binaryData.Length)
	End Function

' </snippetimportwebresources3>