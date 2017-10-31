---
title: "xRM messages in the Organization service (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Read about the data messages available in the xRM namespace"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
helpviewer_keywords: 
  - "Microsoft.Xrm.Sdk.Messages namespace, list of data and metadata messages in"
  - "Xrm namespace, list of data and metadata messages in"
  - "Xrm messages in the organization service"
  - "IOrganizationService web service, Xrm messages in"
  - "Xrm messages in the IOrganizationService"
  - "organization service web service, Xrm messages in"
ms.assetid: f392ebae-4012-4861-a335-42e1d9243409
caps.latest.revision: 39
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# xRM messages in the Organization service

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

The <xref:Microsoft.Xrm.Sdk.Messages> namespace supports the core messages used to work with the data stored in any entity. This namespace also contains the messages you can use to retrieve and customize the metadata for entities, attributes, and relationships.  
  
 Messages are used with the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*> method. All messages available in the <xref:Microsoft.Xrm.Sdk.Messages> namespace apply to all three deployment types.  
  
 The request page indicates whether the message works while online (connected to the server) or offline (disconnected from the server).  
  
## Data messages  
 The following table lists the data messages available in the xRM namespace.  
  
|Message|Description|  
|-------------|-----------------|  
|<xref:Microsoft.Xrm.Sdk.Messages.AssociateRequest>|Creates a link between records that participate in a relationship.|  
|<xref:Microsoft.Xrm.Sdk.Messages.ConvertDateAndTimeBehaviorRequest>|[!INCLUDE[internal](../../includes/internal.md)]|  
|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest>|Creates a record of any type that supports the **Create** message, including custom entities.|  
|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest>|Deletes an existing record.|  
|<xref:Microsoft.Xrm.Sdk.Messages.DisassociateRequest>|Removes the link between records.|  
|<xref:Microsoft.Xrm.Sdk.Messages.ExecuteAsyncRequest>|Executes a message asynchronously. Currently this only supports the <xref:Microsoft.Crm.Sdk.Messages.ImportSolutionRequest> message.|  
|<xref:Microsoft.Xrm.Sdk.Messages.ExecuteTransactionRequest>|Executes multiple message requests in a single database transaction.|  
|<xref:Microsoft.Xrm.Sdk.Messages.ReactivateEntityKeyRequest>|Submits a new asynchronous system job to create the index for the key.|  
|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|Retrieves the changes in an entity since the last sync.|  
|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest>|Retrieves a record.|  
|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest>|Retrieves a collection of records. The query can be specified using a query expression or a FetchXML query.|  
|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest>|Updates an existing record.|  
|<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|Updates or inserts a record.|  
  
## Metadata messages  
 The following table lists the metadata messages available in the XRM namespace.  
  
