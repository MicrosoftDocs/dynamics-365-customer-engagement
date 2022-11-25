---
title: Manage feedback for knowledge articles 
description: Learn how to add feedback to your knowledge articles and update your knowledge articles based on the feedback.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.service: dynamics-365
ms.topic: how-to
ms.date: 11/24/2022
ms.custom: bap-template
---

# Manage feedback for knowledge articles

Mange feedback received for your articles by adding them to your knowledge articles. Update your knowledge articles based on the feedback to make your articles useful for agents.

## Add feedback to an article

1. In the **Feedback** subgrid, select **Create Feedback**. You can also select ![Add a record button.](../customer-service/media/add-recordbutton.gif "Add a record button") in the nav bar and then go to **Feedback** to create a feedback.  
  
2. In the **Create Feedback** flyout, fill in the information:  
  
   - **Title**. Type a descriptive title for the feedback. For example, if the feedback is about customer satisfaction, type that.  
   
   - **Regarding**. Look for relevant records to associate the feedback.
  
   - **Source**. Select whether the feedback is internal or from a portal. If you received the feedback via a phone call, you can select **Internal**.  
  
   - **Comments**. Type any feedback comments that you want.  
  
   - **Rating**. Type a number to specify how useful the related record is. For example, if you are tracking the customer satisfaction for a case, and you want to rate it a 2 on a scale of 1–10, type 2.  
  
   - **Minimum Rating Value** and **Maximum Rating Value**. Specify a minimum and maximum rating to define a rating scale. For example, you want to give a rating of 2  on the scale of 1–10, type 1 as the minimum rating and 10 as the maximum rating.  
  
   - **Created by (Contact)**. If you're creating the feedback on behalf of a customer contact, select the contact here.  
  
        The **Created By** and **Closed By** fields are automatically populated with the user who creates or deactivates the feedback record.  
  
   - Dynamics 365 Customer Service automatically calculates the **Normalized Rating** based on the following formula: **(Rating - Minimum Rating)/ (Maximum Rating - Minimum Rating)**.  
  
3. Select **Save**.

   ![Knowledge article feedback.](media/ka-feedback.png "Knowledge article feedback.")

> [!NOTE]
> You can also update the owner of the feedback in the flyout.

## Update knowledge articles based on the feedback  

Ensure that your articles are up to date and accurate at all times by updating them based on feedback you receive.  
  
1. In the Customer Service Hub, go to **Service** > **Knowledge Articles**.  
  
2. Select the article you want to edit.  
  
    If the reviewer has suggested any changes from their review, you can see them as notes in the **Timeline** section.  
  
3. Update the article based on the feedback.  
  
4. Select **Save**.  
  
5. To assign the article back to the reviewer for approval or publishing, on the command bar, select **Assign**, and then select a user or a team.
