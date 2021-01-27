---
title: "Configure Microsoft Teams dialer in Dynamics 365 Sales | MicrosoftDocs"
description: "How to configure Microsoft Teams dialer in Dynamics 365 Sales."
ms.date: 01/29/2021
ms.service: dynamics-365-sales
ms.custom: dyn365-sales
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Configure Microsoft Teams dialer

> [!IMPORTANT]
> - Microsoft Teams dialer<!--note from editor: Or should this be "Conversation intelligence" instead?--> is a preview feature. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
> - [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
> - [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

Microsoft Teams dialer helps sellers to be more productive and get work done more effectively by calling customers directly from within Dynamics 365 apps.<!--note from editor: Does this truly apply to all Dynamics 365 apps (including Finance and Operations)? If not, can you name the actual apps (or even use "customer engagement apps", if it fits? (see https://styleguides.azurewebsites.net/Styleguide/Read?id=2858&topicid=44518)).-->
As an administrator, you must configure Microsoft Teams dialer for sellers to use. Perform the following steps:

1.	[Review the prerequisites](#review-the-prerequisites).
2.	[Configure the dialer](#configure-the-dialer).

## Review the prerequisites

Review the following requirements before you configure Microsoft Teams dialer in your sales app:<!--note from editor: Should this be "Dynamics 365 Sales or Sales Hub," or something similar? I don't think "sales app", lowercase, is specific enough.-->
-	You must have an administrator or equivalent security role. More information: [Assign a security role to a user](https://docs.microsoft.com/power-platform/admin/create-users-assign-online-security-roles#assign-a-security-role-to-a-user)
-	Your organization has a phone system installed, with a valid license to use it. More information: [Set up Phone System in your organization](https://docs.microsoft.com/MicrosoftTeams/setting-up-your-phone-system)
-	You have a license for using Microsoft Teams. More information: [Microsoft Teams add-on licenses](https://docs.microsoft.com/MicrosoftTeams/teams-add-on-licensing/microsoft-teams-add-on-licensing?tabs=small-business)

## Configure the dialer

1.	Sign in to your sales app.<!--note from editor: See note in line 28.-->     
2.	Go to **App settings**, and under **General settings**, select **Teams calls (preview)**.    
    > [!div class="mx-imgBorder"]
    > ![Microsoft Teams dialer configuration page](media/teams-dialer-configuration-page.png "Microsoft Teams dialer configuration page")     
3.	In the **What you need to set up Microsoft Teams calls** section, the application validates that your organization has sufficient privileges to use **Phone system** and **Microsoft Teams**.
    - Upon successful validation, the status corresponding to **Phone system license** and **Teams license** displays **Status: Successfully set up**. Proceed to step 4.
        > [!div class="mx-imgBorder"]
        > ![Phone system and Microsoft Teams licenses successful validation](media/teams-dialer-systems-validation-successful.png "Phone system and Microsoft Teams licenses successful validation")      
    - <a name="tenant-admin-contact"></a> If any of the validations fails, you can't proceed with the configuration. You must contact your tenant administrator to set up the phone system and Microsoft Teams for your organization. 
    When the tenant administrator completes the configuration of [phone system](https://docs.microsoft.com/MicrosoftTeams/setting-up-your-phone-system) and [Teams licenses](https://docs.microsoft.com/MicrosoftTeams/teams-add-on-licensing/microsoft-teams-add-on-licensing?tabs=small-business), you can continue with the configuration. Select **Check status**.
        > [!div class="mx-imgBorder"]
        > ![Phone system and Microsoft Teams licenses failed validation](media/teams-dialer-systems-validation-failed.png "Phone system and Microsoft Teams licenses failed validation")
4.	Select **Enable preview**.
    >[!NOTE]
    >The **Enable preview** option will only be available after the phone system and Microsoft Teams licenses are successfully validated.
    
    > [!div class="mx-imgBorder"]
    > ![Enable the preview](media/teams-dialer-enable-preview.png "Enable the preview") 
5.	In the **Security role** section, select one of the following options to provide permissions to users to view Microsoft Teams dialer. 

    | Option | Description |
    |--------|-------------|
    | All security roles | This option provides access to view Microsoft Teams dialer to users in all the security roles in your organization. |
    | Specific security roles | This option allows you to specify security roles when you want to give access to view Microsoft Teams dialer to specific users. |

    > [!div class="mx-imgBorder"]
    > ![Select security roles](media/teams-dialer-select-security-roles.png "Select security roles")
6.	Select **Advanced options**, and in the **Select app** drop-down list, select and add apps such as your custom apps. By default, **Sales Hub** is selected.<!--note from editor: In this screenshot, what does "Dynamics 365 UCI apps" mean? UCI is an obsolete term for "Unified Interface," and even so this doesn't tell me which apps you're talking about.-->
    > [!div class="mx-imgBorder"]
    > ![Select apps to use Microsoft Teams dialer](media/teams-dialer-select-apps.png "Select apps to use Microsoft Teams dialer")

    >[!NOTE]
    >When Microsoft Teams dialer is enabled in your organization for an app, other telephony systems that are connected to the app through Dynamics 365 Channel Integration Framework<!--note from editor: This always requires "Dynamics 365" in front of it, see https://styleguides.azurewebsites.net/StyleGuide/Read?id=2858&topicid=44486--> will stop working. As an administrator, you can deactivate or delete the Dynamics 365 Channel Integration Framework phone system. Follow these steps:
    >1.	Go to your **Channel Integration Framework** app.
    >2.	From the **Active Channel Providers** view, select the phone system.
    >3.	From the **Tool** bar<!--note from editor: Is "Tool" really the name in the UI? Or should this just be "From the toolbar, select..."?-->, select **Deactivate** or **Delete** according to your requirements.

7.	Save and publish the configuration.
    A confirmation message is displayed, and the Microsoft Teams dialer is enabled in your organization for selected security roles in the selected app. 
    >[!NOTE]
    >You must refresh the configuration page to make the changes available in the application. 

### See also

[Microsoft Teams integration](../teams-integration/teams-integration.md)     
[Call a customer](https://docs.microsoft.com/dynamics365/ai/sales/connect-with-customers#call-a-customer)      
[View and understand call summary pages](https://docs.microsoft.com/dynamics365/ai/sales/view-and-understand-call-summary)
