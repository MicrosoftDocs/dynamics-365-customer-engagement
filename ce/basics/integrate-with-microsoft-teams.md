---
title: "Preview: Integrate Dynamics 365 Customer Engagement with Microsoft Teams| MicrosoftDocs"
ms.custom: ""
description: "Integrate Dynamics 365 Customer Engagement with Microsoft Teams."
ms.date: 10/30/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 8097c9ec-023b-407d-ac0e-074b5e1964a5
caps.latest.revision: 17
author: "jimholtz"
ms.author: "jimholtz"
manager: "kvivek"
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Preview: Integrate Dynamics 365 Customer Engagement with Microsoft Teams 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]  
> - [!INCLUDE[cc_preview_features_expect_changes](../includes/cc-preview-features-expect-changes.md)]  
> - Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren't meant for production use and are subject to a separate [supplemental terms of use](https://go.microsoft.com/fwlink/p/?linkid=870960).

If you're familiar with [Microsoft Teams](https://products.office.com/microsoft-teams/group-chat-software), you know it's the place to manage all your conversations, files, and tools in one team workspace. Create and edit documents right in the app and enjoy instant access to SharePoint, OneNote, PowerBI, and now, [!INCLUDE [pn-crm-online](../includes/pn-crm-online.md)].

Check out the following video to get a quick overview of Dynamics 365 and Teams can work together to make easy collaboration possible: [Dynamics 365 app for Microsoft Teams Demo Video](https://www.youtube.com/watch?v=U11x5BlQlDU&feature=youtu.be)
<!-- Cyndy will provide new video when it's published. -->

There are two areas of integration: 
- The Dynamics 365 app installed in Microsoft Teams
- In Dynamics 365 (online), you can see the connected Microsoft Teams channel and files synchronized between Teams app and Dynamics 365 (online)

## Dynamics 365 app in Teams
The Dynamics 365 (online) tab, when added to a Teams channel, provides a fully functional page in which you edit information and navigate to related records; all this without leaving Teams.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-pinned-record2.png "Dynamics 365 record tab")

You can also use the Dynamics 365 bot to look up and make a quick update on any record. The bot essentially brings Dynamics 365 (online) to you in a chat format.

> [!div class="mx-imgBorder"] 
> ![](media/teams-bot-welcome2.png "Use Dynamics 365 bot")

For more information on installing and configuring the personal app and bot, see: [Install the personal and team apps](install-personal-team-apps.md). 

## Teams integration in Dynamics 365 (online)

In Dynamics 365 (online) records, select **Collaborate** to display a list of all the connected team channels. Then, select a team channel to go to the relevant channel conversation in Teams.

> [!div class="mx-imgBorder"] 
> ![](media/teams-select-collaborate.png "From Dynamics 365, open a conversation in Teams")

In addition, document management actions in Dynamics 365 (online) are integrated with Teams. You can see the channel file library in Dynamics 365 (online) and directly upload files; uploaded files will appear in the Teams channel file library under the **Files** tab. Files uploaded in the Teams app will appear in the **Documents** tab in Dynamics 365 (online).

> [!div class="mx-imgBorder"] 
> ![](media/teams-documents-d365.png "Dynamics 365 document management in Teams")

### If you see this message: Shared files exist in multiple locations. Select "Document Location" to see files in other locations.

> [!div class="mx-imgBorder"] 
> ![](media/teams-error-multiple-locations.png "Shared files in multiple locations")

The record has been pinned to multiple Teams channels. In Dynamics 365 (online), select **Document Location** to specify the location of the file. 

> [!div class="mx-imgBorder"] 
> ![](media/teams-change-document-location.png "Change document location")

## Privacy notice

While using the Dynamics 365 for Sales bot in Microsoft Teams, the user’s text inputs are analyzed for understanding the underlying query/intent. The user’s input such as “Search account Contoso” is routed to one of Microsoft’s Cognitive Service called Language Understanding Intelligent Service (LUIS). Read more about LUIS [here](https://www.luis.ai/). The LUIS service disambiguates or understands the intent of user input (in this case, the intent is to find information) and the target entity (in this case, the intended entity is an account named Contoso). This information is then passed on to Microsoft’s [Azure bot framework](https://azure.microsoft.com/services/bot-service/) which interacts with Dynamics data and retrieves the desired information for the user query.

By installing and allowing access to use of the bot, you agree to allow the LUIS service and Azure Bot framework to process the intent behind the input – which results in an enhanced conversational user experience. The LUIS service and Azure bot framework  may have varying levels of compliance compared to Dynamics 365 for Sales. While the LUIS service has access to only the user queries and is not designed to be connected to the user’s Dynamics data or account, a user of the Dynamics 365 for Sales bot could voluntarily enter a query containing Customer Data, Personal Data or other data and such query content could get sent to the LUIS service and the Azure bot framework. 

The content of user’s queries and messages is retained in LUIS system for a maximum of 30 days, encrypted at rest and is not used for training or service improvement. Read more about Cognitive Services [here](https://azure.microsoft.com/services/cognitive-services/language-understanding-intelligent-service/). 

To manage admin settings for apps in Teams, go to the Office 365 admin center and open **Settings** > **Services & add-ins**, then choose Microsoft Teams. If you're signed in as an Office 365 admin, you can access these controls [here](https://portal.office.com/adminportal/home#/Settings/ServicesAndAddIns), including the ability to uninstall.

### See also
 [Download and install Microsoft Teams](https://support.office.com/article/download-and-install-microsoft-teams-422bf3aa-9ae8-46f1-83a2-e65720e1a34d)
 [Microsoft Teams help center](https://support.office.com/teams)