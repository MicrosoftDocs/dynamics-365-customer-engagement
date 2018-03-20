---
title: "Work with Predictive lead scoring feature for Dynamics 365 Customer Engagement  | MicrosoftDocs"
ms.custom: ""
ms.date: 04/01/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: f5f685e2-ea1b-4c1c-8a68-857160e22fb3
caps.latest.revision: 01
author: "udag"
ms.author: "udag"
manager: "sakudes"
---

# Work with Predictive lead scoring

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

Predictive lead scoring helps you to focus on revenue generation efforts by providing score to prioritize efforts on quality leads. Using this score, you can identify best possible opportunities that are available for you to close deals and achieve your targets. When the score is higher the more likely that you can convert it into an opportunity. These leads are displayed in a system view and when you select a lead, you can view reasons influences of a lead to further analyze and build a strategy and turn lead into an opportunity.

> [!IMPORTANT]
> Contact your system administrator to enable Predictive lead scoring in your organization. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure and enable embedded intelligence](../admin/configure-enable-embedded-intelligence.md)

## Understand leads in views
When the Predictive lead scoring is enabled in your organization, the system view My Open Leads Scored is available for you. Open the view and a list of leads that can be converted into opportunities are displayed.<br>
The following screen displays a typical view with a list of lead that consist of parameter that are used to analyze possible opportunities.<br>
![My open leads scored view](../admin/media/my-open-lead-score-view.png "My open leads scored view")

1.	**Lead Score:** Specifies the value that is representative of the likelihood of the lead to convert into an opportunity.  
2.	**Lead Grade:** Specifies the grades of a lead that are categorized into A, B, C, and D with colors Green, Orange, Yellow, and Red respectively where Grade A (Green) is the lead with highest likelihood for conversion into an opportunity followed by Grade B (Orange), Grade C (Yellow), and Grade D (Red).

    >   [!NOTE]
    >   A system administrator can define lead score ranges for a grade depending on the organizational requirements. 

3.	**Lead Score Trend:** Specifies the direction in which a lead is trending such as Increasing (up arrow), Decreasing (down arrow), Steady (right arrow), or Not enough info. These trends are displayed by comparing the present lead score with previous. For example, score of a lead was 65 and the present score is decreased to 45, a down arrow is displayed in the Lead Score Trend column specifying that the lead is losing traction and needs some action from you to improve the score.  

## Understand lead score widget in forms

The lead score widget provides an insight into top ten reasons coming leads and related entities that are impacting the lead score. This helps you to analyze  and work on the lead to improve the score and convert into a possible opportunity. <br>
The following screen displays a typical lead score widget with positives and negatives reasons that are used to analyze. <br>
![Predective lead score widget](../admin/media/predictive-lead-scoring-widget.png "Predective lead score widget")

1.	**Basic Information:** Displays the basic information of a lead such as lead score, lead grade, and lead score trend and helps you to in not to moving back to **My Open Leads Scored** view for basic information.
2.	**Top Reasons:** Displays the list of reason that are affecting the lead score and helps you to analyze and take a decision to consider the lead for converting into an opportunity. further, you can take necessary action such as set up meetings and follow-ups to improve the lead score.  
3.	**Feedback:** Displays feedback that is provided by user to a lead and you can change the feedback with appropriate lead score. 
    To provide feedback, select the chat icon and enter the expected score and comments. Select Send to save the feedback.


### See also 
[Configure and enable embedded intelligence](../admin/configure-enable-embedded-intelligence.md)    