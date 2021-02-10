---
title: "Basic auto capture for Dynamics 365 Sales Insights | MicrosoftDocs"
keywords: 
ms.date: 01/31/2020
ms.service: crm-online
ms.custom: 
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 01
---

# Basic auto capture

The activities captured by the auto capture feature are shown on the timeline in Microsoft Dynamics 365 Sales. The feature finds activities by applying a set of rules that are specific to the record type. For example, when you look at an opportunity in Microsoft Dynamics 365 Sales, the timeline shows all the activities you've logged, and in addition it shows suggestions for up to 50 recent emails and meetings from your Outlook account that were sent to or from the primary contact for the opportunity or its stakeholders.

The following images show how tracked and auto-captured (not yet tracked) emails and meetings are displayed on the timeline:

-	**Auto capture emails and meetings**: These emails and meetings were detected by auto capture as being relevant to the current record, but they're still private, so only you can see them. Compared to tracked messages, these messages are shown as untracked emails or meetings. The following image shows an untracked email.

    > [!div class="mx-imgBorder"]
    > ![Untracked auto-captured email](media/auto-capture-basic-capture-email.png "Untracked auto-captured email")

-	**Track link**: Select the **Track** icon on an untracked activity captured by auto capture, making it visible to everyone who has access to the timeline of this specific record.
The activities that auto capture finds are only visible to you, so other members of your sales team won't be able to see them in Dynamics 365 Sales. When you select the **Track** link on any auto-captured message, you turn it into a tracked email message, which saves the activity into the Dynamics 365 Sales database and makes it visible to other members of your team. It might take a few minutes for an activity to go from not being tracked to tracked, during which time it shows a **Tracking pending** message.

    > [!div class="mx-imgBorder"]
    > ![Track link on an untracked email](media/auto-capture-basic-track-link.png "Track link on an untracked email")

-	**Tracked emails and meetings**: The envelope symbol indicates that this email or meeting is already being tracked, so it's already imported into Sales and is being shared with your team.

    > [!div class="mx-imgBorder"]
    > ![Tracked activity](media/auto-capture-basic-tracked-email.png "Tracked email")

As with other types of activity tiles shown on the timeline, you can select the tile to expand or collapse the content on the tile.

## Which activities are captured?

Auto capture queries your Outlook account and looks for activities related to the record you're looking at. The following table summarizes how auto capture identifies related activities.

|Entity type|Matches these field values to the To, CC, or From address of each email and meeting |  
|-----------------|--------------------------------------------------------------------------------------|  
|Account|**Email** address of the listed **Primary Contact**.<br /><br /> **Email** addresses of the top 50 contacts that have the account as their parent account.<br /><br /> All **Email** addresses defined for the account record itself.|  
|Opportunity|**Email** address listed for the **Opportunity Contact**.<br /><br /> **Email** address of any contact in the **Stakeholders** list.<br /><br /> All **Email** addresses defined for the opportunity record itself.|  
|Case|**Email** address of the **Primary Contact**.<br /><br /> All **Email** addresses defined for the case record itself.<br /><br /> If the **Customer** is a contact: all **Email** addresses for  the contact record.<br /><br /> If the **Customer** is an account: all **Email** addresses for the account record.|  
|Lead|**Email** address listed in the **Contact** section.<br /><br /> All **Email** addresses defined for the lead record itself.|  
|Contact|All **Email** addresses defined for the contact record.|  
|Custom entities|For *account* fields: the email address for the **Primary Contact** of the account, plus all **Email** addresses defined for the account record itself.<br /><br /> For *contact* fields: all **Email** addresses defined for the contact record.<br /><br /> For *customer* fields that refer to a contact: all **Email** addresses defined for the contact record.<br /><br /> For *customer* fields that refer to an account: the **Email** address of the listed **Primary Contact**, plus all **Email** addresses defined for the account record itself.|  


### See also

[Enable and configure auto capture](configure-auto-capture.md)<br>
[Premium auto capture](premium-auto-capture.md)