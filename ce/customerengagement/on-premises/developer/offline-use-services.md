---
title: "Offline use of the Dynamics 365 Customer Engagement (on-premises) services (Developer Guide for Dynamics 365 Customer Engagement (on-premises) )| MicrosoftDocs"
description: "Learn about how various Dynamics 365 Customer Engagement (on-premises) services can be used offline. There are several messages that are supported offline. You can also determine whether a IOrganizationService message works offline by checking the SdkMessage.Availability attribute for the desired message"
ms.custom: on-premise
ms.date: 09/05/2019
ms.reviewer: pehecke
ms.service: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 7bd0c158-6def-410f-987e-7a376f7a7fae
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Offline use of the Dynamics 365 Customer Engagement (on-premises) services

[!INCLUDE[pn_crm_outlook_offline_access](../includes/pn-crm-outlook-offline-access.md)] enables you to continue your work when you are disconnected from the server.  
  
 In addition, the event and plug-in infrastructure lets you leverage development investments across solutions by using the same APIs and programming model. The <xref:Microsoft.Xrm.Sdk.IOrganizationService> methods and the Dynamics 365 Customer Engagement (on-premises) OData service methods function both online and offline. When using a method such as `Create` or `Update` offline, the data is written locally and then when the user connects to the server, the actions are played back to the server.  
  
 For more information about whether a message is supported offline, see <xref:Microsoft.Crm.Sdk.Messages>. You can also determine whether a <xref:Microsoft.Xrm.Sdk.IOrganizationService> message works offline by checking the `SdkMessage.Availability` attribute for the desired message. If the message works for multiple entity types, you must also check the `SdkMessageFilter.Availability` attribute to see whether the message is available offline for the entity you want to work with. For example, the `Create` message is available offline, but not for the queue, user, or site entities.  
  
 Tracing can be enabled on the [!INCLUDE[pn_crm_outlook_offline_access](../includes/pn-crm-outlook-offline-access.md)] for debugging. For more information about the event viewer and platform tracing, see [Monitoring and troubleshooting Dynamics 365 Customer Engagement (on-premises)](/previous-versions/dynamicscrm-2016/deployment-administrators-guide/hh699694(v=crm.8)).  
  
### See also  
 [Extend Dynamics 365 Customer Engagement (on-premises) on the server](extend-dynamics-365-server.md)   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]