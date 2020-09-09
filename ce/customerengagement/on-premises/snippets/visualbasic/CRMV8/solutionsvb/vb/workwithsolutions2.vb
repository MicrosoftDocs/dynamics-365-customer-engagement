' <snippetworkwithsolutions2>


 ' Retrieve the Default Publisher

 'The default publisher has a constant GUID value;
 Dim DefaultPublisherId As New Guid("{d21aab71-79e7-11dd-8874-00188b01e34f}")

 Dim DefaultPublisher As Publisher =
  CType(_serviceProxy.Retrieve(Publisher.EntityLogicalName,
                               DefaultPublisherId,
                               New ColumnSet(New String() {"friendlyname"})), 
                              Publisher)

 Dim DefaultPublisherReference As EntityReference = New EntityReference With {
  .Id = DefaultPublisher.Id,
  .LogicalName = Publisher.EntityLogicalName,
  .Name = DefaultPublisher.FriendlyName
 }
 Console.WriteLine("Retrieved the {0}.", DefaultPublisherReference.Name)

' </snippetworkwithsolutions2>