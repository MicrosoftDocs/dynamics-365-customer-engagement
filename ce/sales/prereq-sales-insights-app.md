---
title: Prerequisites to configure Conversation intelligence app
description: Verify the prerequisites that are necessary to configure the Conversation intelligence app."
ms.date: 07/28/2023
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
---
# Prerequisites to set up conversation intelligence

Before you set up conversation intelligence, you must verify that you have the required licenses and security roles. You must also complete the setup of conversation intelligence from the Sales Hub app.

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

- You must have a Dynamics 365 Sales organization.  
- You must purchase a Dynamics 365 Sales Enterprise or Dynamics 365 Sales Premium license to get unlimited access to conversation intelligence.  
- If you want to use your own storage for conversation intelligence, create a v2 storage account with an Azure subscription. The account will include a blob container to configure call data. To learn more, see [Create a call recording repository in Azure](create-azure-repo.md).
- You must [set up conversation intelligence](fre-setup-ci-sales-app.md) from the Sales Hub app to select storage, grant app permissions, and define organization-level tracked keywords and competitors. This setup is mandatory to use conversation intelligence in the Sales Hub app and Conversation intelligence app.  

### See also

- [Introduction to administer conversation intelligence](intro-admin-guide-sales-insights.md#administer-conversation-intelligence)  
- [Overview of conversation intelligence](dynamics365-sales-insights-app.md)  
- [Which Conversation intelligence features are available in Dynamics 365 Sales versus Microsoft Sales Copilot?](faqs-sales-insights.md#which-conversation-intelligence-features-are-available-in-dynamics-365-sales-versus-microsoft-sales-copilot)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
