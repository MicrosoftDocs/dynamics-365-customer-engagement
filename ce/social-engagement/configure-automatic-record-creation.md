---
title: "Set up record creation for social activity entities from Social Engagement | Microsoft Docs"
description: "Learn how to configure rules in Dynamics 365 to automatically turn social activities into records."
keywords: "rule framework, update rules, create record, entity mapping"
ms.date: 01/30/2018
ms.service: dynamics-365-marketing
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: 74f05ebd-73b9-597f-45a5-6faf66c99967
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
ms.custom: dyn365-socialengagement
---

# Configure Automatic Record Creation and Update Rules in Dynamics 365 to process Social Activity entities from Social Engagement

To automatically create an entity record (such as a Case or a Lead) from a Social Activity record in [!include[](../includes/pn-dynamics-crm.md)], an administrator or customizer must configure Automatic Record Creation and Update Rules in [!include[](../includes/pn-dynamics-crm.md)].

In [!INCLUDE[MSE](../includes/pn-social-engagement-short.md)], when users [link a post to Dynamics 365](link-posts-to-dynamics-365.md), a Social Activity record is created in the connected [!include[](../includes/pn-dynamics-crm.md)] instance. The entity type the user creates in [!INCLUDE[MSE](../includes/pn-social-engagement-short.md)] (Case, Lead, and so on) is passed on as part of the [JSON Payload](create-dynamics-365-record-from-social-post.md#understand-the-data-sent-to-dynamics-365-when-you-create-a-social-activity) to the social activity in [!include[](../includes/pn-dynamics-crm.md)].


> [!IMPORTANT]
>  Without Automatic Record Creation and Update Rules, the Social Activity record created in [!include[](../includes/pn-dynamics-crm.md)] by [!INCLUDE[MSE](../includes/pn-social-engagement-short.md)] does not automatically result in a corresponding [!include[](../includes/pn-dynamics-crm.md)] entity record (such as a Case or Lead record).

![Open drop-down menu with Case and Lead option for creating a record in Dynamics 365 from within Social Engagement.](media/select-entity-mse.png "Open drop-down menu with Case and Lead options for creating a record in Dynamics 365 from within Social Engagement")

## Create a rule to automatically turn social activities into Lead or Case records

1. Sign in to [!include[](../includes/pn-dynamics-crm.md)] with your system administrator or customizer credentials.

2. Go to **Settings** > **Business Management** > **Automatic Record Creation and Update Rules**.

  ![Clickpath to access Automatic record Creation and Update Rules settings.](media/business-management-settings-D365.png "Access Automatic Record Creation and Update Rules settings")

3. Select **New** to create a new rule.

  ![Position of New control to create new rules.](media/new-record-creation-update-rule.png "Location of the New command to create new rules")

4. Provide a **Name** for the rule.

5. Set the **Source Type** to **Social Activity**.

6. Click **Save** to create the record.

  ![Highlighted areas for Name, Source Type, and Save control.](media/create-record-creation-update-rule.png "Location of areas for Name, Source Type, and the Save command")

7. Under **Channel Properties**, select **Additional Properties**.

8. Select the **Search** button, and then select **New**.

9. In the new dialog box, provide a **Name** for the Channel Property Group. For **Source Type**, select **Social Activity**.

10. Select **Save**.

11. Select **Add Channel Property record** in the newly created Channel Property Group. Enter **userPreferredTargetEntity** for the name, and set the **Data Type** to **Single Line of Text**. It's important that you match the name as documented in the [JSON payload](create-dynamics-365-record-from-social-post.md#understand-the-data-sent-to-dynamics-365-when-you-create-a-social-activity). Now that the Channel Property is in place, you create the actual update rules.

12. Select **Save**, and then close the dialog boxes.

  ![Details of the Channel Property record for the Social Engagement payload](media/channel-property-group-userPreferredTargetEntity.png "Details of the Channel Property record for the Social Engagement payload")


13. In **Record Creation and Update Rule**, select **Add Record Creation and Update Rule Item record**.

  ![Highlighted area of the New rule control.](media/specify-record-creation-and-update-details.png "Location of the New Rule command")

14. In the new dialog box that opens, provide a **Name** for the rule and then select **Save** to create the rule.

15. Under **Condition**, choose **Select**, and scroll to the bottom of the drop-down list to find **Channel Properties** under **Local Values**. Then, select **userPreferredTargetEntity** **Equals** **lead**.  
    
    > [!NOTE]
    > The value for userPreferredEntity must exactly match the value in the JSON payload. This value is the [!include[](../includes/pn-dynamics-crm.md)] entity type name that can be different from the name in the [!include[](../includes/pn-dynamics-crm.md)] user interface. For example, the entity type name for Case is _incident_.

  ![Highlighted condition for lead field in Social Engagement payload for userPrefrerredTargeEntity.](media/lead-creation-condition.png "Condition for a Lead field in the Social Engagement payload for userPrefrerredTargeEntity")

16. Under **Action**, select **Add Step**, and then select **Create Record**. Set the value to **Lead**. 

  ![Actions area with record creation set to Lead record.](media/configure-action-update-rule.png "Actions area with record creation set to Lead")

17. Click **Save & Close** to finalize the rule.

18. Verify that the rules were created, and then select **Activate** to activate the rule.    
Social Activity entities created from [!INCLUDE[MSE](../includes/pn-social-engagement-short.md)] will now automatically create the configured record type in [!include[](../includes/pn-dynamics-crm.md)]. 

  ![Activate the newly created rule to automatically turn social activity entities into other record types.](media/activate-update-rule.png "Activate the newly created rule to automatically turn Social Activity entities into other record types")

> [!TIP]
> To create a Case record, repeat the steps above but select **userPreferredTargetEntity** **Equals** **incident**, and under **Action**, set the **Create Record** value to **Case**.

### See also

[Set up the connection to link posts from Social Engagement to Dynamics 365](link-posts-to-dynamics-365.md)    
[Link posts from Social Engagement to Dynamics 365](create-dynamics-365-record-from-social-post.md)    
[Set up rules to automatically create or update records in Dynamics 365](https://technet.microsoft.com/library/mt812474.aspx)
