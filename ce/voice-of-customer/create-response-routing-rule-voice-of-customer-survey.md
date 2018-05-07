---
title: "Create a response routing rule for a Voice of the Customer for Dynamics 365 survey | MicrosoftDocs"
description: ""
ms.assetid: bd1b39a2-fa08-4adb-af1b-7a8cf3459d22
ms.custom: dyn365-VoC
ms.date: 07/26/2017
ms.service: dynamics-365-customerservice
ms.topic: "article"
applies_to: "Dynamics 365 (online)"
redirect_url: /dynamics365/customer-engagement/voice-of-customer/design-advanced-survey
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Create a response routing rule to ask additional questions for a Voice of the Customer survey
When you want to ask additional questions based on responses in a [!INCLUDE[pn-voice-of-the-customer-full](../includes/pn-voice-of-the-customer-full.md)] survey, create one or more response routing rules for the response you want more information about.  
  
 For example, for the question **How likely is it that you would recommend us to a friend?**, you can create a response routing rule to ask the reason if someone responds **Not likely**.  
  
1.  Click the down arrow next to your survey name at the top of the screen.  
  
2.  Click **Response Routings**.  
  
3.  Click **Add New Response Routing**.  
  
4.  Enter a name for your survey in **Name**, and then click **Save** so you can continue editing your response routing.  
  
5.  In the **Conditions** area, click **+** to add a condition.  
  
6.  In the **Response Condition** screen, select the question you want to get more information about, specify the operator (for example, equal or greater), enter a comparison value, and then click **Save**.  
  
7.  In the **Actions** area, click **+** to add an action to take.  
  
8.  In the **Name** field, click the search button, and then click **+ New**.  
  
9. In the **Response Action** screen, enter a name for the action and specify the scope:  
  
    - **Client**. Choose this if the action occurs within the survey (for example, show or hide a question). In the **Client** area, select the survey and the action to take, and then click **Save**.  
  
    - **Server**. Choose this if the action occurs outside of the survey (for example, request contact or unsubscribe). In the **Server** area, select the action type and select the users or queues to notify, if applicable, and then click **Save**.  
  

  
