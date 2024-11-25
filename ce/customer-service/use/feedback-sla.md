---
title: Manage feedback for knowledge articles 
description: Learn how to manage feedback to your knowledge articles and update your knowledge articles based on the feedback.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 06/14/2024
ms.custom: bap-template
---

# Manage feedback for knowledge articles

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]


Manage feedback received for your articles by adding it to your knowledge articles. Update your knowledge articles based on feedback to make the articles more useful for agents.

## Add feedback to an article

1. In Customer Service workspace or Contact Center workspace, select **Knowledge Articles**.

1. Select the article you want to add feedback for.

1. In the **Feedback** subgrid, select **Create Feedback**. You can also select ![Add a record button.](../media/add-recordbutton.gif "Add a record button") in the navigation bar and then go to **Feedback** to create a feedback item.  
  
1. In the **Quick Create: Feedback** dialog, fill in the following information:  
  
   - **Title**: Enter a descriptive title for the feedback.  
   
   - **Regarding**: Look for relevant records with which to associate the feedback.
  
   - **Source**: Select whether the feedback is internal or from a portal. If you received the feedback through a phone call, select **Internal**.  
  
   - **Comments**: Type any feedback comments that you want.  
  
   - **Rating**: Type a number to specify how useful the related record is. For example, if you're tracking the customer satisfaction for a case and you want to rate it a two on a scale of 1–10, type 2.  
  
   - **Minimum Rating** and **Maximum Rating**: Specify the minimum and maximum ratings to define a rating scale. For example, if you want to give feedback a rating of 2 on the scale of 1–10, type 1 as the minimum rating and 10 as the maximum.  
  
   - **Created by (Contact)**: If you're creating the feedback on behalf of a customer contact, select the contact here.  
  
        The **Created By** and **Closed By** fields are automatically populated with the user who creates or deactivates the feedback record.  
  
   - Dynamics 365 Customer Service automatically calculates the **Normalized Rating** based on the following formula: **(Rating - Minimum Rating)/ (Maximum Rating - Minimum Rating)**.  
  
1. Select **Save and Close**.

   ![Knowledge article feedback.](../media/ka-feedback.png "Knowledge article feedback.")

> [!NOTE]
> You can also update the owner of the feedback in the flyout.

## Update knowledge articles based on the feedback  

Ensure that your articles are always up to date and accurate by updating them based on feedback you receive.  
  
1. In Customer Service workspace or Contact Center workspace, select **Knowledge Articles**.

1. Select the article you want to edit.  
  
    If the reviewer suggested any changes from their review, you can see them as notes in the **Timeline** section.  
  
1. Update the article based on the feedback.  
  
1. Select **Save**.  
  
1. To assign the article back to the reviewer for approval or publishing, on the command bar, select **Assign**, and then select a user or a team.
