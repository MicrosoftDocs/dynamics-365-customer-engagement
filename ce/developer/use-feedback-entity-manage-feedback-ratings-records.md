---
title: "Use the Feedback entity to manage feedback and ratings for Dynamics 365 records (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about the feedback eneity to obtain feedback and ratings for the records."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c0d69f7b-5016-44e7-8b73-1f8c2de5b526
caps.latest.revision: 13
author: "KumarVivek"
ms.author: "kvivek"
---
# Use the Feedback entity to manage feedback and ratings for Dynamics 365 records

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

Improve your products and services by enabling users to provide feedback and ratings for entity records in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. For example, you can enable feedbacks and ratings for the `Product` entity to know user's feedback on the products you sell, or on the `Incident` (case) entity to understand and improve the quality of your customer support team.  
  
 You can enable feedback and rating for both system and custom entities in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. By default, the `KnowledgeArticle` entity is enabled for feedback and ratings. Use the new `Feedback` entity to programmatically create and manage feedback for entity records.  
  
> [!NOTE]
> [!INCLUDE[cc_feature_included_with_update_8_1_0_admins](../includes/cc-feature-included-with-update-8-1-0-admins.md)]  
  
 To programmatically enable feedback for a:  
  
- System entity, use the <xref:Microsoft.Xrm.Sdk.Messages.UpdateEntityRequest> message to update the entity, and set the <xref:Microsoft.Xrm.Sdk.Messages.UpdateEntityRequest.HasFeedback> property to true.  
  
- Custom entity, set the <xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest>.<xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest.HasFeedback> property to true  while creating the entity, or update existing custom entity to set the <xref:Microsoft.Xrm.Sdk.Messages.UpdateEntityRequest>.<xref:Microsoft.Xrm.Sdk.Messages.UpdateEntityRequest.HasFeedback> property to true.  
  
  Once you have enabled an entity for feedback and rating, you can't disable it. After you enable an entity for feedback, a regarding relationship is created between the entity and the `Feedback` entity.  
  
> [!NOTE]
>  You can also use the customization tools in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] to enable feedback and rating for system and custom entities. More information: [Enable an entity for feedback](http://go.microsoft.com/fwlink/p/?LinkId=785436)  
  
 The `Feedback` entity stores the following information :  
  
- Feedback title  
  
- Feedback comments  
  
- Feedback rating. You can also define a range for ratings by specifying a minimum and maximum (numerical) value for ratings. For example, a rating of 4 on the scale of 1-5.  
  
- Normalized rating for feedback that is automatically calculated  to show the specified user rating scaled to a value between 0 and 1 based on the minimum and maximum rating values.  
  
  > [!NOTE]
  >  The normalized rating helps to normalize or even out the specified rating value for different rating ranges (minimum and maximum rating values). The normalized  rating is calculated as follows: (Rating - Minimum Rating) / (Maximum Rating - Minimum Rating).  
  >   
  >  Also, rating for a record is calculated as an average of all the normalized ratings for the record.  
  
- Feedback status such as Open or Closed  
  
- Feedback source to display the source from where the feedback was submitted. If the feedback was created from within [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], the value is set to **Internal**. Developers can add a value of their choice depending on the application used to provide feedback.  
  
- User who created or last modified the feedback record  
  
- Entity record that the feedback is associated with  
  
## In This Section  
 [Feedback Entity](entities/feedback.md)  
  
### See also  
 [Work with knowledge articles in Dynamics 365](work-knowledge-articles.md)   
 [Service entities in Customer Engagement](service-entities.md)
