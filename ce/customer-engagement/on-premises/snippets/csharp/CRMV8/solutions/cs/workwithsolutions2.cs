// <snippetworkwithsolutions2>


 // Retrieve the Default Publisher

 //The default publisher has a constant GUID value;
 Guid DefaultPublisherId = new Guid("{d21aab71-79e7-11dd-8874-00188b01e34f}");

 Publisher DefaultPublisher = (Publisher)_serviceProxy.Retrieve(Publisher.EntityLogicalName, DefaultPublisherId, new ColumnSet(new string[] {"friendlyname" }));

 EntityReference DefaultPublisherReference = new EntityReference
 {
     Id = DefaultPublisher.Id,
     LogicalName = Publisher.EntityLogicalName,
     Name = DefaultPublisher.FriendlyName
 };
 Console.WriteLine("Retrieved the {0}.", DefaultPublisherReference.Name);

// </snippetworkwithsolutions2>