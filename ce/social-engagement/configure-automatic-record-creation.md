---
title: "Configure the automatic record creation for social activity entities from Social Engagement | Microsoft Docs"
description: "Learn how to configure rules in Dynamics 365 to automatically turn social activities into records."
keywords: "rule framework, update rules, create record, entity mapping"
ms.date: 11/27/2017
ms.service: mse
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: 74f05ebd-73b9-597f-45a5-6faf66c99967
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Configure Record Creation and Update Rule in Dynamics 365 to process Social Actity entities from Social Engagement

To automatically turn a Social Activity into another record type in [!INCLUDE[Dynamics 365](../includes/pn-dynamics365.md)], an administrator or customizer needs to confiure the Record Creation and Update Rule feature in [!INCLUDE[Dynamics 365](../includes/pn-dynamics365.md)]. 

In [!INCLUDE[MSE](../includes/pn-social-engagement-short.md)], users can select whether they want to [create a case or lead entity](link-posts-to-dynamics-365.md) in the connected [!INCLUDE[Dynamics 365](../includes/pn-dynamics365.md)] instance.

![Open drop-down menu with Case and Lead option for creating a record in Dynamics 365 from within Social Engagement.](media/select-entity-mse.png "Open drop-down menu with Case and Lead option for creating a record in Dynamics 365 from within Social Engagement.")

In [!INCLUDE[Dynamics 365](../includes/pn-dynamics365.md)], a Social Activity entity gets created, containing the information if the target record is a `lead` or an `incident`. 

When you create an Automatic Record Creation rule, the system will convert social activities created from [!INCLUDE[MSE](../includes/pn-social-engagement-short.md)] to the corresponding entities in [!INCLUDE[Dynamics 365](../includes/pn-dynamics365.md)].

## Create a rule to automatically turn social actitivites into lead or case records

1. Sign in to [!INCLUDE[Dynamics 365](../includes/pn-dynamics365.md)] with your system administrator credentials.

2. Go to **Settings** > **Business Management** > **Automatic Record Creation and Update Rules**.

  ![Clickpath to access Automatic record Creation and Update Rules settings.](media/business-management-settings-D365.png "Clickpath to access Automatic record Creation and Update Rules settings.")

3. Select **New** to create a new rule.

  ![Position of New control to create new rules.](media/new-record-creation-update-rule.png "Position of New control to create new rules.")

4. Provide a **Name** for the rule.

5. Set the **Source Type** to **Social Activity**.

6. Click **Save** to create the record before proceeding to the next steps.

  ![Higlighted areas for Name, Source Type, and Save control.](media/create-record-creation-update-rule.png "Higlighted areas for Name, Source Type, and Save control.")

7. Create a **Channel Property Group** and name it.

8. For **Source Type**, select **Social Activity**.

9. Create a **Channel Property** with the name `userPreferredTargetEntity` and set the **Data Type** to **Single Line of Text**. It's important that you match the name as documented in the [JSON payload](link-posts-to-dynamics-365.md). Now that the Channel Property is in place, we can proceed to creat the actual update rules.

  ![Details of the Channel Property record for the Social Engagement payload.](media/channel-property-group-userPreferredTargetEntity.png "Details of the Channel Property record for the Social Engagement payload.")

[comment]: <> (Validate link and update to l2CRM doc, add + icon)

10. Click the **New rule** button to open the rule editor.

  ![Highlighted area of the New rule control.](media/specify-record-creation-and-update-details.png "Highlighted area of the New rule control.")

11. Provide a **Name** for the rule and select **Save** to create the rule.

12. Under **Condition**, choose **Select** and scroll to the bottom of the list to find **Channel Properties** under **Local Values**. Then, select `userPreferredTargetEntity` `Equals` `lead`. 

  ![Highlghted condition for lead field in Social Engagement payload for userPrefrerredTargeEntity.](media/lead-creation-condition.png "Highlghted condition for lead field in Social Engagement payload for userPrefrerredTargeEntity.")

13. Under **Action**, select **Add Step** and select **Create Record**. Set the value to **Lead**. 

![Actions area with record creation set to Lead record.](media/configure-action-update-rule.png "Actions area with record creation set to Lead record.")

14. Click **Save & Close** to finalize the rule.

15. Verify if the rules were created and select **Activate** to activate the rule.    
Social activity entities created from [!INCLUDE[MSE](../includes/pn-social-engagement-short.md)] now automatically create the configured record type in [!INCLUDE[Dynamics 365](../includes/pn-dynamics365.md)]. 

  ![Activate the newly created rule to automatically turn social activity entities into other record types.](media/activate-update-rule.png "Activate the newly created rule to automatically turn social activity entities into other record types.")

> [!TIP]
> To create a case record, repeat the steps above but select `userPreferredTargetEntity` `Equals` `incident` and under **Action**, set the **Create Record** value to **Case**.

### See also

[Set up the connection to link posts from Social Engagement to Dynamics 365](link-posts-to-dynamics-365.md)
[Link posts from Social Engagement to Dynamics 365](create-dynamics-365-record-from-social-post.md)