|Message|Description|  
|-------------|-----------------|  
|<xref:Microsoft.Xrm.Sdk.Messages.CanBeReferencedRequest>|Checks to see if the specified entity can be the primary entity (one) in a one-to-many relationship.|  
|<xref:Microsoft.Xrm.Sdk.Messages.CanBeReferencingRequest>|Checks to see if the specified entity can be the referencing entity (many) in a one-to-many relationship.|  
|<xref:Microsoft.Xrm.Sdk.Messages.CanManyToManyRequest>|Checks to see if the entity can participate in a many-to-many relationship.|  
|<xref:Microsoft.Xrm.Sdk.Messages.CreateAttributeRequest>|Creates a custom attribute for an entity.|  
|<xref:Microsoft.Xrm.Sdk.Messages.CreateEntityKeyRequest>|Creates an alternate key for an entity.|  
|<xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest>|Creates a custom entity.|  
|<xref:Microsoft.Xrm.Sdk.Messages.CreateManyToManyRequest>|Creates a many-to-many relationship between two entities.|  
|<xref:Microsoft.Xrm.Sdk.Messages.CreateOneToManyRequest>|Creates a one-to-many relationship between two entities.|  
|<xref:Microsoft.Xrm.Sdk.Messages.CreateOptionSetRequest>|Creates a custom global option set.|  
|<xref:Microsoft.Xrm.Sdk.Messages.DeleteAttributeRequest>|Deletes an attribute from an entity.|  
|<xref:Microsoft.Xrm.Sdk.Messages.DeleteEntityKeyRequest>|Deletes the alternate key for an entity.|  
|<xref:Microsoft.Xrm.Sdk.Messages.DeleteEntityRequest>|Deletes an entity.|  
|<xref:Microsoft.Xrm.Sdk.Messages.DeleteOptionSetRequest>|Deletes an option set.|  
|<xref:Microsoft.Xrm.Sdk.Messages.DeleteOptionValueRequest>|Deletes an option value from a list of options.|  
|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRelationshipRequest>|Deletes a relationship.|  
|<xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest>|Executes one or more message requests as a single batch operation.|  
|<xref:Microsoft.Xrm.Sdk.Messages.GetValidManyToManyRequest>|Returns the set of entities that can participate in a many-to-many relationship.|  
|<xref:Microsoft.Xrm.Sdk.Messages.GetValidReferencedEntitiesRequest>|Returns the set of entities that are valid as the primary entity (one) from the specified entity in a one-to-many relationship. If no entity is specified, this message returns all entities that can be the primary entity in a one-to-many relationship.|  
|<xref:Microsoft.Xrm.Sdk.Messages.GetValidReferencingEntitiesRequest>|Returns the set of entities that are valid as the related entity (many) to the specified entity in a one-to-many relationship. If no entity is specified, this message returns all entities that can be the related entity in a one-to-many relationship.|  
|<xref:Microsoft.Xrm.Sdk.Messages.InsertOptionValueRequest>|Inserts an option value into a list of options.|  
|<xref:Microsoft.Xrm.Sdk.Messages.InsertStatusValueRequest>|Inserts a status value into a list of status values.|  
|<xref:Microsoft.Xrm.Sdk.Messages.IsDataEncryptionActiveRequest>|Checks if data encryption is currently running (active or inactive).|  
|<xref:Microsoft.Xrm.Sdk.Messages.OrderOptionRequest>|Sets the order of a list of options.|  
|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesRequest>|Retrieves the metadata for all entities.|  
|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllOptionSetsRequest>|Retrieves information about all global option sets.|  
|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveAttributeRequest>|Retrieves the metadata for the specified attribute.|  
|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveDataEncryptionKeyRequest>|Retrieves the data encryption key value.|  
|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|Retrieves the changes for an entity.|  
|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityKeyRequest>|Retrieves an alternate key for an entity.|  
|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityRequest>|Retrieves the metadata for the specified entity.|  
|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveManagedPropertyRequest>|Retrieves a managed property definition.|  
|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMetadataChangesRequest>|Retrieves a collection of metadata records that satisfy the specified criteria.|  
|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveOptionSetRequest>|Retrieves a specified option set.|  
|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRelationshipRequest>|Retrieve the metadata for the specified relationship.|  
|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveTimestampRequest>|Retrieves a time stamp indicating the last time that the metadata was changed.|  
|<xref:Microsoft.Xrm.Sdk.Messages.SetDataEncryptionKeyRequest>|Sets or restores the data encryption key.|  
|<xref:Microsoft.Xrm.Sdk.Messages.UpdateAttributeRequest>|Updates the metadata for an attribute.|  
|<xref:Microsoft.Xrm.Sdk.Messages.UpdateEntityRequest>|Updates the metadata for an entity.|  
|<xref:Microsoft.Xrm.Sdk.Messages.UpdateOptionSetRequest>|Updates an option set.|  
|<xref:Microsoft.Xrm.Sdk.Messages.UpdateOptionValueRequest>|Updates the metadata for an option value.|  
|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRelationshipRequest>|Updates the metadata for a relationship.|  
|<xref:Microsoft.Xrm.Sdk.Messages.UpdateStateValueRequest>|Updates the metadata for a state value.|  
  
### See also  
 [Web Services: IOrganizationService](use-organization-service-read-write-data-metadata.md)   
 [Dynamics 365 Messages in the Organization Service](organization-service-messages.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Xrm.Sdk.Messages>