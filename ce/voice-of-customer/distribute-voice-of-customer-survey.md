---
title: "Distribute a survey (Voice of the Customer) | MicrosoftDocs"
ms.custom: ""
ms.date: "2016-11-01"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics CRM Online"
ms.assetid: bdf1401d-1998-480b-ada2-38a2667eced6
caps.latest.revision: 13
author: "brycho"
ms.author: "brycho"
manager: "brycho"
---
# Distribute a survey (Voice of the Customer)
You can invite respondents to take part in a survey in different ways, depending on how you want to send the invitation out, whether you want non-anonymous responses, and whether you want to pipe data to the survey.  
  
 Surveys can be:  
  
- **Anonymous**. [!INCLUDE[pn_crm_shortest](includes/pn-crm-shortest-md.md)] doesn’t know who the respondents are. You can distribute a link to the survey using email, social sites [!INCLUDE[tn_twitter](includes/tn-twitter-md.md)] or [!INCLUDE[tn_facebook](includes/tn-facebook-md.md)], or other web pages.  
  
- **Non-anonymous**.   You send survey invites to specific contacts, accounts, or leads in [!INCLUDE[pn_crm_shortest](includes/pn-crm-shortest-md.md)].  
  
||Media|Trigger|Invitation can be piped|Response in [!INCLUDE[pn_crm_shortest](includes/pn-crm-shortest-md.md)]|Comments|  
|-|-----------|-------------|-----------------------------|---------------------------------------------------------------------------------|--------------|  
|**Anonymous**|Any|Any|No|Create lead||  
|**Email templates**|Email|Direct email<br /><br /> Workflow<br /><br /> Campaign<br /><br /> Quick campaign<br /><br /> Email merge<br /><br /> Manual email|Yes|Account<br /><br /> Contact<br /><br /> Lead<br /><br /> Regarding|Need to create an email template for each survey|  
|**Email**|Email|Workflow<br /><br /> Campaign<br /><br /> Quick campaign<br /><br /> Manual email|Yes (for workflows)|Account<br /><br /> Contact<br /><br /> Lead<br /><br /> Regarding||  
|**Invitations only**|For subsequent use with any media|Any|Yes (for workflows)|Account<br /><br /> Contact<br /><br /> Lead<br /><br /> Regarding|Useful for integration with third-party email providers|  
  
### Anonymous surveys  
 If you configure your survey to allow anonymous respondents, you can copy the survey URL and paste it from the survey to the medium you want to send it with. You can send it in email, post it on social media sites like [!INCLUDE[tn_twitter](includes/tn-twitter-md.md)] or [!INCLUDE[tn_facebook](includes/tn-facebook-md.md)], or publish it on your website.  
  
 To embed the survey in an iFrame on your website, copy and paste the HTML from the **IFrame URL** field on the survey. Choose **Run in IFrame** to remove the header and footer elements of the survey.  
  
 Dynamics 365 doesn’t associate responses with a customer record in [!INCLUDE[pn_crm_shortest](includes/pn-crm-shortest-md.md)]. If you want to create a lead from an anonymous response, set **Create Lead For Anonymous Responses** to **Yes**.  
  
### Non-anonymous surveys  
 For non-anonymous surveys, the link you send to respondents is specific and unique for each customer. [!INCLUDE[pn_crm_shortest](includes/pn-crm-shortest-md.md)] generates the URLs for you to use when you create a survey invitation or embed the survey snippet in an email. You can use the email snippet in the survey’s **Email Snippet** field.  
  
 When you copy the email snippet from the survey and paste it to an email within [!INCLUDE[pn_crm_shortest](includes/pn-crm-shortest-md.md)], [!INCLUDE[pn_crm_shortest](includes/pn-crm-shortest-md.md)] converts the snippet from its GUID form:  
  
 [Survey-Snippet-Start]73379cd2-77b4-e511-8112-00155d0a190d[Survey-Snippet-End]  
  
 to a link with the link text you specify in the survey’s **Invitation Link Text** field, such as:  
  
 Click here to take the survey.  
  
## Use piped data in a survey invite  
 If you want to personalize your survey invite in a [!INCLUDE[pn_crm_shortest](includes/pn-crm-shortest-md.md)] email, make sure your survey snippet contains piped data, and then add a vertical bar (&#124;), also called a pipe, plus the parameters after the GUID in your email invite.  
  
 For example, this survey snippet contains piped data for Customer, User, and Other_1 (used for the case number):  
  
 Thank you _CUSTOMER_PIPED_DATA\_ for giving your feedback and helping us improve the service we are able to deliver to you. Please take the time to answer a few questions regarding case number _OTHER_1_PIPED_DATA\_ and Customer Service Representative _USER_PIPED_DATA\_.  
  
 In the email invite, add the piped data field, followed by **=** and the value. You can add multiple parameters, separated by **&#124;**. Using the survey snippet example above, the following line in an email invite:  
  
 [Survey-Snippet-Start]bd3b2cc6-3597-e511-80bd-00155db50802&#124;customer=Marie&#124;other_1=298724&#124;user=Nancy[Survey-Snippet-End]  
  
 would look like this to the customer:  
  
 Thank you Marie for giving your feedback and helping us improve the service we are able to deliver to you. Please take the time to answer a few questions regarding case number 298724 and Customer Service Representative Nancy.  
  
> [!NOTE]
>  You can also create workflows to use with surveys and specify the appropriate fields instead of individual names, so you can send emails automatically as part of the workflow. For more information about creating workflows, see [Technet: Workflow processes](https://technet.microsoft.com/library/dn531067.md).  
  
 [![Left arrow icon](media/crm-ua-icons-arrowleftbluecircled.png "Left arrow icon")](create-response-routing-rule-voice-of-customer-survey.md) [Response routing](create-response-routing-rule-voice-of-customer-survey.md)  
  
 [View reports](view-voice-of-customer-survey-dashboards-reports.md) [![Right arrow icon](media/crm-ua-icons-arrowrightbluecircled.png "Right arrow icon")](view-voice-of-customer-survey-dashboards-reports.md)  
  
## See Also  
 [Get feedback with Voice of the Customer for Microsoft Dynamics 365 surveys](create-voice-of-customer-survey.md)