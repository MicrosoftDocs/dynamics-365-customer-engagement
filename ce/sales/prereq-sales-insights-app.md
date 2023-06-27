---
title: Prerequisites to configure Conversation intelligence app
description: Verify the prerequisites that are necessary to configure the Conversation intelligence app."
ms.date: 09/30/2022
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
---
# Prerequisites to configure Conversation intelligence app

Verify the prerequisites that are necessary to configure the Conversation intelligence app.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator  <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


>[!IMPORTANT]
>This feature is intended to help sales managers or supervisors enhance their team's performance. This feature isn't intended for use in making&mdash;and shouldn't be used to make&mdash;decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with sales persons may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their sales persons that their communications with end users may be monitored, recorded, or stored.

## Prerequisites

Verify the following requirements before setting up the Conversation intelligence app for your organization:  

-	You must have an administrator or similar role.  

-	You must have a Dynamics 365 Sales organization.   
-	You must purchase a Dynamics 365 Sales Enterprise, [Dynamics 365 Sales Insights](https://portal.office.com/Signup/MainSignUp.aspx?OfferId=5be85c9f-df71-4bcf-ac2f-b2a05b4a1f99) or Dynamics 365 Sales Premium license.         
    > [!NOTE]
    > - The Dynamics 365 Sales Enterprise license provides you access to the conversation intelligence feature with 3 hours of call processing capacity for all licensed users from your organization.<br>
    > - The Dynamics 365 Sales Insights or Dynamics 365 Sales Premium license provides you access to the conversation intelligence feature with 10 hours of call processing capacity for all licensed users from your organization.<br> 
    > - To extend the capacity of processing hours for your organization, you must purchase the conversation intelligence add-on for Sales Insights.<br>
    > - To learn more, see **Add-on Capacities** section in **Appendix F: Dynamics 365 Capacity Add-ons** from [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544).         
-	You must get access to conversation intelligence. If you don't have access, follow these steps:       
    1.	To access the app, go to [Conversation intelligence](https://sales.ai.dynamics.com/).  
    2.	Enter your work email address.  
    3.	When the application recognizes the email, you must sign in using Azure Active Directory. To learn more, see [Azure AD Connect user sign-in options](/azure/active-directory/hybrid/plan-connect-user-signin).  
-	If you want to use your own storage for conversation intelligence, create a v2 storage account with an Azure subscription. The account will include a blob container to configure call data. To learn more, see [Create a call recording repository in Azure](create-azure-repo.md).
-    [Set up conversation intelligence](fre-setup-ci-sales-app.md) from the Sales Hub app to select storage, grant app permissions, and define organization-level tracked keywords and competitors.  

### See also

- [Introduction to administer conversation intelligence](intro-admin-guide-sales-insights.md#administer-conversation-intelligence)  
- [Overview of conversation intelligence](dynamics365-sales-insights-app.md)  
- [Which Conversation intelligence features are available in Dynamics 365 Sales versus Viva Sales?](faqs-sales-insights.md#which-conversation-intelligence-features-are-available-in-dynamics-365-sales-versus-viva-sales)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
