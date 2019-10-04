// <snippetexportribbonxml2>


 /// <summary>
 /// A helper method that decompresses the Ribbon data returned
 /// </summary>
 /// <param name="data">The compressed ribbon data</param>
 /// <returns></returns>
 public byte[] unzipRibbon(byte[] data)
 {
  System.IO.Packaging.ZipPackage package = null;
  MemoryStream memStream = null;

  memStream = new MemoryStream();
  memStream.Write(data, 0, data.Length);
  package = (ZipPackage)ZipPackage.Open(memStream, FileMode.Open);

  ZipPackagePart part = (ZipPackagePart)package.GetPart(new Uri("/RibbonXml.xml", UriKind.Relative));
  using (Stream strm = part.GetStream())
  {
   long len = strm.Length;
   byte[] buff = new byte[len];
   strm.Read(buff, 0, (int)len);
   return buff;
  }
 }

// </snippetexportribbonxml2>