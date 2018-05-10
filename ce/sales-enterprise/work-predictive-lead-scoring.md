---
title: "Work with Predictive lead scoring feature for Dynamics 365 Customer Engagement  | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 04/01/2018
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: f5f685e2-ea1b-4c1c-8a68-857160e22fb3
author: udag
ms.author: udag
manager: sakudes
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 01
topic-status: Drafting
---

# Work with Predictive lead scoring

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>

Predictive lead scoring helps you to focus on revenue generation efforts by providing score to prioritize efforts on quality leads. Using this score, you can identify best possible opportunities that are available for you to close deals and achieve your targets. When the score is higher, the more likely that you can convert it into an opportunity. These leads are displayed in a system view—and when you select a lead, you can view reasons influences of a lead to further analyze and build a strategy and turn lead into an opportunity.

> [!IMPORTANT]
> To enable Predictive lead scoring in your organization, contact your system administrator. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure and enable embedded intelligence](../sales-enterprise/embedded-intelligence.md)

## Understand leads in views
When the Predictive lead scoring is enabled in your organization, you can use the My Open Leads Scored system view. This view gives you a list of leads that can be converted into opportunities.<br>
The following screen displays a typical view with a list of leads that consist of parameters that are used to analyze possible opportunities.<br>
![My open leads scored view](media/my-open-lead-score-view.png "My open leads scored view")

The numbered columns are:
1.	**Lead Score.** Specifies the value that is representative of the likelihood of the lead to convert into an opportunity.  
2.	**Lead Grade.** Specifies the grades of a lead that are categorized into A, B, C, and D with colors green, orange, yellow, and red, respectively, where Grade A (green) is the lead with highest likelihood for conversion into an opportunity followed by Grade B (orange), Grade C (yellow), and Grade D (red).

    >   [!NOTE]
    >   A system administrator can define lead score ranges for a grade, depending on the organizational requirements. 

3.	**Lead Score Trend.** Specifies the direction in which a lead is trending such as **Improving** (up arrow), **Declining** (down arrow), **Steady** (right arrow), or **Not enough info**. These trends are displayed by comparing the present lead score with the previous score. For example, the score of a lead was 65 and the present score is decreased to 45, a down arrow is displayed in the **Lead Score Trend** column specifying that the lead is losing traction and needs some action from you to improve the score. 
 
## Analyze and improve your lead score

In forms, you can use the Lead Score widget to see the top ten reasons that affect how coming leads and related entities are impacting the lead score. This helps you to analyze and work on the lead to improve the score and convert it into a possible opportunity. <br>
The following screen displays a typical Lead Score widget with positive and negative reasons that are used to analyze. <br>
![Predective lead score widget](media/predictive-lead-scoring-widget.png "Predective lead score widget")

The numbered sections are:
1.	**Basic Information.** Displays the basic information of a lead—such as lead score, lead grade, and lead score trend—to help you avoid going back to the My Open Leads Scored view to see basic information.
2.	**Top Reasons.** Displays the list of reason that are affecting the lead score. This helps you to analyze and consider the lead for converting into an opportunity. You can also take necessary action to improve the lead score, such as set up meetings and follow-ups.  
3.	**Feedback.** Displays feedback that's provided by a user to a lead. You can change the feedback with an appropriate lead score. <br>
    To provide feedback, select the **Chat** icon and enter the expected score and comments. To save the feedback, select **Send**.


### See also 

[Configure and enable embedded intelligence](../sales-enterprise/action-cards-reference.md)    
