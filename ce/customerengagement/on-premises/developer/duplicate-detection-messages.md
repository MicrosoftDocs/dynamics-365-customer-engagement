---
title: "Duplicate detection messages (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Use the BulkDetectDuplicatesRequest or RetrieveDuplicatesRequest messages to detect duplicates."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - duplicate detection messages
ms.assetid: f041dfd5-cfc4-44e2-b274-1107bdf75293
caps.latest.revision: 13
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Duplicate detection messages

Use the messages listed in the following table to detect duplicates in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  


|                                                                                                                                                                                                                   Message                                                                                                                                                                                                                   |                                      Web API Operation                                       |                         SDK Assembly                          |
|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------|---------------------------------------------------------------|
| Detects duplicates for a specified entity type based on query criteria and store them as instances of a duplicate record entity type in the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database.<br /><br /> The query expression that describes the records on which to run the duplicate detection job is specified in the <xref:Microsoft.Crm.Sdk.Messages.BulkDetectDuplicatesRequest.Query> property of this request. | <xref href="Microsoft.Dynamics.CRM.BulkDetectDuplicates?text=BulkDetectDuplicates Action" /> | <xref:Microsoft.Crm.Sdk.Messages.BulkDetectDuplicatesRequest> |
|                                                                                                         Detects and retrieves duplicates for a specified record.<br /><br /> The matching entity type is specified in the <xref:Microsoft.Crm.Sdk.Messages.RetrieveDuplicatesRequest.MatchingEntityName> property of this request.                                                                                                          |  <xref href="Microsoft.Dynamics.CRM.RetrieveDuplicates?text=RetrieveDuplicates Function" />  |  <xref:Microsoft.Crm.Sdk.Messages.RetrieveDuplicatesRequest>  |

### See also  
 [Enable and disable duplicate detection](enable-disable-duplicate-detection.md)  
 [Running Duplicate Detection](run-duplicate-detection.md)   
 [Duplicate Rule entities](duplicaterule-entities.md)<br />


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]