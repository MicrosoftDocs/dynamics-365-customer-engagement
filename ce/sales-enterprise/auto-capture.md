---
title: "Auto capture for Dynamics 365 Customer Engagement | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 09/30/2017
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 1d005ded-099e-4d66-a435-f1024e1316b6
author: udag
ms.author: udag
manager: sakudes
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 13
topic-status: Drafting
---

# Auto capture of related emails

Applies to Dynamics 365 (online), version 9.0.2<br>

Auto capture enables [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] to access your email in [!INCLUDE[pn_Microsoft_Exchange](../includes/pn-microsoft-exchange.md)] to find and display messages that are related to your work in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. This makes it easy to see your relevant email messages together with all of the other activities that are related to a given record in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. Each message remains private and visible only to you unless you choose to convert it to a *tracked email*, which you can do with just one click to make that email visible to the rest of your team in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)].  
  
Auto capture is part of the *Embedded intelligence* suite of features. 
  
[Watch a short video (1:43) about Dynamics 365 Auto Capture](https://go.microsoft.com/fwlink/p/?linkid=841309).  

The administrator must enable auto capture before you can try it out. For complete details about prerequisites, how to enable the feature, and how to set it up, see [Configure and enable embedded intelligence](../admin/configure-enable-../sales-enterprise/embedded-intelligence.md).  
  
## View auto-captured messages and convert them into tracked messages  

 Messages found by auto capture are merged with other relevant [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] activities and shown in the **Activities** column for the record they apply to. You can see them on Contact, Opportunity, Lead, Account, Case, and Custom entities. So, for example, if you are looking at an opportunity in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], then the **Activities** column shows all of the activities you have logged for that opportunity, plus up to 50 recent email messages in your [!INCLUDE[pn_Microsoft_Exchange](../includes/pn-microsoft-exchange.md)] account that were sent to or from the primary contact for that opportunity or  its stakeholders.  
  
 ![Auto capture messages in the Activities column](../admin/media/auto-capture-messages-the-activities-column.png "Auto capture messages in the Activities column")  
  
 The figure shows both tracked and auto-captured (not tracked) messages in the **Activities** column, and highlights the following:  
  
1. **Tracked message**: This message is already being tracked, so it is already imported into [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and is being shared with your team. It shows a black symbol and does not include any tracking controls or messages.  
  
2. **Auto capture messages**: These messages were found by the auto capture feature. They have been identified as possibly being relevant to the current record, but they are still private so only you can see them. Compared to tracked messages, these messages show a gray symbol and a dotted border, and include a **Track** link and a private email label.  
  
3. **Track link**: Select the link to convert a private message found by auto capture to a tracked message in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].
  
4. **Private email label**: Private messages found by auto capture but not yet tracked in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] include this label to indicate their status.  
  
 Initially, the messages that auto capture finds are private for you, so other members of your sales team will not be able to see them in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. Select the **Track** link to turn any auto capture message into a *tracked email message*, which copies the message into the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] database and makes it visible to other members of your team. Auto capture messages that don't include a **Track** link are already being tracked. It may take a few minutes for a message to go from untracked to tracked, during which time it will show a **Tracking pending** message.  
  
 As with other types of email message tiles shown in the **Activities** list, click the tile to expand or collapse the message content.  
  
> [!NOTE]
>  Untracked messages do not indicate the send direction (in or out) or if they include an attachment. But once a message is tracked, both the direction and any attachments are indicated.  
  
## Which messages are captured?  
 Auto capture works by querying your [!INCLUDE[pn_Microsoft_Exchange](../includes/pn-microsoft-exchange.md)] account each time you open the **Activities** column for a record  in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. The query looks for messages that relate to the record you are looking at. The following table summarizes  how auto capture identifies a related message.  
  
|Entity type|Matches these field values  to the To, CC, or From address of each email message|  
|-----------------|--------------------------------------------------------------------------------------|  
|Account|**Email** address of the listed **Primary Contact**<br /><br /> **Email** address of the top 50 contacts that have the account as their parent account<br /><br /> All **Email** addresses defined for the account record itself.|  
|Opportunity|**Email** address listed for the **Opportunity Contact**<br /><br /> **Email** addresses of any contact in the **Stakeholders** list<br /><br /> All **Email** addresses defined for the opportunity record itself.|  
|Case|Primary contact's **Email** address<br /><br /> All **Email** addresses defined for the case record itself.<br /><br /> If the **Customer** is a contact, then use all **Email** addresses for  the contact record.<br /><br /> If the **Customer** is an account, then use all **Email** addresses for the account record|  
|Lead|**Email** address listed in the **Contact** section<br /><br /> All **Email** addresses defined for the lead record itself.|  
|Contact|All **Email** addresses defined for the contact record.|  
|Custom entities|For *account* fields, use the email address for the **Primary Contact** of the account, plus all **Email** addresses defined for the account record itself.<br /><br /> For *contact* fields, use all **Email** addresses defined for the contact record.<br /><br /> For *customer* fields that refer to a contact,  use all **Email** addresses defined for the contact record<br /><br /> For *customer* fields that refer to an account, use the **Email** address of the listed **Primary Contact**, plus all **Email** addresses defined for the account record itself.|  
  
<a name="UserPreferences"></a>   

## Set your auto capture options  
 When auto capture is enabled for your site, it will also be enabled for you by default. If you prefer not to see the messages, then you can turn this feature off. You can turn it back on at any time. When the feature is turned off for your site, you won't see the setting in your personal options. To set your auto capture options:  
  
1.  Select the gear button on the nav bar, and then choose **Options** from the menu.  
  
    ![Options menu](../admin/media/options-menu.png "Options menu")  
  
2.  The **Set Personal Options** dialog opens. Select the **Email** tab.  
  
    ![Auto capture personal options](../admin/media/auto-capture-personal-options.png "Auto capture personal options")  
  
3.  Set the **Show email not tracked in Dynamics 365 in the Activities list** option to **Yes** or **No**, as needed.  
  
4.  Select **OK**.  

## Incoming untracked email support

The following describes the support for viewing, opening, and tracking untracked emails for various synchronization methods.


|Sync method for incoming emails  |View untracked emails  |Open untracked emails |Track untracked emails  |
|---------|---------|---------|---------|
|None     |Yes      |Yes         |N/A, tracking requires server-side sync         |
|Server-Side Sync with **Email Not Approved** or **Test Not Run**     |Yes         |Yes         |No         |
|Server-Side Sync with **Email Approved** and **Test Enabled**     |Yes         |Yes         |Yes         |
|Microsoft Dynamics 365 for Outlook   |Yes         |Yes         |N/A, tracking requires server-side sync         |
|Email Router     |Yes         |Yes         |N/A, tracking requires server-side sync         |
|Forward Mailbox     |No         |No         |No         |

  
<a name="BKMK_Privacy"></a>   

## Privacy notice  
[!INCLUDE[cc_privacy_relationship_insights_auto_capture](../includes/cc-privacy-relationship-insights-auto-capture.md)]
  
### See also

[Configure and enable embedded intelligence](../sales-enterprise/action-cards-reference.md)
