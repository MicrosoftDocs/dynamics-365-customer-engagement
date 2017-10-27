---
title: "Entity attribute metadata messages (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "An entity attribute is a container for a piece of data in an entity. In the developer guide (SDK) documentation the term “attribute” and “property” (class property) are often used interchangeably with the term “entity attribute.”"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 56f3ec6e-622c-43e2-9d7a-9a3a4d77e701
caps.latest.revision: 17
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Entity attribute metadata messages
An entity attribute is a container for a piece of data in an entity. In this developer guide, the term “attribute” and “property” (class property) are often used interchangeably with the term “entity attribute.” The [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement application uses the term “field” when it refers to entity attributes.  

> [!NOTE]
> It is possible to create and update entity attributes using the Web API. See [Create attributes using Web API](webapi/create-update-entity-definitions-using-web-api.md#create-attributes) for more details.

## Entity attribute messages  
 The following table lists the messages that you can use to perform actions on entity attributes.  
  
|Message|Description|  
|-------------|-----------------|  
|<xref:Microsoft.Xrm.Sdk.Messages.CreateAttributeRequest>|Creates entity attributes.|  
|<xref:Microsoft.Xrm.Sdk.Messages.DeleteAttributeRequest>|Deletes entity attributes.|  
|<xref:Microsoft.Xrm.Sdk.Messages.DeleteOptionValueRequest>|Deletes an option from <xref:Microsoft.Xrm.Sdk.Metadata.PicklistAttributeMetadata> or <xref:Microsoft.Xrm.Sdk.Metadata.StatusAttributeMetadata> attributes.|  
|<xref:Microsoft.Xrm.Sdk.Messages.InsertOptionValueRequest>|Adds an option to a <xref:Microsoft.Xrm.Sdk.Metadata.PicklistAttributeMetadata> attribute.|  
|<xref:Microsoft.Xrm.Sdk.Messages.InsertStatusValueRequest>|Adds an option to a <xref:Microsoft.Xrm.Sdk.Metadata.StatusAttributeMetadata> attribute.|  
|<xref:Microsoft.Xrm.Sdk.Messages.OrderOptionRequest>|Changes the order of the options presented in an <xref:Microsoft.Xrm.Sdk.Metadata.PicklistAttributeMetadata> attribute.|  
|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveAttributeRequest>|Retrieves entity attributes.|  
|<xref:Microsoft.Xrm.Sdk.Messages.UpdateAttributeRequest>|Updates entity attributes.|  
|<xref:Microsoft.Xrm.Sdk.Messages.UpdateStateValueRequest>|Updates a label for a <xref:Microsoft.Xrm.Sdk.Metadata.StateAttributeMetadata> attribute.|  

### See also  
 [Customize Entity Attribute Metadata](customize-entity-attribute-metadata.md)   
 [Create auto-number attribute](create-auto-number-attributes.md)   
 [Work with Attributes](org-service/work-attribute-metadata.md)   
 [Sample: Work with Attributes](org-service/sample-work-attribute-metadata.md)
