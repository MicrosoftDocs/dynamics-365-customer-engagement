---
title: Frequently asked questions about messaging extensions
description: Use this topic to find frequently asked questions (FAQs) and answers about messaging extensions.
ms.date: 05/24/2022
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
---

# Frequently asked questions

We've compiled a list of frequently asked questions and provided brief answers to help you get to your information quickly.

**How are the Dynamics 365 messaging extension and the Dynamics 365 app for Teams related?**

The Dynamics 365 messaging extension is a part of the Dynamics 365 app for Teams. You get access to the messaging extension when you install the Dynamics 365 app for Teams. Conversely, if you want to access the messaging extension, you need to install the Dynamics 365 app for Teams.

**If I'm already using (and therefore have installed) the Dynamics 365 app for Teams, do I need to do any installation to access the messaging extension?**  

If you're already using (and therefore have installed) the Dynamics 365 app for Teams, you'll find the Dynamics 365 app in the messaging extensions (…) list in the compose toolbar. But, it may not be pinned.

**If I install the Dynamics 365 app from the messaging extension (…) compose toolbar in a chat, will it also add a personal dashboard to Teams?**

If you install the Dynamics 365 app from the messaging extension (…) compose toolbar in a chat, it will add a personal dashboard to Teams. You'll need to configure it before use when you first access the personal dashboard.

**Can I search and share custom table records using the Dynamics 365 app?**  

You can search and share custom table records using the Dynamics 365 app. The **All** tab in the Dynamics 365 app will allow you to search on all tables, including custom tables. The search in **All** tab is powered by [Dataverse Search](/power-platform/admin/configure-relevance-search-organization) if it is enabled on the organization; otherwise, it defaults to [Categorized search](/powerapps/user/quick-find#multiple-table-quick-find-categorized-search). The tabs in the search fly-out show the most recently used records across tables by default (before you start a search).

**How does the application pick the information to show in the card about a record I choose to share?**

The application shows the fields that are included in the **Quick Find View** view of the table to which the record belongs.

**How do I change the information that appears on a card after I choose a record to share?**

You can change the information that appears on a card by changing the columns included in the **Quick Find View** view of the table to which the record belongs. For performance optimizations, it takes about 24 hours to refresh the view metadata cached in the Dynamics 365 app for Teams and the changes to the quick find views would automatically flow when the search is accessed the next time.

**Can I change the action buttons on a card?**

You can't change the action buttons on a card.

**Does the card refresh? Or does it show static information as at the time of insertion of the card?**

The card is reloaded or refreshed every time you open the chat in which the card is inserted.

**What happens if I inadvertently share a record with someone who doesn't have permissions to view the record on Dynamics 365?**

Only users who are authorized to access the record on Dynamics 365 are allowed to view the information on the card. Those who don't have permissions will see a message calling out their lack of permissions.

**Can I see who in my channel has access to a record I have shared?**

The app or the card doesn't call out who has (or doesn't have) permissions to the card you're sharing. However, the card details will be visible only to those who have access to the record in Dynamics 365.

**Can I connect to multiple environments using the Dynamics 365 app?**

You can connect only to one environment at a time.

**Can I connect to multiple applications using the Dynamics 365 app?**

You can connect only to one application at a time. Note that you can search and insert any record you have access to in the environment to which you are connected. The application you choose when setting up the app is used only to generate the deep link to record for directing users when they select **Open in Dynamics** on the card. Users will still be able to view a record that is in the environment but not in the app that is set up.

**Can I connect to different environments or applications in different chats where I use the Dynamics 365 app?**

When you change the settings of the app, you are changing it for all chats and environments.

**What happens to the messages with cards in a chat when I uninstall the Dynamics 365 app?**

The cards continue to display the record information to the user even after the user uninstalls the Dynamics 365 app in Teams. The cards would auto refresh as well. However, when the user selects **View details** on the card, they would see the app installation dialog box again.

**Why do messages containing attachments or media not get copied to Dynamics 365 while using the **Add to Dynamics 365** action?**  

We don't support copying over of messages with media such as files, images, videos, and adaptive cards to Dynamics 365. The messages with simple and rich text information with less than 3,000 characters gets automatically copied.

**Is the Dynamics 365 app supported on mobiles devices?**

We don't support adaptive cards or the Dynamics 365 app on mobile devices yet. Some of the experiences might be broken in mobiles but we aren't supporting these clients.

