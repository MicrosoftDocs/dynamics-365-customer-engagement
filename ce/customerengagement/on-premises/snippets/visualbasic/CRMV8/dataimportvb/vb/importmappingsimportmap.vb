' <snippetimportmappingsimportmap>


          ' Create the import mapping from the XML
          Dim request = New ImportMappingsImportMapRequest With
                        {
                            .MappingsXml = _mappingXml,
                            .ReplaceIds = True
                        }

          Console.WriteLine(String.Concat(vbLf &amp; "Creating mapping based on XML:" &amp; vbLf,
                                          _mappingXml))

          Dim response = CType(_serviceProxy.Execute(request), 
              ImportMappingsImportMapResponse)

	_newImportMapId = response.ImportMapId

          Console.WriteLine(String.Concat(vbLf &amp; "New import mapping created: ",
                                          _newImportMapId.Value))

' </snippetimportmappingsimportmap>