' <snippetexportmappingsimportmap>


          ' Retrieve the value for validation
          Dim exportRequest = New ExportMappingsImportMapRequest With
                              {
                                  .ImportMapId = _newImportMapId.Value,
                                  .ExportIds = True
                              }

          Dim exportResponse = CType(_serviceProxy.Execute(exportRequest), 
              ExportMappingsImportMapResponse)

	Dim mappingXml = exportResponse.MappingsXml

          Console.WriteLine(String.Concat(vbLf &amp; "Validating mapping xml for : ",
                                          _newImportMapId.Value,
                                          "," &amp; vbLf &amp; "MappingsXml:" &amp; vbLf,
                                          mappingXml))

' </snippetexportmappingsimportmap>