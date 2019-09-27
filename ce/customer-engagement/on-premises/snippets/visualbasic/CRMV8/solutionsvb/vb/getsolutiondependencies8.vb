' <snippetgetsolutiondependencies8>


 ' Use the RetrieveOptionSetRequest message to retrieve  
 ' a global option set by it's name.
 Dim retrieveOptionSetRequest_Renamed As RetrieveOptionSetRequest =
     New RetrieveOptionSetRequest With {.Name = _globalOptionSetName}

 ' Execute the request.
 Dim retrieveOptionSetResponse_Renamed As RetrieveOptionSetResponse =
     CType(_serviceProxy.Execute(retrieveOptionSetRequest_Renamed), RetrieveOptionSetResponse)
 _globalOptionSetId = retrieveOptionSetResponse_Renamed.OptionSetMetadata.MetadataId
 If _globalOptionSetId IsNot Nothing Then
     'Use the global OptionSet MetadataId with the appropriate componenttype
     ' to call RetrieveDependenciesForDeleteRequest
     Dim retrieveDependenciesForDeleteRequest_Renamed As RetrieveDependenciesForDeleteRequest =
         New RetrieveDependenciesForDeleteRequest With
         {
             .ComponentType = CInt(Fix(componenttype.OptionSet)),
             .ObjectId = CType(_globalOptionSetId, Guid)
         }

     Dim retrieveDependenciesForDeleteResponse_Renamed As RetrieveDependenciesForDeleteResponse =
         CType(_serviceProxy.Execute(retrieveDependenciesForDeleteRequest_Renamed), 
             RetrieveDependenciesForDeleteResponse)
     Console.WriteLine("")
     For Each d As Dependency In retrieveDependenciesForDeleteResponse_Renamed _
         .EntityCollection.Entities

         If d.DependentComponentType.Value = 2 Then 'Just testing for Attributes
             Dim attributeLabel As String = ""
             Dim retrieveAttributeRequest_Renamed As RetrieveAttributeRequest =
                 New RetrieveAttributeRequest With
                 {
                     .MetadataId = CType(d.DependentComponentObjectId, Guid)
                 }
             Dim retrieveAttributeResponse_Renamed As RetrieveAttributeResponse =
                 CType(_serviceProxy.Execute(retrieveAttributeRequest_Renamed), 
                     RetrieveAttributeResponse)

             Dim attmet As AttributeMetadata = retrieveAttributeResponse_Renamed.AttributeMetadata

             attributeLabel = attmet.DisplayName.UserLocalizedLabel.Label

             Console.WriteLine("An {0} named {1} will prevent deleting the {2} global option set.",
                               CType(d.DependentComponentType.Value, componenttype),
                               attributeLabel, _globalOptionSetName)
         End If
     Next d
 End If

' </snippetgetsolutiondependencies8>