---
title: "Sync leads by using the Dynamics 365 Connector for LinkedIn Lead Gen Forms | Microsoft Docs"
description: "Learn how to set up and configure the Dynamics 365 Connector for LinkedIn Lead Gen Forms to sync leads from sponsored campaigns on LinkedIn to your Dynamics 365 organization."
keywords: linkedin lead gen, lead gen form, get started
ms.date: 04/02/2018
ms.service: dynamics-365-sales
ms.topic: article
applies_to:
  - Dynamics 365 Sales
ms.assetid: 13c8a439-30bc-45a4-bf4e-a25781148a4c
author: shubhadaj
ms.author: shujoshi
manager: sakudes
ms.custom:
  - dyn365-LinkedIn
search.audienceType:
  - admin
  - customizer
  - enduser
search.app:
  - D365CE
  - D365LinkedIn
---

# How to sync [!include[LinkedIn](../includes/pn-linkedin.md)] leads by using [!include[Dynamics 365 Connector for LinkedIn Lead Gen Forms](../includes/cc-linkedin-solution.md)]

[!include[Dynamics 365 Connector for LinkedIn Lead Gen Forms](../includes/cc-linkedin-solution.md)] enables seamless synchronization of [!include[LinkedIn](../includes/pn-linkedin.md)] leads to Dynamics 365 apps. [!include[LinkedIn](../includes/pn-linkedin.md)] members can drive leads from [Sponsored Content](https://business.linkedin.com/marketing-solutions/native-advertising) campaigns, based on a variety of calls to action. The [!include[LinkedIn Connector](../includes/pn-linkedin-solution-shortest.md)] lets campaign managers sync the leads from [LinkedIn's Lead Gen forms](https://business.linkedin.com/marketing-solutions/native-advertising/lead-gen-ads) to a Dynamics 365 instance for further nurturing. If a lead is already known in a Dynamics 365 app, the data for that lead will be updated by using the information provided from [!include[LinkedIn](../includes/pn-linkedin.md)]; otherwise, a new lead record is created.

>[!NOTE]
>You need a Dynamics 365 organization with the Sales app to use the [!include[LinkedIn Connector](../includes/pn-linkedin-solution-shortest.md)].


## Quick start guide to install and use the connector

1. A system administrator or customizer installs the [Connector for LinkedIn Lead Gen Forms from Microsoft AppSource](https://go.microsoft.com/fwlink/p/?linkid=850928).
   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Install Dynamics 365 Connector for LinkedIn Lead Gen Forms from AppSource](install-linkedin-connector.md)

2. Optionally, a campaign manager defines the matching strategy between [!include[LinkedIn](../includes/pn-linkedin.md)] leads and Dynamics 365 Sales lead records, and analyzes individual forms and submissions.
   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure the matching strategy to update lead records from LinkedIn leads](configure-matching-strategy.md), [Analyze individual LinkedIn Lead Gen forms and submissions](review-leads.md#analyze-individual-linkedin-lead-gen-forms-and-submissions).

3. A person filling the roles of both a campaign manager on [!include[LinkedIn](../includes/pn-linkedin.md)] and a salesperson in Dynamics 365 Sales authorizes the system to receive data from [!include[LinkedIn](../includes/pn-linkedin.md)].
   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Connect Dynamics 365 Sales and LinkedIn](connect-dynamics-365-linkedin.md)

4. Optionally, a sales manager can review the lead performance in a dashboard.
   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Analyze leads and lead performance](review-leads.md)

### See also
[Install Dynamics 365 Connector for LinkedIn Lead Gen Forms from AppSource](install-linkedin-connector.md)
[Establish a connection between Dynamics 365 Connector for LinkedIn Lead Gen Forms and LinkedIn](connect-dynamics-365-linkedin.md)
[Configure a matching strategy to update leads from LinkedIn Lead Gen ads](configure-matching-strategy.md)
[Analyze leads and lead performance](review-leads.md)
[Microsoft Online Services Privacy Statement](https://go.microsoft.com/fwlink/p/?LinkId=512132)


[!INCLUDE[footer-include](../includes/footer-banner.md)]