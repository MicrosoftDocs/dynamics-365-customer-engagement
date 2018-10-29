' <snippetexportribbonxml2>


 ''' <summary>
 ''' A helper method that decompresses the Ribbon data returned
 ''' </summary>
 ''' <param name="data">The compressed ribbon data</param>
 ''' <returns></returns>
 Public Function unzipRibbon(ByVal data() As Byte) As Byte()
  Dim package As System.IO.Packaging.ZipPackage = Nothing
  Dim memStream As MemoryStream = Nothing

  memStream = New MemoryStream()
  memStream.Write(data, 0, data.Length)
  package = CType(ZipPackage.Open(memStream, FileMode.Open), ZipPackage)

  Dim part As ZipPackagePart = CType(package.GetPart(New Uri("/RibbonXml.xml", UriKind.Relative)), ZipPackagePart)
  Using strm As Stream = part.GetStream()
   Dim len As Long = strm.Length
               Dim buff(CInt(len - 1)) As Byte
   strm.Read(buff, 0, CInt(len))
   Return buff
  End Using
 End Function

' </snippetexportribbonxml2>