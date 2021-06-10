---
title: "Campaign entities (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about creating campaign activites, use the marketing lists to distribute the campaign activites, and analyze campaign responses to the campaign activities."
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: peheckenabuthuk
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - campaign entities, introduction
  - comparing campaigns and quick campaigns
  - campaign response, definition
  - campaigns and quick campaigns, comparing
  - campaigns and quick campaigns, about
  - quick campaign, definition
  - campaign, definition
  - campaign activities, definition
ms.assetid: fd788b2b-eab0-4f0c-b48e-911cd8aad69b
caps.latest.revision: 28
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Campaign entities

A *campaign* in Dynamics 365 Customer Engagement (on-premises) is designed to accomplish a specific result, such as introducing a new product or increasing market share. The main way to accomplish this result is through communicating the benefits of a product or service to people and businesses. Campaigns often include more than one communication method, such as print advertisements, promotional discounts, and direct mail. A campaign can be thought of as a container in which a business keeps planning tasks, campaign activities, and campaign responses. It has a list of related products, sales literature, and a set of marketing lists of existing or potential customers. This information is used to plan and track the results of a marketing campaign throughout its life.  
  
 Marketing automation supports campaign execution through *campaign activities* that are used to distribute emails, phone calls, and other activities to qualified customers. Each campaign activity may include a set of marketing lists of existing or potential customers. Bulk email may result in the responses from the customers that are captured in a *campaign response* record.  
  
 If you plan to distribute only one type of the activity, such as an email, use a *quick campaign*. The results of a quick campaign are captured in the quick campaign log.  
  
## Campaigns and Quick Campaigns  
 A campaign or a quick campaign can be used to accomplish the following:  
  
- Create campaign activities to communicate with a customer, such as sending an email, a letter, or making a telephone call.  
  
- Use marketing lists to distribute the campaign activities. Marketing lists are usually assembled based on certain criteria, such as customers that previously bought a particular product or used a particular service.  
  
- Analyze campaign responses to the campaign activities.  
  
  The following table compares campaigns and quick campaigns:  
  
|Feature|Campaign|Quick Campaign|  
|-------------|--------------|--------------------|  
|Campaign activities|A campaign may include different marketing activities. Some activities, such as tasks, are assigned to team members to perform specific tasks, for example, preparing a marketing list or printing sales literature. Other activities, such as emails, faxes, or letters are distributed through multiple campaign activities represented by the campaign activity entity (`CampaignActivity`). Each campaign activity is used to distribute one type of activity that specifies a recipient: phone call, appointment, letter, letter vial mail merge, fax, fax via mail merge, email, email via mail merge. The activities can be distributed over a period of time and at different times.|A quick campaign distributes one type of activity that specifies a recipient: phone call, appointment, letter, letter vial mail merge, fax, fax via mail merge, email, email via mail merge. The activities are distributed to recipients at one point in time.|  
|Marketing lists|You can distribute a campaign to the members of different marketing lists. Each campaign activity (`CampaignActivity`) may contain multiple lists. A marketing list contains the records of one type, such as accounts or leads. To distribute a campaign to accounts and leads, you must create two separate marketing lists.|A quick campaign can be distributed to the members of one marketing list, or to the accounts, contacts, or leads selected by a query.|  
|Campaign response|A reply to a campaign activity can be captured in the campaign response (`CampaignResponse`) and converted to an opportunity, lead, order, or quote.|The results of a quick campaign are captured in the quick campaign log (`BulkOperationLog`).|  
|Entities|Use the campaign (`Campaign`) entity, the campaign activity (`CampaignActivity`) entity and the campaign response (`CampaignResponse`) entity to distribute a campaign.|Use the bulk operation (quick campaign) (`BulkOperation`) entity and the bulk operation log (quick campaign log) (`BulkOperationLog`) entity to distribute a quick campaign.|  
|Distribute Activities|Use the <xref:Microsoft.Crm.Sdk.Messages.DistributeCampaignActivityRequest> message to distribute a campaign activity (`CampaignActivity`) to the members of a marketing list.|Use the <xref:Microsoft.Crm.Sdk.Messages.PropagateByExpressionRequest> message to distribute an activity, such as email or fax, to the accounts, contacts, or leads selected by the query.<br /><br /> Use the <xref:Microsoft.Crm.Sdk.Messages.CreateActivitiesListRequest> message to distribute an activity, such as email or fax, to the members of a marketing list.|  
  
### See also  
 [BulkOperation Entity](entities/bulkoperation.md)   
 [BulkOperationLog Entity](entities/bulkoperationlog.md)   
 [Campaign Entity](entities/campaign.md)   
 [CampaignActivity Entity](entities/campaignactivity.md)   
 [CampaignResponse Entity](entities/campaignresponse.md)   
 [Sample: Distribute a Quick Campaign](sample-distribute-a-quick-campaign.md)   
 [Marketing Entities (Campaign, List)](marketing-entities-campaign-list.md)   
 [List (Marketing List) Entity](list-marketing-list-entity.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]