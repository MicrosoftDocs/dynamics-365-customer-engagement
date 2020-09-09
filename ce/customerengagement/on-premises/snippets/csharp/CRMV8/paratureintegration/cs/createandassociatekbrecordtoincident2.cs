// <snippetcreateandassociatekbrecordtoincident2>


 // Associate the knowledge base record with an incident record

 // Step 1: Create a collection of knowledge base record that will be 
 // associated to the incident. In this case, we have only a single
 // knowledge base record to be associated.
 EntityReferenceCollection relatedEntities = new EntityReferenceCollection();
 relatedEntities.Add(new EntityReference(KnowledgeBaseRecord.EntityLogicalName, _kbRecordId));

 // Step 2: Create an object that defines the relationship between knowledge base record and incident.
 // Use the many-to-many relationship name (KnowledgeBaseRecord_Incident) between knowledge base
 // record and incident.
 Relationship relationship = new Relationship("KnowledgeBaseRecord_Incident");

 // Step 3: Associate the knowledge base record with the incident record.
 _serviceProxy.Associate(Incident.EntityLogicalName, _incidentId, relationship,
     relatedEntities);

// </snippetcreateandassociatekbrecordtoincident2>