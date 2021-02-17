---
title: "Incident (case) entities (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about incident (case) entities that performs the incident management by creating an incident and specifying an active SLA record. An incident can be in one of three states: Active, Resolved, or Canceled."
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: pehecke
ms.service:
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - incident (case) entities, tracking actions and communications
  - routing and queuing, definition
  - tracking actions and communications, incident (case) entities
  - incident (case) entities, tracking incidents and activities
  - incident (case) entities, tracking customer requests; questions; or problems
  - tracking customer requests; questions; or problems
  - knowledge base, definition
  - managing incidents, incident (case) entities
  - incident (case) entities, introduction
  - incident management, definition
  - incident (case) entities, managing
  - managing cases, incident (case) entities
  - incident, definition
  - tracking incidents and activities, incident (case) entities
  - incident states, types of
  - case entities, see 'incident (case) entities'
ms.assetid: 441cd857-456f-4319-a0e3-69555277eee5
author: KumarVivek
ms.author: kvivek
manager: annbe
search.audienceType: 
  - developer

---
# Incident (case) entities

In the Dynamics 365 Customer Engagement (on-premises) platform, *incident management* is the primary aspect of the customer service part of the [!INCLUDE[cc-dyn365-ce-web-services](../includes/cc-dyn365-ce-web-services.md)]. The other features, such as the *knowledge base*, are used to help manage cases. In [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], an incident is referred to as a case.  
  
 A customer service representative creates an incident (case) to track a customer request, question, or a problem. All actions and communications can be tracked in the `incident` entity. You can manually apply a service level agreement (SLA) to an incident by updating the incident record, and specifying an active SLA record in the `SLAId` attribute of the incident record. An incident can be in one of three states: *Active*, *Resolved*, or *Canceled*.  
  
 By using the incident management APIs, you can create reports to measure statistics, such as individual customer service representative statistics (call lengths, resolutions, and so on) and the average length of time that incidents remain active.  
  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] supports the ability to track many incidents and activities. Many of these tasks overlap with activities in sales force automation. Routing and queuing is the process of moving activities and cases from the customer to the correct customer service representative for service request completion.  

> [!IMPORTANT]
> If you see the error `Incident does not have valid status code` when using the [Incident entity](entities/incident.md), make sure that you have used valid values for both [StateCode](entities/incident.md#BKMK_StateCode) and [StatusCode](entities/incident.md#BKMK_StatusCode) attributes in the request body while initiating any state change. See [StateCode Options](entities/incident.md#BKMK_StateCode_options) and [StatusCode options](entities/incident.md#BKMK_StatusCode_options) for the list of valid values for these two attributes.

## In This Section  
 [Incident Entity](entities/incident.md)  
  
 [Incident (case) hierarchies](incident-case-hierarchies.md)  
  
 [IncidentResolution Entity](entities/incidentresolution.md)  
  
 [Sample: Close an Incident](sample-close-incident.md)  
  
## Related Sections  
 [Contract Entities](contract-entities.md)  
  
 [Knowledge Base Entities](knowledge-management-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]