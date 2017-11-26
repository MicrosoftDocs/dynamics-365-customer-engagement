---
title: "Configure the automatic record creation for social activity entities in Social Engagement | Microsoft Docs"
description: "Learn how to configure rules in Dynamics 365 to automatically turn social activities into records."
keywords: "rule framework, update rules, create record, entity mapping"
ms.date: 11/24/2017
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

[comment]: <> (Tokenize and add pictures!)

# Configure Record Creation and Update Rule in Dynamics 365

To automatically turn a Social Activity into another record type in Dynamics 365, an administrator or customizer needs to confiure the Record Creation and Update Rule feature in Dynamics 365. 

In Social Engagement, users can select whether they want to create a case or lead entity in the connected Dynamics 365 instance. However, in Customer Engagement, a Social Activity entity gets created, containing the information if the target record is a `lead` or an `incident`. 

When you create an Automatic Record Creation rule, the system will convert social activities created from Social Engagement to the corresponding entities in Customer Engagement.

## Create a rule to automatically turn social actitivites into lead or case records

1. Sign in to Dynamics 365 Customer Engagement with your admin credentials.

2. Go to **Settings** > **Business Management** > **Automatic Record Creation and Update Rules**.

3. Select **New** to create a new rule.

4. Provide a **Name** for the rule.

5. Set the **Source Type** to **Social Activity**.

6. Click **Save** to create the record before proceeding to the next steps.

7. Create a **Channel Property Group** and name it.

8. For **Source Type**, select **Social Activity**.

9. Create a **Channel Property** with the name `userPreferredTargetEntity` and set the **Data Type** to **Single Line of Text**. It's important that you match the name as documented in the [JSON payload](link-posts-to-dynamics-365.md). Now that the Channel Property is in place, we can proceed to creat the actual update rules.

[comment]: <> (Validate link and update to l2CRM doc, add + icon)

10. Click the **New rule** button to open the rule editor.

11. Provide a **Name** for the rule and select **Save** to create the rule.

12. Under **Condition**, choose **Select** and scroll to the bottom of the list to find **Channel Properties** under **Local Values**. Then, select `userPreferredTargetEntity` `Equals` `lead`. 

13. Under **Action**, select **Add Step** and select **Create Record**. Set the value to **Lead**. 

14. Click **Save & Close** to finalize the rule.

14. To create a case record, repeat the steps above but select `userPreferredTargetEntity` `Equals` `incident` and under **Action**, set the **Create Record** value to **Case**.

15. Verify if the rules were created and select **Activate** to activate the rules.