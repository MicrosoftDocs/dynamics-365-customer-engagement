---
title: Configure Microsoft Teams chat in Dynamics 365 Sales 
description: Enable Teams chat to help users effectively collaborate on their sales records without having to leave the application.
ms.date: 07/26/2024
ms.topic: article
author: sbmjais
ms.author: shjais
ms.reviewer: shjais 
---

# Configure Microsoft Teams chat in Dynamics 365 Sales

Enable Teams chat to help users effectively collaborate on their sales records without having to leave the application.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | <ul><li>Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, Dynamics 365 Sales Professional, or any Dynamics 365 customer engagement app license</li> <li>Microsoft Teams license</li></ul>  <br>More information: <ul><li>[Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/)</li><li>[Microsoft Teams pricing](https://www.microsoft.com/microsoft-teams/compare-microsoft-teams-options?activetab=pivot:primaryr2&rtc=1)</li><li>[Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409)</li></ul> |
| **Security roles** | System Administrator<br>  More information: [Predefined security roles for Sales](../security-roles-for-sales.md)|

## Overview

As an administrator, you can configure the ability for sellers to chat in Microsoft Teams from within the Sales Hub app and custom apps. This helps with effective collaboration on the sales records without having to leave the application.

> [!NOTE]
> Teams settings apply across all customer engagement apps. So, whether you enable the feature from Sales Hub or a custom app, it'll be enabled for all supported customer engagement apps.

When the feature is enabled, while working on sales records, sellers can start a new chat or connect an existing chat to a record, and thus collaborate efficiently without switching context or leaving the application. Connecting all the associated chats to a record can help sellers maintain all the chats related to the record in one place. You can also configure an optional introduction message that sellers can use to provide further context when collaborating on Teams.

## Enable or disable Teams chat

1. In the Sales Hub app, select **Change area** ![Icon to change the work area](media/change-area-icon.png) in the lower-left corner, and then select **App Settings**.

2. Under **General Settings**, select **Chat and collaborate**.

3. Turn on the toggle for **Turn on Microsoft Teams chats inside Dynamics 365**.

4. Select one of the following:

    - **Turn on for all Dynamics 365 apps** – Enables Teams chat for all supported Dynamics 365 apps in your organization, including any that you add in the future.
    - **Turn on for selected Dynamics 365 apps** – Enables Teams chat for the apps you choose. If your organization already uses Teams, the selection you made previously remains.

    :::image type="content" source="media/teams-settings.png" alt-text="Teams settings page showing toggle set to Yes.":::

5. Save the changes.

Teams chat is now enabled for all Dynamics 365 apps of the apps you selected. You can open a record and verify whether you're able to view the chats and channels related to the record. More information: [Open Teams chats and channels related to a record](using-teams-chat-in-dynamics.md#open-teams-chats-and-channels-related-to-a-record)

> [!NOTE]
> Teams chat is enabled by default for the Customer Service workspace and Customer Service Hub apps.


## Add the Teams settings page to the sitemap of a custom app

1. Sign in to [Power Apps](https://make.powerapps.com/).

2. Select the environment, and then select **Apps**. 

3. Select your custom app, and then select **Edit**.

4. In the **App Designer**, edit the **Site Map**.

5. To add the Teams **Chat and collaborate** settings page, add a subarea component, and then from the **Type** list, select  **URL**.

6.  Copy the following value and paste it into the **URL** field:  
    ```/main.aspx?pagetype=control&controlName=MscrmControls.TeamsCollaborationAdmin.TeamsCollaborationAdmin```

7. Save and publish the changes.


## Enable Teams chat from Power Platform admin center

1. Sign in to [Power Platform admin center](https://admin.powerplatform.microsoft.com).

2. Go to the **Environments** tab, select an environment in which you want to enable Teams chat.

3. On the **Environments** page, select **Settings**.

4. On the **Settings** page, expand **Integration**, and then select **Teams integration settings**.

    :::image type="content" source="media/ppac-teams-chat.png" alt-text="Enable Teams chat from Power Platform admin center":::

5. On the **Microsoft Teams collaboration and chat** page, turn on the **Turn on Microsoft Teams chats inside Dynamics 365** toggle.
        
    :::image type="content" source="media/teams-settings.png" alt-text="Teams settings page showing toggle set to Yes.":::

6. Save the changes.

## Configure the ability to connect chats to Dynamics 365 records

After you enable Teams chats, you can connect the chats to different record types. Standard record types, including case, account, contacts, knowledge article, and email, are available out-of-the-box, or you can add your desired record type.

1. In the Sales Hub app, select **Change area** ![Icon to change the work area](media/change-area-icon.png) in the lower-left corner, and then select **App Settings**.

2. Under **General Settings**, select **Chat and collaborate**.
   
1. Under **Connect chats to Dynamics 365 records**, select the record type you want to configure.<br>
   If you want to add a record type, see [Add record types](#add-record-types)
    
1. Select **Save**.

### Add record types

To add a record type to connect chats to in Dynamics 365 records:

1. In the Sales Hub app, select **Change area** ![Icon to change the work area](media/change-area-icon.png) in the lower-left corner, and then select **App Settings**.

2. Under **General Settings**, select **Chat and collaborate**.
   
1. Under **Connect chats to Dynamics 365 records**, select **Add record types**.
	
1. In the **Allow chats to be connected to this record type** pane, in **Choose record type**, type the name of the record type you want to use.
	
1. Turn on the toggles for settings as per your requirement, such as **Join chat** and **Automatically name chats**.
            
1. Select **Save**.

## Set the default name for connected chats

As an administrator, you can set the chat title to be used as the record title by default. Users can later change the title if they want.

1. In the Sales Hub app, select **Change area** ![Icon to change the work area](media/change-area-icon.png) in the lower-left corner, and then select **App Settings**.

2. Under **General Settings**, select **Chat and collaborate**.

3. Under **Connect chats to Dynamics 365 records**, select the record type (for example, Lead).

4. In the settings panel, turn on the **Automatically name chats** toggle.

    :::image type="content" source="media/lead-configure-auto-name.png" alt-text="Settings page for turning the automatically name chats feature on or off.":::

## Data security and privacy

The following data security and privacy considerations apply for Teams chat functionality in Dynamics 365:

- Dynamics 365 doesn't store any Teams data, except for the mapping between the record ID and the connected chat ID. No data from Teams is duplicated in Dynamics 365, unless the user manually adds it to the record notes or tasks.

- The communication between the applications is secured through TLS.

- Policies that apply both to Teams and Dynamics 365 are honored by the integration. For example, confidential files shared in a connected chat can only be accessed by permitted users. Similarly, a record shared in a Teams chat in Dynamics 365 can only be accessed if the user has permissions to view it.  

## Related information

[Use Microsoft Teams chat in Sales Hub](using-teams-chat-in-dynamics.md)  
[How to enhance sales productivity on deals using D365 & Teams (video)](https://youtu.be/cLulSxWepMQ) 
