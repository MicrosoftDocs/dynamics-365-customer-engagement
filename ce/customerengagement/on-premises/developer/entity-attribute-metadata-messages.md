---
title: "Entity attribute metadata messages (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "An entity attribute is a container for a piece of data in an entity. In the developer guide (SDK) documentation the term “attribute” and “property” (class property) are often used interchangeably with the term “entity attribute.”"
ms.custom: 
ms.date: 05/20/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 56f3ec6e-622c-43e2-9d7a-9a3a4d77e701
caps.latest.revision: 17
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Entity attribute metadata messages

An entity attribute is a container for a piece of data in an entity. In this developer guide, the term “attribute” and “property” (class property) are often used interchangeably with the term “entity attribute.” The Dynamics 365 Customer Engagement (on-premises) application uses the term “field” when it refers to entity attributes.  

> [!NOTE]
> It is possible to create and update entity attributes using the Web API. See [Create attributes using Web API](/powerapps/developer/common-data-service/webapi/create-update-entity-definitions-using-web-api#create-attributes) for more details.

## Entity attribute messages  
 The following table lists the messages that you can use to perform actions on entity attributes.  


|                                                                                       Message                                                                                        |                                                                                                      Web API Operation                                                                                                       |                        SDK Assembly                        |
|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------|
|                                                                  CreateAttribute</br></br>Create entity attributes                                                                   | POST to EntityMetadata Attributes collection-valued navigation property with JSON definition of attribute. More information: [Create attributes](/powerapps/developer/common-data-service/webapi/create-update-entity-definitions-using-web-api#create-attributes) |  <xref:Microsoft.Xrm.Sdk.Messages.CreateAttributeRequest>  |
|                                                                  DeleteAttribute</br></br>Delete entity attributes                                                                   |                                                                                             DELETE to the URL of the attribute.                                                                                              |  <xref:Microsoft.Xrm.Sdk.Messages.DeleteAttributeRequest>  |
| DeleteOptionValue</br></br>Delete an option from <xref:Microsoft.Xrm.Sdk.Metadata.PicklistAttributeMetadata> or <xref:Microsoft.Xrm.Sdk.Metadata.StatusAttributeMetadata> attributes |                                                                    <xref href="Microsoft.Dynamics.CRM.DeleteOptionValue?text=DeleteOptionValue Action" />                                                                    | <xref:Microsoft.Xrm.Sdk.Messages.DeleteOptionValueRequest> |
|                                 InsertOptionValue</br></br>Add an option to a <xref:Microsoft.Xrm.Sdk.Metadata.PicklistAttributeMetadata> attribute                                  |                                                                    <xref href="Microsoft.Dynamics.CRM.InsertOptionValue?text=InsertOptionValue Action" />                                                                    | <xref:Microsoft.Xrm.Sdk.Messages.InsertOptionValueRequest> |
|                                  InsertStatusValue</br></br>Add an option to a <xref:Microsoft.Xrm.Sdk.Metadata.StatusAttributeMetadata> attribute                                   |                                                                    <xref href="Microsoft.Dynamics.CRM.InsertStatusValue?text=InsertStatusValue Action" />                                                                    | <xref:Microsoft.Xrm.Sdk.Messages.InsertStatusValueRequest> |
|                                                                RetrieveAttribute</br></br>Retrieve entity attributes                                                                 |                             Use the Web API query mentioned in [Querying EntityMetadata attributes](/powerapps/developer/common-data-service/webapi/query-metadata-web-api#bkmk_queryAttributesexample) to retrieve entity attributes.                             | <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAttributeRequest> |
|                                                                  UpdateAttribute</br></br>Update entity attributes                                                                   |                                                               See [Update entities](/powerapps/developer/common-data-service/webapi/create-update-entity-definitions-using-web-api#update-entities)                                                                |  <xref:Microsoft.Xrm.Sdk.Messages.UpdateAttributeRequest>  |
|                                  UpdateStateValue</br></br>Update a label for a <xref:Microsoft.Xrm.Sdk.Metadata.StateAttributeMetadata> attribute                                   |                                                                     <xref href="Microsoft.Dynamics.CRM.UpdateStateValue?text=UpdateStateValue Action" />                                                                     | <xref:Microsoft.Xrm.Sdk.Messages.UpdateStateValueRequest>  |

### See also  
 [Customize Entity Attribute Metadata](customize-entity-attribute-metadata.md)   
 [Create auto-number attribute](create-auto-number-attributes.md)   
 [Work with Attributes](/powerapps/developer/data-platform/org-service/metadata-attributemetadata)   
 [Sample: Work with Attributes](org-service/sample-work-attribute-metadata.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]