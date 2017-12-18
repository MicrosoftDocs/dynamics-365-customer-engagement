---
title: "Perform specialized operations using Update (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Before Dynamics CRM Online 2015 Update 1, specialized messages were required to update certain entity attribute values. Learn about how UpdateRequest can now be used to set these attributes. This article lists the specialized deprecated message requests and the related message attributes that can be updated using UpdateRequest"
ms.custom: ""
ms.date: 12/15/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 03511f6c-62f5-4976-b91f-996354b1d135
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Perform specialized operations using Update

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

 Using <xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> you can now update certain entity attribute values. The following table identifies the specialized deprecated message requests and the related message attributes that can be updated using <xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest>.
  
|Deprecated message request|Attribute to update|  
|--------------------------------|-------------------------|  
|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|\<entity>.`OwnerId`*|  
|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|\<entity>.`StateCode`* **Important:**  For **SLA** and **RoutingRule** entities, changing the **OwnerId** and **StateCode** in a single **Update** message invocation is not supported and results in an exception.|   
|<xref:Microsoft.Crm.Sdk.Messages.SetParentSystemUserRequest>|`SystemUser.ParentSystemUserId`|  
|<xref:Microsoft.Crm.Sdk.Messages.SetParentTeamRequest>|`Team.BusinessUnitId`|  
|<xref:Microsoft.Crm.Sdk.Messages.SetParentBusinessUnitRequest>|`BusinessUnit.ParentBusinessUnitId`|  
|<xref:Microsoft.Crm.Sdk.Messages.SetBusinessEquipmentRequest>|`Equipment.BusinessUnitId`|  
|<xref:Microsoft.Crm.Sdk.Messages.SetBusinessSystemUserRequest>|`SystemUser.BusinessUnitId`|  
  
 *\<entity> refers to any entity that provides this attribute.  
  
 These specialized messages will continue to work with the 2011 endpoint. However, the recommendation is to use the `UpdateRequest` or <xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*> method when possible to set these attributes. The `Update` message simplifies the Organization Service and makes it easier to code standard data integration tools used with Dynamics 365. In addition, it is easier to code and register a plug-in to execute for a single **Update** message instead of multiple specialized messages. The <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.IsValidForUpdate> property for the above listed attributes has been changed to `true` in this release to enable this capability.  
  
 You can continue to use these specialized messages of the 2011 endpoint in your code. However, the Web API that eventually replaces the Organization Service supports only the **Update** message for these types of operations. If you want to get a head start on changing your code to align with the Web API, you can now do so. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Use the Dynamics 365 Customer Engagement Web API](../use-microsoft-dynamics-365-web-api.md).  
  
## Impact of this change on plug-ins  
 When update requests are processed that include both owner fields plus other standard fields for business owned entities, plug-ins registered for the **Update** message in pipeline stage 20 and/or stage 40 execute once for all non-owner fields, and then once for the owner fields. Examples of owner fields would be `businessunit` and `manager` (for a `SystemUser` entity). Examples of business owned entities include `SystemUser`, `BusinessUnit`, `Equipment`, and `Team`.  
  
 When update requests are processed that include both state/status fields plus other standard fields, plug-ins registered for the **Update** message in pipeline stage 20 and/or stage 40 execute once for all non-state/status fields, and then once for the state/status fields.  
  
 In order for plug-in code to receive the full data changes of the update, you must register the plug-in in stage 10 and then store relevant information in <xref:Microsoft.Xrm.Sdk.IExecutionContext.SharedVariables> in the plug-in context for later plug-ins (in the pipeline) to consume.  
  
## Impact of this change on workflows  
 When update requests are processed that include both owner fields plus other standard fields, workflows registered for the **Update** message execute once for all non-owner fields, and then once for the owner fields. Workflows registered for the **Assign** message by users continue to be triggered by updates to owner fields.  
  
 When update requests are processed that include both state/status fields plus other standard fields, workflows registered for the **Update** message execute once for all non-state/status fields, and then once for the state/status fields. Workflows registered for the **Change Status** step continue to be triggered by updates to state/status fields.  
  
### See also  
 [Write plug-ins to extend business processes](../write-plugin-extend-business-processes.md)   
 [Automate your business processes in Customer Engagement](../automate-business-processes-customer-engagement.md)
