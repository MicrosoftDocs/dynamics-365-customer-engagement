---
title: Sync LinkedIn leads
description: Learn how to set up the Dynamics 365 Connector for LinkedIn Lead Gen Forms to sync leads from sponsored LinkedIn campaigns to your Dynamics 365 apps.
ms.date: 12/13/2024
ms.topic: overview
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - bap-template
  - dyn365-LinkedIn
keywords: linkedin lead gen, lead gen form, get started
search.audienceType: 
  - admin
  - customizer
  - enduser
applies_to: 
  - Dynamics 365 Sales
---

# Sync LinkedIn leads

> [!NOTE]
> LinkedIn lead generation capabilities have been removed. You can however, develop your own custom integration for LinkedIn lead generation. Learn more about this customization in the [LinkedIn Lead Sync Integration blog post](https://community.dynamics.com/blogs/post/?postid=fb6ed89f-67a1-ef11-8a69-7c1e520b1f9b).

[!include[Dynamics 365 Connector for LinkedIn Lead Gen Forms](../../includes/cc-linkedin-solution.md)] enables seamless synchronization of [!include[LinkedIn](../../includes/pn-linkedin.md)] leads to Dynamics 365 sales apps. [!include[LinkedIn](../../includes/pn-linkedin.md)] members can drive leads from [Sponsored Content](https://business.linkedin.com/marketing-solutions/native-advertising) campaigns, based on a variety of calls to action. The [!include[LinkedIn Connector](../../includes/pn-linkedin-solution-shortest.md)] lets campaign managers sync the leads from [LinkedIn's Lead Gen forms](https://business.linkedin.com/marketing-solutions/native-advertising/lead-gen-ads) to a Dynamics 365 instance for further nurturing. If a lead is already known in a Dynamics 365 app, the data for that lead will be updated by using the information provided from [!include[LinkedIn](../../includes/pn-linkedin.md)]; otherwise, a new lead record is created.

> [!NOTE]
> You need a Dynamics 365 organization with the sales app to use the [!include[LinkedIn Connector](../../includes/pn-linkedin-solution-shortest.md)].

Depending on your role, you can perform the following tasks:

| Role | Task |
|------|------|
| System administrator or customizer | Install the [Connector for LinkedIn Lead Gen Forms from Microsoft AppSource](https://go.microsoft.com/fwlink/p/?linkid=850928).<br>[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Install Dynamics 365 Connector for LinkedIn Lead Gen Forms from AppSource](install-linkedin-connector.md) |
| Campaign manager | Define the matching strategy between [!include[LinkedIn](../../includes/pn-linkedin.md)] leads and Dynamics 365 Sales lead records, and analyzes individual forms and submissions.<br>[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure the matching strategy to update lead records from LinkedIn leads](configure-matching-strategy.md), [Analyze individual LinkedIn Lead Gen forms and submissions](review-leads.md#analyze-individual-linkedin-lead-gen-forms-and-submissions). |
| Campaign manager on LinkedIn<br>Salesperson in Dynamics 365 Sales | Authorize the system to receive data from [!include[LinkedIn](../../includes/pn-linkedin.md)].<br>[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Connect Dynamics 365 Sales and LinkedIn](connect-dynamics-365-linkedin.md) |
| Sales manager | Review the lead performance in a dashboard.<br>[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Analyze leads and lead performance](review-leads.md) |

## Related information

[Install Dynamics 365 Connector for LinkedIn Lead Gen Forms from AppSource](install-linkedin-connector.md)  
[Establish a connection between Dynamics 365 Connector for LinkedIn Lead Gen Forms and LinkedIn](connect-dynamics-365-linkedin.md)  
[Configure a matching strategy to update leads from LinkedIn Lead Gen ads](configure-matching-strategy.md)  
[Analyze leads and lead performance](review-leads.md)  
[Microsoft Online Services Privacy Statement](https://go.microsoft.com/fwlink/p/?LinkId=512132)
