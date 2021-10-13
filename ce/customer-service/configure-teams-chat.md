---
title: "Configure Teams chats in Customer Service | Microsoft Docs"
description: "Learn how to configure Teams chat functionality in Dynamics 365 Customer Service and Dynamics 365 Customer Service workspace."
ms.date: 10/18/2021
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Configure Teams chat in Customer Service

You can configure the ability for agents to chat in Teams from within Dynamics 365 Customer Service Hub and Customer Service workspace. When the feature is enabled, while working on customer records, agents can start a new chat or link an existing chat to a record, and thus collaborate efficiently without switching context or leaving the application. Linking all the associated chats to a record can help agents maintain all the conversations related to the record in one place. 

## Enable or disable Teams chat

This feature requires certain permissions to access Teams data. Review the following permissions required section to learn more.

### Permissions required

As a tenant administrator, when you enable the Teams chat feature, the app has the following permissions:

|Permission | What the app does with the permission |
|-------------|-----------------------|
|Chat.ReadWrite.All |Reads user’s chats and recent messages to display in chat list. |
|Directory.Read.All	|Reads user’s teams and channels display name. |
|Presence.Read.All	|Reads presence information of all users to be displayed on the user avatars in chat list. |
|User.Read.All	|Reads users’ display name and licenses to validate if the suggested participants have a Teams license assigned. This is used by the suggested section in the chat list.|
|User.ReadBasic.All	|Reads users’ photos. |


### Add the Teams chat settings page to the sitemap of your app
1.	In the Customer Service Hub app, select **Change area** in the lower-left corner, and then select **Service Management**.

2.	Under **Microsoft Teams Integration**, select **Collaboration**.

3.	Toggle **Turn on Microsoft Teams chats inside Dynamics 365 (preview)** and **Use record title as the default chat name for linked chats** to **Yes**.

    > [!div class="mx-imgBorder"] 
    > ![Enable the Microsoft Teams chat experience in Dynamics 365 Customer Service.](media/teams-chat-enable-cs.png)
    
4.	Save the changes.<br>
    The preview is now enabled for the Dynamics 365 Customer Service Hub and Customer Service workspace (and also Field Service and Sales customer engagement apps, if you're using them). You can open a record and verify if you’re able to view the chats and channels related to the record. See Open Teams chats and channels related to a record.
    
    
### Add the Teams chat settings page for specific multisession users
If you want Teams chat to work for specific users, you can enable the feature for your custom profile. For more information about creating custom profiles in App profile manager, see [Overview of App profile manager](/dynamics365/app-profile-manager/overview).

To enable Teams chat settings for specific multisession users, complete the following steps:
1. Go to [Power Apps](https://make.powerapps.com/), and then under **Environments**, select your environment.

2. In the left-side pane, select **Apps**, and then next to the custom app, select the **More Commands** ellipsis.

    > [!div class="mx-imgBorder"] 
    > ![Configure Teams chat settings for specific multisession users.](media/teams-chat-more-commands.png)

3. From the dropdown menu, select **App profile manager**, select your custom profile, and then select **Edit**.

4. Select the **Productivity pane** tab, and then toggle **Turn on productivity pane** to **On**.

5. Under **Productivity tools**, toggle **Microsoft Teams collaboration** to **On**.

6. Select the **General** tab to assign users. More information: [Assign profiles to users](/dynamics365/app-profile-manager/app-profile-manager#assign-profiles-to-users)

## Configure the ability to link chats to Dynamics 365 records

Once you’ve enabled Teams chats, you can link the chats to different record types. Standard record types, including case, conversation, account, contacts, knowledge article, and email, are available out of the box, or you can add your desired record type.

### To configure the ability to link a chat to a record type:

1.	In Customer Service Hub, open the **Microsoft Teams collaboration and chat settings** page.

2.	Under **Link chats to Dynamics 365 records**, select the record type you want to configure.<br>
  	If you want to add a record type, see Add record types in the section below.
    
3.	Select **Save**.

### To add a record type to link chats to in Dynamics 365 records:

1.	In Customer Service Hub, open the **Microsoft Teams collaboration and chat settings** page.
	
2.	Under **Link chats to Dynamics 365 records**, select **Add record types**.
	
3.	In the **Link chat to record type** pane, in **Choose record type**, type the name of the record type you want to use.
	
4.	(Optional): If you want to display content for new linked chats, toggle **Introduction message** to **Yes**, and then type the message you want to use. If you turn on this context card, a **Message view** dropdown menu is displayed, where you can do the following:
    a.	Select a message view you want to use, and then enter the relative details.
    Or
    b.	Create a custom view in Power Apps.
    
5.	Select **Save**.

For any view that's selected, keep in mind the following details:
 - The first five fields of any view are used as the context card details (in addition to a link to the record).
 - If a field isn't supported, it's skipped and the display will include the first four fields that are supported. You'll be able to see from the configuration experience that the specific field isn't supported.
 
    > [!div class="mx-imgBorder"] 
    > ![View for supported fields and message for an unsupported field.](media/teams-chat-unsupported-field-type.png)
    
 - Because the data fields are static, field-level permissions aren't checked for collaborators. This means if the agent has the field-level permissions to show data fields, collaborators will also be able to see those fields.
- If you don't select a view, agents will only see the default, out-of-box **Case introduction message** view.

    > [!div class="mx-imgBorder"] 
    > ![Default case introduction message view.](media/teams-chat-case-intro-message-view.png)

