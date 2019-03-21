---
title: "Social-medial posting with Dynamics 365 for Marketing | Microsoft Docs"
description: "Create social media posts for immediate or scheduled publishing in Dynamics 365 for Marketing"
keywords: social media; social posting
ms.date: 01/02/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 781000c9-c885-432a-95ae-f15e7eeadf6d
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Schedule and post messages on social media

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] can schedule and post messages directly to your organization's accounts on social media sites. Use the **Social posts** settings to author and schedule your posts. 


## Schedule and post messages on social media

Use the **Social posts** entity to author and schedule your posts. You can post from any social-media account that your admin has set up and authenticated in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

In the current version, you can post updates to Twitter, LinkedIn, and Facebook.

To schedule and post a message to one of your social-media channels:

1. **Go to Marketing** > **Marketing execution** > **Social Posts**.
1. A calendar opens, showing all scheduled and previously posted messages. Do one of the following:
    - To schedule a post using the calendar, choose a calendar view (month, day or week), select a day or time slot to highlight it, and then select again (click or press enter) and choose **New item** from the context menu. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Work with marketing calendars](marketing-calendar.md)
    - To schedule a post using date pickers, or to send it right away, select **New** on the command bar.
1. A new social post record is created. Make the following settings:
    - **Name**: Enter an internal name for the post. This name will be shown on the calendar, but won't appear in the post itself.
    - **Social channel**: Choose the social channel on which to post your message. Each of the channels currently supported by [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is listed here.
    - **Posting from**: Select the specific account through which to post your message. This drop-down list shows each account for the selected **Social channel** that your admin has set up and authenticated in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Configure your social media accounts](#config-social)
    - **Select scheduling**: Choose how to schedule your post by selecting one of the following:
        - **Post now**: Your message will be posted immediately when you save the record, and will be shown on the calendar for the current date and time.
        - **Schedule**: Choose a specific date and time to post the message. If you started by choosing a date and time on the calendar, then this option is preselected.
        - **Schedule later**: Choose this if you want to save the messages without posting or scheduling it. You can come back later to either choose a schedule or post immediately by selecting one of the other options here.
    - **Posted time**: If you choose to schedule your message, then specify the date and time to post it here. If you started by choosing a date and time on the calendar, then those values are already shown here.

    > [!IMPORTANT]
    > The dates and times for the posting schedule use the time zone configured in your personal settings. To view or edit your time zone, open the **Settings** menu ![The Settings menu icon](media/settings-icon.png "The Settings menu icon") at the top of the page and then select **Personalization settings**.

1. Enter the content of your message in the large text field, exactly as you want it to appear in your social-media post.
1. Select **Save** to post or schedule your message according to your settings.

### Reschedule or cancel a post

You can reschedule or cancel any post that hasn't been sent yet. Just find and select it on the calendar to open the record, and then edit the schedule or select **Delete** on the command bar, as needed.

Posts that were already sent are read-only, so you can't change or reschedule them, but you can remove them from the calendar if you want.