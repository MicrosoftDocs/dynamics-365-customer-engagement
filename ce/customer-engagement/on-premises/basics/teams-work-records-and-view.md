---
title: "Work with Teams integration| MicrosoftDocs"
ms.custom: 
description: "Work with Teams integration"
ms.date: 8/05/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
ms.assetid: 8097c9ec-023b-407d-ac0e-074b5e1964a5
caps.latest.revision: 1
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - enduser
search.app: 
  - D365CE
  - Powerplatform
---
# Work with Teams integration

Once Team integration is set up, you can start working with Dynamics 365 customer information and share files directly from Microsoft Teams.

## Open a record or view in Dynamics 365 for Customer Engagement apps

It's easy to use Teams to open a record or view in Dynamics 365 for Customer Engagement apps. From the Dynamics 365 tab pinned in a Teams channel, select the **Go to website** button to open the record or view in Dynamics 365 for Customer Engagement apps.

> [!div class="mx-imgBorder"] 
> ![Open a record in Dynamics 365 for Customer Engagement apps](media/teams-open-record-d365.png "Open a record in Dynamics 365 for Customer Engagement apps")

## Have a conversation
You can chat with your team members side-by-side with the Dynamics 365 tab. From the Dynamics 365 tab pinned in a Teams channel, select the **Show tab converation** button to open the conversation tab.

> [!div class="mx-imgBorder"] 
> ![Start a conversation](media/teams-start-conversation.png "Start a conversation")


### If you see this message: Shared files exist in multiple locations. Select "Document Location" to see files in other locations.

> [!div class="mx-imgBorder"] 
> ![Shared files in multiple locations](media/teams-error-multiple-locations.png "Shared files in multiple locations")

When there is more than one Microsoft Teams channel connected to a Dynamics 365 for Customer Engagement apps record, each of the channels appears as a separate document location in Dynamics. You can switch to a different location by selecting **Document Location** to specify the location of the file.

> [!div class="mx-imgBorder"] 
> ![Change document location](media/teams-change-document-location.png "Change document location")


To view a consolidated file list across all document locations including all connected team channel file libraries, from **Document Location** select **All Locations**.

> [!div class="mx-imgBorder"] 
> ![Document location](media/doclocation.png "Document location")


> [!div class="mx-imgBorder"] 
> ![Document location](media/doclocation1.png "Document location")

## Record types supporting Collaborate    

Currently, the following record types only support Microsoft Teams collaborate capabilities in Dynamisc 365 Customer Engagement app. The **Collaborate** button and file share feature will only work with the record types listed below in Dynamisc 365 Customer Engagement app.

> [!NOTE]
   >  The list below shows the logical name of an entity (not the display name).
 
- Account
-	Agreement
-	Annotation
- Appointment
-	Businessunit
-	Campaign
-	Case
-	Category
-	Competitor
-	Contact
-	Email
-	Expense
-	Fulfillment Preference
- Inventory Adjustment
-	Inventory Transfer
-	Invoice
-	Kbarticle
-	Knowledge Article
-	Lead
-	Opportunity
-	Opportunityproduct
-	Order
-	Product
-	Project
-	Purchase Order
-	Purchase Order Receipt
-	Quote
-	Resource Request
-	RMA
-	RMA Receipt
-	RTV
-	Sales Literature
-	Task
-	Team
-	Work Order

If not enabled, users can still connect Dynamics 365 for Customer Engagement apps records to Microsoft Teams but the connected Microsoft Teams channel and the file library do not appear in Dynamics 365 for Customer Engagement apps.

When the feature is enabled, the collaboration feature is enabled only for a selected set of system entities. If you want to enable Microsoft Teams integration for additional entities or custom entities, you can only do it programmatically using the **msdyn_SetTeamsDocumentStatus** Web API action. More information: [Enable or disable Microsoft Teams Integration using code](../developer/integration-dev/teams-integration-using-code.md)

