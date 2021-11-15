---
title: "Enable or disable Teams chat in Dynamics 365 | MicrosoftDocs"
description: "Enable Teams chat to help users effectively collaborate on their Dynamics 365 customer engagement records without having to leave the application."
ms.date: 11/03/2021
ms.topic: article
ms.service: crm-online
search.app: 
  - D365CE
  - Powerplatform
author: sbmjais
ms.author: shjais
manager: shujoshi
---
# Preview: Enable or disable Microsoft Teams chat in Dynamics 365

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

As an administrator, you can enable the preview to help your users effectively collaborate on their Dynamics 365 customer engagement records without having to leave the application. This feature requires certain permissions to access Microsoft Teams data. Review the [FAQ on Dynamics 365 integration with Microsoft Teams](teams-in-dynamics-faq.md) and [Data security and privacy](#data-security-and-privacy) sections to know more.


## Access Teams chat and collaborate settings in Dynamics 365

To enable Teams chat in Dynamics 365, you need to access the **Chat and collaborate** settings page by doing one of the following:  

- If you're using the Sales Hub app, use the **App Settings** page.

- If you're not using the Sales Hub app, add the settings page to the site map of your app.

> [!NOTE]
> Teams settings are in effect across all customer engagement apps. So, whether you enable the preview from the Sales Hub app or a custom app, it will be enabled for all the supported customer engagement apps.

### Access settings in Sales Hub

1. In the Sales Hub app, select **Change area** ![Icon to change the work area](media/change-area-icon.png) in the lower-left corner, and then select **App Settings**.

2. Under **General Settings**, select **Chat and collaborate**.

### Add the Teams settings page to a custom app

1. Sign in to [Power Apps](https://make.powerapps.com/).

2. Select the environment, and then select **Apps**. 

3. Select your custom app, and then select **Edit**.

4. In the **App Designer**, edit the **Site Map**.

5. To add the Teams **Chat and collaborate** settings page, add a subarea component, select the **Type** as **URL**, and copy the following value to the **URL** field:  
    ```/main.aspx?pagetype=control&controlName=MscrmControls.TeamsCollaborationAdmin.TeamsCollaborationAdmin```

6. Save and publish the changes.

## Enable or disable the preview

1. Access the **Chat and collaborate** settings page.

2. Turn on the **Turn on Microsoft Teams chats inside Dynamics 365 (preview)** toggle.
    > [!IMPORTANT]
    > You must be a global administrator (tenant administrator) to provide the initial consent. After that, application administrators can enable the preview for other instances.

3. To set the chat title to be used as the record title by default, turn on the **Use record title as the default chat name for linked chats** toggle. Users can change the title if they want.
    :::image type="content" source="media/teams-settings.png" alt-text="Teams settings page showing these two toggles set to Yes.":::

4. Save the changes.

The preview is now enabled for all the customer engagement apps. You can open a record and verify whether you're able to view the chats and channels related to the record. More information: [Open Teams chats and channels related to a record](using-teams-chat-in-dynamics.md#open-teams-chats-and-channels-related-to-a-record)


## Data security and privacy

The following data security and privacy considerations apply for Teams chat functionality in Dynamics 365:

- Dynamics 365 doesn't store any Teams data, except for the mapping between the record ID and the linked chat ID. No data from Teams is duplicated in Dynamics 365, unless the user manually adds it to the record notes or tasks.

- The communication between the applications is secured through TLS.

- Policies that apply both to Teams and Dynamics 365 are honored by the integration. For example, confidential files shared in a linked chat can only be accessed by permitted users. Similarly, a record shared in a Teams chat in Dynamics 365 can only be accessed if the user has permissions to view it.  

- The app requires certain permissions to start a chat, display suggested contacts, show presence, and so on. For more information, go to [What are the privileges and type of permissions required by the integration?](teams-in-dynamics-faq.md#what-are-the-privileges-and-types-of-permissions-required-by-the-integration).  


### See also

[Engage in Microsoft Teams chats from within Dynamics 365](teams-collaboration-in-dynamics.md)  
[Using Microsoft Teams chat in Dynamics 365](using-teams-chat-in-dynamics.md)  
 
