---
title: "Unified Service Desk for Dynamics CRM 2013 SP1 package | MicrosoftDocs"
ms.custom: ""
ms.date: "2016-11-01"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
  - "Dynamics CRM Online"
ms.assetid: 8a8018a7-91c3-42ff-94fa-0e2cf1a56f6a
caps.latest.revision: 19
author: "Mattp123"
ms.author: "matp"
manager: "brycho"
---
# Unified Service Desk for Dynamics CRM 2013 SP1 package
[!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] (USD) is a desktop application that helps your customer service agents provide phone, email, chat, and social media support to your customers. USD provides a configurable framework to quickly build an Agent Desktop application that’s integrated with [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. With USD you can quickly make a customized Agent Desktop application by leveraging the [!INCLUDE[pn_user_interface_integration](../includes/pn-user-interface-integration.md)] framework.  
  
 With the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] for [!INCLUDE[pn_crmv6](../includes/pn-crmv6.md)] Service Pack 1 sample application package for [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], the following components are installed:  
  
-   User Interface Integration Solution  
  
-   Unified Service Desk Solution  
  
-   Customizations for this package  
  
-   Data required for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and customizations  
  
-   KPI Custom Control  
  
-   Customer Information System  
  
> [!IMPORTANT]
>  The sample applications are not supported for production use.  
  
 For more information on how to set up and administer USD, see the [Unified Service Desk Administration guide](https://technet.microsoft.com/library/dn499779.aspx).  
  
 Here’s what you’ll see when you install USD:  
  
1. **Left Nav**: Opens the left navigation area that you can open or collapse.  
  
2. **Dashboards**: Opens the Dynamics 365 customer service dashboard.  
  
3. **My Work:** Shows a list of all the active cases assigned to a service rep.  
  
4. **search**: Opens search for navigating through various entities. For this package you can search for accounts contacts, cases, activities, and queues.  
  
5. **Reminder**: Shows a list of your activity reminders.  
  
6. **Applications**: Shows custom applications for this package. When you’re working on a customer session, this shows global applications and session-specific applications.  
  
7. **Session tabs**: Each tab shows a different session when you have multiple customer sessions open. The tabs make it easy for an agent to work on multiple customer cases.  
  
8. **Session overview**: Shows relevant customer information.  
  
9. **Call Script**: Shows call scripts the service agent can use when they’re working on a case. The scripts help guide the agent by giving them step-by-step instructions on how to handle the case.  
  
10. **Notes**: Shows an area to take notes in regarding the case.  
  
11. **KPI Control**: Shows Key Performance Indicators (KPIs) such as Average Case Resolution Time, Number of Cases Resolved, and Customer Satisfaction.  
  
12. **Session timer**: Shows how long a service rep has been on the session.  
  
 ![Unified Service Desk Base SP package diagram](../unified-service-desk/media/unifiedservicedeskbasesppackage.png "Unified Service Desk Base SP package diagram")  
  
## View your activities  
 From the toolbar, click or tap **My Work** to see all of your activities.  
  
## Create a case  
  
1.  Look up the contact information. From the toolbar, click or tap **search**.  
  
2.  In the **search** field, enter the contact information.  
  
3.  When you find the contact information, click or tap the record to open a new session.  
  
4.  In the left nav **Call Script** area, use the list of call scripts to guide you through the support case. When you click or tap a call script, a green check mark indicates the action has been performed.  
  
5.  Enter your case notes in the **Notes** area. To attach your notes to the case, click or tap **Update notes** from call scripts.  
  
## Locate a customer  
 When you’re working on a customer session, if you want to find your customer’s location, use Bing Maps.  
  
 From the toolbar, click or tap **Applications** > **Locate the customer**. Then use Bing Maps to look up the customer’s location. This opens Bing Maps and automatically populates the customer’s address in the **search** field.  
  
## search for solutions  
 To help resolve a case, use the knowledge base articles or Bing search to find a solution.  
  
1.  From the **Call script** area, click or tap the **search for solutions** call script.  
  
2.  Then click or tap one of the following:  
  
    - **KB articles**: Use search to find articles that can help you resolve the case.  
  
    - **Bing search**: A title automatically populates in the Bing search box.  
  
## Send an email  
 From the list of call scripts, click or tap the **Send email** call script, and then select a template that automatically populates the body of the email.  
  
## Resolve a case  
 To resolve a case, from the **Call Script** area, click or tap the **Resolve Case** call script.  
  
 When the case is resolved, the time spent on the case gets updated in **Actual Service Unit** field of case form. The KPI control is also updated with number of cases and average handling time.