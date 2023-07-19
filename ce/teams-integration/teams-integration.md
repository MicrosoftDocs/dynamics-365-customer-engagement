---
title: "Overview of Microsoft Teams integration with Dynamics 365 apps"
description: "Dynamics 365 for Microsoft Teams integration enables users to easily work with customer engagement apps and share files directly from Microsoft Teams."
ms.date: 05/26/2023
ms.topic: article
author: sbmjais
ms.author: shjais
---

# Overview of Microsoft Teams integration

In today's business scenario, business groups often collaborate across departments while working on a marketing campaign, pursuing a sales opportunity, or solving a customer issue. Dynamics 365 and Microsoft Teams integration allows you to speed up the flow of work, enabling anyone in an organization to view and collaborate on Dynamics 365 records, from within the flow of work with Teams—at no additional cost. 

Using Teams integration, you can invite anyone in the organization to view and collaborate on customer records right within a Teams chat or channel. You can also make and receive calls from within Dynamics 365 and get the work done more effectively. As a seller, you can share details on the sales opportunity, customer history, and more. As a customer service representative, you can share the customer case record, troubleshooting steps, and track the follow-up tasks.

Teams can be integrated with Dynamics 365 Sales, Dynamics 365 Customer Service, Dynamics 365 Field Service, Dynamics 365 Marketing, and Dynamics 365 Project Service Automation.

> [!NOTE]
> Microsoft Teams integration is not supported on the following: 
> 
>  - Dynamics 365 Customer Engagement (on-premises)
>  - Microsoft Dataverse environment
>  - Legacy web client or legacy apps
>  - If Dynamics 365 and Microsoft Teams are in different tenants
>  - Mobile devices


Dynamics 365 and Teams integration is built around the following pillars:

- **Collaborate seamlessly**: Invite anyone in your organization to view and contribute to Dynamics 365 customer records within the flow of a Teams chat or channel.

- **Accelerate productivity**: Connect conversations across the organization. Meet, chat, call, and collaborate in Dynamics 365.

- **Enhance engagement**: Bring related conversations together with real-time contextual and suggested chats, and capture customer sentiment to stay in tune with their needs. 

- **Integrate experiences**: Increase audience engagement during and after events across multiple channels with engaging content and recommendations.


## Features of Teams integration

Microsoft Teams is integrated into Dynamics 365 and additional capabilities are added to bring Dynamics 365 data into Teams. This helps you in connecting and collaborating in the flow of work with anyone, anywhere with Dynamics 365 and Microsoft Teams.

- **In Dynamics 365**

  - **Engage in Teams chat**: You can engage in a Teams chat conversation from within Dynamics 365 while working on a record. More information: [Using Microsoft Teams chat in Dynamics 365](../sales/teams-integration/using-teams-chat-in-dynamics.md)

  - **Link Dynamics 365 records to Teams channels**: You can easily connect a Dynamics 365 record to an existing Teams channel or create a new team or channel. More information: [Enhanced Collaboration Experience with the Dynamics 365 app for Microsoft Teams](../sales/teams-integration/teams-collaboration-enhanced-experience.md)

  - **Embedded Teams calling**: Boost seller's productivity by making and receiving Teams calls directly in Dynamics 365. Avoid the need to switch apps, get calls automatically recorded in the relevant record's timeline and save your call notes directly where you need them.  More information: [Call customers through Microsoft Teams dialer in Dynamics 365 Sales](../sales/call-using-microsoft-teams.md)
  
  - **Integrate Dynamics 365 and Teams meetings**: Microsoft Teams meeting integration allows you to stay in the flow of work, whether you're in Dynamics 365 or Teams. In Dynamics 365, you can create and join Teams meetings directly from Dynamics 365. More information: [Integrate Dynamics 365 and Teams meetings](../sales/teams-integration/teams-meeting-integration.md)

- **In Microsoft Teams**

  - **Display a record or view in tab**: You can add a Dynamics 365 record or a view as tabs into a Teams channel. For example, you can add a tab for an account named Fourth Coffee. When you select the tab, the record’s detail is displayed in its form. Similarly, you can add the view My Open Opportunities as a tab. When you select the tab, you see all your open opportunities. More information: [Basic Collaboration Experience with the Dynamics 365 app for Microsoft Teams](../sales/teams-integration/teams-collaboration.md)

  - **File integration**: You can co-author documents using Microsoft 365 and automatically sync with Dynamics 365 records that are linked to a Teams channel. Files uploaded to a Teams channel are associated with the Dynamics 365 record. Similarly, files uploaded to the linked Dynamics 365 record are visible in the Teams channel. More information: [Document management with Microsoft Teams integration](teams-doc-management.md)

  - **Personal dashboard**: You can use the Dynamics 365 app to set up and view your personal dashboard in Teams. More information: [View your personal dashboard with the Dynamics 365 app for Microsoft Teams](teams-personal-use.md)
  
  - **Work with Dynamics 365 records in a Teams meeting**: With Microsoft Teams meeting integration, you can:
      - View and update Dynamics 365 records seamlessly in a Teams meeting.
      - Capture notes and tasks seamlessly during a Teams meeting. Your notes and tasks automatically sync to Dynamics 365.
    
    More information: [Configure Microsoft Teams meeting integration in Dynamics 365](teams-meeting-integration.md)



## Questions and feedback

 If you have additional feedback or questions regarding this feature, contact Microsoft Support.

## Privacy notice

While using customer engagement apps in a Dynamics 365 bot in Microsoft Teams, the user’s text inputs are analyzed for understanding the underlying query/intent. The user’s input such as “Search account Contoso” is routed to a service within Azure Cognitive Services called Language Understanding (LUIS). [Read more about LUIS.](https://www.luis.ai/) The LUIS service disambiguates or understands the intent of user input (in this case, the intent is to find information) and the target entity (in this case, the intended entity is an account named Contoso). This information is then passed on to Microsoft’s [Azure Bot Service](https://azure.microsoft.com/services/bot-service/), which interacts with Dynamics 365 data and retrieves the desired information for the user query.

By installing and allowing access to use of the bot, you agree to allow the LUIS service and Azure Bot Service to process the intent behind the input – which results in an enhanced conversational user experience. The LUIS service and Azure Bot Service may have varying levels of compliance compared to Dynamics 365 Sales apps. While the LUIS service has access to only the user queries and is not designed to be connected to the user’s Dynamics 365 data or account, a user of the Dynamics 365 Sales bot could voluntarily enter a query containing Customer Data, Personal Data or other data and such query content could get sent to the LUIS service and Azure Bot Service. 

The content of user’s queries and messages is retained in the LUIS system for a maximum of 30 days, encrypted at rest and is not used for training or service improvement. Read more about [Cognitive Services](https://azure.microsoft.com/services/cognitive-services/language-understanding-intelligent-service/). 

To manage admin settings for apps in Microsoft Teams, go to the Microsoft 365 admin center and open **Settings** > **Services & add-ins**, then choose Microsoft Teams. If you're signed in as a Microsoft 365 admin, you can [access these controls here](https://admin.microsoft.com/adminportal/home#/Settings/ServicesAndAddIns), including the ability to uninstall.


### See also
- [Download and install Microsoft Teams](https://support.office.com/article/download-and-install-microsoft-teams-422bf3aa-9ae8-46f1-83a2-e65720e1a34d)
- [Microsoft Teams help center](https://support.office.com/teams)



[!INCLUDE[footer-include](../includes/footer-banner.md)]
