---
title: "Configure the automatic record creation for social activity entities from Social Engagement | Microsoft Docs"
description: "Learn how to configure rules in Dynamics 365 to automatically turn social activities into records."
keywords: "rule framework, update rules, create record, entity mapping"
ms.date: 12/05/2017
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

To automatically create an Entity record (such as a Case or a Lead) from a Social Activity record in [!include[](../includes/pn-dynamics-crm.md)], an administrator or customizer must configure Automatic Record Creation and Update Rules in [!include[](../includes/pn-dynamics-crm.md)].

In [!INCLUDE[MSE](../includes/pn-social-engagement-short.md)], when users [link a post to Dynamics 365](link-posts-to-dynamics-365.md), a Social Activity record is created in the connected [!include[](../includes/pn-dynamics-crm.md)] instance. The entity type the user makes in [!INCLUDE[MSE](../includes/pn-social-engagement-short.md)] (Case, Lead, etc.) is passed on as part of the [JSON Payload](create-dynamics-365-record-from-social-post.md#understand-the-data-sent-to-dynamics-365-when-you-create-a-social-activity) to the Social Activity in Dynamics 365.


> [!IMPORTANT]
>  Without Automatic Record Creation and Update Rules, the Social Activity created in [!include[](../includes/pn-dynamics-crm.md)] by [!INCLUDE[MSE](../includes/pn-social-engagement-short.md)] does not automatically result in a corresponding [!include[](../includes/pn-dynamics-crm.md)] entity record (such as Case or Lead).

![Open drop-down menu with Case and Lead option for creating a record in Dynamics 365 from within Social Engagement.](media/select-entity-mse.png "Open drop-down menu with Case and Lead option for creating a record in Dynamics 365 from within Social Engagement.")

## Create a rule to automatically turn social actitivites into lead or case records

1. Sign in to [!include[](../includes/pn-dynamics-crm.md)] with your system administrator or customizer credentials.

2. Go to **Settings** > **Business Management** > **Automatic Record Creation and Update Rules**.

  ![Clickpath to access Automatic record Creation and Update Rules settings.](media/business-management-settings-D365.png "Clickpath to access Automatic record Creation and Update Rules settings.")

3. Select **New** to create a new rule.

  ![Position of New control to create new rules.](media/new-record-creation-update-rule.png "Position of New control to create new rules.")

4. Provide a **Name** for the rule.

5. Set the **Source Type** to **Social Activity**.

6. Click **Save** to create the record before proceeding to the next steps.

  ![Higlighted areas for Name, Source Type, and Save control.](media/create-record-creation-update-rule.png "Higlighted areas for Name, Source Type, and Save control.")

7. Select the **Additional Properties** field under the **Channel Properties** section.

8. Select the **Search** button and then select the **New**.

9. In the new dialog, provide a **Name** for the Channel Property Group. For **Source Type**, select **Social Activity**.

10. Select **Save**.

11. Select **Add Channel Property record** in the newly created Channel Property Group. Set the name to `userPreferredTargetEntity` and set the **Data Type** to **Single Line of Text**. It's important that you match the name as documented in the [JSON payload](create-dynamics-365-record-from-social-post.md#understand-the-data-sent-to-dynamics-365-when-you-create-a-social-activity). Now that the Channel Property is in place, we can proceed to create the actual update rules.

12. Select **Save** and close the dialog boxes.

  ![Details of the Channel Property record for the Social Engagement payload.](media/channel-property-group-userPreferredTargetEntity.png "Details of the Channel Property record for the Social Engagement payload.")


13. In **Record Creation and Update Rule**, select the **Add Record Creation and Update Rule Item record** button.

  ![Highlighted area of the New rule control.](media/specify-record-creation-and-update-details.png "Highlighted area of the New rule control.")

14. In the new dialog that opens, provide a **Name** for the rule and select **Save** to create the rule.

15. Under **Condition**, choose **Select** and scroll to the bottom of the drop-down to find **Channel Properties** under **Local Values**. Then, select `userPreferredTargetEntity` `Equals` `lead`.  
    
    > [!NOTE]
    > The value for userPreferredEntity must exactly match the value in the JSON payload. This value is the [!include[](../includes/pn-dynamics-crm.md)] entity type name that can be different from the name in the [!include[](../includes/pn-dynamics-crm.md)] user interface. For example, the entity type name for Case is _incident_.

  ![Highlighted condition for lead field in Social Engagement payload for userPrefrerredTargeEntity.](media/lead-creation-condition.png "Highlighted condition for lead field in Social Engagement payload for userPrefrerredTargeEntity.")

16. Under **Action**, select **Add Step** and select **Create Record**. Set the value to **Lead**. 

  ![Actions area with record creation set to Lead record.](media/configure-action-update-rule.png "Actions area with record creation set to Lead record.")

17. Click **Save & Close** to finalize the rule.

18. Verify if the rules were created and select **Activate** to activate the rule.    
Social activity entities created from [!INCLUDE[MSE](../includes/pn-social-engagement-short.md)] now automatically create the configured record type in [!include[](../includes/pn-dynamics-crm.md)]. 

  ![Activate the newly created rule to automatically turn social activity entities into other record types.](media/activate-update-rule.png "Activate the newly created rule to automatically turn social activity entities into other record types.")

> [!TIP]
> To create a case record, repeat the steps above but select `userPreferredTargetEntity` `Equals` `incident` and under **Action**, set the **Create Record** value to **Case**.

### See also

[Set up the connection to link posts from Social Engagement to Dynamics 365](link-posts-to-dynamics-365.md)    
[Link posts from Social Engagement to Dynamics 365](create-dynamics-365-record-from-social-post.md)    
[Set up rules to automatically create or update records in Dynamics 365](https://technet.microsoft.com/library/mt812474.aspx)