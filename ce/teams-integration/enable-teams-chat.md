---
title: "Enable or disable Teams chat in Dynamics 365 | MicrosoftDocs"
description: "Enable Teams chat to help users effectively collaborate on their Dynamics 365 customer engagement records without having to leave the application."
ms.date: 08/13/2021
ms.topic: article
ms.service: crm-online
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---
# Admin: Enable or disable Teams chat in Dynamics 365 (preview)

Enable the preview to help your users effectively collaborate on their Dynamics 365 customer engagement records without having to leave the application. This feature requires certain permissions to access Teams data. Review the [Permissions required](#permissions-required) and [Data security and privacy](#data-security-and-privacy) sections to know more.


## Access Teams Chat and collaborate settings in Dynamics 365

To enable the Teams chat in Dynamics 365, you need to access the **Chat and collaborate** setting page.  

-   If you're using the Sales Hub app, use the **App Settings** page to access the settings page.

-   If you're not using the Sales Hub app, add the settings page to the sitemap of your app.

> [!NOTE]
> The Teams settings are common across all the customer engagement apps. So, even if you enable the preview from the Sales Hub app or a custom app, it is enabled for all the supported customer engagement apps.

### Access settings in Sales Hub

1.  In the Sales Hub app, select **Change area** ![Icon to change the work area](media/change-area-icon.png) in the lower-left corner, and then select **App Settings**.

2.  Under **General Settings**, select **Chat and collaborate**.

### Add Teams settings page to custom app

1.  Sign in to [Power Apps](https://make.powerapps.com/).

2.  Select the environment and then select **Apps**. 

3.  Select your custom app, and then select **Edit**.

4.  In the **App Designer**, edit the **Site Map**.

5.  To add the Teams **Chat and collaborate** settings page, add a subarea component, select the **Type** as **URL** and copy the following value to the **URL** field:  
    ```/main.aspx?pagetype=control&controlName=MscrmControls.FieldControls.CCFadminsettings&data={"id":"overview","ismanage":"cnc"}```

6. Save and publish the changes.
    
## Enable or disable the preview

**To enable or disable the preview**

1.  Access the **Chat and collaborate** settings page.

2.  Toggle the **Microsoft Teams chats inside Dynamics 365 (preview)** option.

3.  To set the chat title as the record title by default, turn on the **Use record title as the default chat name for linked chats** option. Users can change the title if they want.
    :::image type="content" source="media/teams-settings.png" alt-text="Teams settings page":::

4.  Save the changes.

The preview is now enabled for all the customer engagement apps. You can open a record and verify if you're able to view the chats and channels related to the record. See [Open Teams chats and channels related to a record](using-teams-chat-in-dynamics.md#open-teams-chats-and-channels-related-to-a-record).

## Permissions required

As a tenant administrator, when you enable this feature, you agree to give the following permissions to the app:

| **Permission**     | **What the app does with the permission**                                                                                                                              |
|--------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Chat.ReadWrite.All | Reads user's chats and recent messages to display in chat list.                                                                                                         |
| Directory.Read.All | Reads user's teams and channels display name.                                                                                                                           |
| Presence.Read.All  | Reads presence information of all users to be displayed on the user avatars in chat list.                                                                               |
| User.Read.All      | Reads display name and licenses of users to validate if the suggested participants have a Teams license assigned. This is used by the suggested section in the chat list. |
| User.ReadBasic.All | Reads users' photos.                                                                                                                                                  |

## Data security and privacy

The following data security and privacy considerations apply for the Teams chat functionality in Dynamics 365:

- Dynamics 365 doesn't store any of the Teams data, except for the mapping between the record ID and linked chat ID. No data from Teams is duplicated in Dynamics 365, unless the user manually adds them to the record notes or tasks.

- The communication between the applications is secured through TLS.

- Policies applicable in Teams and Dynamics 365 are honored by the integration. For example, confidential files shared on a linked chat can only be accessed by permitted users. Similarly, a record shared on Teams chat in Dynamics 365 can only be accessed if the user has permissions to view it.  

- The app requires certain permissions to start a chat, display suggested contacts, show presence, and so on. For more information, see [Permissions required](#permissions-required).  

### See also
- [Engage in Teams chats from within Dynamics 365 (Preview)](teams-collaboration-in-dymanics.md)
- [Using Teams chat in Dynamics 365](using-teams-chat-in-dynamics.md)
 